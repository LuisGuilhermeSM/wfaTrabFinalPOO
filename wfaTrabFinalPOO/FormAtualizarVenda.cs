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
    public partial class FormAtualizarVenda : Form
    {
        public FormAtualizarVenda()
        {
            InitializeComponent();
            mtbCPFFormAtualizarVenda.Mask = "000.000.000-00";
            dgvAtualizarVenda.ReadOnly = true;
            dgvAtualizarVenda.AllowUserToAddRows = false;
            dgvAtualizarVenda.MultiSelect = false;
        }

        public void AtualizarDGV(int modo)
        {
            StringConexao conTemp = new StringConexao();

            string texto_conexao = conTemp.StringParaConexao();

            NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

            conexao.Open();

            string command_text = string.Empty;

            if (modo == 0)
            {
                command_text = string.Format(
                "SELECT * FROM vendas");
            }
            else if (modo == 1 && mtbCPFFormAtualizarVenda.MaskCompleted)
            {
                command_text = string.Format(
                "SELECT * FROM vendas " +
                "WHERE cpf = '{0}'", mtbCPFFormAtualizarVenda.Text.Replace(",", "."));

            }

            if (!mtbCPFFormAtualizarVenda.MaskCompleted && modo == 1)
            {
                MessageBox.Show("Insira o cpf corretamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command_text, conexao))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    dgvAtualizarVenda.DataSource = dt;
                    if (dt.Rows.Count == 0 && modo == 0)
                    {
                        MessageBox.Show("Não há calçados cadastrados", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (dt.Rows.Count == 0 && modo == 1)
                    {
                        MessageBox.Show("Não foi encontrado nenhuma venda para esse cpf", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            conexao.Close();
        }

        private void FormAtualizarVenda_Load(object sender, EventArgs e)
        {
            AtualizarDGV(0);
        }

        private void btPesquisarFormAtualizarVenda_Click(object sender, EventArgs e)
        {
            AtualizarDGV(1);
        }

        private void btRemoverFormAtualizarVenda_Click(object sender, EventArgs e)
        {
            StringConexao conTemp = new StringConexao();

            string texto_conexao = conTemp.StringParaConexao();

            NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

            conexao.Open();

            string cpf_cliente = Convert.ToString(dgvAtualizarVenda.Rows
                [dgvAtualizarVenda.CurrentCell.RowIndex].Cells[5].Value);

            string command_text = string.Format(
                "DELETE FROM vendas WHERE código = '{0}'", cpf_cliente);


            using (NpgsqlCommand cmd = new NpgsqlCommand(command_text, conexao))
            {
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Dados de venda Excluidos com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarDGV(0);

            conexao.Close();
        }

        private void btEditarFormAtualizarVenda_Click(object sender, EventArgs e)
        {
            string codigo_venda = Convert.ToString(dgvAtualizarVenda.Rows
              [dgvAtualizarVenda.CurrentCell.RowIndex].Cells[5].Value);

            FormEditaVenda formEditaVenda = new FormEditaVenda(codigo_venda);
            formEditaVenda.ShowDialog();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarDGV(0);
        }
    }
}
