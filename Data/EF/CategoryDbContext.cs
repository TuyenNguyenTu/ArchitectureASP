using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectWithArchitecture.Data.Entities;

namespace ProjectWithArchitecture.Data.EF
{
    public class CategoryDbContext :DbContext
    {
        public CategoryDbContext(DbContextOptions<CategoryDbContext> options) :base(options)
        {

        }
        public DbSet<Category> Categories { set; get; }
    }
}
