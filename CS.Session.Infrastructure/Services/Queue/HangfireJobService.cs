using CS.Session.Infrastructure.Abstractions;
using CS.Session.Infrastructure.Services.Queue.Jobs;
using Hangfire;
using System.Linq.Expressions;

namespace CS.Session.Infrastructure.Services.Queue
{
    public class HangfireJobService : IJobService
    {
        public void AddRecurringPingJob(string jobId, string userIP)
        {
            AddRecurringJob<UserPingJob>(jobId, job => job.Execute(jobId, userIP), 30);
        }

        public void AddRecurringJob<T>(string jobId, Expression<Action<T>> action, int everySeconds)
        {
            RecurringJob.AddOrUpdate<T>(
                jobId,
                action,
                $"*/{everySeconds} * * * * *",
                options: new RecurringJobOptions
                {
                    MisfireHandling = MisfireHandlingMode.Relaxed
                }
            );
        }

    }
}
