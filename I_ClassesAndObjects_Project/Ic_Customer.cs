using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsOfClassesAndObjects
    {
    class Ic_Customer
    {
        private string name;
        private Ib_Account account; //a object name account of the class Account
        public Ic_Customer(string n, Ib_Account a)
        {
            name = n;
            account = a;
        }
        public void display()
        {
            Console.WriteLine("Name : " + name + " | Account Number : " + account.getAccountNumber() + " | Balance : " + account.getBalance());
        } 
        public string getName()
        {
            return name;
        }
        public Ib_Account  getAccount()
        {
            return account;
        }

    }
}
