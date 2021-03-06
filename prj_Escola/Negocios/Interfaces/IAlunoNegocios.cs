﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.Interface;
using DTO;

namespace Negocios.Interfaces
{
    public interface IAlunoNegocios: IRepositorio<Aluno>
    {
        AlunoCollection ConsultaAlunoCurso(int id);
    }
}
