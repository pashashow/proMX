using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.Common
{
    /// <summary>
    /// Summary description for ToolBar
    /// </summary>
    public class ToolBar
    {
        private readonly BrowserWindow m_bw;

        public ToolBar(BrowserWindow bw)
        {
            m_bw = bw;
        }

        private HtmlSpan m_tabHomePane;

        public HtmlSpan TabHomePane
        {
            get
            {
                if (m_tabHomePane != null)
                {
                    return m_tabHomePane;
                }
                m_tabHomePane = new HtmlSpan(m_bw);
#region Search Criteria
                m_tabHomePane.SearchProperties[HtmlDiv.PropertyNames.Id] = "TabSFA";
                m_tabHomePane.SearchProperties[HtmlDiv.PropertyNames.Name] = "TabHome";
                m_tabHomePane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                m_tabHomePane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                m_tabHomePane.FilterProperties[HtmlDiv.PropertyNames.Class] = "navTabButton navTabButtonRight SubAreaNodePadding";
                m_tabHomePane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"navTabButton navTabButtonRight SubAreaNodePadding\" id=\"TabSFA\" name=\"TabHo" +
                                                                                          "me\"";
                m_tabHomePane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "19";
                m_tabHomePane.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
#endregion
                return m_tabHomePane;
            }
        }

        private HtmlHyperlink m_projectServiceHyperLink;

        public HtmlHyperlink ProjectServiceHyperlink
        {
            get
            {
                if (m_projectServiceHyperLink != null)
                {
                    return m_projectServiceHyperLink;
                }
                m_projectServiceHyperLink = new HtmlHyperlink(m_bw);
#region Search Criteria
                m_projectServiceHyperLink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "proRM";
                m_projectServiceHyperLink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                m_projectServiceHyperLink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                m_projectServiceHyperLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "\r\nProject Service";
                m_projectServiceHyperLink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/main.aspx";
                m_projectServiceHyperLink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "Project Service";
                m_projectServiceHyperLink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "https://promxtest20180312.crm4.dynamics.com/main.aspx?area=cMyWork&page=proRM&web" +
                                                                                                        "=true";
                m_projectServiceHyperLink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "navActionButtonContainer navActionButton navModuleButton normal";
                m_projectServiceHyperLink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "title=\"Project Service\" class=\"navAction";
                m_projectServiceHyperLink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "47";
                m_projectServiceHyperLink.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
#endregion

                return m_projectServiceHyperLink;
            }
        }

        private HtmlHyperlink m_projectGanttHyperLink;

        public HtmlHyperlink ProjectGanttHyperlink
        {
            get
            {
                if (m_projectGanttHyperLink != null)
                {
                    return m_projectGanttHyperLink;
                }
                m_projectGanttHyperLink = new HtmlHyperlink(m_bw);
#region Search Criteria
                m_projectGanttHyperLink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "prorm_gantt";
                m_projectGanttHyperLink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                m_projectGanttHyperLink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                m_projectGanttHyperLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Project Gantt";
                m_projectGanttHyperLink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/%7B636564669310000569%7D/WebResources/prorm_/Apps/Gantt.SMB/index.html";
                m_projectGanttHyperLink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "Project Gantt";
                m_projectGanttHyperLink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "https://promxtest20180312.crm4.dynamics.com/%7B636564669310000569%7D/WebResources" +
                                                                                             "/prorm_/Apps/Gantt.SMB/index.html?orglcid=1033&orgname=org6980cb4f&userlcid=1033" +
                                                                                             "";
                m_projectGanttHyperLink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "nav-rowBody normal";
                m_projectGanttHyperLink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "title=\"Project Gantt\" class=\"nav-rowBody";
                m_projectGanttHyperLink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "60";
                m_projectGanttHyperLink.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
#endregion
                return m_projectGanttHyperLink;
            }
        }
    }
}
