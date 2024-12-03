namespace Projeto_do_Chibiu._2
{
    partial class frmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtExcluir = new System.Windows.Forms.Button();
            this.lswLista = new System.Windows.Forms.ListView();
            this.txtExcluir1 = new System.Windows.Forms.Button();
            this.txtAtualizar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEndereço = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCadastro = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.Btnpesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(227, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(12, 156);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(227, 20);
            this.txtCpf.TabIndex = 1;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 200);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(227, 20);
            this.txtTelefone.TabIndex = 2;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 244);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(227, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 52);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 288);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(61, 40);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtExcluir
            // 
            this.txtExcluir.Location = new System.Drawing.Point(79, 288);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(61, 40);
            this.txtExcluir.TabIndex = 6;
            this.txtExcluir.Text = "Limpar";
            this.txtExcluir.UseVisualStyleBackColor = true;
            this.txtExcluir.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lswLista
            // 
            this.lswLista.FullRowSelect = true;
            this.lswLista.GridLines = true;
            this.lswLista.HideSelection = false;
            this.lswLista.Location = new System.Drawing.Point(316, 48);
            this.lswLista.Name = "lswLista";
            this.lswLista.Size = new System.Drawing.Size(444, 179);
            this.lswLista.TabIndex = 7;
            this.lswLista.UseCompatibleStateImageBehavior = false;
            this.lswLista.DoubleClick += new System.EventHandler(this.lswLista_DoubleClick);
            // 
            // txtExcluir1
            // 
            this.txtExcluir1.Location = new System.Drawing.Point(632, 233);
            this.txtExcluir1.Name = "txtExcluir1";
            this.txtExcluir1.Size = new System.Drawing.Size(61, 40);
            this.txtExcluir1.TabIndex = 8;
            this.txtExcluir1.Text = "Excluir";
            this.txtExcluir1.UseVisualStyleBackColor = true;
            this.txtExcluir1.Click += new System.EventHandler(this.txtExcluir1_Click);
            // 
            // txtAtualizar
            // 
            this.txtAtualizar.Location = new System.Drawing.Point(699, 233);
            this.txtAtualizar.Name = "txtAtualizar";
            this.txtAtualizar.Size = new System.Drawing.Size(61, 40);
            this.txtAtualizar.TabIndex = 9;
            this.txtAtualizar.Text = "Atualizar";
            this.txtAtualizar.UseVisualStyleBackColor = true;
            this.txtAtualizar.Click += new System.EventHandler(this.txtAtualizar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(16, 140);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 11;
            this.lblCpf.Text = "CPF:";
            this.lblCpf.Click += new System.EventHandler(this.txtCpf_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Enabled = false;
            this.lblTelefone.Location = new System.Drawing.Point(12, 184);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 12;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtEndereço
            // 
            this.txtEndereço.AutoSize = true;
            this.txtEndereço.Location = new System.Drawing.Point(12, 228);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(56, 13);
            this.txtEndereço.TabIndex = 13;
            this.txtEndereço.Text = "Endereço:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCadastro
            // 
            this.txtCadastro.AutoSize = true;
            this.txtCadastro.Location = new System.Drawing.Point(12, 9);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(49, 13);
            this.txtCadastro.TabIndex = 15;
            this.txtCadastro.Text = "Cadastro";
            this.txtCadastro.Click += new System.EventHandler(this.txtCadastro_Click);
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(317, 15);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(217, 20);
            this.txt_pesquisa.TabIndex = 16;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pesquisa_KeyPress);
            // 
            // Btnpesquisar
            // 
            this.Btnpesquisar.Location = new System.Drawing.Point(551, 9);
            this.Btnpesquisar.Name = "Btnpesquisar";
            this.Btnpesquisar.Size = new System.Drawing.Size(86, 33);
            this.Btnpesquisar.TabIndex = 17;
            this.Btnpesquisar.Text = "Pesquisar";
            this.Btnpesquisar.UseVisualStyleBackColor = true;
            this.Btnpesquisar.Click += new System.EventHandler(this.Btnpesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnpesquisar);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.txtCadastro);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtAtualizar);
            this.Controls.Add(this.txtExcluir1);
            this.Controls.Add(this.lswLista);
            this.Controls.Add(this.txtExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button txtExcluir;
        private System.Windows.Forms.ListView lswLista;
        private System.Windows.Forms.Button txtExcluir1;
        private System.Windows.Forms.Button txtAtualizar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label txtEndereço;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label txtCadastro;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button Btnpesquisar;
    }
}

