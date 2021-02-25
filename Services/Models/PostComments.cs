using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Services.Models
{
    [Table("PostComments")]
    public class PostComments : BaseTableInfo
    {
        [Key]
        public long Id { get; set; }
        public long PostId { get; set; }
        public long? UserId { get; set; }
        public long? ReplyId { get; set; }
        public string Comments { get; set; }
    }
}
