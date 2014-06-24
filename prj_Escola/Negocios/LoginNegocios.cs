using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoDados;
using DTO; 

namespace Negocios
{
    public class LoginNegocios
    {
        private readonly LoginDao _loginDao = new LoginDao();

        public int Logon(string usuario, string senha)
        {
            var login = _loginDao.Logon(usuario, senha);
            return login;
        }
    }
}
