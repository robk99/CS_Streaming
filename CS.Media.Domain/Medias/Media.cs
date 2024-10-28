using CS.Common.Database.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CS.Media.Domain.Medias
{
    public class Media : AuditMetadata
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int MediaTypeId { get; set; }
        [ForeignKey("MediaTypeId")]
        public MediaType MediaType { get; set; }
        public int? LengthInSeconds { get; set; }
    }
}
