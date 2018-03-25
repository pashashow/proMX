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
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "contentIFrame0";
            this.SearchProperties[HtmlFrame.PropertyNames.Name] = "contentIFrame0";
            this.FilterProperties[HtmlFrame.PropertyNames.AbsolutePath] = null;
            this.FilterProperties[HtmlFrame.PropertyNames.PageUrl] = null;
            this.FilterProperties[HtmlFrame.PropertyNames.Title] = "Content Area";
            this.FilterProperties[HtmlFrame.PropertyNames.Class] = null;
            this.FilterProperties[HtmlFrame.PropertyNames.ControlDefinition] = "name=\"contentIFrame0\" title=\"Content Are";
            this.FilterProperties[HtmlFrame.PropertyNames.TagInstance] = "1";
            this.WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public ProjectGanttDocument ProjectGanttDocument
        {
            get
            {
                if ((this.m_projectGanttDocument == null))
                {
                    this.m_projectGanttDocument = new ProjectGanttDocument(this);
                }
                return this.m_projectGanttDocument;
            }
        }
        #endregion

        #region Fields
        private ProjectGanttDocument m_projectGanttDocument;
        #endregion
    }
}