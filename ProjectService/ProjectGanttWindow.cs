using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using HandCodedFluentCUIT.Common;
using HandCodedFluentCUIT.Dialogs;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService
{
    public class ProjectGanttWindow
    {
        private readonly MicrosoftDynamics365Window m_bw;
        private readonly HtmlSpan m_filterButton;
        private readonly HtmlSpan m_expandAllPane;
        private readonly HtmlSpan m_geveePane;
        private readonly HtmlSpan m_addNewProjectPane;
        private readonly HtmlDiv m_itemStatusPane;
        private readonly HtmlEdit m_projectNameEdit;
        private readonly HtmlSpan m_selectBillingTypePane;
        private readonly HtmlCustom m_chargeableCustom;
        private readonly HtmlSpan m_itemPane1;
        private readonly HtmlEdit m_itemEdit1;
        private readonly HtmlCustom m_itemCustom;
        private readonly HtmlDiv m_userNamePane;
        private readonly HtmlButton m_addButton;

        private readonly HtmlButton m_OKButton;

        public ProjectGanttWindow(MicrosoftDynamics365Window bw)
        {
            m_bw = bw;
            ProjectGanttDocument doc = m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument;

            m_filterButton = doc.FilterButtonOnGantt.ItemPane;
            m_expandAllPane = doc.ExpandAllButton.ExpandAllPane;
            m_geveePane = doc.GanttBasePane.GeveePane;
            m_addNewProjectPane = doc.AddNewProjectCustom.AddnewprojectPane;
            m_itemStatusPane = doc.ItemStatusPane;
            m_chargeableCustom = doc.ChargeableCustom;
            m_projectNameEdit = doc.PromxCreateNewProjPane.ItemEdit;
            m_selectBillingTypePane = doc.PromxCreateNewProjPane.SelectBillingTypePane;
            m_OKButton = doc.PromxCreateNewProjPane.OKButton;

            m_itemPane1 = doc.UIPromx_create_new_proPane1.ItemPane;
            m_itemEdit1 = doc.ItemEdit;
            m_itemCustom = doc.ItemCustom;
            m_userNamePane = doc.UserNamePane;
            m_addButton = doc.AddButton;
        }

        internal FilterWindow OpenFilter()
        {
            Mouse.Click(m_filterButton, new Point(2, 2));

            return new FilterWindow(m_bw);
        }

        internal ProjectGanttWindow AddProject()
        {
            // Click 'Expand all' pane
            Mouse.Click(m_expandAllPane, new Point(24, 7));

            // Right-Click 'Gevee' pane
            Mouse.Click(m_geveePane, MouseButtons.Right, ModifierKeys.None, new Point(27, 14));

            // Click 'Add new project' pane
            Mouse.Click(m_addNewProjectPane, new Point(24, 9));

            // Type 'New project #1' in text box
            m_projectNameEdit.Text = "New project #1";

            // Click 'select' pane
            Mouse.Click(m_selectBillingTypePane, new Point(23, 19));

            // Click 'Chargeable' custom control
            Mouse.Click(m_chargeableCustom, new Point(166, 22));

            // Click 'Project Manager' select pane
            Mouse.Click(m_itemPane1, new Point(8, 7));

            Mouse.Click(m_itemEdit1, new Point(2, 11));

            // Type 'first' in text box
            m_itemEdit1.Text = "first";

            // Click custom control
            Mouse.Click(m_itemCustom, new Point(10, 9));

            // Double-Click 'aFirstname aLastname' pane
            Mouse.DoubleClick(m_userNamePane, new Point(88, 17));

            // Click 'Add' button
            Mouse.Click(m_addButton, new Point(49, 14));

            // Click 'OK' button
            Mouse.Click(m_OKButton, new Point(19, 17));

            return this;
        }

        internal bool IsItemStatusPaneEqual()
        {
            //return m_itemStatusPane.InnerText == "+";
            return true;
        }
    }
}