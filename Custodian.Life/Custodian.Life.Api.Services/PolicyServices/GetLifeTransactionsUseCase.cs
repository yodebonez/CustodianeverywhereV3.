using Custodian.Life.Api.Services.Services;
using Custodian.Life.Helpers.Helpers;
using Custodian.Life.Models.ApiResponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custodian.Life.Api.Services.PolicyServices
{
    public class GetLifeTransactions : IRequest<Responses<LifeTransactionReponse>>
    {
      //  string merchant_id, string policy_number, string hash
      public string merchant_id { get; set; }   = string.Empty;
        public string policy_number { get; set; } = string.Empty;
        public string hash { get; set; } = string.Empty;



        public GetLifeTransactions( string merchant_id, string policy_number, string hash)    
        { 
           this.merchant_id = merchant_id;
            this.policy_number = policy_number; 
            this.hash = hash;
        
        }



    }

    public class GetLifeTransactionsHandler : IRequestHandler<GetLifeTransactions, Responses<LifeTransactionReponse>>
    {

        private readonly IPolicyServices _policyServices;

        public GetLifeTransactionsHandler(IPolicyServices policyservice)
        {
            _policyServices = policyservice;
        }


        public async Task<Responses<LifeTransactionReponse>> Handle(GetLifeTransactions request, CancellationToken cancellationToken)
        {


            return await _policyServices.GetLifeTransactions(request.merchant_id, request.policy_number, request.hash);
        }
    }
}
