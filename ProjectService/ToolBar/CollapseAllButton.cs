using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService.ToolBar
{
    public class CollapseAllButton : HtmlButton
    {

        public CollapseAllButton(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlButton.PropertyNames.Id] = "collapseButton";
            this.SearchProperties[HtmlButton.PropertyNames.Name] = null;
            this.SearchProperties[HtmlButton.PropertyNames.DisplayText] = " Collapse all ";
            this.SearchProperties[HtmlButton.PropertyNames.Type] = "button";
            this.FilterProperties[HtmlButton.PropertyNames.Title] = "Collapse all";
            this.FilterProperties[HtmlButton.PropertyNames.Class] = "k-button ama-button k-button-icontext";
            this.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "tabindex=\"0\" title=\"Collapse all\" class=";
            this.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "6";
            this.WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlSpan CollapseallPane
        {
            get
            {
                if ((this.m_collapseAllPane == null))
                {
                    this.m_collapseAllPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.m_collapseAllPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.m_collapseAllPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.m_collapseAllPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Collapse all";
                    this.m_collapseAllPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.m_collapseAllPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.m_collapseAllPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = null;
                    this.m_collapseAllPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "12";
                    this.m_collapseAllPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_collapseAllPane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_collapseAllPane;
        #endregion
    }
}