using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CS.Session.Domain.Sessions
{
    public class Session
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [ForeignKey("MediaId")]
        public int MediaId { get; set; }
        [Required]
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        [Required]
        public SessionState State { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
