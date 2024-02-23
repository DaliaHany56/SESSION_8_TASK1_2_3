using SESSION_8_TASK1_2_3.TASK_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SESSION_8_TASK1_2_3
{
    public class SavingAccount : IBankAccount
    {
        public int maxWithdrrawPerDay = 8000;
        public string ClientName { get; }
        public int AccountId { get; }
        public double Balance { get; set; }
        public List<string> LogData { get; set; }
        public SavingAccount(string name, int id)
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
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                LogData.Add($"The withdrawn is more than your Balance ");
            }
            else if (amount > maxWithdrrawPerDay)
            {
                LogData.Add($"You cannot withdrawn more than {maxWithdrrawPerDay}");
            }
            else 
            {
                Balance -= amount;
                LogData.Add($"{amount} withdrawn");
                LogData.Add($"Current Balance = {Balance} EGP");
            }

        }
    }
}
