using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Custodian.Life.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyServiceController : ControllerBase
    {

       public PolicyServiceController() { }

        [HttpPost]
        [Route("SetUp")]
        public async Task<IActionResult> SetUp()
        {

            return Ok();
        }


        [HttpPost]
        [Route("ValidateOTP")]
        public async Task<IActionResult> ValidateOtp()
        {

            return Ok();
        }



        [HttpGet]
        [Route("ValidateOTP")]
        public async Task<IActionResult> GetPolicies(string merchant_id, string pin, string customer_id, string hash)
        {

            return Ok();
        }



        [HttpGet]
        [Route("ResetPin")]
        public async Task<IActionResult> ResetPin(string merchant_id, string newpin, string otp, string customer_id, string hash)
        {

            return Ok();
        }



        [HttpGet]
        [Route("getpoliciesdetails")]
        public async Task<IActionResult> getPoliciesDetails(string merchant_id, string newpin, string otp, string customer_id, string hash)
        {

            return Ok();
        }


    }
}
