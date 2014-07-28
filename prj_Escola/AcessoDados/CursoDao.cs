using System;
using System.Collections.Generic;
using System.Data;
using AcessoDados.Interface;
using DTO;

namespace AcessoDados
{
    public class CursoDao:IRepositorio<Curso>
    {
        readonly AcessoSqlServer _contexto = new AcessoSqlServer();
      
        private string Inserir(Curso curso)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeCurso", curso.NomeCurso);
                string IdCurso = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspCursoInserir").ToString();
                return IdCurso;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }

        private string Alterar(Curso curso)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdCurso", curso.IdCurso);
                _contexto.AdicionarParametros("NomeCurso", curso.NomeCurso);
                string IdCurso = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspCursoAlterar").ToString();
                return IdCurso;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }

        public string Salvar(Curso curso)
        {
            var idCurso = "";
            if (curso.IdCurso > 0)
            {
                idCurso = Alterar(curso);
            }
            else
            {
                idCurso = Inserir(curso);
            }

            return idCurso;
        }

        public string Excluir(Curso curso)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdCurso", curso.IdCurso);
                string IdCurso = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspCursoExcluir").ToString();
                return IdCurso;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }
          
        public Curso ListarId(string id)
        {
            try
            {
                var cursoCollection = new Curso();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdCurso", id);
                DataTable dtCurso = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspCursoConsultaId");
                foreach (DataRow linha in dtCurso.Rows)
                {                  
                    cursoCollection.IdCurso = Convert.ToInt32(linha["IdCurso"]);
                    cursoCollection.NomeCurso = Convert.ToString(linha["NomeCurso"]);                   
                }
                return cursoCollection;
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possivel consultar o curo por Id" + erro.Message);
            }
        }

        public IEnumerable<Curso> ListarNome(string txt)
        {
            try
            {
                CursoCollection cursoCollection = new CursoCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeCurso", txt);
                DataTable dtCurso = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspCursoConsultaNome");
                foreach (DataRow linha in dtCurso.Rows)
                {
                    Curso curso = new Curso();
                    curso.IdCurso = Convert.ToInt32(linha["IdCurso"]);
                    curso.NomeCurso = Convert.ToString(linha["NomeCurso"]);
                    cursoCollection.Add(curso);
                }
                return cursoCollection;
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possivel consultar o curso por nome" + erro.Message);
            }
        }

        public IEnumerable<Curso> ListarTodos()
        {
            try
            {
                CursoCollection cursoCollection = new CursoCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeCurso", "%");
                DataTable dtCurso = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspCursoListarTodos");
                foreach (DataRow linha in dtCurso.Rows)
                {
                    Curso curso = new Curso();
                    curso.IdCurso = Convert.ToInt32(linha["IdCurso"]);
                    curso.NomeCurso = Convert.ToString(linha["NomeCurso"]);
                    cursoCollection.Add(curso);
                }
                return cursoCollection;
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possivel consultar o curso por nome" + erro.Message);
            }
        }

        public DataTable CarregaComboBoxCurso(string nome)
        {
            try
            {
                CursoCollection cursoCollection = new CursoCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@NomeCurso", nome);
                DataTable dtCurso = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspCursoConsultaNome");
                return dtCurso;
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
        }

    }
}
