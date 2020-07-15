using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectWithArchitecture.Data.Entities;
using ProjectWithArchitecture.IBusiness;
using ProjectWithArchitecture.IRepository;

namespace ProjectWithArchitecture.Business
{
    public class CategoryService : ICategoryManager
    {
        public readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<long> Add(Category entity)
        {
            return await _categoryRepository.Add(entity);
        }

        public async Task<bool> Delete(long id)
        {
            return await _categoryRepository.Delete(id);
        }

        public async Task<Category> Get(long Id)
        {
            return await _categoryRepository.Get(Id);
        }

        public  async Task<IList<Category>> GetAll()
        {
            return await _categoryRepository.GetAll();
        }

        public async Task<IEnumerable<Category>> GetCategoryWithParentId(long id)
        {
            return await _categoryRepository.GetCategoryWithParentId(id);
        }

        public async Task<IEnumerable<Category>> GetListParentCategory()
        {
            return await _categoryRepository.GetListParentCategory();
        }

        public async Task<bool> Update(Category entity)
        {
            return await _categoryRepository.Update(entity);
        }
    }
}
