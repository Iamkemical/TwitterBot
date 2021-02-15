using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwitterBot
{
    public class StartupClass
    {
        public static FirefoxDriver fireFoxDriver;
        public static void Startup()
        {
            FirefoxOptions options = new FirefoxOptions();

            // Makes browser to hide
            //options.AddArgument("--headless");
            FirefoxDriverService firefoxDriverService = FirefoxDriverService.CreateDefaultService();
            firefoxDriverService.HideCommandPromptWindow = true;
            fireFoxDriver = new FirefoxDriver(firefoxDriverService, options);
        }

        public static void SharePost()
        {
            // Goes to the Twitter Login page
            fireFoxDriver.Navigate().GoToUrl("https://www.twitter.com/login");

            Thread.Sleep(5000);

            ConsoleLogger.ConsoleLog("You are now on Twitter's Login Page!");

            // Finding Username and Password Input box using XPath
            IWebElement usernameInput = fireFoxDriver
                .FindElementByXPath("/html/body/div/div/div/div[2]/main/div/div/div[2]/form/div/div[1]/label/div/div[2]/div/input");

            IWebElement userPasswordInput = fireFoxDriver
                .FindElementByXPath("/html/body/div/div/div/div[2]/main/div/div/div[2]/form/div/div[2]/label/div/div[2]/div/input");

            ConsoleLogger.ConsoleLog("Username and Password Input successfully located!");

            // Clicks on the Username Input box
            usernameInput.Click();
            // Enters Username in Input box
            usernameInput.SendKeys("Enter your username");

            // Clicks on the Password Input box
            userPasswordInput.Click();
            // Enters Password into the Input box
            userPasswordInput.SendKeys("Enter your password");

            Thread.Sleep(250);

            // Finds and Clicks on Login Button
            fireFoxDriver.FindElementByXPath("/html/body/div/div/div/div[2]/main/div/div/div[2]/form/div/div[3]/div/div").Click();

            ConsoleLogger.ConsoleLog("Logged In and redirecting to Home page...");

            Thread.Sleep(4000);

            // Locates New Tweet Input
            IWebElement tweetInputArea = fireFoxDriver.FindElementByXPath("/html/body/div/div/div/div[2]/main/div/div/div/div/div/div[2]/div/div[2]/div[1]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/div/div/div/div[1]/div/div/div/div[2]/div");

            // Enters tweet
            tweetInputArea.SendKeys("Hi! This is my bot tweeting. This bot is built using C#.");

            ConsoleLogger.ConsoleLog("Tweet successfully entered!");

            Thread.Sleep(3000);

            // Finds and Clicks on the tweet button to send tweet.
            fireFoxDriver.FindElementByXPath("/html/body/div/div/div/div[2]/main/div/div/div/div/div/div[2]/div/div[2]/div[1]/div/div/div/div[2]/div[4]/div/div/div[2]/div[3]/div/span/span").Click();

            ConsoleLogger.ConsoleLog("Tweet successfully shared!");

            Thread.Sleep(6000);

            // Delete Tweet after tweeting!



            fireFoxDriver.Quit();
        }
    }
}
