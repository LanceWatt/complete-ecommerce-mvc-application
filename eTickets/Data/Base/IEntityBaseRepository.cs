using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Base
{
    // Services inheriting this interface ALSO must inherit from IEntityBase
    public interface IEntityBaseRepository<T> where T: class, IEntityBaseRepository, new()
    {
        Task<IEnumerable<T>> GetAllAsync(); // Task will make async operation

        Task<T> GetByIdAsync(int id);

        Task AddAsync(T entity);

        Task UpdateAsync(int id, T entity);

        Task DeleteAsync(int id);
    }
}
