using System.Configuration;
using AcessoDados.Properties;
using System;
using System.Data;
using System.Data.SqlClient;



namespace AcessoDados
{
    public class AcessoSqlServer
    {
        private SqlConnection _conexao;

        public AcessoSqlServer()
        {
            _conexao = new SqlConnection(Settings.Default.strConexao);            
        }
       
        private readonly SqlParameterCollection _sqlParameterCollection = new SqlCommand().Parameters;

        private SqlCommand CriarComando(CommandType cmdType, string cmdSql)
        {
                _conexao.Open();
                SqlCommand cmd = _conexao.CreateCommand();                
                cmd.CommandType = cmdType;
                cmd.CommandText = cmdSql;
                cmd.CommandTimeout = 7200;                
                foreach (SqlParameter sqlParameter in _sqlParameterCollection)
                {
                    cmd.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
            return cmd;
        }

        public void LimparParametros()
        {
            _sqlParameterCollection.Clear();
        }
              
        public void AdicionarParametros(string nomeParametro, object valorParametro)
        { 
            _sqlParameterCollection.Add(new SqlParameter(nomeParametro,valorParametro));
        }

        public object ExecutaManipulacao(CommandType cmdType, string cmdSql)
        {
            try
            {
                var cmd = CriarComando(cmdType, cmdSql);                                                      
                object obj = cmd.ExecuteScalar();
                _conexao.Close();
                return obj;
            }
            catch (Exception erro)
            {
                _conexao.Close();
                throw new Exception(erro.Message);
            }

        }
     
        public DataTable ExecutaConsulta(CommandType cmdType, string cmdSql)
        {
            try
            {

                var cmd = CriarComando(cmdType, cmdSql);              
                DataTable dataTable = new DataTable();               
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);               
                sqlDataAdapter.Fill(dataTable);
                _conexao.Close();
                return dataTable;
            }
            catch(Exception erro)
            {
                _conexao.Close();
                throw new Exception(erro.Message);
            }
        }
    }
}
