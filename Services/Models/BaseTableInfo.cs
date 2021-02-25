using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models
{
    public class BaseTableInfo
    {
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

    }
}
