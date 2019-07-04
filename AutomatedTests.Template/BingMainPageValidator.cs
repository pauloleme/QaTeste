using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AutomatedTests.Template
{

    public class BingMainPageValidator
    {
        private readonly IWebDriver browser;
        public BingMainPageValidator(IWebDriver browser)
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
        public void ResultsCount(int expectedCount)
        {
            var currentText = Map.ResultsCountDiv.Text;

            Assert.IsTrue(currentText.Contains("RESULTS"), "The results DIV doesn’t contains the specified text.");

            var currentCount = Convert.ToInt32(currentText.Split(' ')[0].Replace(".",""));
            Assert.Greater(currentCount, expectedCount);
        }
    }
}