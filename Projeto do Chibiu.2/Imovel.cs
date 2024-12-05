using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_do_Chibiu._2
{
    public class Imovel : Base<Imovel>
    {
       public string CodigoDoImovel { get; set; }
       public string qtd { get; set; }
       public string area { get; set; }
       public string valor {  get; set; }
       public string numero {  get; set; }
       public bool garagem { get; set; }
       public string TipodeTransacao { get; set; }
       public string TipodoImovel  { get; set; }
        public string Descricao  { get; set; }
        public string OBS { get; set; }
        public string Lougradouro { get; set; }
        public string Complemento { get; set; }
        public string NomeDoPropietario { get; set; }

        public void Alterar(Imovel dados)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Imovel dados)
        {
            throw new NotImplementedException();
        }

        public List<Imovel> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Imovel ListarUm()
        {
            throw new NotImplementedException();
        }
    }
}
