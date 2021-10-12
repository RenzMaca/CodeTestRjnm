using CodeTestRjnm.Models;
using System.Linq;

namespace CodeTestRjnm.CodeTestData
{
    public class SqlAccountData : IAccountData
    {
        private AccountContext _accountContext;
        public SqlAccountData(AccountContext accountContext)
        {
            _accountContext = accountContext;
        }

        public Account GetAccount(string accountNumber)
        {
            var account = _accountContext.Accounts.SingleOrDefault(a => a.accountNumber == accountNumber);
            return account;
        }
    }
}
