using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.VMModels
{
    public class ResponseMessage
    {
        public object Data { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
