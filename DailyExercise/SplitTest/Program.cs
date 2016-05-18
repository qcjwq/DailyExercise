using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = string.Empty;
            string b = null;
            var c = "";
            var d = " ";
            var e = "1,";
            var f = "1,2";

            Print(a, b, c, d, e, f);


            var list = Enumerable.Empty<string>().ToList();
            var cc = a.Split(',').ToList();

            Console.ReadKey();
        }

        static void Print(params string[] strs)
        {
            foreach (var str in strs.Where(a => a != null))
            {
                var ss = str.Split(',');
                if (ss.Length > 1)
                {
                    Print(ss.ToArray());
                }
                else
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
