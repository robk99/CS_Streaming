namespace CS.Media.Domain.Abstractions
{
    public interface IMediaTypeRepository
    {
        Task<Medias.MediaType> GetById(int id);
    }
}
