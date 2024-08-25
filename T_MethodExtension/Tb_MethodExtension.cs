/*
 Extension Method : kono class(sealed class) or structure e kono method externally add korar je prokriya. 
 ai mechanism e existing class er re compilation er dorkar hoy na
 Extension Method er Boisisto : 
 1. Extension Method ti obossoi static hobe, ar amra aita jani static method static class e thake.
2. Extension Method er first parameter ti obossoi je class er moddhe bind korte chacchi seta hobe.
3. Extension Method guli orginal method guli k override korte pare na.
SYNTEX : accessModifier    static    returnType   MethodName (this  Class  ObjectReference ) { method body; }
NOTE: Inheritance is a mechanism jetar maddhome method extension er e samoyek shubidha pete pari but
             - A "scaled class" can't be inherited
             - A "structure" can't be inherited
*/

using System;
namespace T_MethodExtension
    {
    static class Tb_MethodExtension
        {
        ///Method Extension on classes
        internal static void Method2(this Ta_OldClass oldClass)
            {
            Console.WriteLine("This is Method 4");
            }

        internal static void Method3(this Ta_OldClass oldClass)
            {
            Console.WriteLine("This is Method 3");
            }

        internal static void Method4(this Ta_OldClass oldClass, int i)
            {
            Console.WriteLine("This is Method "+i);
            }

        ///Method Extension on structure [Int32]
        public static long Factorial(this Int32 i)
            {
            if (i == 1) return 1;
            else if (i == 2) return 2;
            else return (i * Factorial(i-1));
            }

        public static int AddAB(this Int32 N, int i,int j)
            {
            return (i+j);
            }

        ///Method Extension on sealed class [string]
        public static string ToProper(this String s)
            {
            s = s.Trim(); /// let s = " jitu is " then s.Trim() returns "jitu is"
            if (s.Length > 0)
                {
                string ProperString = null;
                s = s.ToLower();
                string[] words = s.Split(' ');
                for (int i = 0; i < words.Length; i++)
                    {
                    char[] letters = words[i].ToCharArray();
                    letters[0] = Char.ToUpper(letters[0]);
                    //words[i] = letters.ToString();
                    words[i] = new string(letters);

                    if (ProperString == null)
                        {
                        ProperString = words[i];
                        }
                    else
                        {
                        ProperString = ProperString + ' ' + words[i];
                        }
                    }
                return ProperString;
                }
            return s;
            }


        }
    }
