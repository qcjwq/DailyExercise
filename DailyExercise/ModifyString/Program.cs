using System;

namespace ModifyString
{
    class Program
    {
        static void Main(string[] args)
        {
            string csharp = "I love CSharp";
            Console.Write(csharp + " = ");

            unsafe
            {
                fixed (char* pJava = csharp)
                {
                    pJava[7] = 'J';
                    pJava[8] = 'a';
                    pJava[9] = 'v';
                    pJava[10] = 'a';
                    pJava[11] = ' ';
                    pJava[12] = ' ';
                }
            }

            Console.WriteLine(csharp);
            Console.WriteLine("I love CSharp".Equals("I love Java  "));
            Console.ReadKey();
        }
    }
}
