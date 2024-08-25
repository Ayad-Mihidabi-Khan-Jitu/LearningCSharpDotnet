/*
 Method overriding ar method hiding aki jinish
 taile tuita ala korar ki dorkar??
 Difference dekhle e bojha jabe:

 Overriding                                                                                                                       hiding
 ---------------------------------------------------------------------------------------------------------------------
 i) syntex:     Super Class                                     | i) syntex:            Super Class
     virtual functionName(){code}                     |     functionName(){code}           
                        Sub Class                                         |                                 Sub Class
    override functionName(){code}                   |     new functionName(){code} or functionName(){code} 
 ii) Main difference : Super class er instance jodi Sub class er instance k refer kore tahole 
                                        super class er instance dara probeshkrito overriden method betito method 
                                        direct Super Class er method k call kore. 
NOTE: method hiding holew instance variable hiding hoy na.
 */

///ami kichu akta
using System;
namespace Methods
    {
    class Ee_MethodHiding
        {
        public static void Main()
            {
            //Daughter meye = new Daughter();
            //meye.subMethod();
            //Father baba = meye;
            //baba.supMethod();
            //baba.VsupMethod();
            
            /*
            ///checking variable hiding (not valid)
            Father f1 = new Daughter();
            int v = f1.t;
            Console.WriteLine(v);
            Daughter d1 = (Daughter)f1;
            Console.WriteLine(d1.t);
           */
            }
        }
    class Father
        {
        //public int t = 100;
        public string f_name = "I am father";
        /*public void supMethod()
            {
            Console.WriteLine("This is in Super Class : "+f_name);
            }
        */
        
        public virtual void VsupMethod()
            {
            Console.WriteLine("This is in Super Class : (defined as virtual) " + f_name);
            }
        
        }
    class Daughter:Father
        {
        //public int t = 50;
        public string d_name = "I am daughter";
        //public void supMethod()
        /*
        public new void supMethod()
            {
            Console.WriteLine("This is in Sub Class : " + d_name);
            }
        */
        
        public override void VsupMethod()
            {
            Console.WriteLine("This is in Sub Class : (defined as overriden) " + d_name);
            }
        

        }
    }
