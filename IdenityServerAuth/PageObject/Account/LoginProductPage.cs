using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdenityServerAuth.PageObject.Account
{
    public class LoginProductPage
    {
        private readonly IWebDriver _driver;
        private readonly By _user = By.Name("Username");
        private readonly By _password = By.Name("Password");
        private readonly By _next = By.Id("next");
        private readonly By _enter = By.Id("enter");

        public LoginProductPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void LoginAs(string user, string password)
        {
            _driver.FindElement(_user).SendKeys(user);
            _driver.FindElement(_next).Click();
            _driver.FindElement(_password).SendKeys(password);
            _driver.FindElement(_enter).Click();
        }
    }
}
