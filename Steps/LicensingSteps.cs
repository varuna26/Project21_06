using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowFirst.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowFirst.Steps
{
    [Binding]
    class LicensingSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly DriverHelper _driverHelper;
        CommonPage commonPage;
        //WorkspacePage workspacePage;
        PermittingPage permittingPage;
        LicensePage lp;
        //NotesPage notesPage;
        LoginPage loginPage;
        public LicensingSteps(DriverHelper driverHelper, ScenarioContext scenarioContext)
        {
            _driverHelper = driverHelper;
            _scenarioContext = scenarioContext;
            commonPage = new CommonPage(_driverHelper.webDriver);
            //workspacePage = new WorkspacePage(_driverHelper.webDriver);
            permittingPage = new PermittingPage(_driverHelper.webDriver);
            lp = new LicensePage(_driverHelper.webDriver);
            //notesPage = new NotesPage(_driverHelper.webDriver);
            loginPage = new LoginPage(driverHelper.webDriver);
        }


        [Given(@"The user logged into the application")]
        public void GivenTheUserLoggedIntoTheApplication()
        {
            loginPage.AppLogin("vv", "trakit1234");

        }

        [Given(@"The user is on '(.*)' window")]
        public void GivenTheUserIsOnWindow(string moduleName)
        {
            lp.ClickLeftPanelIcons(moduleName);


            Thread.Sleep(1000);
            Assert.That(commonPage.getPageTitle(moduleName), Does.Contain(moduleName).IgnoreCase);
        }

    }
}
