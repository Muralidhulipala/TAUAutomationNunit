using OpenQA.Selenium;
using Royale.Pages;

namespace Rayale.Pages
{
    public abstract class PageBase
    {
        public readonly HeaderNav header;
        public PageBase(IWebDriver driver)
        {
            header=new HeaderNav(driver);
        }

    }
    
}