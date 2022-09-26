using UserRegistration.Api.Models;

namespace UserRegistration.Api.Data
{
    public class UserRepository : IRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(User user)
        {
            if (user is null) 
                throw new ArgumentNullException(nameof(user)); 

            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User? GetById(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            return user;
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
