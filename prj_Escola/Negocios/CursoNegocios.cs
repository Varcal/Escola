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
    public class CursoNegocios
    {
        private readonly CursoDao _cursoDao = new CursoDao();
       
        public string Salvar(Curso curso)
        {
            string idCurso = _cursoDao.Salvar(curso);
            return idCurso;
        }

        public string Excluir(Curso curso)
        {
            var idCurso = _cursoDao.Excluir(curso);
            return idCurso;
        }

        public Curso ConsultaCursoId(string id)
        {
            var curso = _cursoDao.ListarId(id);
            return curso;
        }

        public IEnumerable<Curso> ConsultaCursoNome(string nome)
        {
            var cursoCollection = _cursoDao.ListarNome(nome);
            return cursoCollection;
        }

        public IEnumerable<Curso> ListarTodos()
        {
            var cursoCollection = _cursoDao.ListarTodos();
            return cursoCollection;
        }

        public DataTable CarregaComboBoxCurso(string nome)
        {
            var dtCurso = _cursoDao.CarregaComboBoxCurso(nome);
            return dtCurso;
        }

    }
}
