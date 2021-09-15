using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xaml_ATM_Project.Database
{
    internal class SelectCardPin
    {
        public int SelectPin(int cardNumber, int accountId)
        {
            String SQL = $"select card_pin from useraccounts where card_number='{cardNumber}' AND account_id='{accountId}";
            String command = DBCommand.Command(SQL).ExecuteScalar().ToString();
            return int.Parse(command);
        }
    }
}
