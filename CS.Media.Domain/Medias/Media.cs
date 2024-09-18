namespace CS.Media.Domain.Medias
{
    public class Media
    {
        public int Id { get; set; }
        public int MediaTypeId { get; set; }
        public int? LengthInSeconds { get; set; }
    }
}
