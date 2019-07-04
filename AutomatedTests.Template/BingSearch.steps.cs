using TechTalk.SpecFlow;

namespace AutomatedTests.Template
{
    [Binding]
    [Scope(Tag = "simpleSearchTag")]
    public class BingSearch
    {
        private BrowserNavigator navigator;
        private BingMainPage bingPage;

        [Given(@"Opened Browser")]
        public void GivenOpenedBrowser()
        {
            navigator = new BrowserNavigator();
            navigator.Start();
        }

        [Given(@"Navigate to Bing Url")]
        public void GivenNavigateToBingUrl()
        {
            bingPage = new BingMainPage(navigator.Driver);
            bingPage.Navigate();
        }

        [When(@"Enter text on search box")]
        public void WhenEnterTextOnSearchBox()
        {
            bingPage.Search("Automate The Planet");
        }

        [When(@"Click on SearchButton")]
        public void WhenClickOnSearchButton()
        {
            bingPage.GoButtonClick();
        }

        [Then(@"Show the results")]
        public void ThenShowTheResults()
        {
            bingPage.Validate().ResultsCount(2000000);
        }

        [Then(@"Close Browser")]
        public void ThenCloseBrowser()
        {
            navigator.Stop();
        }
    }
}