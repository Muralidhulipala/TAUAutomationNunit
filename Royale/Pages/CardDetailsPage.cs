using OpenQA.Selenium;

namespace Rayale.Pages
{
    public class CardDetailsPage
    {
        public readonly CardDetailsPageMap Map;
        public CardDetailsPage(IWebDriver driver)
        {
            Map=new CardDetailsPageMap(driver);
        }
        public (string type,string name) GetCategoryname()
        {
            var details=Map.cardcategory.Text.Split(", ");
            string cat=details[0];
            string name=details[1];
            return (cat,name);
        }
    }
    public class CardDetailsPageMap
    {
        IWebDriver driver;
        public CardDetailsPageMap(IWebDriver driver)
        {
            this.driver=driver;
        }
        public IWebElement cardname=>driver.FindElement(By.CssSelector(".card__cardName"));
        public IWebElement cardcategory=>driver.FindElement(By.CssSelector(".card__rarity"));
        
    }
}