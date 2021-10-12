using CodeTestRjnm.CodeTestData;
using CodeTestRjnm.Models;
using System.Collections.Generic;

namespace CodeTestRjnm.AccountData
{
    public class MockPaymentHistoryData : IPaymentHistoryData
    {
        private List<Payment> _paymentHistory = new List<Payment>();
        //{
        //    new Payment(Guid.NewGuid(), "11111111111", "01/01/2021", 2000, "COMPLETE", "N/A"),
        //    new Payment(Guid.NewGuid(), "11111111111", "02/01/2021", 4000, "COMPLETE", "N/A"),
        //    new Payment(Guid.NewGuid(), "11111111111", "03/01/2021", 1000, "COMPLETE", "N/A"),
        //    new Payment(Guid.NewGuid(), "22222222222", "01/01/2021", 1000, "CANCELED", "CUSTOMER INITIATED"),
        //    new Payment(Guid.NewGuid(), "22222222222", "10/01/2021", 100000, "REJECTED", "INSUFICIENT ACCOUNT FUNDS")
        //};

        public List<Payment> GetPaymentHistory(Account account)
        {
            if (null == account)
            {
                return null;
            }

            var paymentHistory = _paymentHistory.FindAll( x => x.accountNumber == account.accountNumber );

            return paymentHistory;
        }
    }
}
