using Mazhar___Course_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Mazhar___Course_Project.Data{
    public class DataContext : DbContext {
        public DataContext (DbContextOptions<DataContext> options) : base (options) {

        }
        public DbSet<User> users { get; set; }

        
    }
}