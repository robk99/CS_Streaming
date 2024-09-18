using CS.User.Domain.Abstractions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CS.User.Infrastructure.Database.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(Domain.Users.User user)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC Users_Create @Name, @Surname, @Email",
                new SqlParameter("@Name", user.Name),
                new SqlParameter("@Surname", user.Surname),
                new SqlParameter("@Email", user.Email)
            );
        }

        public Domain.Users.User GetById(int id)
        {
            return _context.Users.FromSqlRaw("EXEC Users_GetById @Id",
                new SqlParameter("@Id", id)).FirstOrDefault();
        }
    }
}
