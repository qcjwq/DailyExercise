using System;
using System.Collections.Generic;

namespace BitAction
{
    class Program
    {
        static void Main(string[] args)
        {
            var power = new List<int> { 1, 2, 4, 8, 16, 32, 64 };
            var value = 126;

            foreach (var i in power)
            {
                if ((value & i) != 0)
                {
                    Console.WriteLine($"对于{value}，有power[{i}]所代表的权限");
                }
            }

            value = 0;
            WriteLine($"{value}^=1", value ^= 1);
            WriteLine($"{value}|=4", value |= 4);
            WriteLine($"{value}|=8", value |= 8);

            if ((value & 2) == 2)//对于【异或】操作，一定要先判断【与】操作
            {
                WriteLine($"{value}^=2", value ^= 2);
            }
            else
            {
                Console.WriteLine($"({value}&2) != 2");
            }

            WriteLine($"{value}^=2", value ^= 2); //注意

            /* 输出
            (0^=1) == 1
            (1|=4) == 5
            (5|=8) == 13
            (13&2) != 2
            (13^=2) == 15
            */

            Console.ReadKey();
        }

        private static void WriteLine(string message, int value)
        {
            Console.WriteLine($"({message}) == {value}");
        }
    }
}
