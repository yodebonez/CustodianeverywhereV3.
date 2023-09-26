using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custodian.Life.Helpers.Helpers
{
    public class Responses<T>
    {
        public Status Status { get; set; }
        public T Result { get; set; }
    }

    public class Status
    {
        public string text { get; set; }
        public string status_code { get; set; }
        public string description { get; set; }

        //     "text": "OK",
        //"status_code": "200",
        //"description": "Account successfully activated"

    }
}
