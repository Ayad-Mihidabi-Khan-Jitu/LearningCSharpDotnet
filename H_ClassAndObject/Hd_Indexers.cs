/*
Akta object er member guli k jokhon arrayr moto express korte para jay 
tokhon je process e eta kora hoy take indexers bole
*/
using System;
namespace H_ClassAndObject
    {
    class Student
        {
        internal int id;
        internal string name;
        internal string faculty;
        internal double cgpa;
        public Student(int id, string name, string faculty, double cgpa)
            {
            this.id = id;
            this.name = name;
            this.faculty = faculty;
            this.cgpa = cgpa;
            }
        public object this[int index]
            {
            get
                {
                if (index == 0) return id;
                else if (index == 1) return name;
                else if (index == 2) return faculty;
                else if (index == 3) return cgpa;
                else return null;
                }
            set
                {
                if (index == 0) id = (int)value;
                else if (index == 1) name = (string)value;
                else if (index == 2) faculty = (string)value;
                else if (index == 3) cgpa = (double)value;
                }
            }

        public object this[string Key]
            {

            get
                {
                if (Key == "id") return id;
                else if (Key == "name") return name;
                else if (Key == "faculty") return faculty;
                else if (Key == "cgpa") return cgpa;
                else return null;
                }
            set
                {
                if (Key == "id") id = (int)value;
                else if (Key == "name") name = (string)value;
                else if (Key == "faculty") faculty = (string)value;
                else if (Key == "cgpa") cgpa = (double)value;
                }


            /*
             ///type safe method
            get
                {
                if (Key.ToLower() == "id") return id;
                else if (Key.ToLower() == "name") return name;
                else if (Key.ToLower() == "faculty") return faculty;
                else if (Key.ToLower() == "cgpa") return cgpa;
                else return null;
                }
            set
                {
                if (Key.ToLower() == "id") id = (int)value;
                else if (Key.ToLower() == "name") name = (string)value;
                else if (Key.ToLower() == "faculty") faculty = (string)value;
                else if (Key.ToLower() == "cgpa") cgpa = (double)value;
                }
            */
            }
        }
    class Indexers
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Indexer");
            Student student = new Student(1702028, "Jitu", "CSE", 10.00);
            /*
            Console.WriteLine("ID : "+student.id); 
            Console.WriteLine("Name : "+student.name); 
            Console.WriteLine("Faculty : "+student.faculty); 
            Console.WriteLine("CGPA : "+student.cgpa); 
           */
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ID : " + student[0]);
            Console.WriteLine("Name : " + student[1]);
            Console.WriteLine("Faculty : " + student[2]);
            Console.WriteLine("CGPA : " + student[3]);

            student[0] = 1202028;
            student[1] = "Eshita";
            student[2] = "CSE";
            student[3] = 9.0;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("ID : " + student[0]);
            Console.WriteLine("Name : " + student[1]);
            Console.WriteLine("Faculty : " + student[2]);
            Console.WriteLine("CGPA : " + student[3]);

            student["id"] = 1212028;
            student["name"] = "Tuni";
            student["faculty"] = "CSE";
            student["cgpa"] = 99.0;
            //student["Cgpa"] = 99.0; //have to use type safe

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ID : " + student["id"]);
            Console.WriteLine("Name : " + student["name"]);
            Console.WriteLine("Faculty : " + student["faculty"]);
            Console.WriteLine("CGPA : " + student["cgpa"]);
            //Console.WriteLine("CGPA : " + student["Cgpa"]); //have to use type safe




            }
        }
    }
