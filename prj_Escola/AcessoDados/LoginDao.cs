﻿using System;
using System.Data;

namespace AcessoDados
{
    public class LoginDao
    {
        readonly AcessoSqlServer _contexto = new AcessoSqlServer();
       
        public int Logon(string usuario, string senha)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@Usuario", usuario);
                _contexto.AdicionarParametros("@Senha", senha);
                string retorno = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspLogar").ToString();
                int idUsuario = Convert.ToInt32(retorno);
                return idUsuario;
            }
            catch(Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
