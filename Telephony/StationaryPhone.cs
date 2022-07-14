using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICalled
    {
        public string Call(string number)
        {
            if (!number.All(Char.IsDigit))
            {
                return "Invalid number!";
            }

            return $"Dialing... {number}";
        }
        
    }
}
