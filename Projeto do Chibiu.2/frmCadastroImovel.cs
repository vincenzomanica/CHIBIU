using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_do_Chibiu._2
{
    public partial class frmCadastroImovel : Form
    {
        public frmCadastroImovel()
        {
            InitializeComponent();
        }

        List <Imovel> list = new List <Imovel>();   

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Imovel imovel = new Imovel();
            imovel.CodigoDoImovel = txtCodigodoImovel.Text;
            imovel.area = txtArea.Text;
            imovel.valor = txtValor.Text;
            imovel.NomeDoPropietario = txtPropietario.Text;
            imovel.numero = txtNumero.Text;
            imovel.qtd = txtQTD.Text;
            imovel.TipodeTransacao = cmbTipodeTranasacao.Text;
            imovel.TipodoImovel = cmbTipoDoImovel.Text;
            imovel.garagem = chkSim.Checked;
            imovel.Endereco = txt

        }
    }
}
