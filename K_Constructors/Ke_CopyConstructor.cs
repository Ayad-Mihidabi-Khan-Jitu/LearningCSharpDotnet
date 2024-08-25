/*
 ata special kichui na just amon akta constructor jeta parameter hisebe object reference ney that's why oi object ta hububu copy hoye jay.
*/

using System;
namespace Constructor
{
    class Ke_CopyConstructor
    {
        string name;

        Ke_CopyConstructor(string n)
            {
            Console.WriteLine("First constructor taking string as parameter");
            this.name = n;
            }

        Ke_CopyConstructor(Ke_CopyConstructor c)
            {
            Console.WriteLine("Second constructor taking The Class as parameter");
            this.name = c.name;
            }

        void DisplayName()
            {
            Console.WriteLine("Name : " + this.name);
            }


        public static void Main()
        {
            Console.WriteLine("Entering into the main method");
            Ke_CopyConstructor c1 = new Ke_CopyConstructor("Jitu");
            c1.DisplayName();

            Ke_CopyConstructor c2 = new Ke_CopyConstructor("Eshita");
            c2.DisplayName();

            Ke_CopyConstructor c3 = new Ke_CopyConstructor(c1);
            c3.DisplayName();

            Ke_CopyConstructor c4 = new Ke_CopyConstructor(c2);
            c4.DisplayName();
            }
    }
}
