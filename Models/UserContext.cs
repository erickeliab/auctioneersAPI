using Microsoft.EntityFrameworkCore;
using Madalali.Models;

namespace Madalali.Models
{

    public class UserContext : DbContext
    {
       
        public UserContext(DbContextOptions<UserContext> options) : base(options) {

        }


        public DbSet<User> Users;


        public DbSet<Madalali.Models.User> User { get; set; }
    }
    
}
