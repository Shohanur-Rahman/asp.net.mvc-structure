using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Services.Models
{
    [Table("POSTS")]
    public class POSTS : BaseTableInfo
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string FeaturedImage { get; set; }
    }
}
