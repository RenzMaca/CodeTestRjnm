using System.Text.Json;
using CodeTestRjnm.CodeTestData;
using CodeTestRjnm.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CodeTestRjnm.Controllers
{
    [ApiController]
    public class PaymentHistoryController : ControllerBase
    {
        private IAccountData _accountData;
        private IPaymentHistoryData _paymentHistoryData;

        public PaymentHistoryController(IAccountData accountData, IPaymentHistoryData paymentHistoryData)
        {
            _accountData = accountData;
            _paymentHistoryData = paymentHistoryData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetAccountData()
        {
            return BadRequest($"No Account Number provided");
        }
        
        [HttpGet]
        [Route("api/[controller]/{accountNumber}")]
        public IActionResult GetPaymentHistory(string accountNumber)
        {
            if ( !CustomHelpers.IsValidAccountNumber(accountNumber) )
            {
                return BadRequest($"Account Number provided is invalid.");
            }

            var accountInfo = _accountData.GetAccount(accountNumber);
            if ( null == accountInfo )
            {
                return NotFound($"Account with Number: {accountNumber} was not found.");
            }

            var paymentHistory = _paymentHistoryData.GetPaymentHistory(accountInfo);

            var jsonBuilder = new[] { new { balance = accountInfo.balance, paymentHistory } };
            string jsonString = JsonSerializer.Serialize(jsonBuilder);
            return Ok(jsonBuilder);
        }
    }
}
