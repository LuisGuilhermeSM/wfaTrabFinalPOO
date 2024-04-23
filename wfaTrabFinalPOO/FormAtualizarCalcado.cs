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
    public partial class FormAtualizarCalcado : Form
    {
        public FormAtualizarCalcado()
        {
            InitializeComponent();
            mtbCodigoFormAtualizarCalcado.Mask = "";
            dgvAtualizarCalcado.ReadOnly = true;
            dgvAtualizarCalcado.AllowUserToAddRows = false;
            dgvAtualizarCalcado.MultiSelect = false;
        }

        private void AtualizaDGV(int modo) //0 seleciona tudo, 1 é com o código passado
        {
            StringConexao conTemp = new StringConexao();

            string texto_conexao = conTemp.StringParaConexao();

            NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

            conexao.Open();

            string command_text = string.Empty;

            if (modo == 0)
            {
                command_text = string.Format(
                "SELECT * FROM calçado");
            }
            else if(modo == 1 && mtbCodigoFormAtualizarCalcado.Text != string.Empty)
            {
                command_text = string.Format(
                "SELECT * FROM calçado " +
                "WHERE código = '{0}'", mtbCodigoFormAtualizarCalcado.Text);
                
            }

            if(mtbCodigoFormAtualizarCalcado.Text == string.Empty && modo ==1)
            {
                MessageBox.Show("Insira o código", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command_text, conexao))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    dgvAtualizarCalcado.DataSource = dt;
                    if (dt.Rows.Count == 0 && modo == 0)
                    {
                        MessageBox.Show("Não há calçados cadastrados", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (dt.Rows.Count == 0 && modo == 1)
                    {
                        MessageBox.Show("Não foi encontrado nenhum calçado com esse código", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            conexao.Close();
        }

        private void FormAtualizarCalcado_Load(object sender, EventArgs e)
        {
            AtualizaDGV(0);
        }

        private void btPesquisarFormAtualizarCalcado_Click(object sender, EventArgs e)
        {
            AtualizaDGV(1);
        }

        private void btEditarFormAtualizarCalcado_Click(object sender, EventArgs e)
        {
            string codigo_calcado = Convert.ToString(dgvAtualizarCalcado.Rows
               [dgvAtualizarCalcado.CurrentCell.RowIndex].Cells[1].Value);

            FormEditaCalcado formEditaCalcado= new FormEditaCalcado(codigo_calcado);
            formEditaCalcado.ShowDialog();
        }

        private void btRemoverFormAtualizarCalcado_Click(object sender, EventArgs e)
        {
            StringConexao conTemp = new StringConexao();

            string texto_conexao = conTemp.StringParaConexao();

            NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

            conexao.Open();

            string codigo_calcado = Convert.ToString(dgvAtualizarCalcado.Rows
                [dgvAtualizarCalcado.CurrentCell.RowIndex].Cells[1].Value);

            string command_text = string.Format(
                "DELETE FROM calçado WHERE código = '{0}'", codigo_calcado);


            using (NpgsqlCommand cmd = new NpgsqlCommand(command_text, conexao))
            {
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Dados Excluidos com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizaDGV(0);

            conexao.Close();
        }

        private void btRefreshDGV_Click(object sender, EventArgs e)
        {
            AtualizaDGV(0);
        }
    }
}
