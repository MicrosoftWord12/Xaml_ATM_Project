using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xaml_ATM_Project.Database
{
    internal class SelectAccountID
    {
        public static int SelectAccountId(int cardNumber)
        {
            String sql = "select account_id from useraccounts where card_number='" + cardNumber + "'";
            String command = DBCommand.Command(sql).ExecuteScalar().ToString();
            return int.Parse(command);
        }
    }
}
