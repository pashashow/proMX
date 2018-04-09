using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.Common.Navigation
{
    public class DashboardsDocument : HtmlDocument
    {
        public DashboardsDocument(UITestControl searchLimitContainer) 
            : base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[PropertyNames.RedirectingPage] = "False";
            SearchProperties[PropertyNames.FrameDocument] = "False";
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
                    m_projectGanttHyperlink.SearchProperties[HtmlControl.PropertyNames.InnerText] = "Project Gantt";
                    m_projectGanttHyperlink.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
                    #endregion
                }
                return m_projectGanttHyperlink;
            }
        }
        #endregion

        #region Fields
        private HtmlHyperlink m_firstnameLastnameHyperlink;

        private HtmlHyperlink m_projectServiceHyperlink;

        private HtmlHyperlink m_projectGanttHyperlink;
        #endregion
    }
}