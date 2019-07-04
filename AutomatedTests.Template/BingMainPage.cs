using OpenQA.Selenium;

namespace AutomatedTests.Template
{
    public class BingMainPage
    {
        private readonly IWebDriver browser;
        private readonly string url = @"http://www.bing.com/";
        public BingMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }
        protected BingMainPageElementMap Map
        {
            get
            {
                return new BingMainPageElementMap(browser);
            }
        }   
        public BingMainPageValidator Validate()
        {
            return new BingMainPageValidator(browser);
        }
        public void Navigate()
        {
            browser.Navigate().GoToUrl(url);
        }
        public void Search(string textToType)
        {
            Map.SearchBox.Clear();
            Map.SearchBox.SendKeys(textToType);            
        }
        public void GoButtonClick()
        {            
            Map.GoButton.Click();
        }
    }
}