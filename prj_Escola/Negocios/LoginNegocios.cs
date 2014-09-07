using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoDados;
using DTO;
using JetBrains.ReSharper.Psi.VB.Util;

namespace Negocios
{
    public class LoginNegocios
    {
        private readonly LoginDao _loginDao = new LoginDao();

        public int Logon(string usuario, string senha)
        {
            try
            {
                var login = _loginDao.Logon(usuario, senha);
                return login;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
           
        }
    }
}
