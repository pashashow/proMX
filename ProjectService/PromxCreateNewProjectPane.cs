using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService
{
    public class PromxCreateNewProjectPane : HtmlDiv
    {

        public PromxCreateNewProjectPane(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlDiv.PropertyNames.Id] = "promx_create_new_project_window";
            SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Projectname\r\nFrom\r\nselect\r\n \r\nCustomer\r\n";
            FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            FilterProperties[HtmlDiv.PropertyNames.Class] = "popup-window k-window-content k-content";
            FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = @"tabindex=""0"" class=""popup-window k-window-content k-content"" id=""promx_create_new_project_window"" role=""dialog"" aria-labelledby=""promx_create_new_project_window_wnd_title"" data-height=""290"" data-title=""Create new project"" data-bind=""visible: hidden"" data-role=""window"" data-actions=""['Close']"" data-resizable=""false"" data-width=""700"" data-position=""{top: '0px', left: '0px'}""";
            FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "66";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlEdit ProjectNameItemEdit
        {
            get
            {
                if (m_projectNameItemEdit == null)
                {
                    m_projectNameItemEdit = new HtmlEdit(this);
                    #region Search Criteria
                    m_projectNameItemEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = null;
                    m_projectNameItemEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = null;
                    m_projectNameItemEdit.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    m_projectNameItemEdit.SearchProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    m_projectNameItemEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    m_projectNameItemEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "k-input k-textbox";
                    m_projectNameItemEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "class=\"k-input k-textbox\" style=\"width: ";
                    m_projectNameItemEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "1";
                    m_projectNameItemEdit.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_projectNameItemEdit;
            }
        }

        public HtmlSpan SelectBillingTypePane
        {
            get
            {
                if (m_selectPane == null)
                {
                    m_selectPane = new HtmlSpan(this);
                    #region Search Criteria
                    m_selectPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_selectPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_selectPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "select";
                    m_selectPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_selectPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-select";
                    m_selectPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-select\" unselectable=\"on\"";
                    m_selectPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "135";
                    m_selectPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_selectPane;
            }
        }

        public HtmlButton OKButton
        {
            get
            {
                if (m_OKButton == null)
                {
                    m_OKButton = new HtmlButton(this);
                    #region Search Criteria
                    m_OKButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    m_OKButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    m_OKButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "OK";
                    m_OKButton.SearchProperties[HtmlButton.PropertyNames.Type] = "button";
                    m_OKButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    m_OKButton.FilterProperties[HtmlButton.PropertyNames.Class] = "lookup-button";
                    m_OKButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "class=\"lookup-button\" type=\"button\" data";
                    m_OKButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "3";
                    m_OKButton.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_OKButton;
            }
        }
        #endregion

        #region Fields
        private HtmlEdit m_projectNameItemEdit;

        private HtmlSpan m_selectPane;

        private HtmlButton m_OKButton;
        #endregion
    }
}