using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Notas: Aluno
    {
        public int IdCurso { get; set; }
        public int IdDisciplina { get; set; }
        public string NomeDisciplina { get; set; }
        public int IdProfessor {get; set; }
        public int IdAluno { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double Trabalho { get; set; }
        public double Media { get; set; }
        public Boolean Situacao { get; set; }
    }
}
