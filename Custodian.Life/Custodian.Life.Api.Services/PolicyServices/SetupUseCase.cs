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
     public class Setup : IRequest<Responses<string>>
     {

        public string merchant_id { get; set; }
        public string policynumber { get; set; }
        public string hash { get; set; }
        public string imei { get; set; }
        public string email { get; set; }
        public string devicename { get; set; }
        public string os { get; set; }


       public Setup(string merchant_id, string policynumber, string hash, string imei, string email, string devicename, string os)
        {
            this.merchant_id = merchant_id;
            this.policynumber = policynumber;
            this.hash = hash;
            this.imei =imei;
            this.email = email;
            this.devicename = devicename;
            this.os = os;
        }

    }

    public class SetUpHandler : IRequestHandler<Setup, Responses<string>>
    {

        private readonly IPolicyServices _policyServices;

        public SetUpHandler(IPolicyServices policyservice)
        {
            _policyServices = policyservice;
        }

        public async Task<Responses<string>> Handle(Setup request, CancellationToken cancellationToken)
        {
            SetUp setUp = new SetUp
            {
                devicename = request.devicename,
                os = request.os,
                email = request.email,
                hash = request.hash,
                imei = request.imei,
                merchant_id = request.merchant_id,
                policynumber = request.policynumber

            };


          return await   _policyServices.Setup(setUp);
        }
    }



}
