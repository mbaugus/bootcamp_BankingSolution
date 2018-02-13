using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Investment
    {
        public Account account { get; set; }
        public Investment()
        {
            account = new Account();
        }
        public Investment(Account a)
        {
            if(a != null)
                account = a;
        }
        public void Deposit(decimal amount)
        {
            account.Deposit(amount);
        }
        public void WithDraw(decimal amount)
        {
            account.WithDraw(amount);
        }
        public void GetBalance()
        {
            account.GetBalance();
        }
        public void ShowHistory()
        {
            account.ShowHistory();
        }
    }
}
