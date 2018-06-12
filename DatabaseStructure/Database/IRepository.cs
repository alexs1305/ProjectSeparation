using System;
using System.Threading.Tasks;

namespace Database
{
    interface IRepository<T>
    {
        Task Create(T entity);

        Task ReadById(Guid id);

        Task Update(T entity);

        Task DeleteById(Guid id);
    }
}
