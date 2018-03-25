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
            this.SearchProperties[HtmlButton.PropertyNames.Id] = "filter_button_on_gantt_page";
            this.SearchProperties[HtmlButton.PropertyNames.Name] = null;
            this.SearchProperties[HtmlButton.PropertyNames.DisplayText] = null;
            this.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
            this.FilterProperties[HtmlButton.PropertyNames.Title] = null;
            this.FilterProperties[HtmlButton.PropertyNames.Class] = "k-button";
            this.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "tabindex=\"0\" class=\"k-button\" id=\"filter";
            this.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "8";
            this.WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlSpan UIItemPane
        {
            get
            {
                if ((this.mUIItemPane == null))
                {
                    this.mUIItemPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-icon k-i-search";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-icon k-i-search\"";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "17";
                    this.mUIItemPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.mUIItemPane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan mUIItemPane;
        #endregion
    }
}