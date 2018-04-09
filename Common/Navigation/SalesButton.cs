using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.Common.Navigation
{
    public class SalesButton : HtmlSpan
    {
        public SalesButton(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[HtmlControl.PropertyNames.Id] = "TabSFA";
            SearchProperties[UITestControl.PropertyNames.Name] = "TabHome";
            WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");

            #endregion
        }

        #region Properties
        public HtmlHyperlink SalesHyperlink
        {
            get
            {
                if (m_salesHyperlink == null)
                {
                    m_salesHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    m_salesHyperlink.SearchProperties[HtmlControl.PropertyNames.Title] = "Sales";
                    m_salesHyperlink.SearchProperties[HtmlControl.PropertyNames.Class] = "navTabButtonLink";
                    m_salesHyperlink.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
                    #endregion
                }
                return m_salesHyperlink;
            }
        }
        #endregion

        #region Fields
        private HtmlHyperlink m_salesHyperlink;
        #endregion
    }
}