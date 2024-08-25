/*
C# Coding Standards
C# is a general-purpose, modern and object-oriented programming language pronounced as “C Sharp”. 
It was developed by Microsoft led by Anders Hejlsberg and his team within the .NET initiative and was approved by 
the European Computer Manufacturers Association (ECMA) and International Standards Organization (ISO). 
C# is among the languages for Common Language Infrastructure. C# is a lot similar to Java syntactically 
and is easy for users who have knowledge of C, C++, or Java.

Below are some of the best practices which all the .Net Developers should follow:

1. Class and Method names should always be in Pascal Case
public class Employee
{
    public Employee GetDetails()
    {
        //...
    }
    public double GetBonus()
    {
        //...
    }
}

2. Method argument and Local variables should always be in Camel Case
public class Employee
{
    public void PrintDetails(int employeeId, String firstName)
    {
        int totalSalary = 2000;
        // ...
    }
}

3. Avoid the use of underscore while naming identifiers
// Correct
public DateTime fromDate;
public String firstName;
 
// Avoid
public DateTime from_Date;
public String first_Name;

4. Avoid the use of System data types and prefer using the Predefined data types.
// Correct
int employeeId;
string employeeName;
bool isActive;
 
// Avoid
Int32 employeeId;
String employeeName;
Boolean isActive;

5. Always prefix an interface with letter I.
// Correct
public interface IEmployee
{
}
public interface IShape
{
}
public interface IAnimal
{
}

// Avoid
public interface Employee
{
}
public interface Shape
{
}
public interface Animal
{
}

6. For better code indentation and readability always align the curly braces vertically.
// Correct
class Employee
{
    static void PrintDetails()
    {
    }
}
 

// Avoid
class Employee
    {
    static void PrintDetails()
    {
      }
}

7. Always use the using keyword when working with disposable types. It automatically disposes the object when program flow leaves the scope.
using(var conn = new SqlConnection(connectionString))
{
    // use the connection and the stream
    using (var dr = cmd.ExecuteReader())
    {
     //
    }
}

8. Always declare the variables as close as possible to their use.
// Correct
String firstName = "Shubham";
Console.WriteLine(firstName);
//--------------------------
 
// Avoid
String firstName = "Shubham";
//--------------------------
//--------------------------
//--------------------------
Console.WriteLine(firstName);

9. Always declare the properties as private so as to achieve Encapsulation and ensure data hiding.
// Correct
private int employeeId { get; set; }

// Avoid
public int employeeId { get; set; }

10. Always seperate the methods, different sections of program by one space.
// Correct
class Employee
{
private int employeeId { get; set; }

public void PrintDetails()
{
//------------
}
}

// Avoid
class Employee
{

private int employeeId { get; set; }



public void PrintDetails()
{
//------------
}

}

11. Constants should always be declared in UPPER_CASE.
// Correct
public const int MIN_AGE = 18;
public const int MAX_AGE = 60;

// Avoid
public const int Min_Age = 18;
public const int Max_Age = 60; 
 
*/

/*using System;
namespace A_CSharpCodingStandard
    {
    class Aa_CSCodingStd
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Standard Coding Style of C#");

            }
        }
    }*/
