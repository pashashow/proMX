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

        public HtmlSpan ExpandFirstLevelItemPane
        {
            get
            {
                if ((this.m_expandFirstLevelPane == null))
                {
                    this.m_expandFirstLevelPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.m_expandFirstLevelPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.m_expandFirstLevelPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.m_expandFirstLevelPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                    this.m_expandFirstLevelPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.m_expandFirstLevelPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-icon k-i-expand";
                    this.m_expandFirstLevelPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-icon k-i-expand\"";
                    this.m_expandFirstLevelPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "34";
                    this.m_expandFirstLevelPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_expandFirstLevelPane;
            }
        }

        public HtmlSpan ExpandSecondLevelItemPane
        {
            get
            {
                if ((this.m_expandSecondLevelPane == null))
                {
                    this.m_expandSecondLevelPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.m_expandSecondLevelPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.m_expandSecondLevelPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.m_expandSecondLevelPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                    this.m_expandSecondLevelPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.m_expandSecondLevelPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-icon k-i-expand";
                    this.m_expandSecondLevelPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-icon k-i-expand\"";
                    this.m_expandSecondLevelPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "90";
                    this.m_expandSecondLevelPane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_expandSecondLevelPane;
            }
        }

        public HtmlSpan Task1Pane
        {
            get
            {
                if ((this.m_task1Pane == null))
                {
                    this.m_task1Pane = new HtmlSpan(this);
                    #region Search Criteria
                    this.m_task1Pane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.m_task1Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.m_task1Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Task #1";
                    this.m_task1Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.m_task1Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.m_task1Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"vertical-align: middle;\" aria-label=\"Task #1, 0 %\"";
                    this.m_task1Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "106";
                    this.m_task1Pane.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_task1Pane;
            }
        }
        #endregion

        #region Fields
        private HtmlSpan m_newProjectPane;

        private HtmlSpan m_geveePane;

        private HtmlSpan m_itemPane;

        private HtmlSpan m_expandFirstLevelPane;

        private HtmlSpan m_expandSecondLevelPane;

        private HtmlSpan m_task1Pane;

        private HtmlSpan m_project1Pane;
        #endregion
    }
}