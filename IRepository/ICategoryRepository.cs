using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectWithArchitecture.Data.Entities;

namespace ProjectWithArchitecture.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<IEnumerable<Category>> GetCategoryWithParentId(long id);
        Task<IEnumerable<Category>> GetListParentCategory();
    }
}
