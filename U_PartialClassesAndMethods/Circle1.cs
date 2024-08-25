/*
A partial class is a special feature of C#. 
It provides a special ability to implement the functionality of a single class into multiple files and all these 
files are combined into a single class file when the application is compiled. A partial class is created by using a partial keyword. 
This keyword is also useful to split the functionality of methods, interfaces, or structure into multiple files.
Here are some points that you should be when you are developing a partial class.
1. Need to use partial keyword in each part of partial class.
2. The name of each part of partial class should be the same but 
     source file name for each part of partial class can be different.
3. All parts of a partial class should be in the same namespace.
4. Each part of a partial class should be in the same assembly or DLL, in other words you can't 
    create a partial class in source files of a different class library project.
5. Each part of a partial class has the same accessibility.
6. If you inherit a class or interface on a partial class then it is inherited on all parts of a partial class.
7. If a part of a partial class is sealed then the entire class will be sealed.
8. If a part of partial class is abstract then the entire class will be an abstract class.
SYNTEX: 
partial class class_name
{
    // Code
}
NOTE: mot kotha akta normal class er khetre ja ja boisistho chilo partial class guli ke akta purno 
             class bibechona kore normal class er motoi boisistho hobe.
*/
using System;
using System.Collections.Generic;
using System.Text;
namespace U_PartialClassesAndMethods
    {
    internal partial class Circle
        {
        internal double radius;
        internal const double PI = 3.1416;
        internal Circle(double r)
            {
            radius = r;
            }
        }
    }
