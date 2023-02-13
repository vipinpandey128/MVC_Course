using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMVCourse.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(long Id);
        Task AddAsync(T entity);
        Task UdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
