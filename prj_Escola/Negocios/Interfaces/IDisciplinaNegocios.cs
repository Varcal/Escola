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
    interface IDisciplinaNegocios: IRepositorio<Disciplina>
    {
        DisciplinaCollection ConsultaDisciplinaCurso(string nome);

        DisciplinaCollection ConsultaCursoDisciplina(int idCurso, int idDisciplina);

        DataTable CarregaComboDisciplina(string nome);
      
        string InserirDisciplinaCurso(Disciplina disciplina);

    }
}
