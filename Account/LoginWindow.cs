using System.Drawing;
using HandCodedFluentCUIT.Common;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace HandCodedFluentCUIT.Account
{
    public class LoginWindow
    {
        private readonly MicrosoftDynamics365Window m_bw;

        public LoginWindow(MicrosoftDynamics365Window bw)
        {
            m_bw = bw;
        }

        private HtmlDiv m_otherUserDiv;

        private HtmlDiv OtherUserPan
        {
            get
            {
                if (m_otherUserDiv != null)
                {
                    return m_otherUserDiv;
                }
                m_otherUserDiv = new HtmlDiv(m_bw);
#region Search Criteria
                m_otherUserDiv.SearchProperties[HtmlControl.PropertyNames.Id] = "otherTileText";
                m_otherUserDiv.SearchProperties[UITestControl.PropertyNames.Name] = null;
                m_otherUserDiv.FilterProperties[HtmlControl.PropertyNames.InnerText] = "Use another account";
                m_otherUserDiv.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "id=\"otherTileText\" data-bind=\"text: str[\'TILE_STR_UseAnother\']\"";
                m_otherUserDiv.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "39";
                m_otherUserDiv.WindowTitles.Add("Sign in to your account");
#endregion
                return m_otherUserDiv;
            }
        }

        private HtmlEdit m_loginEdit;

        private HtmlEdit LoginEdit
        {
            get
            {
                if (m_loginEdit != null)
                {
                    return m_loginEdit;
                }
                m_loginEdit = new HtmlEdit(m_bw);

#region Search Criteria
                m_loginEdit.SearchProperties[HtmlControl.PropertyNames.Id] = "i0116";
                m_loginEdit.SearchProperties[UITestControl.PropertyNames.Name] = "loginfmt";
                m_loginEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                m_loginEdit.FilterProperties[HtmlControl.PropertyNames.Type] = "SINGLELINE";
                m_loginEdit.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                m_loginEdit.FilterProperties[HtmlControl.PropertyNames.Class] = "form-control ltr_override";
                m_loginEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "name=\"loginfmt\" class=\"form-control ltr_";
                m_loginEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
                m_loginEdit.WindowTitles.Add("Sign in to your account");
#endregion
                return m_loginEdit;
            }
        }

        private HtmlInputButton m_nextButton;

        private HtmlInputButton NextButton
        {
            get
            {
                if (m_nextButton != null)
                {
                    return m_nextButton;
                }
                m_nextButton = new HtmlInputButton(m_bw);
#region Search Criteria
                m_nextButton.SearchProperties[HtmlControl.PropertyNames.Id] = "idSIButton9";
                m_nextButton.SearchProperties[UITestControl.PropertyNames.Name] = null;
                m_nextButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Next";
                m_nextButton.SearchProperties[HtmlControl.PropertyNames.Type] = "submit";
                m_nextButton.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                m_nextButton.FilterProperties[HtmlControl.PropertyNames.Class] = "btn btn-block btn-primary";
                m_nextButton.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "class=\"btn btn-block btn-primary\" id=\"id";
                m_nextButton.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "4";
                m_nextButton.WindowTitles.Add("Sign in to your account");
#endregion
                return m_nextButton;
            }
        }

        private HtmlEdit m_passwordEdit;

        private HtmlEdit PasswdEdit
        {
            get
            {
                if (m_passwordEdit != null)
                {
                    return m_passwordEdit;
                }
                m_passwordEdit = new HtmlEdit(m_bw);

#region Search Criteria
                m_passwordEdit.SearchProperties[HtmlControl.PropertyNames.Id] = "i0118";
                m_passwordEdit.SearchProperties[UITestControl.PropertyNames.Name] = "passwd";
                m_passwordEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                m_passwordEdit.FilterProperties[HtmlControl.PropertyNames.Type] = "PASSWORD";
                m_passwordEdit.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                m_passwordEdit.FilterProperties[HtmlControl.PropertyNames.Class] = "form-control";
                m_passwordEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "name=\"passwd\" class=\"form-control\" id=\"i";
                m_passwordEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "10";
                m_passwordEdit.WindowTitles.Add("Sign in to your account");
#endregion
                return m_passwordEdit;
            }
        }

        private HtmlInputButton m_signinButton;

        private HtmlInputButton SigninButton
        {
            get
            {
                if (m_signinButton != null)
                {
                    return m_signinButton;
                }
                m_signinButton = new HtmlInputButton(m_bw);

#region Search Criteria
                m_signinButton.SearchProperties[HtmlControl.PropertyNames.Id] = "idSIButton9";
                m_signinButton.SearchProperties[UITestControl.PropertyNames.Name] = null;
                m_signinButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Sign in";
                m_signinButton.SearchProperties[HtmlControl.PropertyNames.Type] = "submit";
                m_signinButton.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                m_signinButton.FilterProperties[HtmlControl.PropertyNames.Class] = "btn btn-block btn-primary";
                m_signinButton.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "class=\"btn btn-block btn-primary\" id=\"id";
                m_signinButton.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "12";
                m_signinButton.WindowTitles.Add("Sign in to your account");
#endregion
                return m_signinButton;
            }
        }

        private HtmlInputButton m_noButton;

        private HtmlInputButton NoButton
        {
            get
            {
                if (m_noButton != null)
                {
                    return m_noButton;
                }
                m_noButton = new HtmlInputButton(m_bw);

#region Search Criteria
                m_noButton.SearchProperties[HtmlControl.PropertyNames.Id] = "idBtn_Back";
                m_noButton.SearchProperties[UITestControl.PropertyNames.Name] = null;
                m_noButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "No";
                m_noButton.SearchProperties[HtmlControl.PropertyNames.Type] = "button";
                m_noButton.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                m_noButton.FilterProperties[HtmlControl.PropertyNames.Class] = "btn btn-block";
                m_noButton.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "class=\"btn btn-block\" id=\"idBtn_Back\" ty";
                m_noButton.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "6";
                m_noButton.WindowTitles.Add("Sign in to your account");
#endregion
                return m_noButton;
            }
        }

        public class LoginParams
        {

            #region Fields
            /// <summary>
            /// Go to web page 'https://promxtest20180312.crm4.dynamics.com/'
            /// </summary>
            public string UINewtabInternetExplorWindowUrl = "https://promxtest20180312.crm4.dynamics.com/";

            /// <summary>
            /// Type 'admin@promxtest20180312.onmicrosoft.com ' in 'loginfmt' text box
            /// </summary>
            public string UILoginfmtEditText = "admin@promxtest20180312.onmicrosoft.com ";

            /// <summary>
            /// Type '********' in 'passwd' text box
            /// </summary>
            public string UIPasswdEditPassword = "0+Q9kMJXOEv61G9zWsgu/DdnW5JJrhKP";
            #endregion
        }

        public MainAppWindow LoginAction()
        {
            // Click 'Use another account' pane
            Mouse.Click(OtherUserPan, new Point(101, 6));

            var param = new LoginParams();

            // Type 'admin@promxtest20180312.onmicrosoft.com ' in 'loginfmt' text box
            LoginEdit.Text = param.UILoginfmtEditText;

            // Click 'Next' button
            Mouse.Click(NextButton, new Point(44, 17));

            // Type '********' in 'passwd' text box
            PasswdEdit.Password = param.UIPasswdEditPassword;

            // Click 'Sign in' button
            Mouse.Click(SigninButton, new Point(57, 26));

            // Click 'No' button
            Mouse.Click(NoButton, new Point(131, 9));

            return new MainAppWindow(m_bw);
        }
    }
}