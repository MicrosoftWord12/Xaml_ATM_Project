using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xaml_ATM_Project.Database
{
    internal class SelectCardNumber
    {
        public static int SelectCardNum(int accountID)
        {
            String SQL = "select card_number from useraccounts where account_id=" + accountID + "'";
            String command = DBCommand.Command(SQL).ExecuteScalar().ToString();
            return int.Parse(command);
        }
    }
}
