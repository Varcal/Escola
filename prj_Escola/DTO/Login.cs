using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Login
    {
        public int IdLogin { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool Situacao { get; set; }
    }
}
