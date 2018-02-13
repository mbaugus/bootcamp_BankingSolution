using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Account acct1 = new Account();
            // Account acct2 = new Account();
            // Savings savingsAcct = new Savings();
            // savingsAcct.InterestRate = .015m;

            // Customer customer = new Customer(1, "Mike");
            // Customer customer2 = new Customer(2, "Hank");

            // savingsAcct.Owner = customer;
            // savingsAcct.Description = "Mikes Savings Account";
            // savingsAcct.Id = 3;

            // acct1.Owner = customer;
            // acct1.Description = "Mikes checking account";
            // acct1.Id = 1;

            // acct2.Owner = customer2;
            // acct2.Description = "Hanks checking";
            // acct2.Id = 2;



            // acct1.Deposit(200.10m);
            // acct1.WithDraw(1000.35m);
            // acct1.WithDraw(-10000.00m);
            // acct1.WithDraw(100.24m);
            // acct1.Deposit(502.51m);
            // acct1.WithDraw(300.21m);
            // acct1.Deposit(50.00m);

            //// acct1.ShowHistory();

            // Account.Transfer(acct1, acct2, 2.22m);

            // acct1.ShowHistory();
            // acct2.ShowHistory();

            // savingsAcct.Deposit(15000.00m);
            // savingsAcct.ApplyInterest(6);
            // savingsAcct.ShowHistory();

            // WriteLine(acct1.ToPrint());
            // WriteLine(acct2.ToPrint());
            // WriteLine(savingsAcct.ToPrint());

            //Checking mychecking = new Checking();
            //mychecking.Description = "Mike Bob's Checking Account 1";
            //Customer c = new Customer(10, "Mike Bob");
            //mychecking.Owner = c;
            //mychecking.Deposit(1000.00m);

            //Checking mychecking2 = new Checking();
            //mychecking2.Description = "Mike Bob's Checking Account 2";
            //mychecking2.Owner = c;
            //mychecking2.Deposit(500.00m);

            //Savings mysaving = new Savings();
            //mysaving.Description = "Mike Bob's Savings Account 1";
            //mysaving.Owner = c;
            //mysaving.Deposit(1500.00m);

            //Account[] accounts = { mychecking, mychecking2, mysaving };


            //for(int i = 0; i < 50; i++)
            //{
            //    mysaving.Deposit((decimal)i * 50);
            //}
            //foreach (var i in accounts)
            //{

            //   // WriteLine(i.ToPrint());
            //}

            //// mychecking.WithDraw(500.00m, 5);
            ////WriteLine(mychecking.ToPrint());
            //mysaving.ShowHistory();

            
            Account account = new Account();
            account.Description = "Its an investment not account";
            Investment i = new Investment(account);
            i.Deposit(500.00m);
            i.ShowHistory();
        }
    }
}
