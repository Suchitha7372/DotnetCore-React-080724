using HandsOnAPIUsingEFCodeFirst.Entities;

namespace HandsOnAPIUsingEFCodeFirst.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ECommContext _context;
<<<<<<< Updated upstream
        private IConfiguration _configuration;

       
        public UserRepository(ECommContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
=======

        public UserRepository(ECommContext context)
        {
            _context = context;
>>>>>>> Stashed changes
        }

        //public UserRepository()
        //{
<<<<<<< Updated upstream
        //    _context = new ECommContext();
=======
        //    _context=new ECommContext();
>>>>>>> Stashed changes
        //}
        public void Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User ValidUser(string email, string password)
        {
            return _context.Users.SingleOrDefault(u=>u.Email==email && u.Password==password);
        }
    }
}
