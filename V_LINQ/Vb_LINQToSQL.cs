/*
 LINQ To SQL
 -Ata akta query language jeta relation database theke data query kore like SQL server.
 -Create(insert), Read(Select), Update, Delete kora jay LINQ er maddhome.
 
 NOTE : SQL server e query korar jonno to SQL e ache taile abar LINQ keno?
              In SQL -> SQL server
                    -SQL er syntex checking ta hoy runtime e that is SQL server engin dara.
                    -ata type safe na.
                    -Intellisense support nai
                    -Debugging of SQL statements is not possible
                    -Combination of SQL statements and OPP statements
                      Ex: "Insert Into Students Values ("+textBox1.Text+",'"+textBox2.Text+'")";
              In LINQ -> SQL server 
                    -Complile time syntex checking.
                    -ata type safe.
                    -Intellisense support nai
                    -Debugging of LINQ statements is possible
                    -Only OPP statements
                      That is:   
                      Table                               =>           Class
                      Colums                           =>           Property
                      Rows or Records         =>           Instance(object)
                      Stored Procedures     =>           Methods
*/
using System;
namespace LINQ
    {
    class Vb_LINQToSQL
        {
        static void Main()
            {
            Console.WriteLine("LINQ to SQL");
            }

            }
    }
