using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using HandCodedFluentCUIT.Account;
using HandCodedFluentCUIT.Common;
using HandCodedFluentCUIT.ProjectService;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


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

            //new LoginWindow(MainBrowserWindow)
            //    .LoginAction()
            //    .GoToProjectGantt().OpenFilter();
            new MainAppWindow(new MicrosoftDynamics365Window())
                .GoToProjectGantt();
        }

        [ClassCleanup]
        public static void ClassCleanUpMethod()
        {
            if (!Playback.IsInitialized)
            {
                Playback.Initialize();
            }

            BrowserWindow bw = BrowserWindow.FromProcess(_process);
            bw.Close();

            Playback.Cleanup();
        }

        [TestMethod]
        public void ProjectGantt_AccountListContainsTestAccount_Geeve()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;

            MicrosoftDynamics365Window bw = new MicrosoftDynamics365Window();
            bw.CopyFrom(BrowserWindow.FromProcess(_process));
            Assert.IsTrue( new ProjectGanttWindow(bw)
                            //.GoToProjectGantt()
                            .OpenFilter()
                            .SelectAccount()
                            .Refresh()
                            .AccoutListContains("Geeve"));
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

        /*
        private static MicrosoftDynamics365Window m_mainBrowserWindow;

        private static MicrosoftDynamics365Window MainBrowserWindow
        {
            get
            {
                if (m_mainBrowserWindow == null)
                {
                    m_mainBrowserWindow = new MicrosoftDynamics365Window();
                }

                return m_mainBrowserWindow;
            }
        }
*/
    }
}
