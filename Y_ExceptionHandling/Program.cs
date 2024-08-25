/*
Compiletime checking : valid SYNTEX of a specific language
Runtime checking : when compiletime checking is successful then in runtime checks the valid LOGICAL statements.
UnHandledException : when runtime error occures then "UnHandledException" comes into picture.
ExceptionHandling: to prevent the "UnHandledException" and to run the program successfully "ExceptionHandling" is a must.

Compile Errors:
1. language er syntex vul hole

Runtime Errors:
1. wrong implementation of logic : dhori amr array size 5 but ami index[6] print korte chacchi
2. wrong input supplied : input dewar kotha int but dilam string
3. missing requried resources : ami akta database create korlam but somehow delete hoye gelo 

LETS see akhon "Exception" ta ki?
Exception : program e jodi runtime error hoy taile oi line ei program ta je terminate kore tar nam e holo Exception.
 # Exception is a class : contains logic for abnormal terminaiton and a virtual method named "Message" that overrides by the child class as 
         - ApplicationException class : akta specific application er jonno (jemon ami chai divid by even numbers hobe always)
         - SystemException class : shob application er jonno (SystemException guli atar moddhe pore)
                -- IndexOutOFBoundsException
                -- FormatException
                -- ArithmaticException 
                        ---- DividedByZeroException
                        ---- OverflowException

SYNTEX : 
                    try    
                       {
                        -je code guli te runtime error aste pare
                        -runtime error asle je guli print howar dorkar nai
                        }
                    catch(exception_class _name variable)
                        {
                        runtime error asle ja korte hobe na ja message show korte hobe
                        }

                        try    
                       {
                        -je code guli te runtime error aste pare
                        -runtime error asle je guli print howar dorkar nai
                        }
                    catch(exception_class _name variable)
                        {
                        runtime error asle ja korte hobe na ja message show korte hobe
                        }
                        finally
                        {
                        -will must execute at any cost, it will execute both exception occurs or not
                        }


            
*/
using System;
namespace Y_ExceptionHandling
    {
    class DividedByOneException : ApplicationException
        {
        public override string Message 
            {
            get
                {
                return "Divided by one attempted";
                }
            }         
        }
    class Program
        {
        static void Main(string[] args)
            {
            /*
            ///statements without exception handling!!! 
            Console.WriteLine("This a valo code");
            int a, b;
            Console.WriteLine("Enter number 1");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            b = Convert.ToInt32(Console.ReadLine());

            int d = a / b;
            Console.WriteLine("That is number 1 / number 2 = "+d);
            */

            /*
            try
                {
                ///statements with exception handling!!!
                Console.WriteLine("This a valo code");
                int a, b;
                Console.WriteLine("Enter number 1");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2");
                b = Convert.ToInt32(Console.ReadLine());

                int d = a / b;
                Console.WriteLine("That is number 1 / number 2 = " + d);
                Console.WriteLine("Operation Completed!!");
                }
            //catch(FormatException fe)
                //{
                //Console.WriteLine(fe.Message);
                //}
            //catch (DivideByZeroException ze)
              //  {
               // Console.WriteLine(ze.Message);
                //}
            catch (Exception oth)
                {
                Console.WriteLine(oth.Message);
                }
            //catch
            // {
            //Console.WriteLine("jani na aida ki");
            // }
            Console.WriteLine("Program Ended!!");
            */

            /*
            ///1. SystemException class
            try
                {
                ///statements with exception handling!!!
                Console.WriteLine("This a valo code");
                int a, b;
                Console.WriteLine("Enter number 1");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2");
                b = Convert.ToInt32(Console.ReadLine());

                int d = a / b;
                Console.WriteLine("That is number 1 / number 2 = " + d);
                Console.WriteLine("Operation Completed!!");

                if (d == 1) return;
                }
            //catch(FormatException fe)
                //{
                //Console.WriteLine(fe.Message);
                //}
            //catch (DivideByZeroException ze)
              //  {
               // Console.WriteLine(ze.Message);
                //}
            catch (Exception oth)
                {
                Console.WriteLine(oth.Message);
                }
            //catch
            // {
            //Console.WriteLine("jani na aida ki");
            // }
            finally
                {
                Console.WriteLine("Finally Block Executed");
                }

            Console.WriteLine("Program Ended!!");
            */

            ///2. ApplicationException class
            //try
          //      {
                ///statements with exception handling!!!
                Console.WriteLine("This a valo code");
                int a, b;
                Console.WriteLine("Enter number 1");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2");
                b = Convert.ToInt32(Console.ReadLine());

                ///ApplicationException 
                if (b == 1)
                    {
                //ApplicationException ex = new ApplicationException();
                //throw ex;
                //throw new ApplicationException();
                //throw new ApplicationException("Divided by 1 exception");
                //throw new DividedByOneException();

                }

            int d = a / b;
                Console.WriteLine("That is number 1 / number 2 = " + d);
                Console.WriteLine("Operation Completed!!");

                if (d == 1) return;
              //  }
            //catch(FormatException fe)
            //{
            //Console.WriteLine(fe.Message);
            //}
            //catch (DivideByZeroException ze)
            //  {
            // Console.WriteLine(ze.Message);
            //}
            //catch (Exception oth)
                //{
              //  Console.WriteLine(oth.Message);
               // }
            //catch
            // {
            //Console.WriteLine("jani na aida ki");
            // }
           // finally
               // {
               // Console.WriteLine("Finally Block Executed");
              //  }

           // Console.WriteLine("Program Ended!!");

            }
        }
    }
