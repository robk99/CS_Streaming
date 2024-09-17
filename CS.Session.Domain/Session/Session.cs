namespace CS.Session.Domain.Session
{
    public class Session
    {
        public long Id { get; set; }
        public int MediaId { get; set; }
        public int UserId { get; set; }
        public SessionState State { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
