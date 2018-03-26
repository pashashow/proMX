using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService
{
    public class EditProjectTaskResourceRolePane : HtmlDiv
    {

        public EditProjectTaskResourceRolePane(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlDiv.PropertyNames.Id] = "promx_edit_project_task_resource_role_lookup_div";
            SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
            FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            FilterProperties[HtmlDiv.PropertyNames.Class] = "smb-lookup";
            FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"smb-lookup\" id=\"promx_edit_project_task_resource_role_lookup_div\"";
            FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "217";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlSpan ItemPane
        {
            get
            {
                if (m_itemPane == null)
                {
                    m_itemPane = new HtmlSpan(this);
                    #region Search Criteria
                    m_itemPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_itemPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-icon k-i-search";
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-icon k-i-search\"";
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "450";
                    m_itemPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_itemPane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_itemPane;
        #endregion
    }
}
