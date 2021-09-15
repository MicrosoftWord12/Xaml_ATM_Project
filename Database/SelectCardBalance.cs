using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xaml_ATM_Project.Database
{
    internal class SelectCardBalance
    {
        public static int CheckBalance(int cardNumber, int cardPin)
        {
            //String SQL = $"select user_amount from useraccounts where card_number = '" + cardNumber+ '" and card_pin =" + cardPin + "'";
            String SQL = $"select user_amount from useraccounts where card_number='{cardNumber}' and card_pin ='{cardPin}'";
            String balance = DBCommand.Command(SQL).ExecuteScalar().ToString();
            return int.Parse(balance);
        }
    }
}
