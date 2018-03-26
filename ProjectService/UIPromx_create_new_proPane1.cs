using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService
{
    public class UIPromx_create_new_proPane1 : HtmlDiv
    {

        public UIPromx_create_new_proPane1(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlDiv.PropertyNames.Id] = "promx_create_new_project_project_manager_lookup_div";
            SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
            FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            FilterProperties[HtmlDiv.PropertyNames.Class] = "smb-lookup";
            FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"smb-lookup\" id=\"promx_create_new_project_project_manager_lookup_div\"";
            FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "179";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlSpan ProjectManagerItemPane
        {
            get
            {
                if (m_projectManagerItemPane == null)
                {
                    m_projectManagerItemPane = new HtmlSpan(this);
                    #region Search Criteria
                    m_projectManagerItemPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_projectManagerItemPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_projectManagerItemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                    m_projectManagerItemPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_projectManagerItemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-icon k-i-search";
                    m_projectManagerItemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-icon k-i-search\"";
                    m_projectManagerItemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "352";
                    m_projectManagerItemPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_projectManagerItemPane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_projectManagerItemPane;
        #endregion
    }
}