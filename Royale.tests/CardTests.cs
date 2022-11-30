
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Rayale.Pages;


namespace Royale.test
{
    public class CardTests
    {
        IWebDriver driver;
        [SetUp]
        public void Beforeeachtest()
        {
            driver = new ChromeDriver(@"../../../../" + "_drivers");
            driver.Url = "https://statsroyale.com";
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void Aftereachtest()
        {
            driver.Quit();
        }
        [Test]
        public void Ice_spririt_is_on_card_list()
        {
            CardsPage page = new CardsPage(driver);
            var cardpresent = page.GoTo().GetCardnamebyName("Ice Spirit");

            Assert.That(cardpresent.Displayed);
        }
        [Test]

        public void Ice_spririt_details_are_displaying_correctly()
        {

            var cardspage = new CardsPage(driver);
            cardspage.GoTo().GetCardnamebyName("Ice Spirit").Click();
            var detailspage = new CardDetailsPage(driver);
            var (cat, value) = detailspage.GetCategoryname();

            var cardname = detailspage.Map.cardname.Text;
            var details = driver.FindElement(By.CssSelector(".card__rarity")).Text.Split(", ");
            var cardnamedetails = cat;
            var cardnamevalue = value;
            Assert.AreEqual("Ice Spirit", cardname);
            Assert.AreEqual("Troop", cardnamedetails);
            Assert.AreEqual("Arena 8", cardnamevalue);

        }
    }
}