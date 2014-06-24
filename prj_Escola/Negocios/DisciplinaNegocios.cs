using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using AcessoDados;

namespace Negocios
{
    public class DisciplinaNegocios
    {
        private readonly DisciplinaDao _disciplinaDao = new DisciplinaDao();

        public string Salvar(Disciplina disciplina)
        {
            var idDisciplina = _disciplinaDao.Salvar(disciplina);
            return idDisciplina;
        }

        public string InserirDisciplinaCurso(Disciplina disciplina)
        {
            var idCurso = _disciplinaDao.InserirDisciplinaCurso(disciplina);
            return idCurso;
        }

        public string Excluir(Disciplina disciplina)
        {
            var idDisciplina = _disciplinaDao.Excluir(disciplina);
            return idDisciplina;
        }

        public IEnumerable<Disciplina> ConsultaDisciplinaNome(string nome)
        {
            var disciplinaCollecion = _disciplinaDao.ListarNome(nome);
            return disciplinaCollecion;
        }

        public DataTable CarregaComboDisciplina(string nome)
        {
            var dtDisciplina = _disciplinaDao.CarregaComboDisciplina(nome);
            return dtDisciplina;
        }

        public DisciplinaCollection ConsultaDisciplinaCurso(string nome)
        {
            var disciplinaCollection = _disciplinaDao.ConsultaDisciplinaCurso(nome);
            return disciplinaCollection;
        }

        public DisciplinaCollection ConsultaCursoDisciplina(int idCurso, int idDisciplina)
        {
            var disciplinaCollection = _disciplinaDao.ConsultaCursoDisciplina(idCurso,idDisciplina);
            return disciplinaCollection;
        }
    }
}