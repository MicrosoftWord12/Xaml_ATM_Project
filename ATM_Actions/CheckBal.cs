using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xaml_ATM_Project.ATM_Actions
{
    internal class CheckBal
    {
        public static int CheckCardBalance(int cardNumber, int cardPin)
        {
            return Database.SelectCardBalance.CheckBalance(cardNumber, cardPin);
        }
    }
}
