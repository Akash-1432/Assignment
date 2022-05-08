using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5
{
    internal class BankException :ApplicationException
    {
        public BankException(string msg) : base(msg)
        {

        } 

    }
    
        class Bank
        {
            int money=15000;
            String account_name="Akash Ugale";
            String account_number;
            static String bank_name = "Dautch bank";
            static public  int DepositeBalance;
            public void depositMoney()
            {
               
                    Console.WriteLine("\nEnter the amount you want to deposit:");
                    int depMoney = int.Parse(Console.ReadLine());
                    DepositeBalance = money + depMoney;
                    if (depMoney == 0)
                    {
                        Console.WriteLine("minimum deposit should be 15000 ");
                    }
                    else
                    {
                        Console.WriteLine("updated balance of " + account_name + " after deposit is " + DepositeBalance);
                    }
                
            }
            public void withdrawMoney()
            {
                try
                {
                    Console.WriteLine("Welcome " + account_name + " your accountbalance: " + DepositeBalance);
                    Console.WriteLine("\nEnter the amount you want to withdraw:");
                    int withdraw = int.Parse(Console.ReadLine());
                    DepositeBalance = DepositeBalance - withdraw;
                    if (withdraw > DepositeBalance)
                    {
                        Console.WriteLine("insuffiecient balance");
                    }
                    else
                    {
                        Console.WriteLine("updated balance of " + account_name + " after withdrawal is " + DepositeBalance);
                    }

                }
                 catch (Exception ex)
                {
                    Console.WriteLine("enter balance in number not in words input miss match exception ");
                }
            }
            public void Balance()
            {
                Console.WriteLine("welcome to the " + bank_name + "bank ");
                Console.WriteLine("Enter account number: ");
                account_number = Console.ReadLine();
                Console.WriteLine("Welcome " + account_name + " your account balance: " + money);

            }
        }
    class UserDefinedException 
    { 
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Balance();
            bank.depositMoney();
            bank.withdrawMoney();
            Console.ReadLine();
        }
    }
}
