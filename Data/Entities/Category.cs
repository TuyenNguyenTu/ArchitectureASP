using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWithArchitecture.Data.Entities
{
    public class Category
    {
        [Key]
        public long Id { set; get; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { set; get; }
        [Column(TypeName = "nvarchar(200)")]
        public string Description { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? ModifiedDate { set; get; }
        public long? ParentId { set; get; }
        public bool? Status { set; get; }
    }
}
