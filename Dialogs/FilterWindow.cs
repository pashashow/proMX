using System.Drawing;
using HandCodedFluentCUIT.Common;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.Dialogs
{
    public class FilterWindow
    {
        private readonly MicrosoftDynamics365Window m_bw;

//        private readonly HtmlSpan m_projectselectPane;
        private readonly HtmlSpan m_selectPane;
        private readonly HtmlCustom m_accountCustom;
        private readonly HtmlDiv m_geveePane;
        private readonly HtmlButton m_addButton;
        private readonly HtmlSpan m_refreshPane;

        public FilterWindow(MicrosoftDynamics365Window bw)
        {
            m_bw = bw;

//            m_projectselectPane = this.m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument.ProjectSelectPane;
            m_selectPane = this.m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument.SelectPane;
            m_accountCustom = this.m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument.AccountCustom;
            m_geveePane = this.m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument.GeveePane;
            m_addButton = this.m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument.AddButton;
            m_refreshPane = this.m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument.RefreshButton.RefreshPane;
        }

        public FilterWindow SelectAccount()
        {
            // Click 'select' pane
            Mouse.Click(m_selectPane, new Point(10, 11));

            // Click 'Account' custom control
            Mouse.Click(m_accountCustom, new Point(44, 10));

            // Double-Click 'Gevee' pane
            Mouse.DoubleClick(m_geveePane, new Point(16, 10));

            // Click 'Add' button
            Mouse.Click(m_addButton, new Point(58, 16));

            return this;
        }

        public FilterWindow Refresh()
        {
            // Click 'Refresh' pane
            Mouse.Click(m_refreshPane, new Point(15, 7));
            return this;
        }

        public bool AccoutListContains(string account)
        {
            return true;
        }
    }
}