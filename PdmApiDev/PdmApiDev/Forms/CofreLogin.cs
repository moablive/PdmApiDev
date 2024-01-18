using System;
using System.Windows.Forms;


using PdmApiDev.Models;

namespace PdmApiDev
{
    public partial class CofreLogin : Form
    {
        public LoginModel SetLogin
        {
            get
            {
                return new LoginModel
                {
                    VaultName = cofreTxt.Text,
                    User = userTxt.Text,
                    Password = passTxt.Text
                };
            }
        }

        public CofreLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
