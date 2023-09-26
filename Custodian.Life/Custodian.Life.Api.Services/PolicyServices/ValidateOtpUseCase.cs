using Custodian.Life.Api.Services.Services;
using Custodian.Life.Helpers.Helpers;
using Custodian.Life.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custodian.Life.Api.Services.PolicyServices
{
    public class ValidateOtp : IRequest<Responses<ValidatePolicy>>
    {

        public string merchant_id { get; set; }
        public string email { get; set; }
        public string otp { get; set; }
        public string hash { get; set; }
        public string pin { get; set; }
        public string customerid { get; set; }

        public ValidateOtp(string merchant_id, string email, string otp, string hash, string pin, string customerid)
        {
            this.merchant_id = merchant_id;
            this.email = email;
            this.otp = otp;
            this.hash = hash;
            this.pin = pin;
            this.customerid = customerid;
        }
    }

    public class ValidateOtpResponse
    {

    }


    public class ValidateOtpHandler : IRequestHandler<ValidateOtp, Responses<ValidatePolicy>>
    {

        private readonly IPolicyServices _policyServices;

        public ValidateOtpHandler(IPolicyServices policyservice)
        {
            _policyServices = policyservice;
        }

        public async Task<Responses<ValidatePolicy>> Handle(ValidateOtp request, CancellationToken cancellationToken)
        {

                ValidatePolicy validatePolicy = new ValidatePolicy
                {
                    customerid = request.customerid,
                    email = request.email,
                    otp = request.otp,
                    hash = request.hash,
                    pin = request.pin,
                    merchant_id = request.merchant_id
                   
                };
             return  await  _policyServices.ValidateOTP(validatePolicy);
            
        }
    }



}
