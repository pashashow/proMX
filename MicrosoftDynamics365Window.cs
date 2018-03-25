using Microsoft.VisualStudio.TestTools.UITesting;

namespace HandCodedFluentCUIT.Common
{
    public class MicrosoftDynamics365Window : BrowserWindow
    {
        public MicrosoftDynamics365Window()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Microsoft Dynamics 365";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }

        #region Properties
        public MicrosoftDynamics365Document MicrosoftDynamics365Document
        {
            get
            {
                if (this.m_mMicrosoftDynamics365Document == null)
                {
                    this.m_mMicrosoftDynamics365Document = new MicrosoftDynamics365Document(this);
                }
                return this.m_mMicrosoftDynamics365Document;
            }
        }

        public DashboardsSalesActivDocument DashboardsSalesActivDocumen
        {
            get
            {
                if (this.m_dashboardsSalesActivDocument == null)
                {
                    this.m_dashboardsSalesActivDocument = new DashboardsSalesActivDocument(this);
                }
                return this.m_dashboardsSalesActivDocument;
            }
        }
        #endregion

        #region Fields
        private MicrosoftDynamics365Document m_mMicrosoftDynamics365Document;

        private DashboardsSalesActivDocument m_dashboardsSalesActivDocument;
        #endregion
    }
}