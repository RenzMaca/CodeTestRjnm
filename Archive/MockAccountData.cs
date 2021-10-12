
using CodeTestRjnm.CodeTestData;
using CodeTestRjnm.Models;
using System.Collections.Generic;

namespace CodeTestRjnm.AccountData
{
    public class MockAccountData : IAccountData
    {
        private List<Account> _accounts = new List<Account>();
        //{
        //    new Account()
        //    {
        //        Guid = Guid.NewGuid(); "11111111111", "Maca", "Renz", 100000, "PHP"
        //    },
        //    new Account(Guid.NewGuid(), "22222222222", "Maca", "Renz", 200000, "PHP"),
        //    new Account(Guid.NewGuid(), "33333333333", "Maca", "Renz", 300000, "PHP")
        //};


        public Account GetAccount(string accountNumber)
        {
            return _accounts.Find(x => x.accountNumber == accountNumber);
        }


    }
}
