using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService.Filter
{
    public class FilterButton : HtmlButton
    {
        public FilterButton(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlButton.PropertyNames.Id] = "filter_button_on_gantt_page";
            SearchProperties[HtmlButton.PropertyNames.Name] = null;
            SearchProperties[HtmlButton.PropertyNames.DisplayText] = null;
//            SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
            SearchProperties[HtmlButton.PropertyNames.Class] = "k-button";
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
                    m_itemPane.SearchProperties[HtmlDiv.PropertyNames.Class] = "k-icon k-i-search";
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