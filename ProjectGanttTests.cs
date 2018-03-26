using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using HandCodedFluentCUIT.Common;
using HandCodedFluentCUIT.ProjectService;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HandCodedFluentCUIT
{
    /// <summary>
    /// Summary description for CodedUITest2
    /// </summary>
    [CodedUITest]
    public class ProjectGanttTests
    {
        private static Process _process;

        [ClassInitialize]
        public static void ClassInitMethod(TestContext testContext)
        {
            Playback.Initialize();

            var bw = BrowserWindow.Launch(new Uri("about:blank"));
            _process = bw.Process;
            bw.CloseOnPlaybackCleanup = false;

            bw.NavigateToUrl(new Uri("https://promxtest20180312.crm4.dynamics.com/"));

            MicrosoftDynamics365Window bw1 = new MicrosoftDynamics365Window();
            bw1.CopyFrom(BrowserWindow.FromProcess(_process));
            new MainAppWindow(bw1).GoToProjectGantt();
        }

        [ClassCleanup]
        public static void ClassCleanUpMethod()
        {
/*            if (!Playback.IsInitialized)
            {
                Playback.Initialize();
            }

            BrowserWindow bw = BrowserWindow.FromProcess(_process);
            bw.Close();

            Playback.Cleanup();
*/        }

        [TestMethod]
        public void ProjectGantt_AccountListContainsTestAccount_Geeve()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;

            MicrosoftDynamics365Window bw = new MicrosoftDynamics365Window();
            bw.CopyFrom(BrowserWindow.FromProcess(_process));
            Assert.IsTrue( new MainAppWindow(bw)
                            .GoToProjectGantt()
                            .OpenFilter()
                            .SelectAccount()
                            .Refresh()
                            .AccoutListContains("Geeve"));
        }

        [TestMethod]
        public void AddProject()
        {
            MicrosoftDynamics365Window bw = new MicrosoftDynamics365Window();
            bw.CopyFrom(BrowserWindow.FromProcess(_process));
            Assert.IsTrue(new ProjectGanttWindow(bw)
                            .AddProject()
                            .IsItemStatusPaneEqual("+"));
        }

        [TestMethod]
        public void SaveChanges()
        {
            MicrosoftDynamics365Window bw = new MicrosoftDynamics365Window();
            bw.CopyFrom(BrowserWindow.FromProcess(_process));
            Assert.IsTrue(new ProjectGanttWindow(bw)
                .SaveChanges()
                .IsItemStatusPaneEqual("~"));
        }

        [TestMethod]
        public void AddTask()
        {
            MicrosoftDynamics365Window bw = new MicrosoftDynamics365Window();
            bw.CopyFrom(BrowserWindow.FromProcess(_process));
            new ProjectGanttWindow(bw)
                .AddTask();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        [TestCleanup]
        public void MyTestCleanup()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
//            ClickPrGButton();
        }

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }
    }
}
