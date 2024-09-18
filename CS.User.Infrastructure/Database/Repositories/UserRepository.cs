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

        public async Task<int> Create(Domain.Users.User user)
        {
            return await _context.Database.ExecuteSqlRawAsync(
                "EXEC Users_Create @Name, @Surname, @Email",
                new SqlParameter("@Name", user.Name),
                new SqlParameter("@Surname", user.Surname),
                new SqlParameter("@Email", user.Email)
            );
        }

        public async Task<Domain.Users.User> GetById(int id)
        {
            return await _context.Users.FromSqlRaw("EXEC Users_GetById @Id",
                new SqlParameter("@Id", id)).FirstOrDefaultAsync();
        }
    }
}
