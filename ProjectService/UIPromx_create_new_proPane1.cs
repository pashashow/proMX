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
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "promx_create_new_project_project_manager_lookup_div";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "smb-lookup";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"smb-lookup\" id=\"promx_create_new_project_project_manager_lookup_div\"";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "179";
            this.WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlSpan ItemPane
        {
            get
            {
                if ((this.m_itemPane == null))
                {
                    this.m_itemPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.m_itemPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.m_itemPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.m_itemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                    this.m_itemPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.m_itemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-icon k-i-search";
                    this.m_itemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-icon k-i-search\"";
                    this.m_itemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "352";
                    this.m_itemPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_itemPane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_itemPane;
        #endregion
    }
}