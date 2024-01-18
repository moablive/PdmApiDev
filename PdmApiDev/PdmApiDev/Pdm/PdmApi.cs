using System;
using EPDM.Interop.epdm;

namespace PdmApiDev
{
    public class PdmApi
    {
        private IEdmVault18 cofrePdm = (IEdmVault18)new EdmVault5();

        public void Login(string VaultName)
        {
            try
            {
                cofrePdm.LoginAuto(VaultName, 0);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Realizar Login: {ex.Message}\n{ex.StackTrace}");
            }
        }

        public void CustomLogin(string VaultName, string usuario, string senha)
        {
            try
            {
                cofrePdm.Login(usuario, senha, VaultName);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Realizar Login: {ex.Message}\n{ex.StackTrace}");
            }
        }

        public bool VerifyLogin()
        {
            return cofrePdm.IsLoggedIn;
        }

        public string ChechUser()
        {
            IEdmUserMgr5 userMgr;
            IEdmUser5 user;

            userMgr = (IEdmUserMgr5)cofrePdm;
            user = (IEdmUser5)userMgr.GetLoggedInUser();

            return user.Name;
        }
    }
}
