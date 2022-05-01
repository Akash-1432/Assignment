using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Program
    {
       class Bankingsystem
        {
            string accountname = "Akash ugale";
            int amount = 30000;
            static int newbalance;
            public void Bank_Balance()
            {
                { Console.WriteLine("Hello! {0} your account balance is: {1}", accountname, amount); }

            }
            public void Deposite()
            {
                try
                { Console.WriteLine("Enter the amount to deposite: "); 
                    int dm = int.Parse(Console.ReadLine());
                    newbalance = amount + dm;
                    Console.WriteLine("Amount depositted successfully!");
                    Console.WriteLine("Total amount in your account is: {0}", newbalance);
                }
                catch (Exception) { Console.WriteLine("Please enter Valid amount"); }
            }
            public void Withdraw()
            {
                try { Console.WriteLine("Enter amount to withdraw: ");
                    int withdrawamount=int.Parse(Console.ReadLine());
                    newbalance = amount - withdrawamount;

                    if (withdrawamount > amount) { Console.WriteLine("Insufficient Amount! Please check your balance"); 
                    }
                    else
                    { Console.WriteLine("Amount withdrawn successfully"); 
                        Console.WriteLine("Remaining amount in your account is: {0}", newbalance); }
                }
                catch (Exception) { Console.WriteLine("Please enter Valid amount."); }   
                
            }
        }
        static void Main(string[] args)
        {
            Bankingsystem bank = new Bankingsystem();
            string accountname = "Akash Ugale";
            string bankname = "HDFC Bank";
            string accountnumber;
            int Pin;         
            int action;
            Console.WriteLine("Hi! {0} welcome to {1} bank", accountname, bankname);
            Console.WriteLine("Please Enter the account number: ");
            accountnumber = Console.ReadLine();
            Console.WriteLine("Welcome! {0}", accountname);
            Console.WriteLine("Please enter pin to access your account");
            Pin = int.Parse(Console.ReadLine());
            if (Pin == 9876) 
                { Console.WriteLine("Select the action to continue the process:"); }
            else
            { Console.WriteLine("Incorrect pin! Please check your pin and try again."); } 
            action=int.Parse(Console.ReadLine());
            if (action == 1) { bank.Bank_Balance(); }
            else if (action == 2) { bank.Deposite(); }
            else if (action == 3) { bank.Withdraw(); }
            else { Console.WriteLine("You have not selected any action! Try again."); }
            Console.Read();
        }
    }
}
