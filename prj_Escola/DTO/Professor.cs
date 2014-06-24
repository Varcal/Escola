using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Professor: Disciplina
    {
        public int IdProfessor { get; set; }
        public string NomeProfessor { get; set; }
    }
}
