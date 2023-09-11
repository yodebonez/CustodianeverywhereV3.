using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custodian.Life.Api.Services.Services
{
    public interface IPolicyServices
    {
        public string GetPolicy(string policyNumber);
    }
}
