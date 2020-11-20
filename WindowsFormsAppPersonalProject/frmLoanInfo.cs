using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmLoanInfo : Form
    {
        public frmLoanInfo()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void frmLoanInfo_Load(object sender, EventArgs e)
        {
            string url = "http://adplatform.co.kr/intro/4241604880070/?gclid=CjwKCAiAzNj9BRBDEiwAPsL0d_PC8fRaFOBGYnRzRfVHXjUZvgdhHaBji3Xq0U42NukEGDLAbmEGnBoCJoEQAvD_BwE";
            webBrowser1.Navigate(url);
        }
    }
}
