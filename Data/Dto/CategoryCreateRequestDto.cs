using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWithArchitecture.Data.Dto
{
    public class CategoryCreateRequestDto
    {
        public string Name { set; get; }
        public string Description { set; get; }
        public long? ParentId { set; get; }

        public bool? Status { set; get; }
    }
}
