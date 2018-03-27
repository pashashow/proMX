using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService.ToolBar
{
    public class SaveButton : HtmlButton
    {

        public SaveButton(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlButton.PropertyNames.Id] = "saveButton";
            SearchProperties[HtmlButton.PropertyNames.Name] = null;
            SearchProperties[HtmlButton.PropertyNames.DisplayText] = " Save ";
            SearchProperties[HtmlButton.PropertyNames.Type] = "button";
            FilterProperties[HtmlButton.PropertyNames.Title] = "Save";
            FilterProperties[HtmlButton.PropertyNames.Class] = "k-button ama-button k-button-icontext";
            FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "tabindex=\"0\" title=\"Save\" class=\"k-butto";
            FilterProperties[HtmlButton.PropertyNames.TagInstance] = "4";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlSpan SavePane
        {
            get
            {
                if (m_savePane == null)
                {
                    m_savePane = new HtmlSpan(this);
                    #region Search Criteria
                    m_savePane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_savePane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_savePane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Save";
                    m_savePane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_savePane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    m_savePane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = null;
                    m_savePane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "8";
                    m_savePane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_savePane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_savePane;
        #endregion
    }
}