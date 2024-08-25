using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsOfClassesAndObjects
    {
    class Ia_Bank
    {
        private double interestRate = 8.5;
        private double transactionFees = 10;
        private Ic_Customer[] customers= new Ic_Customer[1000]; //this is  object array | in c++ => int customer [1000];
        // "new Customer [1000]"  means "customer" has 1000 elements 

        /*
        ask which customer
        get the customer s account
        get the account s balance
        calculate interest amount to that balance and show user be their total
         */
        public void calculateInterest(Ic_Customer customer)
        {
            Ib_Account a = customer.getAccount();
            double balan = a.getBalance();
            double interestAmount = balan * (interestRate / 100);
            double totalBalance = balan + interestAmount;
            //Console.WriteLine("Interest Amount : " + interestAmount + " | Total Balance after adding the interest :" + totalBalance);
            Console.WriteLine("Interest Amount : {0:F1}  | Total Balance after adding the interest : {1:F1}", interestAmount, totalBalance);
        }
       public double getInterestRate()
        {
            return interestRate;
        }
        public double getTransectionFees()
        {
            return transactionFees;
        }
        public Ic_Customer[] getCustomer()
        {
            return customers;
        }

    }
}
