using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Collection
    {
    class Dd_GenericClassesWithUserDefinedType
        {
        /*
        /// Sorting Process-3 : User Defined Type Student on ascending order using Delegate 
        internal static int CompareName(Student s1,Student s2)
            {
            if (String.Compare(s1.name, s2.name) > 0) return 1;
            if (String.Compare(s1.name, s2.name) < 0) return -1;
            else return 0;
            }
        */
        static void Main(string[] args)
            {
            Console.WriteLine("Generic Classes With User Defined Type");
            Console.WriteLine("-----------------------------------------");

            /*
            ///Process-1 (value initializing)
            Student s1 = new Student("Jitu", 1702028, 10.0);
            Student s3 = new Student("Titu", 2102082, 1.0);
            Student s2 = new Student("Eshita", 2002028, 9.99);
            */


            ///Process-2 (value initializing)
            Student s1 = new Student { name = "Jitu", id = 1702028, cgpa = 10.0 };
            Student s3 = new Student { name = "Titu", id = 2102082, cgpa = 1.0 };
            Student s2 = new Student { name = "Eshita", id = 2002028, cgpa = 9.99 };

            ///List (value initializing)
            List<Student> students = new List<Student>() {s1,s2,s3};
            //students.Add(s1); students.Add(s2); students.Add(s3);

            ///Printing the value of students (unordered)
            Console.WriteLine(" {0,-15}{1,-15}{2,-5}", "NAME", "ID", "CGPA");
            foreach (Student stu in students)
                {
                string name = stu.name;
                int id = stu.id;
                double cgpa = stu.cgpa;
                Console.WriteLine(" {0,-15}{1,-15}{2,-5}", name, id, cgpa);
                }Console.WriteLine("Unordered List");

            /*
            ///Sorting Process-1 : User Defined Type Student on ascending order using IComparable
            students.Sort();
            //students.Reverse();
            Console.WriteLine(" {0,-15}{1,-15}{2,-5}", "NAME", "ID", "CGPA");
            //Printing the value of students (sorted by ID)
            foreach (Student stu in students)
                {
                string name = stu.name;
                int id = stu.id;
                double cgpa = stu.cgpa;
                Console.WriteLine(" {0,-15}{1,-15}{2,-5}",name,id,cgpa);
                }Console.WriteLine("Sorted by ID");

            ///Sorting Process-2 : User Defined Type Student on ascending order using IComparer
            SortStudent orderOfname = new SortStudent();
            students.Sort(orderOfname);
            Console.WriteLine(" {0,-15}{1,-15}{2,-5}", "NAME", "ID", "CGPA");
            //Printing the value of students (sorted by Name)
            foreach (Student stu in students)
                {
                string name = stu.name;
                int id = stu.id;
                double cgpa = stu.cgpa;
                Console.WriteLine(" {0,-15}{1,-15}{2,-5}", name, id, cgpa);
                }Console.WriteLine("Sorted by Name");
            */

            /*
            ///Sorting Process-3 : User Defined Type Student on ascending order using Delegate 
            Comparison <Student> orderofName = new Comparison<Student>(CompareName);
            //students.Sort(orderofName); //passing the created delegate orderofName
            //students.Sort(CompareName); //passing the created method CompareName; it automatically does the creation of delegate as previous one
            Console.WriteLine(" {0,-15}{1,-15}{2,-5}", "NAME", "ID", "CGPA");
            //Printing the value of students (sorted by Name)
            foreach (Student stu in students)
                {
                string name = stu.name;
                int id = stu.id;
                double cgpa = stu.cgpa;
                Console.WriteLine(" {0,-15}{1,-15}{2,-5}", name, id, cgpa);
                }Console.WriteLine("Sorted by Name");
            */

            /*
            ///Sorting Process-4 : User Defined Type Student on ascending order using Anonymous Methods
            students.Sort(delegate (Student s1,Student s2) { //syntex of enormas method: delegate (type var,...){-logic}
                if (String.Compare(s1.name, s2.name) > 0) return 1;
                if (String.Compare(s1.name, s2.name) < 0) return -1;
                else return 0;
                }); //creating Anonymous method and writng the same logic 
          
            Console.WriteLine(" {0,-15}{1,-15}{2,-5}", "NAME", "ID", "CGPA");
            //Printing the value of students (sorted by Name)
            foreach (Student stu in students)
                {
                string name = stu.name;
                int id = stu.id;
                double cgpa = stu.cgpa;
                Console.WriteLine(" {0,-15}{1,-15}{2,-5}", name, id, cgpa);
                }Console.WriteLine("Sorted by Name");
            */

            /*
            ///Sorting Process-5 : User Defined Type Student on ascending order using Lambda expression
            students.Sort((n1,n2)=> String.Compare(n1.name, n2.name)); //creating Lambda expression writng the same logic 
            Console.WriteLine(" {0,-15}{1,-15}{2,-5}", "NAME", "ID", "CGPA");
            //Printing the value of students (sorted by Name)
            foreach (Student stu in students)
                {
                string name = stu.name;
                int id = stu.id;
                double cgpa = stu.cgpa;
                Console.WriteLine(" {0,-15}{1,-15}{2,-5}", name, id, cgpa);
                }Console.WriteLine("Sorted by Name");
            */
            }
        }

    
    ///1. User Defined Type Student
   class Student
       {
        /*
       ///Process-1 (value initializing)
       internal string name;
       internal string id;
       internal double cgpa;
       internal Student(string n, string i, double c)
           {
           this.name = n;
           this.id = i;
           this.cgpa = c;
           }
        */

       ///Process-2 (value initializing)
       internal string name { get; set; }
       internal int id { get; set; }
       internal double cgpa { get; set; }
       }
      

    /*
    /// Sorting Process-1 : User Defined Type Student on ascending order using IComparable
    class Student : IComparable<Student>
        {
        /*
         ///Process-1 (value initializing)
         internal string name;
         internal int id;
         internal double cgpa;
         internal Student(string n, int i, double c)
             {
             this.name = n;
             this.id = i;
             this.cgpa = c;
             }
        */

        /*
        ///Process-2 (value initializing)
        internal string name { get; set; }
        internal int id { get; set; }
        internal double cgpa { get; set; }
        public int CompareTo(Student another)
            {
            if (this.id > another.id) return 1;
            else if (this.id > another.id) return -1;
            else return 0;
            }
        /*
        public int CompareTo(Student another)
            {
            if (this.cgpa > another.cgpa) return 1;
            else if (this.cgpa > another.cgpa) return -1;
            else return 0;
            }
     
        }
     */

    /*
    /// Sorting Process-2 : User Defined Type Student on ascending order using IComparer
    class SortStudent : IComparer <Student>
        {
        public int Compare(Student x, Student y)
            {
            if (String.Compare(x.name, y.name) > 0) return 1;  // return -1; for descending
            else if (String.Compare(x.name, y.name) < 0) return -1; // return 1; for descending
            else return 0;
            }
        }
    */

    }
