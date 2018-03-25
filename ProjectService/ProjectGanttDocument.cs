using HandCodedFluentCUIT.Common;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService
{
    public class ProjectGanttDocument : HtmlDocument
    {
        public ProjectGanttDocument(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            FilterProperties[HtmlDocument.PropertyNames.Title] = "Project Gantt";
            FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/%7B636574358220000621%7D/WebResources/prorm_/Apps/Gantt.SMB/index.html";
            FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://promxtest20180312.crm4.dynamics.com/%7B636574358220000621%7D/WebResources" +
                                                                        "/prorm_/Apps/Gantt.SMB/index.html?orglcid=1033&orgname=org6980cb4f&pagemode=ifra" +
                                                                        "me&sitemappath=proRM%7cprorm_project%7cprorm_gantt&userlcid=1033";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public FilterButtonOnGantt FilterButtonOnGantt
        {
            get
            {
                if (m_filterButtonOnGantt == null)
                {
                    m_filterButtonOnGantt = new FilterButtonOnGantt(this);
                }
                return m_filterButtonOnGantt;
            }
        }

        public ExpandAllButton ExpandAllButton
        {
            get
            {
                if (m_expandAllButton == null)
                {
                    m_expandAllButton = new ExpandAllButton(this);
                }
                return m_expandAllButton;
            }
        }

        public GanttBasePane GanttBasePane
        {
            get
            {
                if (m_ganttBasePane == null)
                {
                    m_ganttBasePane = new GanttBasePane(this);
                }
                return m_ganttBasePane;
            }
        }

        public AddNewProjectCustom AddNewProjectCustom
        {
            get
            {
                if (m_addNewProjectCustom == null)
                {
                    m_addNewProjectCustom = new AddNewProjectCustom(this);
                }
                return m_addNewProjectCustom;
            }
        }

        public PromxCreateNewProjectPane PromxCreateNewProjPane
        {
            get
            {
                if (m_promxCreateNewProjectPane == null)
                {
                    m_promxCreateNewProjectPane = new PromxCreateNewProjectPane(this);
                }
                return m_promxCreateNewProjectPane;
            }
        }

        public UIPromx_create_new_proPane1 UIPromx_create_new_proPane1
        {
            get
            {
                if (mUIPromx_create_new_proPane1 == null)
                {
                    mUIPromx_create_new_proPane1 = new UIPromx_create_new_proPane1(this);
                }
                return mUIPromx_create_new_proPane1;
            }
        }

        public HtmlCustom ChargeableCustom
        {
            get
            {
                if (m_chargeableCustom == null)
                {
                    m_chargeableCustom = new HtmlCustom(this);
                    #region Search Criteria
                    m_chargeableCustom.SearchProperties["TagName"] = "LI";
                    m_chargeableCustom.SearchProperties["Id"] = "5ea61955-fd4b-4761-b228-92f1ac62afd8";
                    m_chargeableCustom.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    m_chargeableCustom.FilterProperties["Class"] = "k-item k-state-focused";
                    m_chargeableCustom.FilterProperties["ControlDefinition"] = "tabindex=\"-1\" class=\"k-item k-state-focu";
                    m_chargeableCustom.FilterProperties["InnerText"] = "Chargeable";
                    m_chargeableCustom.FilterProperties["TagInstance"] = "56";
                    m_chargeableCustom.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_chargeableCustom;
            }
        }

        public HtmlSpan SelectPane
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
                    m_selectPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-icon k-i-arrow-s";
                    m_selectPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-icon k-i-arrow-s\" unselectable=\"on\"";
                    m_selectPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "233";
                    m_selectPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_selectPane;
            }
        }

        public HtmlSpan ProjectSelectPane
        {
            get
            {
                if (m_projectSelectPane == null)
                {
                    m_projectSelectPane = new HtmlSpan(this);
                    #region Search Criteria
                    m_projectSelectPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_projectSelectPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_projectSelectPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Project\r\nselect";
                    m_projectSelectPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_projectSelectPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-dropdown-wrap k-state-default";
                    m_projectSelectPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-dropdown-wrap k-state-default\" unselectable=\"on\"";
                    m_projectSelectPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "230";
                    m_projectSelectPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_projectSelectPane;
            }
        }

        public HtmlCustom AccountCustom
        {
            get
            {
                if (m_accountCustom == null)
                {
                    m_accountCustom = new HtmlCustom(this);
                    #region Search Criteria
                    m_accountCustom.SearchProperties["TagName"] = "LI";
                    m_accountCustom.SearchProperties["Id"] = null;
                    m_accountCustom.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    m_accountCustom.FilterProperties["Class"] = "k-item";
                    m_accountCustom.FilterProperties["ControlDefinition"] = "tabindex=\"-1\" class=\"k-item\" role=\"optio";
                    m_accountCustom.FilterProperties["InnerText"] = "Account";
                    m_accountCustom.FilterProperties["TagInstance"] = "66";
                    m_accountCustom.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_accountCustom;
            }
        }

        public HtmlDiv GeveePane
        {
            get
            {
                if (m_geveePane == null)
                {
                    m_geveePane = new HtmlDiv(this);
                    #region Search Criteria
                    m_geveePane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_geveePane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_geveePane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Gevee";
                    m_geveePane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_geveePane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    m_geveePane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"width: 300px; height: 25px; overflow: hidden; margin-right: -3px; display:" +
                        " inline-block; -ms-text-overflow: ellipsis;\" data-bind=\"css:{hovered:Hovered,sel" +
                        "ectRow:Selected}\"";
                    m_geveePane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "155";
                    m_geveePane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_geveePane;
            }
        }

        public HtmlButton AddButton
        {
            get
            {
                if (m_addButton == null)
                {
                    m_addButton = new HtmlButton(this);
                    #region Search Criteria
                    m_addButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    m_addButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    m_addButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Add";
                    m_addButton.SearchProperties[HtmlButton.PropertyNames.Type] = "button";
                    m_addButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    m_addButton.FilterProperties[HtmlButton.PropertyNames.Class] = "lookup-button";
                    m_addButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "class=\"lookup-button\" type=\"button\" data";
                    m_addButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "42";
                    m_addButton.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_addButton;
            }
        }

        public RefreshButton RefreshButton
        {
            get
            {
                if (m_refreshButton == null)
                {
                    m_refreshButton = new RefreshButton(this);
                }
                return m_refreshButton;
            }
        }

        public HtmlDiv ItemStatusPane
        {
            get
            {
                if (m_itemPane == null)
                {
                    m_itemPane = new HtmlDiv(this);
                    #region Search Criteria
                    m_itemPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_itemPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-overlay";
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-overlay\" style=\"display: block; z-index: 10012; opacity: 0.5;\"";
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "62";
                    m_itemPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_itemPane;
            }
        }

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
                    m_itemEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "k-textbox";
                    m_itemEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "class=\"k-textbox\" style=\"width: 210px;\" ";
                    m_itemEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "54";
                    m_itemEdit.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_itemEdit;
            }
        }

        public HtmlCustom ItemCustom
        {
            get
            {
                if (m_itemCustom == null)
                {
                    m_itemCustom = new HtmlCustom(this);
                    #region Search Criteria
                    m_itemCustom.SearchProperties["TagName"] = "A";
                    m_itemCustom.SearchProperties["Id"] = null;
                    m_itemCustom.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    m_itemCustom.FilterProperties["Class"] = "k-icon k-i-search lookup-searchbutton";
                    m_itemCustom.FilterProperties["ControlDefinition"] = "class=\"k-icon k-i-search lookup-searchbu";
                    m_itemCustom.FilterProperties["TagInstance"] = "25";
                    m_itemCustom.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_itemCustom;
            }
        }

        public HtmlDiv UserNamePane
        {
            get
            {
                if (m_userNamePane == null)
                {
                    m_userNamePane = new HtmlDiv(this);
                    #region Search Criteria
                    m_userNamePane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_userNamePane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_userNamePane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "aFirstname aLastname";
                    m_userNamePane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_userNamePane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    m_userNamePane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"width: 300px; height: 25px; overflow: hidden; margin-right: -3px; display:" +
                                                                                                           " inline-block; -ms-text-overflow: ellipsis;\" data-bind=\"css:{hovered:Hovered,sel" +
                                                                                                           "ectRow:Selected}\"";
                    m_userNamePane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "290";
                    m_userNamePane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_userNamePane;
            }
        }

        #endregion

        #region Fields
        private HtmlSpan m_projectSelectPane;

        private FilterButtonOnGantt m_filterButtonOnGantt;

        private ExpandAllButton m_expandAllButton;

        private GanttBasePane m_ganttBasePane;

        private PromxCreateNewProjectPane m_promxCreateNewProjectPane;

        private UIPromx_create_new_proPane1 mUIPromx_create_new_proPane1;

        private HtmlCustom m_chargeableCustom;

        private AddNewProjectCustom m_addNewProjectCustom;

        private HtmlSpan m_selectPane;

        private HtmlCustom m_accountCustom;

        private HtmlDiv m_geveePane;

        private HtmlButton m_addButton;

        private RefreshButton m_refreshButton;

        private HtmlDiv m_itemPane;

        private HtmlEdit m_itemEdit;

        private HtmlCustom m_itemCustom;

        private HtmlDiv m_userNamePane;

        #endregion
    }
}