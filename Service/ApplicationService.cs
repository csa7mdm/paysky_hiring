using Domain.Models;
using Repository;

namespace Service
{
    public class ApplicationService : IService<Application>
    {
        private readonly IRepository<Application> _applicationRepository;
        public ApplicationService(IRepository<Application> applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public void Delete(Application entity)
        {
            try
            {
                if (entity != null)
                {
                    _applicationRepository.Delete(entity);
                    _applicationRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Application Get(int Id)
        {
            try
            {
                var obj = _applicationRepository.Get(Id);
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

        public Application Get(string Id)
        {
            return null;
        }
            public IEnumerable<Application> GetAll()
        {
            try
            {
                var obj = _applicationRepository.GetAll();
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
        public void Insert(Application entity)
        {
            try
            {
                if (entity != null)
                {
                    _applicationRepository.Insert(entity);
                    _applicationRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Remove(Application entity)
        {
            try
            {
                if (entity != null)
                {
                    _applicationRepository.Remove(entity);
                    _applicationRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(Application entity)
        {
            try
            {
                if (entity != null)
                {
                    _applicationRepository.Update(entity);
                    _applicationRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}