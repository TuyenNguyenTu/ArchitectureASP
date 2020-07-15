using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWithArchitecture.IRepository
{
    public interface IRepository<T> where T:class
    {
        Task<IList<T>> GetAll();
        Task<T> Get(long Id);
        Task<long> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(long id);
    }
}
