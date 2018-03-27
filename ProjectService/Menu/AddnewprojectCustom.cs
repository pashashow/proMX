using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService.Menu
{
    public class AddNewProjectCustom : HtmlCustom
    {

        public AddNewProjectCustom(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties["TagName"] = "LI";
            SearchProperties["Id"] = "cmAddNewProject";
            SearchProperties[UITestControl.PropertyNames.Name] = null;
            FilterProperties["Class"] = "k-item k-state-default";
            FilterProperties["ControlDefinition"] = "class=\"k-item k-state-default\" id=\"cmAdd";
            FilterProperties["InnerText"] = "Add new project";
            FilterProperties["TagInstance"] = "19";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlSpan AddnewprojectPane
        {
            get
            {
                if (m_addnewprojectPane == null)
                {
                    m_addnewprojectPane = new HtmlSpan(this);
                    #region Search Criteria
                    m_addnewprojectPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_addnewprojectPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_addnewprojectPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Add new project";
                    m_addnewprojectPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_addnewprojectPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-link";
                    m_addnewprojectPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-link\"";
                    m_addnewprojectPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "107";
                    m_addnewprojectPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_addnewprojectPane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_addnewprojectPane;
        #endregion
    }
}