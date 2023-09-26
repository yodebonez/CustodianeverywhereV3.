using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custodian.Life.Models
{
    public class ValidatePolicy
    {
        public string merchant_id { get; set; }
        public string email { get; set; }
        public string otp { get; set; }
        public string hash { get; set; }
        public string pin { get; set; }
        public string customerid { get; set; }
    }
}
