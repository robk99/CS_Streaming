namespace CS.User.Domain.Abstractions
{
    public interface IUserRepository
    {
        void Create(Users.User user);
        Users.User GetById(int id);
    }
}
