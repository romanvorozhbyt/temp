using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstarction
{
    public interface IRepository<T> where T : class
    {
        void Insert(T item);
        Task InsertAsync(T item);

        void Update(T item);
        Task UpdateAsynk(T item);

        T GetById(int id);
        Task<T> GetByIdAsync(int id);

        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();

        void Delete(int id);
        Task DeleteAsync(int id);
    }
}
