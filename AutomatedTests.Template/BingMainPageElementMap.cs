using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace AutomatedTests.Template
{

    public class BingMainPageElementMap
    {
        private readonly IWebDriver browser;
        public BingMainPageElementMap(IWebDriver browser)
        {
            this.browser = browser;
            PageFactory.InitElements(browser, this);
        }
        [FindsBy(How = How.Id, Using = "sb_form_q")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.Id, Using = "sb_form_go")]
        public IWebElement GoButton { get; set; }

        [FindsBy(How = How.Id, Using = "b_tween")]
        public IWebElement ResultsCountDiv { get; set; }
    }
}