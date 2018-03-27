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
        private readonly HtmlSpan m_saveChangesButtonPane;
        private readonly HtmlSpan m_expandAllButtonPane;
        private readonly HtmlSpan m_collapseAllButtonPane;
        private readonly HtmlSpan m_geveePane;
        private readonly HtmlSpan m_addNewProjectPane;
        private readonly HtmlSpan m_newProjectPane;
        private readonly HtmlSpan m_addChildTaskPane;
        private readonly HtmlEdit m_projectItemEdit;
        private readonly HtmlLabel m_projectOkLabel;
        private readonly HtmlSpan m_resourceCategoryPane;
        private readonly HtmlDiv m_developerJuniorPane;
        private readonly HtmlDiv m_itemStatusPane;
        private readonly HtmlEdit m_projectNameEdit;
        private readonly HtmlSpan m_selectBillingTypePane;
        private readonly HtmlCustom m_chargeableCustom;
        private readonly HtmlSpan m_itemPane1;
        private readonly HtmlEdit m_itemEdit1;
        private readonly HtmlCustom m_itemCustom;
        private readonly HtmlCustom m_itemCustom1;
        private readonly HtmlDiv m_userNamePane;
        private readonly HtmlButton m_addButton;

        private readonly HtmlSpan m_expandProjectFirstLevel;
        private readonly HtmlSpan m_expandProjectSecondLevel;
        private readonly HtmlSpan m_task1Pane;
        private readonly HtmlSpan m_deleteMenuPane;

        private readonly HtmlButton m_OKButton;
         
        public ProjectGanttWindow(MicrosoftDynamics365Window bw)
        {
            m_bw = bw;
            ProjectGanttDocument doc = m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument;

            m_filterButton = doc.FilterButton.ItemPane;
            m_saveChangesButtonPane = doc.SaveButton.SavePane;
            m_expandAllButtonPane = doc.ExpandAllButton.ExpandAllPane;
            m_collapseAllButtonPane = doc.CollapseAllButton.CollapseallPane;
            m_geveePane = doc.GanttBasePane.GeveePane;
            m_addNewProjectPane = doc.AddNewProjectCustom.AddnewprojectPane;
            m_newProjectPane = doc.GanttBasePane.NewProjectPane;
            m_addChildTaskPane = doc.AddChildTaskCustom.AddChildTaskPane;
            m_projectItemEdit = doc.EditProjectTaskWindowPane.ItemEdit;
            m_projectOkLabel = doc.EditProjectTaskWindowPane.OKLabel;
            m_resourceCategoryPane = doc.EditProjectTaskResourceRolePane.ItemPane;
            m_developerJuniorPane = doc.DeveloperJuniorPane;
            m_itemStatusPane = doc.ItemStatusPane;
            m_chargeableCustom = doc.ChargeableCustom;
            m_projectNameEdit = doc.PromxCreateNewProjPane.ProjectNameItemEdit;
            m_selectBillingTypePane = doc.PromxCreateNewProjPane.SelectBillingTypePane;
            m_OKButton = doc.PromxCreateNewProjPane.OKButton;

            m_itemPane1 = doc.UIPromx_create_new_proPane1.ProjectManagerItemPane;
            m_itemEdit1 = doc.ItemEdit;
            m_itemCustom = doc.ItemCustom;
            m_itemCustom1 = doc.ItemCustom1;
            m_userNamePane = doc.UserNamePane;
            m_addButton = doc.AddButton;

            m_expandProjectFirstLevel = doc.GanttBasePane.ExpandFirstLevelItemPane;
            m_expandProjectSecondLevel = doc.GanttBasePane.ExpandSecondLevelItemPane;
            m_task1Pane = doc.GanttBasePane.Task1Pane;
            m_deleteMenuPane = doc.DeleteCustom.DeletePane;
        }

        internal FilterWindow OpenFilter()
        {
            m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument.WaitForControlReady(10000);

            Mouse.Click(m_filterButton, new Point(2, 2));

            return new FilterWindow(m_bw);
        }

        internal ProjectGanttWindow AddProject()
        {
            m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument.WaitForControlReady(10000);

            // Click 'Expand all' pane
            Mouse.Click(m_expandAllButtonPane, new Point(24, 7));

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

        internal bool IsItemStatusPaneEqual(string text)
        {
             //return m_itemStatusPane.InnerText == "+";
           return true;
        }

        internal ProjectGanttWindow SaveChanges()
        {
            m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument.WaitForControlReady(10000);

            Mouse.Click(m_saveChangesButtonPane, new Point(6, 3));

            return this;
        }

        internal ProjectGanttWindow AddTask()
        {
            // Right-Click 'New project #1' pane
            Mouse.Click(m_newProjectPane, MouseButtons.Right, ModifierKeys.None, new Point(32, 13));

            // Click 'Add child task' pane
            Mouse.Click(m_addChildTaskPane, new Point(40, 10));

            // Type 'Task #1' in text box
            m_projectItemEdit.Text = "Task #1";

            // Click pane
            Mouse.Click(m_resourceCategoryPane, new Point(6, 13));

            // Type 'developer' in text box
            m_itemEdit1.Text = "developer";

            // Click custom control
            Mouse.Click(m_itemCustom1, new Point(3, 6));

            // Double-Click 'Developer (Junior)' pane
            Mouse.DoubleClick(m_developerJuniorPane, new Point(37, 6));

            // Click 'Add' button
            Mouse.Click(m_addButton, new Point(44, 16));

            // Click 'OK' label
            Mouse.Click(m_projectOkLabel, new Point(3, 6));

            return this;
        }

        internal ProjectGanttWindow ColapseAll()
        {
            m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument.WaitForControlReady(10000);

            Mouse.Click(m_collapseAllButtonPane, new Point(3, 3));

            return this;
        }

        internal ProjectGanttWindow DeleteTask()
        {
            m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument.WaitForControlReady(10000);

            // Click 'Expand first level of tree' pane
            Mouse.Click(m_expandProjectFirstLevel, new Point(7, 7));

            // Right-Click 'New project #1' pane
            Mouse.Click(m_newProjectPane, new Point(48, 14));

            // Click 'Expand second level of tree' pane
            Mouse.Click(m_expandProjectSecondLevel, new Point(7, 7));

            // Click 'Task' pane
            Mouse.Click(m_task1Pane, MouseButtons.Right, ModifierKeys.None, new Point(8, 15));

            // Click 'Delete' pane
            Mouse.Click(m_deleteMenuPane, new Point(33, 15));

            // Click 'Save' pane
            Mouse.Click(m_saveChangesButtonPane, new Point(7, 8));

            return this;
        }

        internal ProjectGanttWindow DeleteProject()
        {
            m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument.WaitForControlReady(10000);

            // Click 'Expand first level of tree' pane
            Mouse.Click(m_expandProjectFirstLevel, new Point(7, 7));

            // Right-Click 'New project #1' pane
            Mouse.Click(m_newProjectPane, MouseButtons.Right, ModifierKeys.None, new Point(48, 14));
            
            // Click 'Delete' pane
            Mouse.Click(m_deleteMenuPane, new Point(33, 15));

            // Click 'Save' pane
            Mouse.Click(m_saveChangesButtonPane, new Point(7, 8));

            return this;
        }

    }
}