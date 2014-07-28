using AcessoDados;
using DTO;
using System.Collections.Generic;
using System.Data;


namespace Negocios
{
    public class ProfessorNegocios
    {
        private readonly ProfessorDao _professorDao = new ProfessorDao();

        public string Salvar(Professor professor)
        {
            var idProfessor = _professorDao.Salvar(professor);
            return idProfessor;
        }

        public string InserirDisciplina(Professor professor)
        {
            var idDisciplina = _professorDao.InserirDisciplina(professor);
            return idDisciplina;
        }       

        //public string AlterarProfessorDisciplina(Professor professor)
        //{
        //    string idProfessor = AlterarProfessorDisciplina(professor);
        //    return idProfessor;
        //}

        public string Excluir(Professor professor)
        {
            string idProfessor = _professorDao.Excluir(professor);
            return idProfessor;
        }

        public string ExcluirProfessorDisciplina(Professor professor)
        {
            var idProfessor = _professorDao.ExcluirProfessorDisciplina(professor);
            return idProfessor;
        }

        public Professor ConsultaProfessorId(string id)
        {
            var professor = _professorDao.ListarId(id);
            return professor;
        }

        public IEnumerable<Professor> ConsultaProfessorNome(string nome)
        {
            var professorCollection = _professorDao.ListarNome(nome);
            return professorCollection;
        }

        public IEnumerable<Professor> ListarTodos()
        {
            var professorCollection = _professorDao.ListarTodos();
            return professorCollection;
        }

        public ProfessorCollection ConsultaProfessorDisciplina(string nome)
        {
            var professorCollection = _professorDao.ConsultaProfessorDisciplina(nome);
            return professorCollection;
        }

        public ProfessorCollection DisciplinaProfessor(int id)
        {
            var professorCollection = _professorDao.DisciplinaProfessor(id);
            return professorCollection;
        }

        public DataTable CarregaComboProfessor(string nome)
        {
            var dtProfessor = _professorDao.CarregaComboProfessor(nome);
            return dtProfessor;
        }
  
    }
}
