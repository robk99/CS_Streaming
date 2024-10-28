using CS.Common.Database.Schema;
using System.ComponentModel.DataAnnotations;

namespace CS.Media.Domain.Medias
{
    public class MediaType : AuditMetadata
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string LongName { get; set; }
    }
}
