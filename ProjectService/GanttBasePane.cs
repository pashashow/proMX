using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService
{
    public class GanttBasePane : HtmlDiv
    {
        public GanttBasePane(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlDiv.PropertyNames.Id] = "ganttBase";
            SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            FilterProperties[HtmlDiv.PropertyNames.InnerText] = "&nbps;Month\r\nWeek\r\nMonth\r\nYear\r\n\r\n\r\n\r\n\r\n";
            FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            FilterProperties[HtmlDiv.PropertyNames.Class] = "k-widget k-gantt";
            FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-widget k-gantt\" id=\"ganttBase\" style=\"height: 807.36px; overflow: hidden" +
                "; touch-action: pan-y;\" data-role=\"gantt\"";
            FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "5";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlSpan NewProjectPane
        {
            get
            {
                if (m_newProjectPane == null)
                {
                    m_newProjectPane = new HtmlSpan(this);
                    #region Search Criteria
                    m_newProjectPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_newProjectPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_newProjectPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "New project #1";
                    m_newProjectPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_newProjectPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    m_newProjectPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"vertical-align: middle;\" aria-label=\"New project #1, 0 %\"";
                    m_newProjectPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "256";
                    m_newProjectPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_newProjectPane;
            }
        }

        public HtmlSpan GeveePane
        {
            get
            {
                if (m_geveePane == null)
                {
                    m_geveePane = new HtmlSpan(this);
                    #region Search Criteria
                    m_geveePane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_geveePane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_geveePane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Gevee";
                    m_geveePane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_geveePane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    m_geveePane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"vertical-align: middle;\" aria-label=\"Gevee, 0 %\"";
                    m_geveePane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "35";
                    m_geveePane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_geveePane;
            }
        }

        public HtmlSpan ItemPane
        {
            get
            {
                if (m_itemPane == null)
                {
                    m_itemPane = new HtmlSpan(this);
                    #region Search Criteria
                    m_itemPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    m_itemPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "+";
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = null;
                    m_itemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "87";
                    m_itemPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_itemPane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_newProjectPane;

        private HtmlSpan m_geveePane;

        private HtmlSpan m_itemPane;
        #endregion
    }
}