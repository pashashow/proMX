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

            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "TabSFA";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = "TabHome";
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "navTabButton navTabButtonRight SubAreaNodePadding";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] =
                "class=\"navTabButton navTabButtonRight SubAreaNodePadding\" id=\"TabSFA\" name=\"TabHome\"";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "19";
            this.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");

            #endregion
        }

        #region Properties
        public HtmlHyperlink SalesHyperlink
        {
            get
            {
                if ((this.m_salesHyperlink == null))
                {
                    this.m_salesHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.m_salesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.m_salesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.m_salesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.m_salesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = null;
                    this.m_salesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = ";";
                    this.m_salesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "Sales";
                    this.m_salesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "javascript:;";
                    this.m_salesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "navTabButtonLink";
                    this.m_salesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "title=\"Sales\" class=\"navTabButtonLink\" a";
                    this.m_salesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.m_salesHyperlink.WindowTitles.Add("Dashboards: Sales Activity Social Dashboard - Microsoft Dynamics 365");
                    #endregion
                }
                return this.m_salesHyperlink;
            }
        }
        #endregion

        #region Fields
        private HtmlHyperlink m_salesHyperlink;
        #endregion
    }
}