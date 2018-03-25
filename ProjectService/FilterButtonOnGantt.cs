using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService
{
    public class FilterButtonOnGantt : HtmlButton
    {

        public FilterButtonOnGantt(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlButton.PropertyNames.Id] = "filter_button_on_gantt_page";
            SearchProperties[HtmlButton.PropertyNames.Name] = null;
            SearchProperties[HtmlButton.PropertyNames.DisplayText] = null;
            SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
            FilterProperties[HtmlButton.PropertyNames.Title] = null;
            FilterProperties[HtmlButton.PropertyNames.Class] = "k-button";
            FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "tabindex=\"0\" class=\"k-button\" id=\"filter";
            FilterProperties[HtmlButton.PropertyNames.TagInstance] = "8";
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
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "17";
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