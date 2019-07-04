using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomatedTests.Template
{

    
    public class BrowserNavigator
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
                
        public void Start()
        {
            Driver = new ChromeDriver();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
        }

        public void Stop()
        {
            Driver.Close();
            Driver.Quit();
            Driver.Dispose();
        }        
    } 
}