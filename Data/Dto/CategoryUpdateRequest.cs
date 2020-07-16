using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWithArchitecture.Data.Dto
{
    public class CategoryUpdateRequest
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public long? ParentId { set; get; }
        public bool? Status { set; get; }
    }
}
