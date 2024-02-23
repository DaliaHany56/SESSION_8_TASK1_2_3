using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SESSION_8_TASK1_2_3.TASK_3
{
    public interface IBankAccount
    {
        string ClientName { get; }
        int AccountId { get; }
        double Balance { get; set; }

        List<string> LogData { get; set; }
        void ShowAccountData();
        void Deposit(double amount);
        void Withdraw(double amount);





    }
}
