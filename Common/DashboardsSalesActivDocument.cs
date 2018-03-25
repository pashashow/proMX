using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.Common
{
    public class DashboardsSalesActivDocument : HtmlDocument
    {
        public DashboardsSalesActivDocument(UITestControl searchLimitContainer) 
            : base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/main.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://promxtest20180312.crm4.dynamics.com/main.aspx#653246774";
            this.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
            this.WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlHyperlink UserInfoHyperlink
        {
            get
            {
                if (this.m_firstnameLastnameHyperlink == null)
                {
                    this.m_firstnameLastnameHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.m_firstnameLastnameHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "navTabButtonUserInfoLinkId";
                    this.m_firstnameLastnameHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.m_firstnameLastnameHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.m_firstnameLastnameHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "\r\naFirstname aLastname\r\n  ";
                    this.m_firstnameLastnameHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/main.aspx";
                    this.m_firstnameLastnameHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "aFirstname aLastname proMX GmbH";
                    this.m_firstnameLastnameHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "https://promxtest20180312.crm4.dynamics.com/main.aspx#";
                    this.m_firstnameLastnameHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "navTabButtonLink";
                    this.m_firstnameLastnameHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "title=\"aFirstname aLastname proMX GmbH\" ";
                    this.m_firstnameLastnameHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "15";
                    this.m_firstnameLastnameHyperlink.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_firstnameLastnameHyperlink;
            }
        }

        public TabHomePane TabHomePane
        {
            get
            {
                if (this.m_tabHomePane == null)
                {
                    this.m_tabHomePane = new TabHomePane(this);
                }
                return this.m_tabHomePane;
            }
        }

        public HtmlHyperlink ProjectServiceHyperlink
        {
            get
            {
                if ((this.m_projectServiceHyperlink == null))
                {
                    this.m_projectServiceHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.m_projectServiceHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "proRM";
                    this.m_projectServiceHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.m_projectServiceHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.m_projectServiceHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "\r\nProject Service";
                    this.m_projectServiceHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/main.aspx";
                    this.m_projectServiceHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "Project Service";
                    this.m_projectServiceHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "https://promxtest20180312.crm4.dynamics.com/main.aspx?area=cMyWork&page=proRM&web" +
                        "=true";
                    this.m_projectServiceHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "navActionButtonContainer navActionButton navModuleButton normal";
                    this.m_projectServiceHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "title=\"Project Service\" class=\"navAction";
                    this.m_projectServiceHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "47";
                    this.m_projectServiceHyperlink.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_projectServiceHyperlink;
            }
        }

        public HtmlHyperlink ProjectGanttHyperlink
        {
            get
            {
                if ((this.m_projectGanttHyperlink == null))
                {
                    this.m_projectGanttHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.m_projectGanttHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "prorm_gantt";
                    this.m_projectGanttHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.m_projectGanttHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.m_projectGanttHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Project Gantt";
                    this.m_projectGanttHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/%7B636572467710000569%7D/WebResources/prorm_/Apps/Gantt.SMB/index.html";
                    this.m_projectGanttHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "Project Gantt";
                    this.m_projectGanttHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "https://promxtest20180312.crm4.dynamics.com/%7B636572467710000569%7D/WebResources" +
                        "/prorm_/Apps/Gantt.SMB/index.html?orglcid=1033&orgname=org6980cb4f&userlcid=1033" +
                        "";
                    this.m_projectGanttHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "nav-rowBody normal";
                    this.m_projectGanttHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "title=\"Project Gantt\" class=\"nav-rowBody";
                    this.m_projectGanttHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "60";
                    this.m_projectGanttHyperlink.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_projectGanttHyperlink;
            }
        }
        #endregion

        #region Fields
        private HtmlHyperlink m_firstnameLastnameHyperlink;

        private TabHomePane m_tabHomePane;

        private HtmlHyperlink m_projectServiceHyperlink;

        private HtmlHyperlink m_projectGanttHyperlink;
        #endregion
    }
}