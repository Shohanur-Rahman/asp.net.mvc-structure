using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Services.Models
{
    [Table("BlogCategoryMapper")]
    public class BlogCategoryMapper
    {
        [Key]
        public long Id { get; set; }
        public int CategoryId { get; set; }
        public long PostId { get; set; }
    }
}
