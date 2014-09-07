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
    interface IProfessorNegocios: IRepositorio<Professor>
    {
        ProfessorCollection ConsultaProfessorDisciplina(string nome);
    
        ProfessorCollection DisciplinaProfessor(int id);

        string InserirDisciplina(Professor professor);

        string ExcluirProfessorDisciplina(Professor professor);

        DataTable CarregaComboProfessor(string nome);
    }
}
