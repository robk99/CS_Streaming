using CS.User.Domain.Abstractions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

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
            var procedureName = "Users_Create";
            var ouputValue = new SqlParameter("@NewUserId", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            var result =  await _context.Database.ExecuteSqlRawAsync(
                $"EXEC ${procedureName} @Name, @Surname, @Email, @NewUserId OUTPUT;",
                new SqlParameter("@Name", user.Name),
                new SqlParameter("@Surname", user.Surname),
                new SqlParameter("@Email", user.Email),
                ouputValue
            );

            if (ouputValue.Value != DBNull.Value && int.TryParse(ouputValue.Value.ToString(), out int mediaId)) return mediaId;
            else throw new InvalidOperationException($"Failed to parse the new ID: ({ouputValue.Value}) from the stored procedure '{procedureName}'. Stored Procedure Result: {result}");
        }

        public async Task<Domain.Users.User> GetById(int id)
        {
            return _context.Users.FromSqlRaw("EXEC Users_GetById @Id",
                new SqlParameter("@Id", id)).AsEnumerable().First();
        }
    }
}
