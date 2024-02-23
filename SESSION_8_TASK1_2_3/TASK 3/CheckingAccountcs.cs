using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SESSION_8_TASK1_2_3.TASK_3
{
    public class CheckingAccount : IBankAccount
    {
        public string ClientName { get; }
        public int AccountId { get; }
        public double Balance { get; set; }
        public List<string> LogData { get; set; }
        public CheckingAccount(string name, int id)
        {
                ClientName = name;
                AccountId = id;
                Balance = 0;
                LogData = new List<string>();
        }
        public void ShowAccountData()
        {
            Console.WriteLine($"this account is for {ClientName}\n" +
                  $"ID {AccountId} \n" +
                  $"Current Balance:{Balance}\n" +
                  $"\n\nLog History:\n\n{string.Join("\n", LogData)}");
        }
        public void Deposit(double amount)
        {
            Balance += amount;
            LogData.Add($"YOUR Balance after deposit = {Balance}");
        }
        public void Withdraw(double amount1)
        {
            if (amount1 <= Balance)
            {
               Balance -= amount1;
                LogData.Add($"{amount1} withdrawn");
                LogData.Add($"Current Balance = {Balance} EGP");
            }
            else
            {
                LogData.Add("The withdrawn is more than your Balance ");
                LogData.Add($"Current Balance = {Balance} EGP");
            }
        }
    }
}
