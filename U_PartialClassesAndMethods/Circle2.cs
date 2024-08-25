/*
 C# contains a special method is known as a partial method, 
 which contains declaration part in one partial class and definition part in 
 another partial class or may contain both declaration and definition in the same partial class.
Important Points:
1. The declaration of the partial method must begin with partial modifier.
2. The partial method may contain ref.
3. The partial method does not contain out parameters.
4. It is implicitly private method.
5. It can be a static method.
6. Partial method is generic.
7. It can have only void return type.
8. A partial method is created only in partial class or in partial struct.
9. The inplementation of a partial method is optional, 
    if the implementation is absent the compiler will remove the declartion and all tha calls
SYNTEX: 
partial void method_name
{
    // Code
}
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace U_PartialClassesAndMethods
    {
    internal partial class Circle
        {
        internal void GetArea()
            {
            double area = PI * radius * radius;
            Console.WriteLine("Area of the circle is : "+area);
            }
        internal void GetPerimeter()
            {
            double perimeter = 2 * PI * radius;
            Console.WriteLine("Perimeter of the circle is : " + perimeter);
            }

        /*
        ata kaj kortese na bole preview unsupported
        internal partial void GetPerimeter();
        internal partial void GetPerimeter()
            {
            double perimeter = 2 * PI * radius;
            Console.WriteLine("Perimeter of the circle is : " + perimeter);
            } 
         
        */
        }
    }
