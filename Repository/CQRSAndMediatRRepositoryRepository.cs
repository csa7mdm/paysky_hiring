using Domain.Data;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class CQRSAndMediatRRepository<T> : ICQRSAndMediatRRepository<T> where T : BaseEntity
    {
        #region property
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly DbSet<T> entities;
        #endregion
        #region Constructor
        public CQRSAndMediatRRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }
        #endregion

        async Task<bool> ICQRSAndMediatRRepository<T>.Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            int affectedRows = await _applicationDbContext.SaveChangesAsync();

            return  affectedRows > 0;
        }

        async Task<T> ICQRSAndMediatRRepository<T>.Get(int Id)
        {
            return await entities.SingleOrDefaultAsync(c => c.Id == Id);
        }

        async Task<IEnumerable<T>> ICQRSAndMediatRRepository<T>.GetAll()
        {
            return await entities.ToListAsync();
        }

        async Task<T> ICQRSAndMediatRRepository<T>.Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            var result = entities.Add(entity);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        async Task<bool> ICQRSAndMediatRRepository<T>.Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            int affectedRows = await _applicationDbContext.SaveChangesAsync();
            return affectedRows > 0;
        }
    }
}