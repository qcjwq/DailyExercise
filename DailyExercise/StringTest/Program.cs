using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            string b = string.Empty;
            string c = null;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            var temp = a.Equals(b);
            temp = a.Equals(c);

            temp = b.Equals(a);
            temp = b.Equals(c);

            temp = c.Equals(a);//“System.NullReferenceException”类型的未经处理的异常在 StringTest.exe 中发生 其他信息: 未将对象引用设置到对象的实例。
            temp = c.Equals(b);//“System.NullReferenceException”类型的未经处理的异常在 StringTest.exe 中发生 其他信息: 未将对象引用设置到对象的实例。

            Console.ReadKey();
        }
    }
}
