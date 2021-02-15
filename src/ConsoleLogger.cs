using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterBot
{
    public class ConsoleLogger
    {
        public static void ConsoleLog(string s)
        {
            Console.WriteLine($"[{DateTime.Now}] {s}");
        }
    }
}
