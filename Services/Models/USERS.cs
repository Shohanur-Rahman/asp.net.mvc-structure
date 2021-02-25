using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Services.Models
{
    [Table("USERS")]
    public class USERS: BaseTableInfo
    {
        [Key]
        public long Id { get; set; }
        [DefaultValue(3)]
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsLocked { get; set; }
    }
}
