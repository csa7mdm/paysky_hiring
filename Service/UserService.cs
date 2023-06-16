using Domain.Models;
using Repository;

namespace Service
{
    public class UserService : IService<User>
    {
        private readonly IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public void Delete(User entity)
        {
            try
            {
                if (entity != null)
                {
                    _userRepository.Delete(entity);
                    _userRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public User Get(int Id)
        {
            try
            {
                var obj = _userRepository.Get(Id);
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<User> GetAll()
        {
            try
            {
                var obj = _userRepository.GetAll();
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Insert(User entity)
        {
            try
            {
                if (entity != null)
                {
                    _userRepository.Insert(entity);
                    _userRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Remove(User entity)
        {
            try
            {
                if (entity != null)
                {
                    _userRepository.Remove(entity);
                    _userRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(User entity)
        {
            try
            {
                if (entity != null)
                {
                    _userRepository.Update(entity);
                    _userRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}