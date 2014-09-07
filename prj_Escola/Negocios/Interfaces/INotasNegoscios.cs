using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.Interface;
using DTO;

namespace Negocios.Interfaces
{
    interface INotasNegoscios: IRepositorio<Notas>
    {
        string InserirAluno(Notas notas);

        NotasCollection ConsultaNotasRa(int id);

        NotasCollection ConsultaNotasAluno(int idDisciplina, int idProfessor, int idCurso);
    }
}
