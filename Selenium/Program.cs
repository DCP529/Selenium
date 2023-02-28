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

driver.Url = @"https://www.mos.ru/dpir/function/napravlenie-deyatelnosti-dpir/razvitie-chelovecheskogo-kapitala/detskie/";

driver.FindElement(By.CssSelector(".checkbox"));


#region
//while (true)
//{
//    

//    driver.FindElement(By.XPath("//label[@for='budget'][contains(.,'Бюджет')]")).Click();
//}

//while (true)
//{
//    list.ForEach(x =>
//    {
//        Task.Delay(1000).Wait();

//        driver.FindElement(By.XPath($"//label[contains(.,'{x}')]")).Click();
//    });
//}
#endregion

var c = "";

for (int i = 1; i < 22; i++)
{
    Task.Delay(2000).Wait();

    c = driver.FindElement(By.XPath($"(//div[contains(@class,'titleText')])[{i}]")).GetAttribute("textContent");

    Console.WriteLine(c);
}


Console.Read();