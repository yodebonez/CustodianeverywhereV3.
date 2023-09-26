using Custodian.Life.Api.Services.Services;
using Custodian.Life.Helpers.Helpers;
using MediatR;

namespace Custodian.Life.Api.Services.PolicyServices
{
    public class GetPolicyQuery : IRequest<GetPolicyResponse>
    {
        public string PolicyNumber { get; set; } = string.Empty;
    }

    public class GetPolicyResponse
    {
        public string PolicyHolder { get; set; } = string.Empty;
    }





    public class GetPolicyHandler : IRequestHandler<GetPolicyQuery, GetPolicyResponse>
    {
        private readonly IPolicyServices _policyServices;

        public GetPolicyHandler(IPolicyServices policyservice)
        {
            _policyServices = policyservice;
        }

        public Task<GetPolicyResponse> Handle(GetPolicyQuery request, CancellationToken cancellationToken)
        {
            string policyHolderName = _policyServices.GetPolicy(request.PolicyNumber);

            var model = new GetPolicyResponse
            {
                PolicyHolder = policyHolderName
            };

            return Task.FromResult(model);
            
        }
    }

   

}
