using System;

namespace ProjectWithArchitecture.Data.Dto
{
    public class CategoryDto
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? ModifiedDate { set; get; }
        public bool? Status { set; get; }
    }
}
