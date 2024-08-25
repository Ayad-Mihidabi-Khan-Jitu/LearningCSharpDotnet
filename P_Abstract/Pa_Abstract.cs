/*
 Abstract Class : Abstract holo akta bishesh dhoroner class. Je class er moddhe mininum 1 ta ABSTRACT METHOD thake take abstract class bole.
 accha abstract class to bujhlam but abstract method ta ki??
 Abstract Method : je method er body thake na just head thake take abstract method bole
 Abstract Class er  boisisto : 
 Abstract class er kono object banano jay na. What taile eida dia kam da ki ???
 1. Abstract class k jodi kew inherit kore taile taile sei child class er maddhome abstract parent class k access kora jay
     tobe obossoi abstract parent class er je method ti incomplete(method head) chilo take complete(method define) korte hobe
     jodi ata na kori taile ai child class ta o abstract hoye jabe. abong ata obossoi kammo na infact taile kono class er e object 
     create kora jabe na.
 2. Abstract class static hote pare na. constructors and static methods can't be declared as "abstract"
 3. Abstract class gulir baki shob boisisto normal class er motoi, ar abstract class k kew na kew inherit korbe abong incomple method 
     complete korbei.
 4. Abstract class k je inherit korlo that is je class abstract class er method or methods guli implement korlo seguli k obossoi override korbe.
 5. Abstract class er instance variable guli by default private thake, normal method re motoi abstract method private thake kintu for using 
     purpose abstract method k minimum internal/protected kore nite hoy.
 Syntex : abstract class ClassName {  } 
 NOTE : Abstract class er objcet toiri kora jay but seta akhane nai, next e dekhbo insha-Allah
 Why to use abstract??
 Niche akta ghotona ache, in brief same mathod jate sobai implement kore seta enseure kora. 
 ekhane jeta ache seta holo akjon parent er onk guli child ache. 
 */

using System;
namespace Abstract
    {
     class Pa_Abstract
        {
         static void Main(string[] args)
            {

            Console.WriteLine("_________________________________");
            Console.WriteLine("| Welcome to JSA Restaurant Ltd.|");
            Console.WriteLine("| Daily Sale Ammount : "+ DateTime.Now.ToShortDateString()+" |");
            Console.WriteLine("|_______________________________|");
            Console.WriteLine("");
            
            //JSA jsa = new JSA(); //abstract class er object creata kora sombov na
            //JSA_Dhaka jsadhaka = new JSA_Dhaka();
            //JSA_Barishal jsabarishal = new JSA_Barishal();
            //JSA_Pabna jsapabna = new JSA_Pabna();

            //jsadhaka.CalculateSale();          
            //jsabarishal.CalculateSale();
            //jsapabna.CalculateSale();
            //jsadhaka.NonAbstract();

            /*
            /// checking non abstract
            jsadhaka.NonAbstract();
            jsabarishal.NonAbstract();
            jsapabna.NonAbstract();
            */

            
            ///Smart System
            Console.Write("JSA Dhaka Enter Sale Rate  : ");
            int r1 = Convert.ToInt32(Console.ReadLine());
            JSA_Dhaka jsaDhaka = new JSA_Dhaka(r1);
            Console.Write("JSA Dhaka Enter Sale Ammount  : ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            jsaDhaka.CalculateSale(s1);

            Console.Write("JSA Pabna Enter Sale Rate : ");
            int r2 = Convert.ToInt32(Console.ReadLine());      
            JSA_Pabna jsaPabna = new JSA_Pabna(r2);
            Console.Write("JSA Pabna Enter Sale Ammount : ");
            int s2 = Convert.ToInt32(Console.ReadLine()); 
            jsaPabna.CalculateSale(s2);

            Console.Write("JSA Barishal Enter Sale Rate : ");
            int r3 = Convert.ToInt32(Console.ReadLine());
            JSA_Barishal jsaBarishal = new JSA_Barishal(r3);
            Console.Write("JSA Barishal Enter Sale Ammount : ");
            int s3 = Convert.ToInt32(Console.ReadLine());
            jsaBarishal.CalculateSale(s3);
            

            /*
            JSA jsa = new JSA(1,2,3)
                { 
                    
                }
           */
            }
        }
        abstract class JSA
        {  
        /*
        internal int saleRateOfDhaka = 12;
        internal int saleRateOfBarishal = 14;
        internal int saleRateOfPabna = 14;
         //abstract internal void CalculateSale(); 
        */
        /*
        internal virtual void NonAbstract()
            {
            Console.WriteLine("This is NonAbstract From JSA Class");
            }
        */
        

        
        ///Smart System
        internal int saleRateOfDhaka;
        internal int saleRateOfBarishal;
        internal int saleRateOfPabna;  
        abstract internal void CalculateSale(int s);
            
        }
        class JSA_Dhaka : JSA
        {
        //int s = 10;
        /*
        override internal void CalculateSale()
            {
            Console.WriteLine("JSA Restaurant LTD,Dhaka");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Today's Sale : " + saleRateOfDhaka * s);
            Console.WriteLine("");
            }
        */

        /*
         ///ata nonabstract method
         internal sealed override void NonAbstract()
            {
            Console.WriteLine("This is NonAbstract From JSA_Dhaka Class");
            }
        */
        

        
        ///Smart System
        public JSA_Dhaka(int saleRateOfDhaka)
            {
            base.saleRateOfDhaka = saleRateOfDhaka;
            }

        override internal void CalculateSale(int s)
            {
            Console.WriteLine("JSA Restaurant LTD,Dhaka");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Today's Sale : " + saleRateOfDhaka * s);
            Console.WriteLine("");
            }
        
        }
     class JSA_Barishal : JSA
        {
        //int s = 15;

        /*
        override internal void CalculateSale()
            {
            Console.WriteLine("JSA Restaurant LTD,Barishal");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Today's Sale : " + saleRateOfBarishal * s);
            Console.WriteLine("");
            }
        */
        
        ///Smart System
        public JSA_Barishal(int saleRateOfBarishal)
            {
            base.saleRateOfBarishal = saleRateOfBarishal;
            }
        override internal void CalculateSale(int s)
            {
            Console.WriteLine("JSA Restaurant LTD,Barishal");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Today's Sale : " + saleRateOfBarishal * s);
            Console.WriteLine("");
            }
        

        }
    class JSA_Pabna : JSA
        {
        //int s = 15;
        /*
        override internal void CalculateSale()
            {
            Console.WriteLine("JSA Restaurant LTD,Pabna");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Today's Sale : " + saleRateOfPabna * s);
            Console.WriteLine("");
            }
        */
        
        ///Smart System
        public JSA_Pabna(int saleRateOfPabna)
            {
            base.saleRateOfPabna = saleRateOfPabna;
            }
        override internal void CalculateSale(int s)
            {
            Console.WriteLine("JSA Restaurant LTD,Pabna");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Today's Sale : " + saleRateOfPabna * s);
            Console.WriteLine("");
            }
        }

    }
