using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AcessoDados.Interface;
using DTO;

namespace AcessoDados
{
    public class ProfessorDao:IRepositorio<Professor>
    {
        private readonly AcessoSqlServer _contexto = new AcessoSqlServer();

        private string Inserir(Professor professor)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("NomeProfessor", professor.NomeProfessor);
                string IdProfessor = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspProfessorInserir").ToString();
                return IdProfessor;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }

        }

        private string Alterar(Professor professor)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("IdProfessor", professor.IdProfessor);
                _contexto.AdicionarParametros("NomeProfessor", professor.NomeProfessor);
                string IdProfessor = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspProfessorAlterar").ToString();
                return IdProfessor;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }

        public string Salvar(Professor professor)
        {
            var idProfessor = "";

            if (professor.IdProfessor > 0)
            {
                idProfessor = Alterar(professor);
            }
            else
            {
                idProfessor = Inserir(professor);
            }

            return idProfessor;
        }

        public string Excluir(Professor professor)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("IdProfessor", professor.IdProfessor);
                string IdProfessor = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspProfessorExcluir").ToString();
                return IdProfessor;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }

        }

        public Professor ListarId(string id)
        {
            try
            {
                var professorCollection = new ProfessorCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("IdProfessor", id);
                DataTable dtProfessor = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspProfessorConsultaId");
                foreach (DataRow linha in dtProfessor.Rows)
                {
                    var professor = new Professor();
                    professor.IdProfessor = Convert.ToInt32(linha["IdProfessor"]);
                    professor.NomeProfessor = Convert.ToString(linha["NomeProfessor"]);
                    professorCollection.Add(professor);
                }
                return professorCollection.First(x => x.IdProfessor == Convert.ToInt32(id));
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public IEnumerable<Professor> ListarNome(string txt)
        {
            try
            {
                var professorCollection = new ProfessorCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeProfessor", txt);
                DataTable dtProfessor = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspProfessorConsultaNome");
                foreach (DataRow linha in dtProfessor.Rows)
                {
                    var professor = new Professor();
                    professor.IdProfessor = Convert.ToInt32(linha["IdProfessor"]);
                    professor.NomeProfessor = Convert.ToString(linha["NomeProfessor"]);
                    professorCollection.Add(professor);
                }
                return professorCollection;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public IEnumerable<Professor> ListarTodos()
        {
            try
            {
                var professorCollection = new ProfessorCollection();
                DataTable dtProfessor = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspProfessorListarTodos");
                foreach (DataRow linha in dtProfessor.Rows)
                {
                    var professor = new Professor();
                    professor.IdProfessor = Convert.ToInt32(linha["IdProfessor"]);
                    professor.NomeProfessor = Convert.ToString(linha["NomeProfessor"]);
                    professorCollection.Add(professor);
                }
                return professorCollection;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public ProfessorCollection ConsultaProfessorDisciplina(string nome)
        {
            try
            {
                var professorCollection = new ProfessorCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeProfessor",nome);
                DataTable dtProfessor = _contexto.ExecutaConsulta(CommandType.StoredProcedure,"uspProfessorConsultaDisciplina");
                foreach (DataRow linha in dtProfessor.Rows)
	            {
		            Professor professor = new Professor();
                    professor.IdProfessor = Convert.ToInt32(linha["IdProfessor"]);
                    professor.NomeProfessor = Convert.ToString(linha["NomeProfessor"]);
                    professor.NomeDisciplina = Convert.ToString(linha["NomeDisciplina"]);
                    professorCollection.Add(professor);
	            }
                return professorCollection;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public ProfessorCollection DisciplinaProfessor(int id)
        {
            try
            {
                var professorCollection = new ProfessorCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdDisciplina", id);
                DataTable dtProfessor = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspDisciplinaConsultaProfessor");
                foreach (DataRow linha in dtProfessor.Rows)
                {
                    var professor = new Professor();
                    professor.IdProfessor = Convert.ToInt32(linha["IdProfessor"]);
                    professor.NomeProfessor = Convert.ToString(linha["NomeProfessor"]);
                    professorCollection.Add(professor);
                }
                return professorCollection;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public string InserirDisciplina(Professor professor)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdProfessor", professor.IdProfessor);
                _contexto.AdicionarParametros("@IdDisciplina", professor.IdDisciplina);
                string IdProfessor = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspProfessorDisciplinaInserir").ToString();
                return IdProfessor;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }
     
        public string AlterarProfessorDisciplina(Professor professor)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdProfessor", professor.IdProfessor);
                _contexto.AdicionarParametros("@IdDisciplina", professor.IdDisciplina);
                string IdProfessor = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspProfessorDisciplinaAlterar").ToString();
                return IdProfessor;

            }
            catch (Exception erro)
            {
                return erro.Message;
            }
            
        }

        public string ExcluirProfessorDisciplina(Professor professor)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdProfessor", professor.IdProfessor);
                string IdProfessor = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspProfessorDisciplinaExcluir").ToString();
                return IdProfessor;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }

        public DataTable CarregaComboProfessor(string nome)
        {
            _contexto.LimparParametros();
            _contexto.AdicionarParametros("NomeProfessor", nome);
            DataTable dtProfessor = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspProfessorConsultaNome");
            return dtProfessor;
        }

       
    }
}
