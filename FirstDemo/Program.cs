using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace FirstDemo;
class Program
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://www.google.com");

        driver.FindElement(By.Name("q")).SendKeys("Hello");

        Thread.Sleep(10000);

        driver.Quit();
    }
}
