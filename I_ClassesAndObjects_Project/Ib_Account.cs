using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsOfClassesAndObjects
    {
    class Ib_Account
    {
        private double balance = 100.00; //parivate korse karon jate direct access kora na jay
        private string accountNumber;   // private instance variable guli ke method er maddhome access kora jay
        private bool firstTimeWithdrawal = true; // jeta akdom last e getBalance() and getAccountNumber()
       /*public  Account(string accnum)//Constructure
        {
            accountNumber = accnum;
        }*/
        public Ib_Account(string accnum,double accbalan)//Constructure
        {
            accountNumber = accnum;
            if (accbalan >= 100) 
            {
                balance = accbalan;
            }
            else
            {
                balance = 100;
            }
            
        }
        public void deposite(double depmoney)
        {
            if (depmoney > 0)
            {
                balance = balance + depmoney;
                Console.WriteLine(depmoney + " tk was successfully deposited in your account");
                Console.WriteLine("The new balance of your account is "+balance);
            }
            else
            {
                Console.WriteLine("Please ensure the amount to deposited is not negative");
            }
        }
        public void withdraw(double withdramoney)
        {
            if (withdramoney > 0)
            {
                if (firstTimeWithdrawal)
                {
                    double tempBalance = balance;
                    tempBalance = tempBalance - withdramoney;
                    if (tempBalance >= 100)
                    {
                        balance = balance - withdramoney;
                        Console.WriteLine("This is your first withdrawal!! It's free!!");
                        Console.WriteLine("You have Withdrawn "+withdramoney+" tk from your account sucessfully");
                        Console.WriteLine("Now Your Accont Balace is : " + balance);
                        firstTimeWithdrawal = false;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance!");
                        Console.WriteLine("You can't withdraw " + withdramoney); 
                    }
                   
                }
                else
                {
                    Ia_Bank bank = new Ia_Bank();
                    double tempBalance = balance; ;
                    tempBalance = tempBalance - withdramoney-bank.getTransectionFees();
                    if (tempBalance >= 100)
                    {
                        balance = balance - withdramoney- bank.getTransectionFees();
                        Console.WriteLine("You have Withdrawn " + withdramoney + " from your account sucessfully");
                        Console.WriteLine("Transaction Fee is : " + bank.getTransectionFees());
                        Console.WriteLine("Now Your Accont Balace is : " + balance);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance!");
                        Console.WriteLine("You can't withdraw " + withdramoney); 
                    }

                }
            }
            else
            {
                Console.WriteLine("You can't withdraw " + withdramoney + " tk");
            }
        }
        public double getBalance()
        {
            return balance;
        }
        public string getAccountNumber()
        {
            return accountNumber ;
        }

    }
}
