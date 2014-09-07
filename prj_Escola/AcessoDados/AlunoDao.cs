using System;
using System.Data;
using System.Linq;
using AcessoDados.Interface;
using DTO;
using System.Collections.Generic;

namespace AcessoDados
{
    public class AlunoDao:IRepositorio<Aluno>
    {
        private readonly AcessoSqlServer _contexto = new AcessoSqlServer();
     
        private string Inserir(Aluno aluno) 
        {
            try
            {
                CarregarParametros(aluno);
                string idAluno = _contexto.ExecutaManipulacao(CommandType.StoredProcedure,"uspAlunoInserir").ToString();
                return idAluno;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }
       
        private string Alterar(Aluno aluno)
        {
            try
            {
                 CarregarParametros(aluno);
                _contexto.AdicionarParametros("@IdAluno", aluno.IdAluno);
                string idAluno = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspAlunoAlterar").ToString();
                return idAluno;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }

        }

        public string Salvar(Aluno aluno)
        {          
            var idAluno = aluno.IdAluno > 0 ? Alterar(aluno) : Inserir(aluno);
            return idAluno;
        }

        public string Excluir(Aluno aluno)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdAluno", aluno.IdAluno);
                string idAluno = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspAlunoExcluir").ToString();
                return idAluno;
            }
            catch (Exception erro)
            { 
               return erro.Message;
            }
        }

        public IEnumerable<Aluno> ListarTodos()
        {
            try
            {
                var alunoCollection = new AlunoCollection();                         
                var dtAluno = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspAlunoListarTodos");
                foreach (DataRow linha in dtAluno.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.IdAluno = Convert.ToInt32(linha["IdAluno"]);
                    aluno.NomeAluno = Convert.ToString(linha["NomeAluno"]);
                    aluno.IdCurso = Convert.ToInt32(linha["IdCurso"]);
                    aluno.NomeCurso = linha["NomeCurso"].ToString();
                    alunoCollection.Add(aluno);
                }
                return alunoCollection;
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possivel consultar o aluno por nome" + erro.Message);
            }
        }

        public Aluno ListarId(string id)
        {
            try
            {
                var alunoCollection = new Aluno();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdAluno", id);
                DataTable dtAluno = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspAlunoListarId");
                foreach (DataRow linha in dtAluno.Rows)
                {
                    
                    alunoCollection.IdAluno = Convert.ToInt32(linha["IdAluno"]);
                    alunoCollection.NomeAluno = Convert.ToString(linha["NomeAluno"]);
                    alunoCollection.IdCurso = Convert.ToInt32(linha["IdCurso"]);
                    alunoCollection.NomeCurso = Convert.ToString(linha["NomeCurso"]);
                }
                return alunoCollection;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public IEnumerable<Aluno> ListarNome(string txt)
        {
            try
            {
                var alunoCollection = new AlunoCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeAluno", txt);
                DataTable dtAluno = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspAlunoListarNome");
                foreach (DataRow linha in dtAluno.Rows)
                {
                    var aluno = new Aluno();
                    aluno.IdAluno = Convert.ToInt32(linha["IdAluno"]);
                    aluno.NomeAluno = Convert.ToString(linha["NomeAluno"]);
                    aluno.IdCurso = Convert.ToInt32(linha["IdCurso"]);
                    alunoCollection.Add(aluno);
                }

                
                return alunoCollection;

                
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possivel consultar o aluno por nome" + erro.Message);
            }
        }

        public AlunoCollection ConsultaAlunoCurso(int id)
        {
            try
            {
                 var alunoCollection = new AlunoCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdCurso", id);
                DataTable dtAluno = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspAlunoConsultaCurso");
                foreach (DataRow linha in dtAluno.Rows)
                {
                    var aluno = new Aluno();
                    aluno.IdCurso = Convert.ToInt32(linha["IdCurso"]);
                    aluno.IdAluno = Convert.ToInt32(linha["IdAluno"]);
                    aluno.NomeAluno = Convert.ToString(linha["NomeAluno"]);
                    aluno.NomeCurso = Convert.ToString(linha["NomeCurso"]);
                    alunoCollection.Add(aluno);
                }
                return alunoCollection;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public AlunoCollection ConsultaAlunoCursoDisciplina(string curso)
        {
            try
            {
                var alunoCollection = new AlunoCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeCurso", curso);
                DataTable dtAluno = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspAlunoConsultaDisciplinaCurso");
                foreach (DataRow linha in dtAluno.Rows)
                {
                    var aluno = new Aluno();
                    aluno.NomeAluno = Convert.ToString(linha["NomeAluno"]);
                    alunoCollection.Add(aluno);
                }
                return alunoCollection;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public DataTable CarregaComboAluno(string nome)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeAluno", nome);
                var dtAluno = _contexto.ExecutaConsulta(CommandType.Text, "uspAlunoListarNome");
                return dtAluno;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void CarregarParametros(Aluno aluno)
        {
            _contexto.LimparParametros();
            _contexto.AdicionarParametros("@NomeAluno", aluno.NomeAluno);
            _contexto.AdicionarParametros("@IdCurso", aluno.IdCurso);
        }
    }
}

