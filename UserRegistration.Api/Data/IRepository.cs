using UserRegistration.Api.Models;

namespace UserRegistration.Api.Data
{
    public interface IRepository
    {
        void Create(User user);
        void Update(User user);
        void Delete(User user);
        User? GetById(int id);
        IEnumerable<User> GetAll();
    }
}
