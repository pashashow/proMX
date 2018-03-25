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
            m_salesHyperlink = m_bw.DashboardsSalesActivDocumen.TabHomePane.SalesHyperlink;
            m_projectServiceHyperlink = m_bw.DashboardsSalesActivDocumen.ProjectServiceHyperlink;
            m_projectGanttHyperlink = m_bw.DashboardsSalesActivDocumen.ProjectGanttHyperlink;
        }

        public ProjectGanttWindow GoToProjectGantt()
        {
            // Click 'Sales' link
            Mouse.Click(m_salesHyperlink, new Point(13, 24));

            // Click 'Project Service' link
            Mouse.Click(m_projectServiceHyperlink, new Point(64, 25));

            // Click 'Project Gantt' link
            Mouse.Click(m_projectGanttHyperlink, new Point(49, 21));

            return new ProjectGanttWindow(m_bw);
        }
    }
}