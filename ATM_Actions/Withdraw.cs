using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xaml_ATM_Project.ATM_Actions
{
    internal class Withdraw
    {
        public static int WithdrawCash(int cardPin, int cardNumber)
        {

            int currentBalance = Database.SelectCardBalance.CheckBalance(cardNumber, cardPin);
            Console.WriteLine("How much would you like to withdraw?");
            int withdrawAmount = int.Parse(Console.ReadLine());
            int newAmount = currentBalance - withdrawAmount;
            if (currentBalance > withdrawAmount)
            {
                try
                {
                    String SQL = $"Update useraccounts set user_amount='{newAmount}' where card_number='{cardNumber}'";
                    return int.Parse(Database.DBCommand.Command(SQL).ExecuteScalar().ToString());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString()); return 0;
                }
            }
            else if (currentBalance < withdrawAmount)
            {
                throw new Exception("Sorry Not Enough Money in bank account");
            }
            else
            {
                throw new Exception("Sorry Not sure what the issue is here");
            }
        }
    }
}
