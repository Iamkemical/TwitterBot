using OpenQA.Selenium.Firefox;
using System;

namespace TwitterBot
{
    class Program
    {
        static void Main(string[] args)
        {
            StartupClass.Startup();
            StartupClass.SharePost();
        }
    }
}
