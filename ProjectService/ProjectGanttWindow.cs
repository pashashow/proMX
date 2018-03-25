using System.Drawing;
using HandCodedFluentCUIT.Common;
using HandCodedFluentCUIT.Dialogs;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.ProjectService
{
    public class ProjectGanttWindow
    {
        private readonly MicrosoftDynamics365Window m_bw;
        private readonly HtmlSpan m_filterButton; 

        public ProjectGanttWindow(MicrosoftDynamics365Window bw)
        {
            m_bw = bw;
            m_filterButton = m_bw.MicrosoftDynamics365Document.MainContentAreaFrame.ProjectGanttDocument.FilterButtonOnGantt.UIItemPane;
        }

        internal FilterWindow OpenFilter()
        {
            Mouse.Click(m_filterButton, new Point(2, 2));

            return new FilterWindow(m_bw);
        }

/*        

        private HtmlButton FilterButton
        {
            get
            {
                if (m_filterButton == null)
                {
                    m_filterButton = 
                }

                return m_filterButton;
            }
        }
        public class FilterButton : HtmlButton
        {
            #region Properties
            public HtmlSpan UIItemPane
            {
                get
                {
                    if ((this.mUIItemPane == null))
                    {
                        this.mUIItemPane = new HtmlSpan(this);
                        #region Search Criteria
                        this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                        this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                        this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                        this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                        this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "k-icon k-i-search";
                        this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"k-icon k-i-search\"";
                        this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "17";
                        this.mUIItemPane.WindowTitles.Add("Microsoft Dynamics 365");
                        #endregion
                    }
                    return this.mUIItemPane;
                }
            }
            #endregion

            #region Fields
            private HtmlSpan mUIItemPane;
            #endregion
        }

        private FilterButton FilterButton1
        { 
            get
            {
                if (m_filterButton != null)
                {
                    return m_filterButton;
                }

                m_filterButton = new FilterButton();

#region Search Criteria
                m_filterButton.SearchProperties[HtmlButton.PropertyNames.Id] = "filter_button_on_gantt_page";
                m_filterButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                m_filterButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = null;
                m_filterButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                m_filterButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                m_filterButton.FilterProperties[HtmlButton.PropertyNames.Class] = "k-button";
                m_filterButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "tabindex=\"0\" class=\"k-button\" id=\"filter";
                m_filterButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "8";
                m_filterButton.WindowTitles.Add("Microsoft Dynamics 365");
#endregion
                return m_filterButton;
            }
        }
*/

    }
}