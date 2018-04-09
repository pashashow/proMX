using System;
using HandCodedFluentCUIT.Common.Navigation;
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

        public DashboardsDocument DashboardsDocument
        {
            get
            {
                if (m_dashboardDocument == null)
                {
                    m_dashboardDocument = new DashboardsDocument(this);
                }
                return m_dashboardDocument;
            }
        }

        public NavigationBar NavigationBar
        {
            get
            {
                if (m_navigationBar == null)
                {
                    m_navigationBar = new NavigationBar(this);
                }
                return m_navigationBar;
            }
        }
        #endregion

        #region Fields
        private MicrosoftDynamics365Document m_mMicrosoftDynamics365Document;

        private NavigationBar m_navigationBar;

        private DashboardsDocument m_dashboardDocument;

        #endregion
    }
}