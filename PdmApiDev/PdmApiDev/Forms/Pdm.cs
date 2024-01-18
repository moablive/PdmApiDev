using System;
using System.Windows.Forms;

namespace PdmApiDev
{
    public partial class Pdm : Form
    {
        //PdmApi - CLASS
        PdmApi pdmApi = new PdmApi();

        #region FORMS
        //CofreLogin - Form
        CofreLogin cofreLogin = new CofreLogin();
        #endregion

        public Pdm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                pdmApi.Login("skaDeveloper");

                if (pdmApi.VerifyLogin())
                    MessageBox.Show(pdmApi.ChechUser(), "Usario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //cofreLogin ShowDialog
                cofreLogin.ShowDialog();

                //COFRE - STRING
                string vaultName = cofreLogin.SetLogin.VaultName;
                
                //USER - STRING
                string usuario = cofreLogin.SetLogin.User;
                
                //COFRE - STRING
                string senha = cofreLogin.SetLogin.Password;

                pdmApi.CustomLogin(vaultName, usuario, senha);

                if (pdmApi.VerifyLogin())
                    MessageBox.Show("Login Efetuado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERRO",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
