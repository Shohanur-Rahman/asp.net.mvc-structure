using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Services.Models
{
    [Table("UserProfiles")]
    public class UserProfiles : BaseTableInfo
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public int? OccupationId { get; set; }
        public int? ReligionId { get; set; }
        public int? GenderId { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Picture { get; set; }
    }
}
