using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Interface
{
    public interface IRepositorio<T> where T :class
    {
        string Salvar(T entidade);

        string Excluir(T entidade);

        IEnumerable<T> ListarTodos();

        T ListarId(string id);

        IEnumerable<T> ListarNome(string txt);
    }
}
