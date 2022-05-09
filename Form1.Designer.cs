namespace Avaliacao2
{
    partial class Form1
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
            this.gbDadosAluno = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbListaAlunos = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lbListaAlunos = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDadosAluno.SuspendLayout();
            this.gbListaAlunos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosAluno
            // 
            this.gbDadosAluno.Controls.Add(this.txtCpf);
            this.gbDadosAluno.Controls.Add(this.label1);
            this.gbDadosAluno.Controls.Add(this.txtTelefone);
            this.gbDadosAluno.Controls.Add(this.lblTelefone);
            this.gbDadosAluno.Controls.Add(this.txtEndereco);
            this.gbDadosAluno.Controls.Add(this.txtSerie);
            this.gbDadosAluno.Controls.Add(this.lblEndereco);
            this.gbDadosAluno.Controls.Add(this.lblSerie);
            this.gbDadosAluno.Controls.Add(this.btnSalvar);
            this.gbDadosAluno.Controls.Add(this.txtIdade);
            this.gbDadosAluno.Controls.Add(this.txtNome);
            this.gbDadosAluno.Controls.Add(this.lblIdade);
            this.gbDadosAluno.Controls.Add(this.lblNome);
            this.gbDadosAluno.Location = new System.Drawing.Point(32, 34);
            this.gbDadosAluno.Name = "gbDadosAluno";
            this.gbDadosAluno.Size = new System.Drawing.Size(820, 246);
            this.gbDadosAluno.TabIndex = 0;
            this.gbDadosAluno.TabStop = false;
            this.gbDadosAluno.Text = "Dados do Aluno";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(145, 151);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(168, 20);
            this.txtTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(36, 151);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(598, 90);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(183, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(598, 40);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(183, 20);
            this.txtSerie.TabIndex = 4;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(489, 90);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 6;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(489, 43);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(31, 13);
            this.lblSerie.TabIndex = 5;
            this.lblSerie.Text = "Serie";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(706, 197);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(145, 93);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(168, 20);
            this.txtIdade.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(145, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(168, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(36, 93);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 1;
            this.lblIdade.Text = "Idade";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(36, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // gbListaAlunos
            // 
            this.gbListaAlunos.Controls.Add(this.btnEditar);
            this.gbListaAlunos.Controls.Add(this.lbListaAlunos);
            this.gbListaAlunos.Controls.Add(this.btnExcluir);
            this.gbListaAlunos.Location = new System.Drawing.Point(32, 306);
            this.gbListaAlunos.Name = "gbListaAlunos";
            this.gbListaAlunos.Size = new System.Drawing.Size(820, 432);
            this.gbListaAlunos.TabIndex = 5;
            this.gbListaAlunos.TabStop = false;
            this.gbListaAlunos.Text = "Lista de Alunos";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(610, 386);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lbListaAlunos
            // 
            this.lbListaAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaAlunos.FormattingEnabled = true;
            this.lbListaAlunos.ItemHeight = 15;
            this.lbListaAlunos.Location = new System.Drawing.Point(15, 51);
            this.lbListaAlunos.Name = "lbListaAlunos";
            this.lbListaAlunos.Size = new System.Drawing.Size(774, 319);
            this.lbListaAlunos.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(706, 386);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(598, 151);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(183, 20);
            this.txtCpf.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "CPF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 763);
            this.Controls.Add(this.gbListaAlunos);
            this.Controls.Add(this.gbDadosAluno);
            this.Name = "Form1";
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDadosAluno.ResumeLayout(false);
            this.gbDadosAluno.PerformLayout();
            this.gbListaAlunos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosAluno;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbListaAlunos;
        private System.Windows.Forms.ListBox lbListaAlunos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label1;
    }
}

