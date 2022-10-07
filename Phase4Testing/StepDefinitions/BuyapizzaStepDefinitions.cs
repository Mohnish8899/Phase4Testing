using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Phase4Testing.StepDefinitions
{
    [Binding]
    public class BuyapizzaStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public BuyapizzaStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\mohsin.baviskar\\Downloads\\chromedriver_win32");
        [Given(@"I am going to navigate a website")]
        public void GivenIAmGoingToNavigateAWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://localhost:7249/");
        }

        [When(@"i click on purchase pizza button")]
        public void WhenIClickOnPurchasePizzaButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var PurchasepizzaButton = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", PurchasepizzaButton);
        }

        [Then(@"Displays Menu")]
        public void ThenDisplaysMenu()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
        }

        [When(@"I click on purchase now button")]
        public void WhenIClickOnPurchaseNowButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var PurchasenowButton = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/div[2]/div/div[1]/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", PurchasenowButton);
        }

        [Then(@"Displays order details page")]
        public void ThenDisplaysOrderDetailsPage()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
        }

        [When(@"I click on confirm button")]
        public void WhenIClickOnConfirmButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var confirmButton = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", confirmButton);
        }

        [Then(@"Displays thank you page")]
        public void ThenDisplaysThankYouPage()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
        }
    }
}
