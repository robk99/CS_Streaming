using System.Linq.Expressions;

namespace CS.Session.Infrastructure.Abstractions
{
    public interface IJobService
    {
        public void AddRecurringPingJob(string jobId, string userIP);
        public void AddRecurringJob<T>(string jobId, Expression<Action<T>> action, int everySeconds);
    }
}
