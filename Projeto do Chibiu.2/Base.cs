using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_do_Chibiu._2
{
    public interface Base<T>
    {
        void Inserir(T dados);
        void Alterar(T dados);
        T ListarUm();
        List<T> ListarTodos();
        void Deletar(int id);
    }
}
