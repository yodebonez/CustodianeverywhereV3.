using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custodian.Life.Models.ApiResponse
{
    public class LifeTransactionReponse
    {
        public decimal Amount { get; set; }
        public string TransactionDate { get; set; }
        public string RecieptNumber { get; set; }
        public string Status { get; set; }



        //Amount = Convert.ToDecimal(rows["OPR_AMT"]?.ToString()),
        //                    TransactionDate = rows["OPR_DATE"]?.ToString(),
        //                    RecieptNumber = rows["OPR_RECEIPT_NO"]?.ToString(),
        //                    Status = (rows["OPR_DRCR"]?.ToString().ToUpper() == "D") ? "DR" : "CR",
    }
}
