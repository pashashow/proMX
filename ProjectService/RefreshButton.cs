using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService
{
    public class RefreshButton : HtmlButton
    {
        public RefreshButton(UITestControl searchLimitContainer) 
            : base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlButton.PropertyNames.Id] = "refreshButton";
            SearchProperties[HtmlButton.PropertyNames.Name] = null;
            SearchProperties[HtmlButton.PropertyNames.DisplayText] = " Refresh ";
            SearchProperties[HtmlButton.PropertyNames.Type] = "button";
            FilterProperties[HtmlButton.PropertyNames.Title] = "Refresh";
            FilterProperties[HtmlButton.PropertyNames.Class] = "k-button ama-button k-button-icontext";
            FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "tabindex=\"0\" title=\"Refresh\" class=\"k-bu";
            FilterProperties[HtmlButton.PropertyNames.TagInstance] = "3";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlSpan RefreshPane
        {
            get
            {
                if (m_refreshPane == null)
                {
                    m_refreshPane = new HtmlSpan(this);
                    #region Search Criteria
                    m_refreshPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_refreshPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_refreshPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Refresh";
                    m_refreshPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_refreshPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    m_refreshPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = null;
                    m_refreshPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "6";
                    m_refreshPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_refreshPane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_refreshPane;
        #endregion
    }
}