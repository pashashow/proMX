using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.Common.Navigation
{
    public class ProjectServiceButton : HtmlSpan
    {
        public ProjectServiceButton(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[HtmlControl.PropertyNames.Id] = "TabproRM";
            SearchProperties[HtmlSpan.PropertyNames.Name] = "TabHome";
            WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");

            #endregion
        }

        #region Properties

        public HtmlHyperlink ProjectServiceHyperlink
        {
            get
            {
                if (m_projectServiceHyperlink == null)
                {
                    m_projectServiceHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    m_projectServiceHyperlink.SearchProperties[HtmlControl.PropertyNames.Class] = "navTabButtonLink";
                    m_projectServiceHyperlink.SearchProperties[HtmlControl.PropertyNames.Title] = "Project Service";
                    m_projectServiceHyperlink.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
                    #endregion
                }
                return m_projectServiceHyperlink;
            }
        }

        #endregion

        #region Fields
        private HtmlHyperlink m_projectServiceHyperlink;
        #endregion
    }
}