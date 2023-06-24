using Domain.Models;
using Repository;

namespace Service
{
    public class VacancyService : IService<Vacancy>
    {
        private readonly IRepository<Vacancy> _vacancyRepository;
        public VacancyService(IRepository<Vacancy> vacancyRepository)
        {
            _vacancyRepository = vacancyRepository;
        }
        public void Delete(Vacancy entity)
        {
            try
            {
                if (entity != null)
                {
                    _vacancyRepository.Delete(entity);
                    _vacancyRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Vacancy Get(int Id)
        {
            try
            {
                var obj = _vacancyRepository.Get(Id);
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

        public Vacancy Get(string Id)
        {
            return null;
        }
            public IEnumerable<Vacancy> GetAll()
        {
            try
            {
                var obj = _vacancyRepository.GetAll();
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
        public void Insert(Vacancy entity)
        {
            try
            {
                if (entity != null)
                {
                    _vacancyRepository.Insert(entity);
                    _vacancyRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Remove(Vacancy entity)
        {
            try
            {
                if (entity != null)
                {
                    _vacancyRepository.Remove(entity);
                    _vacancyRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(Vacancy entity)
        {
            try
            {
                if (entity != null)
                {
                    _vacancyRepository.Update(entity);
                    _vacancyRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}