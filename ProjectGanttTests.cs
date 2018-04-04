using System;
using HandCodedFluentCUIT.Common;
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
//        private static Process _process;
        private static BrowserWindow s_bw;

        [ClassInitialize]
        public static void ClassInitMethod(TestContext testContext)
        {
//            Playback.Initialize();

//            var bw = BrowserWindow.Launch("https://promxtest20180312.crm4.dynamics.com/");
//            bw.TechnologyName = "Web";
//            bw.CloseOnPlaybackCleanup = false;
//            _process = bw.Process;

/*
            MicrosoftDynamics365Window bw1 = new MicrosoftDynamics365Window();
            bw1.CopyFrom(BrowserWindow.FromProcess(_process));
            new MainAppWindow(bw1).GoToProjectGantt();
*/
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
            MicrosoftDynamics365Window bw1 = new MicrosoftDynamics365Window();
            bw1.CopyFrom(s_bw);
           
            new MainAppWindow(bw1)
                .GoToProjectGantt()
                .OpenFilter();

/*
            Assert.IsTrue( new MainAppWindow(bw1)
                            .GoToProjectGantt()
                            .OpenFilter()
                            .SelectAccount()
                            .Refresh()
                            .AccoutListContains("Geeve"));
*/
        }

        [TestMethod]
        public void AddProject()
        {
            //MicrosoftDynamics365Window bw = new MicrosoftDynamics365Window();
            //bw.CopyFrom(BrowserWindow.FromProcess(_process));
            //Assert.IsTrue(new ProjectGanttWindow(bw)
            //                .AddProject()
            //                .IsItemStatusPaneEqual("+"));
        }

        [TestMethod]
        public void SaveChanges()
        {
            //MicrosoftDynamics365Window bw = new MicrosoftDynamics365Window();
            //bw.CopyFrom(BrowserWindow.FromProcess(_process));
            //Assert.IsTrue(new ProjectGanttWindow(bw)
            //    .SaveChanges()
            //    .IsItemStatusPaneEqual("~"));
        }

        [TestMethod]
        public void AddTask()
        {
            //MicrosoftDynamics365Window bw = new MicrosoftDynamics365Window();
            //bw.CopyFrom(BrowserWindow.FromProcess(_process));
            //new ProjectGanttWindow(bw)
            //    .AddTask();
        }

        [TestMethod]
        public void DeleteTask()
        {
            //MicrosoftDynamics365Window bw = new MicrosoftDynamics365Window();
            //bw.CopyFrom(BrowserWindow.FromProcess(_process));
            //new ProjectGanttWindow(bw)
            //    .ColapseAll()
            //    .DeleteTask();
        }

        [TestMethod]
        public void DeleteeProject()
        {
            //MicrosoftDynamics365Window bw = new MicrosoftDynamics365Window();
            //bw.CopyFrom(BrowserWindow.FromProcess(_process));
            //new ProjectGanttWindow(bw)
            //    .ColapseAll()
            //    .DeleteProject();
        }
        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            SampleBrowserWindowValidator();
        }

        ////Use TestCleanup to run code after each test has run
        [TestCleanup]
        public void MyTestCleanup()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
//            ClickPrGButton();
        }

        #endregion


        private void SampleBrowserWindowValidator()
        {
            if (s_bw == null)
            {
                BrowserWindow.CurrentBrowser = "Firefox";

                s_bw = BrowserWindow.Launch(new Uri("https://promxtest20180312.crm4.dynamics.com/"));
//                s_bw.TechnologyName = "Web";
//                s_bw.CloseOnPlaybackCleanup = false;

//                s_bw.SearchProperties[""] = "";

                TestContext.WriteLine("Launching new browser instance");
            }
            else
            {
                TestContext.WriteLine("Using existing instance of browser window object");
            }
        }

        [TestMethod]
        public void Method1()
        {
            HtmlSpan span = new HtmlSpan(s_bw);

            UITestControlCollection matchingControls = span.FindMatchingControls();
            TestContext.WriteLine($"Spans={matchingControls.Count}");

        }
        [TestMethod]
        public void Method2()
        {
            HtmlDiv div = new HtmlDiv(s_bw);

            UITestControlCollection matchingControls = div.FindMatchingControls();
            TestContext.WriteLine($"DIVs={matchingControls.Count}");
        }

        [TestMethod]
        public void Method3()
        {
            HtmlEdit edit = new HtmlEdit(s_bw);

            UITestControlCollection matchingControls = edit.FindMatchingControls();
            TestContext.WriteLine($"Edits={matchingControls.Count}");
        }
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }
    }
}
