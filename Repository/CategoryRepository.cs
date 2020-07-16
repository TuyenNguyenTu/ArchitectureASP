using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectWithArchitecture.Data.EF;
using ProjectWithArchitecture.Data.Entities;
using ProjectWithArchitecture.IRepository;

namespace ProjectWithArchitecture.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CategoryDbContext _context;
        public CategoryRepository(CategoryDbContext context)
        {
            _context = context;
        }
        public async Task<long> Add(Category entity)
        {
            entity.CreatedDate = DateTime.Now;
            _context.Categories.Add(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<bool> Delete(long id)
        {
            var entity = _context.Categories.Find(id);
            if (entity != null)
            {
                _context.Categories.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            else
                return false;

        }

        public async Task<Category> Get(long Id)
        {
            var entity = await _context.Categories.FirstOrDefaultAsync(x => x.Id == Id);
            return entity;
        }

        public async Task<IList<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<IEnumerable<Category>> GetCategoryWithParentId(long id)
        {
            return await _context.Categories.Where(x => x.ParentId == id).ToListAsync();
        }

        public async Task<IEnumerable<Category>> GetListParentCategory()
        {
            return await _context.Categories.Where(x => x.ParentId == null || x.ParentId == 0).ToListAsync();
        }

        public async Task<bool> Update(Category entity)
        {
            var model = await _context.Categories.FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (model != null)
            {
                model.Name = entity.Name;
                model.Description = entity.Description;
                model.Status = entity.Status;
                model.ParentId = entity.ParentId;
                model.ModifiedDate = DateTime.Now;
                await _context.SaveChangesAsync();
                return true;
            }
            else
                return false;

        }
    }
}
