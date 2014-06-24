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
    public class NotasNegocios
    {
        private readonly NotasDao _notasDao = new NotasDao();

        public string Inserir(Notas notas)
        {
            var idNotas = _notasDao.Inserir(notas);
            return idNotas;
        }

        public string InserirAluno(Notas notas)
        {
            var idNotas = _notasDao.InserirAluno(notas);
            return idNotas;
        }

        public string Alterar(Notas notas)
        {
            var idNotas = _notasDao.Alterar(notas);
            return idNotas;
        }

        public string Excluir(Notas notas)
        {
            var idNotas = _notasDao.Excluir(notas);
            return idNotas;
        }

        public NotasCollection ConsultaNotasRA(int id)
        {
            var notasCollection = _notasDao.ConsultaNotasRA(id);
            return notasCollection;
        }

        public NotasCollection ConsultaNotasAluno(int idDisciplina, int idProfessor, int idCurso)
        {
            var notasCollection = _notasDao.ConsultaNotasAluno(idDisciplina, idProfessor, idCurso);
            return notasCollection;
        }

    }
}
