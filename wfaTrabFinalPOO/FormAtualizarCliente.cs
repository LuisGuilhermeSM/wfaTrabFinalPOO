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
    public partial class FormAtualizarCliente : Form
    {
        public FormAtualizarCliente()
        {
            InitializeComponent();
            mtbCPFFormAtualizar.Mask = "000.000.000-00";
            dgvAtualizarCliente.ReadOnly = true;
            dgvAtualizarCliente.AllowUserToAddRows = false;
            dgvAtualizarCliente.MultiSelect = false;
        }

        private void btPesquisarFormAtualizarCliente_Click(object sender, EventArgs e)
        {
            if (mtbCPFFormAtualizar.MaskCompleted)
            {
                StringConexao conTemp = new StringConexao();

                string texto_conexao = conTemp.StringParaConexao();

                NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

                conexao.Open();

                string command_text = string.Format(
                    "SELECT * FROM cliente " +
                    "WHERE cpf = '{0}'", mtbCPFFormAtualizar.Text.Replace(",", "."));

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command_text, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvAtualizarCliente.DataSource = dt;
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Cliente não encontrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }

                conexao.Close();
            }
            else
            {
                MessageBox.Show("Digite o CPF completo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }

        public void AtualizarDGV()
        {
            StringConexao conTemp = new StringConexao();

            string texto_conexao = conTemp.StringParaConexao();

            NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

            conexao.Open();

            string command_text = string.Format(
                "SELECT * FROM cliente");


            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command_text, conexao))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    dgvAtualizarCliente.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Não há clientes cadastrados", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            conexao.Close();
        }

        public void FormAtualizarCliente_Load(object sender, EventArgs e)
        {
            AtualizarDGV();
        }


        private void btEditarFormAtualizarCliente_Click(object sender, EventArgs e)
        {
            string cpf_cliente = Convert.ToString(dgvAtualizarCliente.Rows
                [dgvAtualizarCliente.CurrentCell.RowIndex].Cells[1].Value);

            FormEditaCliente formEditaCliente = new FormEditaCliente(cpf_cliente);
            formEditaCliente.ShowDialog();

            
        }

        private void btRemoverFormAtualizarCliente_Click(object sender, EventArgs e)
        {
            StringConexao conTemp = new StringConexao();

            string texto_conexao = conTemp.StringParaConexao();

            NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

            conexao.Open();

            string cpf_cliente = Convert.ToString(dgvAtualizarCliente.Rows
                [dgvAtualizarCliente.CurrentCell.RowIndex].Cells[1].Value);

            string command_text = string.Format(
                "DELETE FROM cliente WHERE cpf = '{0}'", cpf_cliente);


            using (NpgsqlCommand cmd = new NpgsqlCommand(command_text, conexao))
            {
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Dados Excluidos com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarDGV();

            conexao.Close();
        }

        private void btRefreshDGV_Click(object sender, EventArgs e)
        {
            AtualizarDGV();
        }
    }
}
