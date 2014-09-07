using System;
using System.Data;
using DTO;

namespace AcessoDados
{
    public class NotasDao
    {
        private readonly AcessoSqlServer _contexto = new AcessoSqlServer();

        public string Salvar(Notas notas)
        {
            return null;
        }

        public string Inserir(Notas notas)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdCurso", notas.IdCurso);
                _contexto.AdicionarParametros("@IdDisciplina", notas.IdDisciplina);
                _contexto.AdicionarParametros("@IdAluno", notas.IdAluno);
                _contexto.AdicionarParametros("@P1", notas.P1);
                _contexto.AdicionarParametros("@P2", notas.P2);
                _contexto.AdicionarParametros("@Trabalho", notas.Trabalho);
                _contexto.AdicionarParametros("@Media", notas.Media);
                _contexto.AdicionarParametros("@Situação", notas.Situacao);
                string idNotas = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspNotasInserir").ToString();
                return idNotas;
            }
            catch(Exception erro)
            {
                return erro.Message;
            }
        }

        public string InserirAluno(Notas notas)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdCurso", notas.IdCurso);
                _contexto.AdicionarParametros("@IdDisciplina", notas.IdDisciplina);
                _contexto.AdicionarParametros("@IdProfessor",notas.IdProfessor);
                _contexto.AdicionarParametros("@IdAluno", notas.IdAluno);
                string idNotas = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspAlunoInserirDiario").ToString();
                return idNotas;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }

        public string Alterar(Notas notas)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdCurso", notas.IdCurso);
                _contexto.AdicionarParametros("@IdDisciplina", notas.IdDisciplina);
                _contexto.AdicionarParametros("@IdProfessor", notas.IdProfessor);
                _contexto.AdicionarParametros("@IdAluno", notas.IdAluno);
                _contexto.AdicionarParametros("@P1", notas.P1);
                _contexto.AdicionarParametros("@P2", notas.P2);
                _contexto.AdicionarParametros("@Trabalho", notas.Trabalho);
                _contexto.AdicionarParametros("@Media", notas.Media);
                _contexto.AdicionarParametros("@Situacao", notas.Situacao);
                string idNotas = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspNotasAlterar").ToString();
                return idNotas;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }    

        public string Excluir(Notas notas)
        {
            try
            {
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdCurso", notas.IdCurso);
                _contexto.AdicionarParametros("@IdDisciplina", notas.IdDisciplina);
                _contexto.AdicionarParametros("@IdAluno", notas.IdAluno);
                string idNotas = _contexto.ExecutaManipulacao(CommandType.StoredProcedure, "uspNotasExcluir").ToString();
                return idNotas;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }

        public NotasCollection ConsultaNotasRa(int id)
        {
            try
            {
                NotasCollection notasCollection = new NotasCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdAluno", id);
                DataTable dtNotas = _contexto.ExecutaConsulta(CommandType.StoredProcedure,"uspNotasConsultaId");
                foreach (DataRow linha in dtNotas.Rows)
                {
                    Notas notas = new Notas();
                    notas.NomeCurso = Convert.ToString(linha["NomeCurso"]);
                    notas.NomeDisciplina = Convert.ToString(linha["NomeDisciplina"]);
                    notas.IdAluno = Convert.ToInt32(linha["IdAluno"]);
                    notas.NomeAluno = Convert.ToString(linha["NomeAluno"]);
                    notas.P1 = Convert.ToDouble(linha["P1"]);
                    notas.P2 = Convert.ToDouble(linha["P2"]);
                    notas.Trabalho = Convert.ToDouble(linha["Trabalho"]);
                    notas.Media = Convert.ToDouble(linha["Media"]);
                    notas.Situacao = Convert.ToBoolean(linha["Situacao"]);
                    notasCollection.Add(notas);
                }
                return notasCollection;

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public NotasCollection ConsultaNotasAluno(int idDisciplina, int idProfessor, int idCurso)
        {
            int i = 1;
            try
            {
                NotasCollection notasCollection = new NotasCollection();
                _contexto.LimparParametros();
                _contexto.AdicionarParametros("@IdCurso", idCurso);
                _contexto.AdicionarParametros("@IdDisciplina", idDisciplina);
                _contexto.AdicionarParametros("@IdProfessor", idProfessor);
                DataTable dtNotas = _contexto.ExecutaConsulta(CommandType.StoredProcedure, "uspDiarioDigital");
                foreach (DataRow linha in dtNotas.Rows)
                {
                    
                    Notas notas = new Notas();
                    notas.IdCurso = i++;
                    notas.IdAluno = Convert.ToInt32(linha["IdAluno"]);
                    notas.NomeAluno = Convert.ToString(linha["NomeAluno"]);
                    notas.P1 = Convert.ToDouble(linha["P1"]);
                    notas.P2 = Convert.ToDouble(linha["P2"]);
                    notas.Trabalho = Convert.ToDouble(linha["Trabalho"]);
                    notas.Media = (notas.P1 + notas.P2 + notas.Trabalho) / 3;
                    if (notas.Media >= 6)
                    {
                        notas.Situacao = true;
                        notasCollection.Add(notas);
                    }
                    else
                    {
                        notas.Situacao = false;
                        notasCollection.Add(notas);
                    }
                    
                    
                }
                return notasCollection;

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

    }
}
