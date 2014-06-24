using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AcessoDados.Interface;
using DTO;

namespace AcessoDados
{
    public class DisciplinaDao:IRepositorio<Disciplina>
    {
        readonly AcessoSqlServer _contexto = new AcessoSqlServer();

        private string Inserir(Disciplina disciplina)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeDisciplina", disciplina.NomeDisciplina);
                string IdDisciplina = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspDisciplinaInserir").ToString();
                return IdDisciplina;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }

        private string Alterar(Disciplina disciplina)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdDisciplina", disciplina.IdDisciplina);
                _contexto.AdicionarParametros("@NomeDisciplina", disciplina.NomeDisciplina);
                string IdDisciplina = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspDisciplinaAlterar").ToString();
                return IdDisciplina;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }


        }

        public string Salvar(Disciplina disciplina)
        {
            var idDiscilina = "";
            if (disciplina.IdDisciplina > 0)
            {
                idDiscilina = Alterar(disciplina);
            }
            else
            {
                idDiscilina = Inserir(disciplina);
            }

            return idDiscilina;
        }

        public string Excluir(Disciplina disciplina)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdDisciplina", disciplina.IdDisciplina);
                string IdDisciplina = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspDisciplinaExcluir").ToString();
                return IdDisciplina;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }

        public IEnumerable<Disciplina> ListarNome(string txt)
        {
            try
            {
                var disciplinaCollection = new DisciplinaCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeDisciplina", txt);
                DataTable dtDisciplina = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspDisciplinaConsultaNome");
                foreach (DataRow linha in dtDisciplina.Rows)
                {
                    Disciplina disciplina = new Disciplina();
                    disciplina.IdDisciplina = Convert.ToInt32(linha["IdDisciplina"]);
                    disciplina.NomeDisciplina = Convert.ToString(linha["NomeDisciplina"]);
                    disciplinaCollection.Add(disciplina);
                }
                return disciplinaCollection;
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possivel consultar a disciplina por nomo" + erro.Message);
            }
        }

        public Disciplina ListarId(string id)
        {
            try
            {
                 var disciplinaCollection= new DisciplinaCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeDisciplina", id);
                DataTable dtDisciplina = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspDisciplinaConsultaId");
                foreach (DataRow linha in dtDisciplina.Rows)
                {
                    Disciplina disciplina = new Disciplina();
                    disciplina.IdDisciplina = Convert.ToInt32(linha["IdDisciplina"]);
                    disciplina.NomeDisciplina = Convert.ToString(linha["NomeDisciplina"]);
                    disciplinaCollection.Add(disciplina);
                }

                return disciplinaCollection.First(x=> x.IdDisciplina == Convert.ToInt32(id));
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possivel consultar a disciplina por nomo" + erro.Message);
            }
        }
      
        public DisciplinaCollection ConsultaDisciplinaCurso(string nome)
        { 
            try
            {
                DisciplinaCollection disciplinaCollection = new DisciplinaCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeCurso", nome);
                DataTable dtDisciplina = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspDisciplinaConsultaCurso");
                foreach (DataRow linha in dtDisciplina.Rows)
                {
                    Disciplina disciplina = new Disciplina();
                    disciplina.NomeCurso = Convert.ToString(linha["NomeCurso"]);
                    disciplina.IdDisciplina = Convert.ToInt32(linha["IdDisciplina"]);
                    disciplina.NomeDisciplina = Convert.ToString(linha["NomeDisciplina"]);
                    disciplinaCollection.Add(disciplina);
                }
                return disciplinaCollection;
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possivel consultar a disciplina por nomo"+erro.Message);
            }
        }

        public DisciplinaCollection ConsultaCursoDisciplina(int idCurso, int idDisciplina)
        {

            try
            {
                var disciplinaCollection = new DisciplinaCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdDisciplina", idDisciplina);
                _contexto.AdicionarParametros("@IdCurso",idCurso);
                DataTable dtDisciplina = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspCursoConsultaDisciplina");
                foreach (DataRow linha in dtDisciplina.Rows)
                {
                    var disciplina = new Disciplina();
                    disciplina.IdCurso = Convert.ToInt32(linha["IdCurso"]);
                    disciplina.NomeCurso = Convert.ToString(linha["NomeCurso"]);
                    disciplina.IdDisciplina = Convert.ToInt32(linha["IdDisciplina"]);
                    disciplina.NomeDisciplina = linha["NomeDisciplina"].ToString();
                    disciplinaCollection.Add(disciplina);
                }
                return disciplinaCollection;
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possivel consultar a disciplina por nome" + erro.Message);
            }
        }

        public DataTable CarregaComboDisciplina(string nome)
        {
            try
            {
                DisciplinaCollection disciplinaCollection = new DisciplinaCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeDisciplina", nome);
                DataTable dtDisciplina = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspDisciplinaConsultaNome");

                return dtDisciplina;
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possivel consultar a disciplina por nomo" + erro.Message);
            }
        }

        public string InserirDisciplinaCurso(Disciplina disciplina)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdCurso", disciplina.IdCurso);
                _contexto.AdicionarParametros("@IdDisciplina", disciplina.IdDisciplina);
                string IdCurso = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspDisciplinaCursoInserir").ToString();
                return IdCurso;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }

        public IEnumerable<Disciplina> ListarTodos()
        {
            try
            {
                var disciplinaCollection = new DisciplinaCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeDisciplina", '%');             
                DataTable dtDisciplina = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspDisciplinaConsultaNome");
                foreach (DataRow linha in dtDisciplina.Rows)
                {
                    var disciplina = new Disciplina();
                    disciplina.IdDisciplina = Convert.ToInt32(linha["IdDisciplina"]);
                    disciplina.NomeDisciplina = Convert.ToString(linha["NomeDisciplina"]);
                    disciplinaCollection.Add(disciplina);
                }
                return disciplinaCollection;
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possivel consultar a disciplina por nomo" + erro.Message);
            }
        }

        
    }
}
