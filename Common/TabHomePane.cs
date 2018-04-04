using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.Common
{
    public class TabHomePane : HtmlSpan
    {
        public TabHomePane(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[HtmlDiv.PropertyNames.Id] = "TabSFA";
            SearchProperties[HtmlDiv.PropertyNames.Name] = "TabHome";
            //this.FilterProperties[HtmlDiv.PropertyNames.Class] = "navTabButton navTabButtonRight SubAreaNodePadding";
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
                    m_salesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    m_salesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    m_salesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    m_salesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = null;
                    m_salesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Title] = "Sales";
                    m_salesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Class] = "navTabButtonLink";
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