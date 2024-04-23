using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace wfaTrabFinalPOO
{
    public partial class FormPrincipal : Form
    {
        

        public FormPrincipal()
        {
            InitializeComponent();
            VisualInicial();
            checarBancosDeDados(); //Checa se os bancos de dados existem e caso não eles são criados

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarCliente formCadastrarCliente = new FormCadastrarCliente();
            formCadastrarCliente.Show();
        }

        private void calçadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarCalcado formCadastrarCalcado = new FormCadastrarCalcado();
            formCadastrarCalcado.Show();
        }

        private void vendaCondicionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarVenda formCadastrarVenda = new FormCadastrarVenda();
            formCadastrarVenda.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAtualizarCliente formAtuaClient = new FormAtualizarCliente();
            formAtuaClient.Show();
        }

        private void calçadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAtualizarCalcado formAtuaCalcado = new FormAtualizarCalcado();
            formAtuaCalcado.Show();
        }

        private void vendaCondicionalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAtualizarVenda formAtuaVenda = new FormAtualizarVenda();
            formAtuaVenda.Show();
        }

        private void VisualInicial()
        {
            
            rbCliente.AutoCheck = false;
            rbCalcado.AutoCheck = false;
            rbVenda.AutoCheck = false;

            rbCliente.AutoCheck = true;
            rbCalcado.AutoCheck = true;
            rbVenda.AutoCheck = true;

            laMenuEscolha.Visible = false;
            mtbDadoPesquisaMenu.Visible = false;
            btPesquisarMenu.Visible = false;

            dgvFormPrincipal.ReadOnly = true;
            dgvFormPrincipal.AllowUserToAddRows = false;
            dgvFormPrincipal.MultiSelect = false;
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            laMenuEscolha.Visible = true;
            mtbDadoPesquisaMenu.Visible = true;
            btPesquisarMenu.Visible = true;

            laMenuEscolha.Text = "Pesquise pelo CPF do cliente:";
            mtbDadoPesquisaMenu.Mask = "000.000.000-00";
        }

        private void rbCalcado_CheckedChanged(object sender, EventArgs e)
        {
            laMenuEscolha.Visible = true;
            mtbDadoPesquisaMenu.Visible = true;
            btPesquisarMenu.Visible = true;

            laMenuEscolha.Text = "Pesquise pelo Código do calçado:";
            mtbDadoPesquisaMenu.Mask = "";
        }

        private void rbVenda_CheckedChanged(object sender, EventArgs e)
        {
            laMenuEscolha.Visible = true;
            mtbDadoPesquisaMenu.Visible = true;
            btPesquisarMenu.Visible = true;

            laMenuEscolha.Text = "Pesquise pelo CPF do cliente:";
            mtbDadoPesquisaMenu.Mask = "000.000.000-00";
        }

        public void checarBancosDeDados()
        {

            StringConexao conTemp = new StringConexao();
            
            string texto_conexao = conTemp.StringParaConexao();

            NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

            conexao.Open();
            //Checa o banco de dado do cliente
            string command_text = string.Format(
                "DO $$" +
                "\r\nBEGIN\r\n" +
                "IF NOT EXISTS (SELECT 1 FROM information_schema.tables " +
                "WHERE table_schema = 'public' AND table_name = 'cliente') THEN\r\n" +
                "CREATE TABLE cliente (" +
                "\r\nNome VARCHAR(100)," +
                "\r\nCPF  VARCHAR(50)," +
                "\r\nRG   VARCHAR(50)," +
                "\r\nSexo VARCHAR(11)," +
                "\r\nTelefone VARCHAR(50)," +
                "\r\nData_de_nascimento VARCHAR(30)," +
                "\r\nRua VARCHAR(50)," +
                "\r\nNúmero Numeric," +
                "\r\nCidade VARCHAR(50)," +
                "\r\nUF     VARCHAR(50)," +
                "\r\nCEP    VARCHAR(12)" +
                ");" +
                "\r\nEND IF;" +
                "\r\nEND $$;");

            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(command_text, conexao))
            {
                npgsqlCommand.ExecuteNonQuery();
            }


            //Checa o banco de dados do calçado
            command_text = string.Format(
                "DO $$" +
                "\r\nBEGIN\r\n" +
                "IF NOT EXISTS (SELECT 1 FROM information_schema.tables " +
                "WHERE table_schema = 'public' AND table_name = 'calçado') THEN\r\n" +
                "CREATE TABLE calçado (" +
                "\r\nReferência VARCHAR(100)," + 
                "\r\nCódigo SERIAL PRIMARY KEY," +
                "\r\nTipo VARCHAR(100)," +
                "\r\nCor  VARCHAR(50)," +
                "\r\nMarca   VARCHAR(50)," +
                "\r\nTamanho VARCHAR(11)," +
                "\r\nPreço float," +
                "\r\nEstoque Integer," +
                "\r\nVendido Integer," +
                "\r\nCondicional Integer" +
                ");" +
                "\r\nEND IF;" +
                "\r\nEND $$;");

            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(command_text, conexao))
            {
                npgsqlCommand.ExecuteNonQuery();
            }


            //Checa o banco ded dados da venda
            command_text = string.Format(
                "DO $$" +
                "\r\nBEGIN\r\n" +
                "IF NOT EXISTS (SELECT 1 FROM information_schema.tables " +
                "WHERE table_schema = 'public' AND table_name = 'vendas') THEN\r\n" +
                "CREATE TABLE vendas (" +
                "\r\nNome VARCHAR(100)," +
                "\r\nCPF VARCHAR(40)," +
                "\r\nStatus VARCHAR(15)," +
                "\r\nCódigos_calçados TEXT," +
                "\r\nPreço  float," +
                "\r\nCódigo SERIAL PRIMARY KEY" + 
                ");" +
                "\r\nEND IF;" +
                "\r\nEND $$;");

            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(command_text, conexao))
            {
                npgsqlCommand.ExecuteNonQuery();
            }

            conexao.Close();

        }

        private void btPesquisarMenu_Click(object sender, EventArgs e)
        {
            if(rbCliente.Checked)
            {
                StringConexao conTemp = new StringConexao();

                string texto_conexao = conTemp.StringParaConexao();

                NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

                conexao.Open();

                string command_text = string.Empty;

                if (mtbDadoPesquisaMenu.Text == "   ,   ,   -")
                {
                    command_text = string.Format(
                    "SELECT * FROM cliente");
                }
                else if (!mtbDadoPesquisaMenu.MaskCompleted)
                {
                    MessageBox.Show("Digite o CPF completo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    command_text = string.Format(
                    "SELECT * FROM cliente " +
                    "WHERE cpf = '{0}'", mtbDadoPesquisaMenu.Text.Replace(",", "."));
                }

                if (command_text != string.Empty)
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command_text, conexao))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvFormPrincipal.DataSource = dt;
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Cliente não encontrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }

                    conexao.Close();
                }
            }

            if (rbCalcado.Checked)
            {
                StringConexao conTemp = new StringConexao();

                string texto_conexao = conTemp.StringParaConexao();

                NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

                conexao.Open();

                string command_text = string.Empty;

                if (mtbDadoPesquisaMenu.Text == string.Empty)
                {
                    command_text = string.Format(
                    "SELECT * FROM calçado");
                }
                
                else
                {
                    command_text = string.Format(
                    "SELECT * FROM calçado " +
                    "WHERE código = '{0}'", mtbDadoPesquisaMenu.Text.Replace(",", "."));
                }

                
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command_text, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvFormPrincipal.DataSource = dt;
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Código do calçado não encontrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }

                conexao.Close();
                
            }

            if (rbVenda.Checked)
            {
                
                StringConexao conTemp = new StringConexao();

                string texto_conexao = conTemp.StringParaConexao();

                NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

                conexao.Open();

                string command_text = string.Empty;

                if (mtbDadoPesquisaMenu.Text == "   ,   ,   -")
                {
                    command_text = string.Format(
                    "SELECT * FROM vendas");
                }
                else if (!mtbDadoPesquisaMenu.MaskCompleted)
                {
                    MessageBox.Show("Digite o CPF completo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    command_text = string.Format(
                    "SELECT * FROM vendas " +
                    "WHERE cpf = '{0}'", mtbDadoPesquisaMenu.Text.Replace(",", "."));
                }
                
                if(command_text != string.Empty)
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command_text, conexao))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvFormPrincipal.DataSource = dt;
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Cliente não encontrado com o cpf passado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }

                    conexao.Close();
                }
                
            }
        }
    }
}
