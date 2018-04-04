using HandCodedFluentCUIT.ProjectService;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.Common
{
    public class MainContentAreaFrame : HtmlIFrame
    {

        public MainContentAreaFrame(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlFrame.PropertyNames.Id] = "contentIFrame0";
            SearchProperties[HtmlFrame.PropertyNames.Name] = "contentIFrame0";
            //this.FilterProperties[HtmlFrame.PropertyNames.Title] = "Content Area";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public ProjectGanttDocument ProjectGanttDocument
        {
            get
            {
                if (m_projectGanttDocument == null)
                {
                    m_projectGanttDocument = new ProjectGanttDocument(this);
                }
                return m_projectGanttDocument;
            }
        }
        #endregion

        #region Fields
        private ProjectGanttDocument m_projectGanttDocument;
        #endregion
    }
}