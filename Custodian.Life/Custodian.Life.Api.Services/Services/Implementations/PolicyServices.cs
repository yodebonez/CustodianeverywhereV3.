using Custodian.Life.Helpers.Helpers;
using Custodian.Life.Models;
using Custodian.Life.Models.ApiResponse;
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

        private readonly DataContext _context;

        public PolicyServices(string connectionString, DataContext context)
        {
            _connectionString = connectionString;
            _context = context;
        }

        public Task<Responses<string>> GenerateOTP(string customer_id, string merchant_id, string hash)
        {
            throw new NotImplementedException();
        }

        public Task<Responses<LifeTransactionReponse>> GetLifeTransactions(string merchant_id, string policy_number, string hash)
        {
            throw new NotImplementedException();
        }

        public Task<Responses<string>> GetPolicies(string merchant_id, string pin, string customer_id, string hash)
        {
            throw new NotImplementedException();
        }

        public string GetPolicy(string policyNumber)
        {
            var s = PolicyHelper.GetPolicyHolderName();

            if (s == "something") throw new Exception();

            return s;
        }

        public Task<Responses<string>> GetPolicyDetails(string merchant_id, string source, string pin, string policynumber, string customer_id, string hash)
        {
            throw new NotImplementedException();
        }

        public Task<Responses<string>> GetVehicleList(string merchant_id, string policy_number, string hash)
        {
            throw new NotImplementedException();
        }

        public Task<Responses<string>> ResetPIN(string merchant_id, string newpin, string otp, string customer_id, string hash)
        {
            throw new NotImplementedException();
        }

        public Task<Responses<string>> Setup(SetUp Setup)
        {
            throw new NotImplementedException();
        }

        public  Task<Responses<ValidatePolicy>> ValidateOTP(ValidatePolicy policy)
        {
            throw new NotImplementedException();
        }
    }
}
