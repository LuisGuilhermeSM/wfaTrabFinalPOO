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
    public partial class FormEditaVenda : Form
    {

        string codigo;

        public FormEditaVenda(string codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            mtbCPFParaVenda.Mask = "000.000.000-00";
            if (this.codigo != string.Empty)
            {
                GetVenda(this.codigo);
            }
        }

        private void GetVenda(string codigo)
        {
            StringConexao conTemp = new StringConexao();

            string texto_conexao = conTemp.StringParaConexao();

            NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

            conexao.Open();


            string command_text = string.Format(
                "SELECT * FROM vendas " +
                "WHERE código = '{0}'", codigo);


            using (NpgsqlCommand cmd = new NpgsqlCommand(command_text, conexao))
            {
                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    //MessageBox.Show("oi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (dr.Read())
                    {
                        tbCodigoCalcado.Text = dr["código"].ToString();
                        tbNome.Text = dr["nome"].ToString();
                        mtbCPFParaVenda.Text = dr["cpf"].ToString();
                        lbPrecoTotal.Text = dr["preço"].ToString();
                        string status = dr["status"].ToString();
                        if(status == "Condicional")
                        {
                            rbCondicional.Checked = true;
                        }
                        else if(status == "Venda")
                        {
                            rbVenda.Checked = true;
                        }
                    }

                }
            }

            conexao.Close();
        }

        private void btConcluir_Click(object sender, EventArgs e)
        {
            Venda obj_venda = new Venda();
            obj_venda.Cpf_cliente = mtbCPFParaVenda.Text;
            obj_venda.Nome_cliente = tbNome.Text;

            if (rbCondicional.Checked)
            {
                obj_venda.Status = "Condicional";
            }
            else if (rbVenda.Checked)
            {
                obj_venda.Status = "Venda";
            }

            //MessageBox.Show(lbPrecoTotal.Text.Replace("R$", "").Replace(".", ","), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            obj_venda.Preco = Convert.ToSingle(lbPrecoTotal.Text.Replace("R$", ""));

            //obj_venda.Cods_calcado[0] = tbCodigoCalcado.Text;


            if (obj_venda.Nome_cliente == string.Empty)
            {
                MessageBox.Show("Não foi encontrado nenhum cliente com este cpf", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (obj_venda.Cpf_cliente == String.Empty ||
                obj_venda.Status == string.Empty ||
                obj_venda.Preco == 0.0 ||
                tbCodigoCalcado.Text == string.Empty
                )
            {
                MessageBox.Show("Preencha todos os dados corretamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                StringConexao conTemp = new StringConexao();

                string texto_conexao = conTemp.StringParaConexao();

                NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

                conexao.Open();

                
                string command_text = string.Format(
                "Update vendas SET nome = '{0}', cpf = '{1}', status = '{2}', códigos_calçados = '{3}', preço = {4} " +
                "WHERE código = '{5}';",
                obj_venda.Nome_cliente, obj_venda.Cpf_cliente,
                obj_venda.Status, tbCodigoCalcado.Text,
                obj_venda.Preco.ToString().Replace(".", "").Replace(",", "."), 
                this.codigo);

                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(command_text, conexao))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
                



                conexao.Close();

                MessageBox.Show("Venda atualizada com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limparCadastroCalcado();
            }
        }
    }
}
