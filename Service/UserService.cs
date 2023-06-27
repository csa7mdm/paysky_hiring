using Domain.Models;
using Repository;

namespace Service
{
    public class UserService : IService<ApplicationUser>
    {
        private readonly IUserRepository<ApplicationUser> _userRepository;
        public UserService(IUserRepository<ApplicationUser> userRepository)
        {
            _userRepository = userRepository;
        }
        public void Delete(ApplicationUser entity)
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
            public ApplicationUser Get(string Id)
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
        public IEnumerable<ApplicationUser> GetAll()
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
        public void Insert(ApplicationUser entity)
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
        public void Remove(ApplicationUser entity)
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
        public void Update(ApplicationUser entity)
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