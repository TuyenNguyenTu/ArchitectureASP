using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectWithArchitecture.Data.Entities;

namespace ProjectWithArchitecture.IBusiness
{
    public interface ICategoryManager
    {
        Task<IList<Category>> GetAll();
        Task<Category> Get(long Id);
        Task<long> Add(Category entity);
        Task<bool> Update(Category entity);
        Task<bool> Delete(long id);
        Task<IEnumerable<Category>> GetCategoryWithParentId(long id);
        Task<IEnumerable<Category>> GetListParentCategory();
    }
}
