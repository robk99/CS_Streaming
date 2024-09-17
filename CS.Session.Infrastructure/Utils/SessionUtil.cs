namespace CS.Session.Infrastructure.Utils
{
    public static class SessionUtil
    {
        public static string GetRedisKey(string UserIP)
        {
            return $"session:{UserIP}";
        }
    }
}
