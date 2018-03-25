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
            this.SearchProperties[HtmlButton.PropertyNames.Id] = "refreshButton";
            this.SearchProperties[HtmlButton.PropertyNames.Name] = null;
            this.SearchProperties[HtmlButton.PropertyNames.DisplayText] = " Refresh ";
            this.SearchProperties[HtmlButton.PropertyNames.Type] = "button";
            this.FilterProperties[HtmlButton.PropertyNames.Title] = "Refresh";
            this.FilterProperties[HtmlButton.PropertyNames.Class] = "k-button ama-button k-button-icontext";
            this.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "tabindex=\"0\" title=\"Refresh\" class=\"k-bu";
            this.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "3";
            this.WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlSpan RefreshPane
        {
            get
            {
                if ((this.m_refreshPane == null))
                {
                    this.m_refreshPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.m_refreshPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.m_refreshPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.m_refreshPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Refresh";
                    this.m_refreshPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.m_refreshPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.m_refreshPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = null;
                    this.m_refreshPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "6";
                    this.m_refreshPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_refreshPane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_refreshPane;
        #endregion
    }
}