using CodeTestRjnm.Models;
using System.Collections.Generic;

namespace CodeTestRjnm.CodeTestData
{
    public interface IPaymentHistoryData
    {
        public List<Payment> GetPaymentHistory(Account account);
    }
}
