using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService
{
    public class ExpandAllButton : HtmlButton
    {

        public ExpandAllButton(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlButton.PropertyNames.Id] = "expandButton";
            SearchProperties[HtmlButton.PropertyNames.Name] = null;
            SearchProperties[HtmlButton.PropertyNames.DisplayText] = " Expand all ";
            SearchProperties[HtmlButton.PropertyNames.Type] = "button";
            FilterProperties[HtmlButton.PropertyNames.Title] = "Expand all";
            FilterProperties[HtmlButton.PropertyNames.Class] = "k-button ama-button k-button-icontext";
            FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "tabindex=\"0\" title=\"Expand all\" class=\"k";
            FilterProperties[HtmlButton.PropertyNames.TagInstance] = "5";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlSpan ExpandAllPane
        {
            get
            {
                if (m_expandAllPane == null)
                {
                    m_expandAllPane = new HtmlSpan(this);
                    #region Search Criteria
                    m_expandAllPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_expandAllPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_expandAllPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Expand all";
                    m_expandAllPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_expandAllPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    m_expandAllPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = null;
                    m_expandAllPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "10";
                    m_expandAllPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_expandAllPane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_expandAllPane;
        #endregion
    }
}