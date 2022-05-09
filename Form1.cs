using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao2
{
    public partial class Form1 : Form
    {
        bool estaEditando = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {

                if (estaEditando)
                {
                    var palavras = lbListaAlunos.SelectedItem.ToString().Split(',');

                    var nome = palavras[0];
                    var aluno = AlunosRepository.Listar().FirstOrDefault(x => x.Nome == nome);

                    aluno.Idade = int.Parse(txtIdade.Text);
                    aluno.Serie = txtSerie.Text;
                    aluno.Endereco = txtEndereco.Text;
                    aluno.Telefone = txtTelefone.Text;
                    aluno.Cpf = txtCpf.Text;

                    estaEditando = false;
                    lbListaAlunos.Items.Clear();

                    var alunos = AlunosRepository.Listar();

                    foreach (var item in alunos)
                    {
                        lbListaAlunos.Items.Add($"{item.Nome},{item.Cpf},{item.Idade},  {item.Serie},  {item.Telefone},  {item.Endereco}");
                    }
                }
                else
                {
                    Aluno aluno = new Aluno();
                    aluno.Nome = txtNome.Text;
                    aluno.Endereco = txtEndereco.Text;
                    aluno.Telefone = txtTelefone.Text;
                    aluno.Serie = txtSerie.Text;
                    aluno.Idade = int.Parse(txtIdade.Text);
                    aluno.Cpf = txtCpf.Text;
    
                    AlunosRepository.Cadastrar(aluno);

                    lbListaAlunos.Items.Add($"{aluno.Nome},{aluno.Cpf},  {aluno.Idade},  {aluno.Serie},  {aluno.Telefone},  {aluno.Endereco}");
                    
                }

                txtEndereco.Text = "";
                txtSerie.Text = "";
                txtIdade.Text = "";
                txtNome.Text = "";
                txtTelefone.Text = "";
                txtCpf.Text = "";
                txtNome.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show(" No campo NOME, insira apenas PALAVRAS!! \n " +
                                "No campo IDADE, insira apenas NUMEROS!! \n " +
                                "No campo TELEFONE, insira apenas NUMEROS!! \n " +
                                "No campo ENDEREÇO, insira PALAVRAS E NUMEROS!! \n " +
                                "No campo CPF, insira apenas NUMEROS!! \n " +
                                "No campo SERIE, insira O ANO(NUMERO) E A LETRA CORRESPONDENTE A SALA!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var alunos = AlunosRepository.Listar();

            foreach (var aluno in alunos)
            {
                lbListaAlunos.Items.Add($"{aluno.Nome},  {aluno.Cpf},  {aluno.Idade},  {aluno.Serie},  {aluno.Telefone},  {aluno.Endereco}");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estaEditando = true;

            var palavras = lbListaAlunos.SelectedItem.ToString().Split(',');

            var nome = palavras[0];
            var aluno = AlunosRepository.Listar().FirstOrDefault(x => x.Nome == nome);

            txtNome.Enabled = false;

            txtNome.Text = aluno.Nome;
            txtIdade.Text = aluno.Idade.ToString();
            txtCpf.Text = aluno.Cpf.ToString();
            txtEndereco.Text = aluno.Endereco.ToString();
            txtSerie.Text = aluno.Serie.ToString();
            txtTelefone.Text = aluno.Telefone.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var palavras = lbListaAlunos.SelectedItem.ToString().Split(',');

            var nome = palavras[0];
            var aluno = AlunosRepository.Listar().FirstOrDefault(x => x.Nome == nome);
            var alunos = AlunosRepository.Listar();

            lbListaAlunos.Items.Remove(lbListaAlunos.SelectedItem.ToString());
            alunos.Remove(aluno);

            lbListaAlunos.Items.Clear();

            foreach (var item in alunos)
            {
                lbListaAlunos.Items.Add($"{item.Nome}, {item.Cpf}, {item.Idade},  {item.Serie},  {item.Telefone},  {item.Endereco}");
            }
        }
    }
}
