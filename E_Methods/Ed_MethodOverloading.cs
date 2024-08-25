using  System;
namespace Methods
    {
    class Ed_MethodOverloading
        {
        ///methods are overloaded jokhon duier odhik methods same nam e thakbe and tara shotontro method rup e kaj korbe
        //but tader return type othoba parameter er data type e vinnota thakbe
        // NOTE : dui ta method er moddhe minimum akta vinnota thaklei tara overloaded hobe 
        // 1. return int, parameter int int
        public  static  int addtion(int a, int b)
         {
          int sum;
          sum = a + b;
          return sum;
         }

        // 2. return long, parameter long long
        public static long addtion(long a, long b)
            {
            long sum;
            sum = a + b;
            return sum;
            }

        // 3. return double, parameter double double
        public static double addtion(double a, double b)
        {
       double sum;
       sum = a + b;
       return sum;
        }

        // 4. return decimal, parameter decimal decimal
        public static decimal addtion(decimal a, decimal b)
            {
            decimal sum;
            sum = a + b;
            return sum;
            }
        // 5. return decimal, parameter decimal int
        public static decimal addtion(decimal a, int b)
            {
            decimal sum;
            sum = a + b;
            return sum;
            }
        static void Main()
            {
           int addInt = addtion(400000000, 2);
            Console.WriteLine(" int addtion(int a, int b) " + addInt);
            long addLong = addtion(4000000000000000000, 200000000000000);
            Console.WriteLine(" long addtion(long a, long b) " + addLong);
            double addDouble = addtion(5555555555555555555555555555555555555.56, 55555555555555555555555555555555557.8);
            Console.WriteLine(" double addtion(double a, double b) " + addDouble);
            decimal addDecimal = addtion(2878787878777777777, 2878787878777777777);
            Console.WriteLine(" decimal addtion(decimal a, decimal b) " + addDecimal);
            double addDoubInt = addtion(1.5, 2);
            Console.WriteLine(" double addtion(double a, int b) " + addDoubInt);
            }
        }
    }
