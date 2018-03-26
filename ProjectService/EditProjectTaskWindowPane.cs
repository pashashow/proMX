using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService
{
    public class EditProjectTaskWindowPane : HtmlDiv
    {

        public EditProjectTaskWindowPane(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlDiv.PropertyNames.Id] = "promx_edit_project_task_window";
            SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Milestone \r\nProject Task Name\r\nFrom Date";
            FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            FilterProperties[HtmlDiv.PropertyNames.Class] = "popup-window k-window-content k-content";
            FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = @"tabindex=""0"" class=""popup-window k-window-content k-content"" id=""promx_edit_project_task_window"" role=""dialog"" aria-labelledby=""promx_edit_project_task_window_wnd_title"" data-height=""320"" data-title=""Create new assignment"" data-bind=""visible: hidden"" data-role=""window"" data-actions=""['Close']"" data-resizable=""false"" data-width=""700"" data-position=""{top: '0px', left: '0px'}""";
            FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "213";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlEdit ItemEdit
        {
            get
            {
                if (m_itemEdit == null)
                {
                    m_itemEdit = new HtmlEdit(this);
                    #region Search Criteria
                    m_itemEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = null;
                    m_itemEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = null;
                    m_itemEdit.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    m_itemEdit.SearchProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    m_itemEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    m_itemEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "k-input k-textbox";
                    m_itemEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "class=\"k-input k-textbox\" style=\"width: ";
                    m_itemEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "2";
                    m_itemEdit.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_itemEdit;
            }
        }

        public HtmlLabel OKLabel
        {
            get
            {
                if (m_OKLabel == null)
                {
                    m_OKLabel = new HtmlLabel(this);
                    #region Search Criteria
                    m_OKLabel.SearchProperties[HtmlLabel.PropertyNames.Id] = null;
                    m_OKLabel.SearchProperties[HtmlLabel.PropertyNames.Name] = null;
                    m_OKLabel.SearchProperties[HtmlLabel.PropertyNames.LabelFor] = null;
                    m_OKLabel.SearchProperties[HtmlLabel.PropertyNames.InnerText] = "OK";
                    m_OKLabel.FilterProperties[HtmlLabel.PropertyNames.Class] = null;
                    m_OKLabel.FilterProperties[HtmlLabel.PropertyNames.ControlDefinition] = "data-bind=\"text: Button_Ok\"";
                    m_OKLabel.FilterProperties[HtmlLabel.PropertyNames.TagInstance] = "14";
                    m_OKLabel.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_OKLabel;
            }
        }
        #endregion

        #region Fields
        private HtmlEdit m_itemEdit;

        private HtmlLabel m_OKLabel;
        #endregion
    }
}