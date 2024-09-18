using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CS.Session.Domain.Sessions
{
    public class Session
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("MediaId")]
        public int MediaId { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public SessionState State { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
