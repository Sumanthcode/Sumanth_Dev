using FirstReqnrollProject.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReqnrollProject.StepDefinitions
{
    [Binding]
    internal class LoginSteps
    {

        IWebDriver driver;
        AppSettings settings =  Config.LoadSettings();

        [Given("User navigate to Signup page")]
        public void GivenUserNavigateToSignupPage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(settings.Url);
        }

    }
}
