using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.Common.Navigation
{
    public class NavigationBar : HtmlDiv
    {
        #region Fields
        private SalesButton m_salesButton;

        private ProjectServiceButton m_projectServiceButton;
        #endregion

        public NavigationBar(UITestControl searchLimitContainer)
        :base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlControl.PropertyNames.Id] = "navBar";
            SearchProperties[HtmlControl.PropertyNames.Class] = "navigationControl";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public SalesButton SalesButton
        {
            get
            {
                if (m_salesButton == null)
                {
                    m_salesButton = new SalesButton(this);
                }
                return m_salesButton;
            }
        }

        public ProjectServiceButton ProjectServiceButton
        {
            get
            {
                if (m_projectServiceButton == null)
                {
                    m_projectServiceButton = new ProjectServiceButton(this);
                }
                return m_projectServiceButton;
            }
        }
        #endregion
    }
}