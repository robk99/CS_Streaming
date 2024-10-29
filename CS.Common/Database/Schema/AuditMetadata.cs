namespace CS.Common.Database.Schema
{
    public abstract class AuditMetadata
    {
        public DateTime CreatedOnUtc { get; set; }

        public DateTime? ModifiedOnUtc { get; set; }
    }
}
