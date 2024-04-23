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
    public partial class FormEditaCalcado : Form
    {
        string codigo_calcado;

        public FormEditaCalcado(string codigo_calcado)
        {
            InitializeComponent();
            this.codigo_calcado = codigo_calcado;
            tbCodigo.ReadOnly = true;
            if(codigo_calcado != string.Empty)
            {
                GetCalcado(codigo_calcado);
            }

        }

        private void GetCalcado(string codigo)
        {
            StringConexao conTemp = new StringConexao();

            string texto_conexao = conTemp.StringParaConexao();

            NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

            conexao.Open();


            string command_text = string.Format(
                "SELECT * FROM calçado " +
                "WHERE código = '{0}'", codigo);


            using (NpgsqlCommand cmd = new NpgsqlCommand(command_text, conexao))
            {
                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    //MessageBox.Show("oi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (dr.Read())
                    {
                        tbCodigo.Text = dr["código"].ToString();
                        cbTipoCalcado.Text = dr["tipo"].ToString();
                        tbReferencia.Text = dr["referência"].ToString();
                        tbCor.Text = dr["cor"].ToString();
                        tbMarca.Text = dr["marca"].ToString();
                        tbTamanho.Text = dr["tamanho"].ToString();
                        tbPreco.Text = dr["preço"].ToString();
                        tbQntCalcadoEstoque.Text = dr["estoque"].ToString();
                        tbQntCalcadoCondicional.Text = dr["condicional"].ToString();
                        tbQntCalcadoVendida.Text = dr["vendido"].ToString();
                    }

                }
            }

            conexao.Close();
        }

        private void btEditaCalcado_Click(object sender, EventArgs e)
        {
            try
            {
                Calcado obj_calcado = new Calcado();
                obj_calcado.Tipo = cbTipoCalcado.Text;
                obj_calcado.Referencia = tbReferencia.Text;
                obj_calcado.Cor = tbCor.Text;
                obj_calcado.Marca = tbMarca.Text;
                obj_calcado.Tamanho = tbTamanho.Text;
                obj_calcado.Qnt_estoque = Convert.ToInt32(tbQntCalcadoEstoque.Text);
                obj_calcado.Qnt_condicional = Convert.ToInt32(tbQntCalcadoCondicional.Text);
                obj_calcado.Qnt_vendida = Convert.ToInt32(tbQntCalcadoVendida.Text); ;
                obj_calcado.Preco = Convert.ToSingle(tbPreco.Text.Replace(".", ","));

                if (obj_calcado.Tipo == string.Empty || obj_calcado.Referencia == string.Empty ||
                    obj_calcado.Cor == string.Empty || obj_calcado.Marca == string.Empty ||
                    obj_calcado.Tamanho == string.Empty || obj_calcado.Qnt_estoque < 0 ||
                    obj_calcado.Preco == 0.0)
                {
                    MessageBox.Show("Preencha todos os campos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    StringConexao conTemp = new StringConexao();

                    string texto_conexao = conTemp.StringParaConexao();

                    NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

                    conexao.Open();

                    string command_text = string.Format(
                        "Update calçado SET referência = '{0}', tipo = '{1}', cor = '{2}', marca = '{3}'," +
                        "tamanho = '{4}', preço = {5}, estoque = {6}, condicional = {7}," +
                        "vendido = {8} " +
                        "WHERE código = '{9}';",
                        obj_calcado.Referencia, obj_calcado.Tipo, obj_calcado.Cor,
                        obj_calcado.Marca, obj_calcado.Tamanho, obj_calcado.Preco.ToString().Replace(",", "."),
                        obj_calcado.Qnt_estoque, obj_calcado.Qnt_condicional, obj_calcado.Qnt_vendida,
                        this.codigo_calcado
                        );

                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(command_text, conexao))
                    {
                        npgsqlCommand.ExecuteNonQuery();
                    }

                    conexao.Close();

                    MessageBox.Show("Dados do calçado atualizados com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Preencha todos os dados corretamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}
