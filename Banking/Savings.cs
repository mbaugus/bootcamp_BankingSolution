using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Savings: Account
    {
        public decimal InterestRate { get; set; }

        public void ApplyInterest(int months)
        {
            for (int i = 0; i < months; i++)
            {
                decimal interestEarned = Balance * (InterestRate / 12);
                Transaction t = new Transaction(Transaction.TransactionTypes.INTEREST, interestEarned, Balance);
                Balance += interestEarned;
                AddTransactionHistory(t, Balance);
            }
        }
    }
}
