using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService.Menu
{
    public class DeleteCustom : HtmlCustom
    {
        public DeleteCustom(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "LI";
            this.SearchProperties["Id"] = "cmDelete";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = "k-item k-state-default";
            this.FilterProperties["ControlDefinition"] = "class=\"k-item k-state-default\" id=\"cmDel";
            this.FilterProperties["InnerText"] = "Delete";
            this.FilterProperties["TagInstance"] = "31";
            this.WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlSpan DeletePane
        {
            get
            {
                if ((this.m_deletePane == null))
                {
                    this.m_deletePane = new HtmlSpan(this);
                    #region Search Criteria
                    this.m_deletePane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.m_deletePane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.m_deletePane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Delete";
                    this.m_deletePane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.m_deletePane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-link";
                    this.m_deletePane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-link\"";
                    this.m_deletePane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "151";
                    this.m_deletePane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_deletePane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_deletePane;
        #endregion
    }
}