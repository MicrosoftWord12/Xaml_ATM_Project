using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xaml_ATM_Project.ATM_Actions
{
    internal class Deposit
    {
        public static int DepositAmount(int cardPin, int cardNumber)
        {
            int currentBalance = Database.SelectCardBalance.CheckBalance(cardNumber, cardPin);
            int withdrawAmount = int.Parse(Console.ReadLine());
            int newAmount = currentBalance + withdrawAmount;

            try
            {
                String SQL = $"update useraccount set user_amount='{newAmount}' where='{cardNumber}'";
                return int.Parse(Database.DBCommand.Command(SQL).ExecuteScalar().ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }

        }
    }
}
