namespace CS.Media.Domain.Abstractions
{
    public interface IMediaTypeRepository
    {
        Medias.MediaType GetById(int id);
    }
}
