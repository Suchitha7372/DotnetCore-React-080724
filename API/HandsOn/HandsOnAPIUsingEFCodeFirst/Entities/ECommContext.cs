using Microsoft.EntityFrameworkCore;

namespace HandsOnAPIUsingEFCodeFirst.Entities
{
    public class ECommContext:DbContext
    {
        private IConfiguration _configuration;
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
        public ECommContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
<<<<<<< Updated upstream


=======
>>>>>>> Stashed changes
        //Entity Set
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        //Configure Connnectionstring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
<<<<<<< Updated upstream
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=EComm;Integrated Security=True;Trust Server Certificate=True\r\n");
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ECommConnection"));
=======
            //optionsBuilder.UseSqlServer("Data Source=SUCHITHA_7372\\SQLEXPRESS;Initial Catalog=ECom;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ECommConnection"));

>>>>>>> Stashed changes
        }
    }
}
