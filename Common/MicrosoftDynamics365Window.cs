using System;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace HandCodedFluentCUIT.Common
{
    public class MicrosoftDynamics365Window : BrowserWindow
    {
        public MicrosoftDynamics365Window()
        {
            #region Search Criteria
            SearchProperties[PropertyNames.Name] = "Microsoft Dynamics 365";
//            SearchProperties[PropertyNames.ClassName] = "IEFrame";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        public void LaunchUrl(Uri url)
        {
            CopyFrom(Launch(url));
        }

        #region Properties
        public MicrosoftDynamics365Document MicrosoftDynamics365Document
        {
            get
            {
                if (m_mMicrosoftDynamics365Document == null)
                {
                    m_mMicrosoftDynamics365Document = new MicrosoftDynamics365Document(this);
                }
                return m_mMicrosoftDynamics365Document;
            }
        }

        public DashboardsSalesActivDocument DashboardsSalesActivDocumen
        {
            get
            {
                if (m_dashboardsSalesActivDocument == null)
                {
                    m_dashboardsSalesActivDocument = new DashboardsSalesActivDocument(this);
                }
                return m_dashboardsSalesActivDocument;
            }
        }
        #endregion

        #region Fields
        private MicrosoftDynamics365Document m_mMicrosoftDynamics365Document;

        private DashboardsSalesActivDocument m_dashboardsSalesActivDocument;
        #endregion
    }
}