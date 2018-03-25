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
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Project Gantt";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/%7B636572467710000569%7D/WebResources/prorm_/Apps/Gantt.SMB/index.html";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://promxtest20180312.crm4.dynamics.com/%7B636572467710000569%7D/WebResources" +
                "/prorm_/Apps/Gantt.SMB/index.html?orglcid=1033&orgname=org6980cb4f&pagemode=ifra" +
                "me&sitemappath=proRM%7cprorm_project%7cprorm_gantt&userlcid=1033";
            this.WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public FilterButtonOnGantt FilterButtonOnGantt
        {
            get
            {
                if ((this.m_filterButtonOnGantt == null))
                {
                    this.m_filterButtonOnGantt = new FilterButtonOnGantt(this);
                }
                return this.m_filterButtonOnGantt;
            }
        }

        public HtmlSpan SelectPane
        {
            get
            {
                if ((this.m_selectPane == null))
                {
                    this.m_selectPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.m_selectPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.m_selectPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.m_selectPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "select";
                    this.m_selectPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.m_selectPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-icon k-i-arrow-s";
                    this.m_selectPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-icon k-i-arrow-s\" unselectable=\"on\"";
                    this.m_selectPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "233";
                    this.m_selectPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_selectPane;
            }
        }

        public HtmlSpan ProjectSelectPane
        {
            get
            {
                if ((this.m_projectSelectPane == null))
                {
                    this.m_projectSelectPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.m_projectSelectPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.m_projectSelectPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.m_projectSelectPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Project\r\nselect";
                    this.m_projectSelectPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.m_projectSelectPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-dropdown-wrap k-state-default";
                    this.m_projectSelectPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-dropdown-wrap k-state-default\" unselectable=\"on\"";
                    this.m_projectSelectPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "230";
                    this.m_projectSelectPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_projectSelectPane;
            }
        }

        public HtmlCustom AccountCustom
        {
            get
            {
                if ((this.m_accountCustom == null))
                {
                    this.m_accountCustom = new HtmlCustom(this);
                    #region Search Criteria
                    this.m_accountCustom.SearchProperties["TagName"] = "LI";
                    this.m_accountCustom.SearchProperties["Id"] = null;
                    this.m_accountCustom.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    this.m_accountCustom.FilterProperties["Class"] = "k-item";
                    this.m_accountCustom.FilterProperties["ControlDefinition"] = "tabindex=\"-1\" class=\"k-item\" role=\"optio";
                    this.m_accountCustom.FilterProperties["InnerText"] = "Account";
                    this.m_accountCustom.FilterProperties["TagInstance"] = "66";
                    this.m_accountCustom.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_accountCustom;
            }
        }

        public HtmlDiv GeveePane
        {
            get
            {
                if (this.m_geveePane == null)
                {
                    this.m_geveePane = new HtmlDiv(this);
                    #region Search Criteria
                    this.m_geveePane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.m_geveePane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.m_geveePane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Gevee";
                    this.m_geveePane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.m_geveePane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.m_geveePane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"width: 300px; height: 25px; overflow: hidden; margin-right: -3px; display:" +
                        " inline-block; -ms-text-overflow: ellipsis;\" data-bind=\"css:{hovered:Hovered,sel" +
                        "ectRow:Selected}\"";
                    this.m_geveePane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "155";
                    this.m_geveePane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_geveePane;
            }
        }

        public HtmlButton AddButton
        {
            get
            {
                if (this.m_addButton == null)
                {
                    this.m_addButton = new HtmlButton(this);
                    #region Search Criteria
                    this.m_addButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    this.m_addButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    this.m_addButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Add";
                    this.m_addButton.SearchProperties[HtmlButton.PropertyNames.Type] = "button";
                    this.m_addButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.m_addButton.FilterProperties[HtmlButton.PropertyNames.Class] = "lookup-button";
                    this.m_addButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "class=\"lookup-button\" type=\"button\" data";
                    this.m_addButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "42";
                    this.m_addButton.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_addButton;
            }
        }

        public RefreshButton RefreshButton
        {
            get
            {
                if ((this.m_refreshButton == null))
                {
                    this.m_refreshButton = new RefreshButton(this);
                }
                return this.m_refreshButton;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_projectSelectPane;

        private FilterButtonOnGantt m_filterButtonOnGantt;

        private HtmlSpan m_selectPane;

        private HtmlCustom m_accountCustom;

        private HtmlDiv m_geveePane;

        private HtmlButton m_addButton;

        private RefreshButton m_refreshButton;

        #endregion
    }
}