using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var list = new List<string>()
{
    "На базе 9 классов",
    "На базе 11 классов",
    "Бюджет",
    "Платное",
    "Очно",
    "Очно-заочно",
    "Заочно",
    "Дистанционно"
};

IWebDriver driver = new ChromeDriver();

driver.Url = @"https://postupi.info/college/5/spec/448";

driver.FindElement(By.CssSelector(".checkbox"));

//while (true)
//{
//    Task.Delay(1000).Wait();

//    driver.FindElement(By.XPath("//label[@for='budget'][contains(.,'Бюджет')]")).Click();
//}

while (true)
{
    list.ForEach(x =>
    {
        Task.Delay(1000).Wait();

        driver.FindElement(By.XPath($"//label[contains(.,'{x}')]")).Click();
    });
}


Console.Read();