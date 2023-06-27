namespace Service
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(string Id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);

    }
}