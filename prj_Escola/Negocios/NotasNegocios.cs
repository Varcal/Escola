using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using AcessoDados;
using Negocios.Interfaces;

namespace Negocios
{
    public class NotasNegocios:NotasDao, INotasNegoscios
    {

        public string Salvar(Notas entidade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Notas> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Notas ListarId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Notas> ListarNome(string txt)
        {
            throw new NotImplementedException();
        }
    }
}
