using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_do_Chibiu._2
{

    public partial class frmCadastro : Form
    {
        List<Pessoa> lista = new List<Pessoa>();

        string arquivo = @"C:\Users\vincenzo.manica\Documents\ListaChibiu.txt";


        public frmCadastro()
        {
            InitializeComponent();
        }

        private void txtCpf_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pess = new Pessoa();

            pess.Codigo = txtCodigo.Text;
            pess.Nome = txtNome.Text;
            pess.Telefone = txtTelefone.Text;
            pess.CPF = txtCpf.Text;
            pess.Endereco = txtEndereco.Text;


            if (btnSalvar.Text == "Alterar")
            {
                Alterar_Arquivo(pess);
                txtCodigo.Clear();
                txtNome.Clear();
                txtTelefone.Clear();
                txtCpf.Clear();
                txtEndereco.Clear();

                foreach (Pessoa item in lista)
                {
                    GravarArquivo(item);
                }



            }
            else
            {
                GravarArquivo(pess);
                txtCodigo.Clear();
                txtNome.Clear();
                txtTelefone.Clear();
                txtCpf.Clear();
                txtEndereco.Clear();
            }



        }
        private void Alterar_Arquivo(Pessoa p)
        {
            Deletar_Arquivo();

            foreach (Pessoa pessoa in lista)
            {
                if (pessoa.Codigo == p.Codigo)
                {

                    pessoa.Codigo = p.Codigo;
                    pessoa.Nome = p.Nome;
                    pessoa.CPF = p.CPF;
                    pessoa.Telefone = p.Telefone;
                    pessoa.Endereco = p.Endereco;
                }
            }
        }

        private void txtAtualizar_Click(object sender, EventArgs e)
        {
            lswLista.Items.Clear();
            lista.Clear();
            lista = PreencheLista_Arquivo();
            Preenchelsw(lista);
            //string retorno = LerArquivo();
            //if (retorno.Length > 0)
            //{
            //    string[] vet = retorno.Split('|');


            //    for (int i = 0; i < vet.Length; i += 5)
            //    {
            //        Pessoa pessoa = new Pessoa();
            //        pessoa.Codigo = vet[i];
            //        pessoa.Nome = vet[i + 1];
            //        pessoa.CPF = vet[i + 2];
            //        pessoa.Telefone = vet[i + 3];
            //        pessoa.Endereco = vet[i + 4];
            //        lista.Add(pessoa);
            //    }
            //    foreach (Pessoa pessoa in lista)
            //    {
            //        ListViewItem item = new ListViewItem();
            //        item.Text = pessoa.Codigo;
            //        item.SubItems.Add(pessoa.Nome);
            //        item.SubItems.Add(pessoa.CPF);
            //        item.SubItems.Add(pessoa.Telefone);
            //        item.SubItems.Add(pessoa.Endereco);

            //        lswLista.Items.Add(item);

            //    }
            //}
            //else
            //{

            //    MessageBox.Show("Arquivo Vazio");

            //}

            btnSalvar.Text = "Salvar";

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            lswLista.View = View.Details;
            lswLista.GridLines = true;
            lswLista.Columns.Add("Código", 60, HorizontalAlignment.Left);
            lswLista.Columns.Add("Nome", 60, HorizontalAlignment.Left);
            lswLista.Columns.Add("CPF", 60, HorizontalAlignment.Left);
            lswLista.Columns.Add("Telefone", 60, HorizontalAlignment.Left);
            lswLista.Columns.Add("Endereço", 60, HorizontalAlignment.Left);
            lista = PreencheLista_Arquivo();
            Preenchelsw(lista);


        }

        private string LerArquivo()
        {

            string resultado = "";
            string result = "";



            if (File.Exists(arquivo))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(arquivo))
                    {
                        String linha;
                        // Lê linha por linha até o final do arquivo
                        while ((linha = sr.ReadLine()) != null)
                        {
                            //string[] lista = linha.Split('|');
                            resultado = resultado + linha;
                            //Console.WriteLine(linha);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine(" O arquivo " + arquivo + "não foi localizado !");
            }

            if (resultado.Length > 0)
            {
                result = resultado.Substring(0, resultado.Length - 1);
            }



            return result;


        }


        private void GravarArquivo(Pessoa pessoa)
        {

            string conteudo = pessoa.Codigo + "|" + pessoa.Nome + "|" + pessoa.CPF + "|" + pessoa.Telefone + "|" + pessoa.Endereco + "|" + "\n";


            File.AppendAllText(arquivo, conteudo);


        }

        private void lswLista_DoubleClick(object sender, EventArgs e)
        {
            txtCodigo.Text = lswLista.SelectedItems[0].Text;
            txtNome.Text = lswLista.SelectedItems[0].SubItems[1].Text;
            txtCpf.Text = lswLista.SelectedItems[0].SubItems[2].Text;
            txtTelefone.Text = lswLista.SelectedItems[0].SubItems[3].Text;
            txtEndereco.Text = lswLista.SelectedItems[0].SubItems[4].Text;
            btnSalvar.Text = "Alterar";

        }

        private void Deletar_Item(Pessoa pessoa)
        {
            lswLista.SelectedItems.Clear();
            Pessoa pessoaAremover = lista.FirstOrDefault(p => p.Codigo == pessoa.Codigo);


            if (pessoaAremover != null)
            {
                lista.Remove(pessoaAremover);
                Deletar_Arquivo();
                foreach (Pessoa item in lista)
                {
                    GravarArquivo(item);

                }
            }


        }

        private void Deletar_Arquivo()
        {
            File.WriteAllText(arquivo, "");
        }

        private void txtExcluir1_Click(object sender, EventArgs e)
        {
            if (lswLista.Items.Count > 0)
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Codigo = lswLista.SelectedItems[0].Text;
                pessoa.Nome = lswLista.SelectedItems[0].SubItems[1].Text;
                pessoa.CPF = lswLista.SelectedItems[0].SubItems[2].Text;
                pessoa.Telefone = lswLista.SelectedItems[0].SubItems[3].Text;
                pessoa.Endereco = lswLista.SelectedItems[0].SubItems[4].Text;
                Deletar_Item(pessoa);
            }
            else
            {
                MessageBox.Show("Lista Vazia");
            }

        }

        private List<Pessoa> PreencheLista_Arquivo()
        {
            List<Pessoa> lista = new List<Pessoa>();
            lswLista.Items.Clear();
            string retorno = LerArquivo();
            if (retorno.Length > 0)
            {
                string[] vet = retorno.Split('|');

                for (int i = 0; i < vet.Length; i += 5)
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Codigo = vet[i];
                    pessoa.Nome = vet[i + 1];
                    pessoa.CPF = vet[i + 2];
                    pessoa.Telefone = vet[i + 3];
                    pessoa.Endereco = vet[i + 4];
                    lista.Add(pessoa);
                }
            }
            return lista;
        }

        private void Preenchelsw(List<Pessoa> pessoas)
        {
            foreach (Pessoa pessoa in pessoas)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pessoa.Codigo;
                item.SubItems.Add(pessoa.Nome);
                item.SubItems.Add(pessoa.CPF);
                item.SubItems.Add(pessoa.Telefone);
                item.SubItems.Add(pessoa.Endereco);

                lswLista.Items.Add(item);
            }
        }

        private void txtCadastro_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnpesquisar_Click(object sender, EventArgs e)
        {
            int i = 0;
            lswLista.Items.Clear();
            
            string itemSelecionado = txt_pesquisa.Text;
            if(txt_pesquisa.Text != "") {
                foreach (Pessoa pess1 in lista)
                {
                    if (pess1.Nome.ToLower().Contains(txt_pesquisa.Text.ToLower()))
                    {
                        i++; 
                        List<Pessoa> list = new List<Pessoa>();
                        list.Add(pess1);
                        Preenchelsw(list);
                    }
             }
                 if (i == 0)
                {
                    
                }
            }
            else{
                Preenchelsw(lista);
            }
        }

        private ListViewItem FindItem(string itemDescoberto)
        {
            foreach (ListViewItem item in lswLista.Items)
            {
                if (item.SubItems[1].Text == itemDescoberto)
                {
                    return item;
                }


            }
            return null;
        }
        private void txt_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == 13)
                {
                    
                    Btnpesquisar_Click(sender, e);
                }
            }
        }



        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
        }
    }
}
