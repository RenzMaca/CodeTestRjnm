using CodeTestRjnm.Models;
using System.Collections.Generic;
using System.Linq;

namespace CodeTestRjnm.CodeTestData
{
    public class SqlPaymentHistoryData : IPaymentHistoryData
    {

        private PaymentHistoryContext _paymentHistoryContext;

        public SqlPaymentHistoryData(PaymentHistoryContext paymentHistoryContext)
        {
            _paymentHistoryContext = paymentHistoryContext;
        }

        public List<Payment> GetPaymentHistory(Account account)
        {
            if ( null == account )
            {
                return null;
            }

            var accountPaymentHistory = _paymentHistoryContext.Payments
                .Where(p => p.accountNumber == account.accountNumber)
                .OrderByDescending(p => p.date)
                .ToList();

            return accountPaymentHistory;
        }
    }
}
