using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICQRSAndMediatRRepository<T> where T : BaseEntity
    {

        public Task<IEnumerable<T>> GetAll();
        public Task<T> Get(int Id);
        public Task<T> Insert(T entity);
        public Task<bool> Update(T entity);
        public Task<bool> Delete(T entity);
    }
}
