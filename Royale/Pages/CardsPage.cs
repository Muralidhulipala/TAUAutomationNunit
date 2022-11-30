using OpenQA.Selenium;

namespace Rayale.Pages
{
    public class CardsPage: PageBase
    {
        public readonly CardsPageMap Map;
        public CardsPage(IWebDriver driver):base(driver)
        {
           Map= new CardsPageMap(driver);
        }
        public IWebElement GetCardnamebyName(string name)
        {
            if(name.Contains(" "))
            {
                name=name.Replace(" ","+");
            }
            return Map.iconIcespirit(name);
        }
        public CardsPage GoTo()
        {
            header.GoTo();
            return this;
        }
    }
    public class CardsPageMap
    {
        IWebDriver _driver;
        public CardsPageMap(IWebDriver driver)
        {
            _driver=driver;
        }
        public IWebElement iconIcespirit(string name)=>_driver.FindElement(By.CssSelector($"[href*='{name}']"));

    }
}