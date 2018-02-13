using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        public int Id { get; set; }
        public string Description { get; set; }
        protected decimal Balance;
        public Customer Owner { get; set; }
        private List<Transaction> History;
        
        public Account()
        {
            History = new List<Transaction>();
        }
        public void Deposit(decimal amount)
        {
            Transaction t = new Transaction(Transaction.TransactionTypes.DEPOSIT, amount, Balance);
            if (amount < 0)
            {
                t.Success = false;
            }
            else
            {
                Balance += amount;
            }
            AddTransactionHistory(t, Balance);
        }

        public void WithDraw(decimal amount)
        {
            Transaction t = new Transaction(Transaction.TransactionTypes.WITHDRAW, amount, Balance);
            if ( (amount < 0) | (Balance - amount < 0) )
            {
                
                t.Success = false;
            }
            else
            {
                Balance -= amount; 
            }
            AddTransactionHistory(t, Balance);
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public virtual string ToPrint()
        {
            return "Acct Name=" + Owner.FullName + ", Acct ID=" + Id + ", Desc=" + Description + ", Bal=" + DecimalToString(Balance);
        }

        public void ShowHistory()
        {
            StringBuilder s = new StringBuilder();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("History for " + Description + ".");
            foreach (Transaction tran in History)
            {
                s.Append(tran.TimeInitiated + "- " + tran.TypeOfTransaction + " ");
                if (tran.Success) {
                    s.Append("Success (");
                }
                else
                {
                    s.Append("Failed (");
                }
              
                s.Append(DecimalToString(tran.Amount) + ")");
                s.Append(" Prior Bal: " + DecimalToString(tran.BalanceBefore) + " ");
                s.Append("New Bal: " + DecimalToString(tran.BalanceAfter));
                if(tran.CheckNumber > 0)
                {
                    s.Append(", Chknum: " + tran.CheckNumber);
                }
                //s.Append("ID: " + tran.GUID);
                s.Append("\n");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(s.ToString());
            Console.ResetColor();
        }


        public string DecimalToString(decimal number)
        {
            return "$" + String.Format("{0:0.00}", number);
        }

        public void AddTransactionHistory(Transaction transaction, decimal endingBalance)
        {
            transaction.BalanceAfter = endingBalance;
            History.Add(transaction);
        }

        public static void Transfer(Account transferFrom, Account transferTo, decimal amount)
        {
            Transaction fromTran = new Transaction(Transaction.TransactionTypes.TRANSFER_FROM, amount, transferFrom.Balance);
            Transaction toTran = new Transaction(Transaction.TransactionTypes.TRANSFER_TO, amount, transferTo.Balance);
        
            if (amount < 0 || transferFrom.Balance - amount < 0)
            {
                fromTran.Success = false;
                toTran.Success = false;
            }
            else
            {
                transferFrom.Balance -= amount;
                transferTo.Balance += amount;
            }
            transferTo.AddTransactionHistory(toTran, transferTo.Balance);
            transferFrom.AddTransactionHistory(fromTran, transferFrom.Balance);
            //Console.WriteLine("From " + transferFrom.Description + " to " + transferTo.Description + " " + amount);
        }


    }
}