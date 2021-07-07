using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SpecflowFirst.Pages
{
    class LicensePage: CommonPage
    {
        private IWebDriver _webDriver;
        //CommonPage common;
        NotesPage notesPage;
        LoginPage loginPage;
        public LicensePage(IWebDriver webDriver) : base(webDriver)
        {
            _webDriver = webDriver;
            notesPage = new NotesPage(webDriver);
            loginPage = new LoginPage(webDriver);
        }
        public IWebElement informationPane => _webDriver.FindElement(By.Id("ctl27"));
       
        // public IWebElement btnClickLicense => _webDriver.FindElement(By.Id("spanIconLicense2"));
        public IWebElement ReturnHeaderElement()
        {
            return informationPane;
        }
        public void ClickLicenseIcon()
        {
            WaitsHelper.WaitUntilClickable(_webDriver, iconLicense, TimeSpan.FromSeconds(20));

            iconLicense.Click();

            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            SwitchToFrame(Convert.ToString(FrameNameEnum.FRMLICENSE));

            //            SwitchToFrame(Convert.ToString(ModuleEnum.Licensing));
            //(moduleName.Contains(Convert.ToString(ModuleEnum.Permitting)
        }
    }
}