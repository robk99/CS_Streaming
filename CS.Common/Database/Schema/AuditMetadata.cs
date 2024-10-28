namespace CS.Common.Database.Schema
{
    public abstract class AuditMetadata
    {
        public DateTime CreatedOnUtc { get; }

        public DateTime? ModifiedOnUtc { get; }
    }
}
