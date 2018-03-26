using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService
{
    public class AddChildTaskCustom : HtmlCustom
    {
        public AddChildTaskCustom(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "LI";
            this.SearchProperties["Id"] = "cmAddNewTask";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = "k-item k-state-default";
            this.FilterProperties["ControlDefinition"] = "class=\"k-item k-state-default\" id=\"cmAdd";
            this.FilterProperties["InnerText"] = "Add child task";
            this.FilterProperties["TagInstance"] = "20";
            this.WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlSpan AddChildTaskPane
        {
            get
            {
                if ((m_addChildTaskPane == null))
                {
                    m_addChildTaskPane = new HtmlSpan(this);
                    #region Search Criteria
                    m_addChildTaskPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_addChildTaskPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_addChildTaskPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Add child task";
                    m_addChildTaskPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_addChildTaskPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-link";
                    m_addChildTaskPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-link\"";
                    m_addChildTaskPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "347";
                    m_addChildTaskPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_addChildTaskPane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_addChildTaskPane;
        #endregion
    }

}
