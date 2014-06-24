using AcessoDados;
using DTO;
using System.Collections.Generic;
using System.Data;


namespace Negocios
{
    public class AlunoNegocios
    {
        private readonly AlunoDao _alunoDao = new AlunoDao();

        public string Salvar(Aluno aluno)
        {          
            string idAluno =_alunoDao.Salvar(aluno);
            return idAluno;
        }

        public string Excluir(Aluno aluno)
        {
            var idAluno = _alunoDao.Excluir(aluno);
            return idAluno;
        }

        public Aluno ConsultaAlunoId(string id)
        {
            var aluno = _alunoDao.ListarId(id);
            return aluno;
        }

        public IEnumerable<Aluno> ConsultaAlunoNome(string nome)
        {
            var alunoCollection = _alunoDao.ListarNome(nome);
            return alunoCollection;
        }

        public AlunoCollection ConsultaAlunoCurso(int id)
        {
            var alunoCollection = _alunoDao.ConsultaAlunoCurso(id);
            return alunoCollection;
        }

        public IEnumerable<Aluno> ListarTodos()
        {
            var listaAlunos = _alunoDao.ListarTodos();
            return listaAlunos;
        }

        public AlunoCollection ConsultaAlunoCursoDisciplina(string curso)
        {
            var alunoCollection = _alunoDao.ConsultaAlunoCursoDisciplina(curso);
            return alunoCollection;
        }

        public DataTable CarregaComboAluno(string nome)
        {
            var dtAluno = _alunoDao.CarregaComboAluno(nome);
            return dtAluno;
        }      
    }
}

