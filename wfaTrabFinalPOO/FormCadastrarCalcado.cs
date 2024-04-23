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
using static System.Net.Mime.MediaTypeNames;

namespace wfaTrabFinalPOO
{
    public partial class FormCadastrarCalcado : Form
    {
        public FormCadastrarCalcado()
        {
            InitializeComponent();
        }

        private void limparCadastroCalcado()
        {
            cbTipoCalcado.Text = string.Empty;
            tbReferencia.Text = string.Empty;
            tbCor.Text = string.Empty;
            tbMarca.Text = string.Empty;
            tbTamanho.Text = string.Empty;  
            tbQntCalcado.Text = string.Empty;
            tbPreco.Text = string.Empty;
        }

        private void btCadastrarCalcado_Click(object sender, EventArgs e)
        {
            try
            {
                Calcado obj_calcado = new Calcado();
                obj_calcado.Tipo = cbTipoCalcado.Text;
                obj_calcado.Referencia = tbReferencia.Text;
                obj_calcado.Cor = tbCor.Text;
                obj_calcado.Marca = tbMarca.Text;
                obj_calcado.Tamanho = tbTamanho.Text;
                obj_calcado.Qnt_estoque = Convert.ToInt32(tbQntCalcado.Text);
                obj_calcado.Qnt_condicional = 0;
                obj_calcado.Qnt_vendida = 0;
                obj_calcado.Preco = Convert.ToSingle(tbPreco.Text.Replace(".", ","));
                    
                

                //MessageBox.Show(Convert.ToString(obj_calcado.Preco), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show(tbPreco.Text, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (obj_calcado.Tipo == string.Empty || obj_calcado.Referencia == string.Empty ||
                    obj_calcado.Cor == string.Empty || obj_calcado.Marca == string.Empty ||
                    obj_calcado.Tamanho == string.Empty || obj_calcado.Qnt_estoque == 0 ||
                    obj_calcado.Preco == 0)
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
                        "INSERT INTO calçado(referência, tipo, cor, marca, tamanho, preço, estoque," +
                        "vendido, condicional) " +
                        "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7}, {8});",
                        obj_calcado.Referencia, obj_calcado.Tipo, obj_calcado.Cor,
                        obj_calcado.Marca, obj_calcado.Tamanho, obj_calcado.Preco.ToString().Replace(",", "."),
                        obj_calcado.Qnt_estoque, obj_calcado.Qnt_vendida, obj_calcado.Qnt_condicional
                        );

                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(command_text, conexao))
                    {
                        npgsqlCommand.ExecuteNonQuery();
                    }

                    conexao.Close();

                    MessageBox.Show("Calçado cadastrado com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCadastroCalcado();
                }
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Preencha todos os dados corretamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btLimparDadosCadastrarCalcado_Click(object sender, EventArgs e)
        {
            limparCadastroCalcado();
        }
    }
}
