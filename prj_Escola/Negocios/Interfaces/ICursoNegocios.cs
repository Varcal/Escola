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
    interface ICursoNegocios: IRepositorio<Curso>
    {
        DataTable CarregaComboBoxCurso(string nome);  
    }
}
