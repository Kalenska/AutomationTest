using OpenQA.Selenium;

namespace Automation_UI_Test_RSM.Pages
{
    public partial class LandingPage : PageBase
    {
        public LandingPage(IWebDriver driver) : base(driver) { }

        public string PageTtile { get; set; }

        public IWebElement FirmDetailsBox()
        {
            return driver.FindElement(By.Id("ctl00_SPWebPartManager1_g_7a908d86_a3d2_4695_9fb2_188ba31b05c1_ctl00_firmDetails"));
        }

        public IWebElement PeopleBox()
        {
            return driver.FindElement(By.Id("ctl00_SPWebPartManager1_g_7a908d86_a3d2_4695_9fb2_188ba31b05c1_ctl00_peopleManagement"));
        }

        public IWebElement InviteUserBox()
        {
            return driver.FindElement(By.Id("ctl00_SPWebPartManager1_g_7a908d86_a3d2_4695_9fb2_188ba31b05c1_ctl00_inviteUser"));
        }

        public IWebElement AdministrationBox()
        {
            return driver.FindElement(By.Id("ctl00_SPWebPartManager1_g_7a908d86_a3d2_4695_9fb2_188ba31b05c1_ctl00_administrationPage"));
        }
    }
}
