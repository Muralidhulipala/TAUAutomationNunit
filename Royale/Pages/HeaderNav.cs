using OpenQA.Selenium;

namespace Royale.Pages
{
    public class HeaderNav
    {
        public readonly HeadernavMap Map;
        public HeaderNav(IWebDriver driver)
        {
            Map=new HeadernavMap(driver);
        }
        public void GoTo()
        {
            Map.cardnamelink.Click();
        }
    }

    public class HeadernavMap
    {
        IWebDriver _driver;
        public HeadernavMap(IWebDriver driver)
        {
            _driver=driver;
        }
        public IWebElement cardnamelink=>_driver.FindElement(By.CssSelector("[href='/cards']"));
    }
}
