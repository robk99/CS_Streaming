namespace CS.Media.Domain.Abstractions
{
    public interface IMediaRepository
    {
        void Create(Medias.Media media);
        Medias.Media GetById(int id);
    }
}
