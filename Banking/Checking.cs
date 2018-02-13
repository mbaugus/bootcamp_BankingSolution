using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>

namespace Banking
{
    public class Checking : Account
    {
        public int LastCheck { get; set; }
        // monthly fee?
        // overdraft protection limit
        // anniversery date monthly?
        public void WithDraw(decimal amount, int checknumber)
        {
            LastCheck = checknumber;
            Transaction t = new Transaction(Transaction.TransactionTypes.WITHDRAW, amount, Balance);
            if ((amount < 0) | (Balance - amount < 0)){
                t.Success = false;
            }
            else{
                Balance -= amount;
            }

            t.CheckNumber = checknumber;
            AddTransactionHistory(t, Balance);
        }

        public override string ToPrint()
        {
            return "Acct Name=" + Owner.FullName + ", Acct ID=" + Id + ", Desc=" + Description + ", Bal=" +
                DecimalToString(Balance) + " Last check#" + LastCheck ;
        }
    }
}
