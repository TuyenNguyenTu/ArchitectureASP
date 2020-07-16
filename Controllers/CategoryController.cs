using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectWithArchitecture.Data.Dto;
using ProjectWithArchitecture.Data.EF;
using ProjectWithArchitecture.Data.Entities;
using ProjectWithArchitecture.IBusiness;

namespace ProjectWithArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryManager categoryManager, IMapper mapper)
        {

            _categoryManager = categoryManager;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IList<CategoryDto>> Get()
        {
            return _mapper.Map<IList<CategoryDto>>(await _categoryManager.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<Category> Get(long id)
        {
            return await _categoryManager.Get(id);
        }

        // POST: api/Category
        [HttpPost]
        public async Task<long> Post(CategoryCreateRequestDto category)
        {
            return await _categoryManager.Add(new Category { 
            Name= category.Name,
            Description = category.Description,
            ParentId = category.ParentId,
            Status = category.Status});

        }

        [HttpPut]
        public async Task<bool> Put(CategoryUpdateRequest category)
        {
            return await _categoryManager.Update(new Category { 
                Id = category.Id,
                Name = category.Name,
                ParentId = category.ParentId,
                Status = category.Status,
                Description = category.Description  
            });
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(long id)
        {
            return await _categoryManager.Delete(id);
        }

        [HttpGet("/api/Category/list-parent")]
        public async Task<IEnumerable<Category>> GetListParentCategory()
        {
            return await _categoryManager.GetListParentCategory();
        }
        [HttpGet("/api/Category/children/{id}")]
        public async Task<IEnumerable<Category>> GetCategoryWithParentId(long id)
        {
            return await _categoryManager.GetCategoryWithParentId(id);
        }

    }
}
