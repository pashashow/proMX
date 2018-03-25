using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.Common
{
    public class MicrosoftDynamics365Document : HtmlDocument
    {

        public MicrosoftDynamics365Document(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Microsoft Dynamics 365";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/main.aspx";
//            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://promxtest20180312.crm4.dynamics.com/main.aspx#678509312";
            this.WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public MainContentAreaFrame MainContentAreaFrame
        {
            get
            {
                if ((this.m_mainContentAreaFrame == null))
                {
                    this.m_mainContentAreaFrame = new MainContentAreaFrame(this);
                }
                return this.m_mainContentAreaFrame;
            }
        }
        #endregion

        #region Fields
        private MainContentAreaFrame m_mainContentAreaFrame;
        #endregion
    }
}