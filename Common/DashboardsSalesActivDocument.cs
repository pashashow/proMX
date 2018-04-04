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
            SearchProperties[HtmlControl.PropertyNames.Id] = null;
            SearchProperties[PropertyNames.RedirectingPage] = "False";
            SearchProperties[PropertyNames.FrameDocument] = "False";
            //this.SearchProperties[HtmlDocument.PropertyNames.Title] = "Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365";
            WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlHyperlink UserInfoHyperlink
        {
            get
            {
                if (m_firstnameLastnameHyperlink == null)
                {
                    m_firstnameLastnameHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    m_firstnameLastnameHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "navTabButtonUserInfoLinkId";
                    m_firstnameLastnameHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    m_firstnameLastnameHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    m_firstnameLastnameHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "\r\naFirstname aLastname\r\n  ";
                    m_firstnameLastnameHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/main.aspx";
                    m_firstnameLastnameHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Title] = "aFirstname aLastname proMX GmbH";
                    m_firstnameLastnameHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Href] = "https://promxtest20180312.crm4.dynamics.com/main.aspx";
                    m_firstnameLastnameHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Class] = "navTabButtonLink";
                    m_firstnameLastnameHyperlink.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
                    #endregion
                }
                return m_firstnameLastnameHyperlink;
            }
        }

        public TabHomePane TabHomePane
        {
            get
            {
                if (m_tabHomePane == null)
                {
                    m_tabHomePane = new TabHomePane(this);
                }
                return m_tabHomePane;
            }
        }

        public HtmlHyperlink ProjectServiceHyperlink
        {
            get
            {
                if (m_projectServiceHyperlink == null)
                {
                    m_projectServiceHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    m_projectServiceHyperlink.SearchProperties[HtmlControl.PropertyNames.Id] = "proRM";
                    m_projectServiceHyperlink.SearchProperties[HtmlControl.PropertyNames.InnerText] = "\r\nProject Service";
//                    this.m_projectServiceHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "Project Service";
//                   this.m_projectServiceHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "navActionButtonContainer navActionButton navModuleButton normal";
                    m_projectServiceHyperlink.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
                    #endregion
                }
                return m_projectServiceHyperlink;
            }
        }

        public HtmlHyperlink ProjectGanttHyperlink
        {
            get
            {
                if (m_projectGanttHyperlink == null)
                {
                    m_projectGanttHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    m_projectGanttHyperlink.SearchProperties[HtmlControl.PropertyNames.Id] = "prorm_gantt";
/*
                    this.m_projectGanttHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Project Gantt";
                    this.m_projectGanttHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "Project Gantt";
                    this.m_projectGanttHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "nav-rowBody normal";
*/                    
                    m_projectGanttHyperlink.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
                    #endregion
                }
                return m_projectGanttHyperlink;
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