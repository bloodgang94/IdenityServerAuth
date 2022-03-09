using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdenityServerAuth.PageObject.Account
{
    public class RequestRecoveryPasswordPage
    {
        private readonly IWebDriver _driver;
        public IWebElement EmailInput => _driver.FindElement(By.XPath("//input[@placeholder='Введите email']"));
        public IWebElement SaveButton => _driver.FindElement(By.XPath("//span[.='Продолжить']/.."));
        public IWebElement ValidateText => _driver.FindElement(By.XPath("//div[@class='el-form-item__error']"));


        public RequestRecoveryPasswordPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SendRecoveryLink(string email)
        {
            EmailInput.Clear();
            EmailInput.SendKeys(email);
            SaveButton.Click();
        }
    }
}
