namespace CS.Media.Domain.Abstractions
{
    public interface IMediaRepository
    {
        Task<int> Create(Medias.Media media);
        Task<Medias.Media> GetById(int id);
    }
}
