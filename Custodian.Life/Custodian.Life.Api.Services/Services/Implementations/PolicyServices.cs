using Custodian.Life.Helpers.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custodian.Life.Api.Services.Services
{
    public class PolicyServices : IPolicyServices
    {
        private readonly string _connectionString;

        public PolicyServices(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string GetPolicy(string policyNumber)
        {
            var s = PolicyHelper.GetPolicyHolderName();

            if (s == "something") throw new Exception();

            return s;
        }
    }
}
