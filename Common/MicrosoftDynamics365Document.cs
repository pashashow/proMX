using HandCodedFluentCUIT.Common.Navigation;
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
            SearchProperties[HtmlControl.PropertyNames.Id] = null;
            SearchProperties[PropertyNames.RedirectingPage] = "False";
            SearchProperties[PropertyNames.FrameDocument] = "False";
            //this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Microsoft Dynamics 365";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public MainContentAreaFrame MainContentAreaFrame
        {
            get
            {
                if (m_mainContentAreaFrame == null)
                {
                    m_mainContentAreaFrame = new MainContentAreaFrame(this);
                }
                return m_mainContentAreaFrame;
            }
        }
        #endregion

        #region Fields
        private MainContentAreaFrame m_mainContentAreaFrame;
        #endregion
    }
}