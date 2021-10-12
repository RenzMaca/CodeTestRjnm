using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTestRjnm.Helpers
{
    public static class CustomHelpers
    {
        public static bool IsValidAccountNumber(string accountNumber)
        {
            // check length validity
            if ( 11 > accountNumber.Length || 16 < accountNumber.Length )
            {
                return false;
            }

            // check if string contains alpha & special characters
            foreach (var c in accountNumber )
            { 
                if ( ('0' > c) || ('9' < c) )
                {
                    return false;
                }
            }

            return true;
        }
    }
}
