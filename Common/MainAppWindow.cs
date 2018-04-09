using System.Drawing;
using HandCodedFluentCUIT.ProjectService;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.Common
{
    public class MainAppWindow
    {
        private readonly MicrosoftDynamics365Window m_bw;

        private readonly HtmlHyperlink m_salesHyperlink;
        private readonly HtmlHyperlink m_projectServiceHyperlink;
        private readonly HtmlHyperlink m_projectGanttHyperlink;

        public MainAppWindow(MicrosoftDynamics365Window bw)
        {
            m_bw = bw;
            m_salesHyperlink = m_bw.NavigationBar.SalesButton.SalesHyperlink;
            m_projectServiceHyperlink = m_bw.DashboardsDocument.ProjectServiceHyperlink;
            m_projectGanttHyperlink = m_bw.DashboardsDocument.ProjectGanttHyperlink;
        }

        public ProjectGanttWindow GoToProjectGantt()
        {
            m_bw.NavigationBar.WaitForControlExist(30000);
            // Click 'Sales' link
            Mouse.Click(m_salesHyperlink);

            m_bw.DashboardsDocument.WaitForControlExist(30000);
            // Click 'Project Service' link
            Mouse.Click(m_projectServiceHyperlink);

            // Click 'Project Gantt' link
            Mouse.Click(m_projectGanttHyperlink);

            return new ProjectGanttWindow(m_bw);
        }
    }
}