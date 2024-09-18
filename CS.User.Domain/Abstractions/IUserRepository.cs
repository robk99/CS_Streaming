namespace CS.User.Domain.Abstractions
{
    public interface IUserRepository
    {
        Task<int> Create(Users.User user);
        Task<Users.User> GetById(int id);
    }
}
