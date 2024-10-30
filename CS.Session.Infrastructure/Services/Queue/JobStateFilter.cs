using CS.Session.Domain.Sessions;
using CS.Session.Infrastructure.Abstractions;
using CS.Session.Infrastructure.Services.Queue.Jobs;
using Hangfire;
using Hangfire.States;
using Serilog;

namespace CS.Session.Infrastructure.Services.Queue
{
    public class JobStateFilter : IElectStateFilter
    {
        private ISessionStateHandler _sessionStateHandler;
        private readonly ILogger _logger;

        public JobStateFilter(ISessionStateHandler sessionStateHandler, ILogger logger)
        {
            _sessionStateHandler = sessionStateHandler;
            _logger = logger;
        }

        public void OnStateElection(ElectStateContext context)
        {
            try
            {
                if (context.CandidateState is SucceededState) HandleSuccessEvent(context);
                else if (context.CandidateState is FailedState) HandleFailEvent(context);

            }
            catch (InvalidOperationException ex)
            {
                _logger.Error($"Error processing job state: {ex.Message}");
            }
            catch (Exception ex)
            {
                _logger.Error($"Unexpected error: {ex.Message}");
            }
        }

        private void HandleSuccessEvent(ElectStateContext context)
        {
            var jobId = context.BackgroundJob.Job.Args[0] as string;
            var jobType = context.BackgroundJob.Job.Type;

            var result = (context.CandidateState as SucceededState).Result;

            switch (jobType.Name)
            {
                case nameof(UserPingJob):

                    _logger.Information($"Job done: {jobId}");

                    var userIP = context.BackgroundJob.Job.Args[1] as string;

                    if (string.IsNullOrEmpty(userIP))
                    {
                        _logger.Error("User IP is missing or invalid.");
                        return;
                    }


                    var resultString = result as string;
                    if (string.IsNullOrEmpty(resultString))
                    {
                        _logger.Error("Job return value is missing or invalid.");
                        return;
                    }

                    if (resultString == SessionState.CLOSED.ToString())
                    {
                        RecurringJob.RemoveIfExists(jobId);
                        _sessionStateHandler.OnStateClosed(jobId, userIP, resultString);
                    }
                    break;

                default:
                    break;
            }
        }

        private void HandleFailEvent(ElectStateContext context)
        {
            var jobId = context.BackgroundJob.Job.Args[0] as string;
            var jobType = context.BackgroundJob.Job.Type;

            switch (jobType.Name)
            {
                case nameof(UserPingJob):
                    _logger.Error($"JOB FAILED {jobId}");
                    break;

                default:
                    break;
            }
        }
    }
}
