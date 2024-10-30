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
                var jobId = context.BackgroundJob.Job.Args[0] as string;
                var jobType = context.BackgroundJob.Job.Type;

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
                    // TODO: Log
                    //Console.WriteLine($"JOB DONE {jobId}");

                    string userIP = context.BackgroundJob.Job.Args[1] as string ?? throw new InvalidOperationException("User IP is missing or invalid.");

                    var resultString = result as string ?? throw new InvalidOperationException("Job return value is missing or invalid.");

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
                    // TODO: Log
                    Console.WriteLine($"JOB FAILED {jobId}");
                    break;

                default:
                    break;
            }
        }
    }
}
