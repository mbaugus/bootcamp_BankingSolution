using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Transaction
    {
        public enum TransactionTypes
        {
            WITHDRAW,
            DEPOSIT,
            CHECKBALANCE,
            INTEREST,
            TRANSFER_FROM,
            TRANSFER_TO
        };

        public Transaction(TransactionTypes type, decimal amount, decimal balanceBefore)
        {
            TypeOfTransaction = type;
            Amount = amount;
            TimeInitiated = System.DateTime.Now;
            GUID = Guid.NewGuid();
            Success = true;
            BalanceBefore = balanceBefore;
        }

        public Guid GUID { get; set; }
        public DateTime TimeInitiated { get; set; }
        public TransactionTypes TypeOfTransaction { get; set; }
        public Decimal Amount { get; set; }
        public bool Success { get; set; }
        public Decimal BalanceBefore { get; set; }
        public Decimal BalanceAfter { get; set; }
        public Decimal InterestApplied { get; set; }
        public int TransferToAccountID {get; set;}
        public int TransferFromAccountID { get; set; }
        public int CheckNumber { get; set; }
    }
}
