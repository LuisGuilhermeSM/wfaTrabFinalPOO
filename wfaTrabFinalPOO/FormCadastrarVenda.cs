using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace wfaTrabFinalPOO
{
    public partial class FormCadastrarVenda : Form
    {
        //private static List<string> codigos = new List<string>();
        //private static int qnt_codigos = 0;

        public void GerarDataGriedView()
        {
            dgvProdutos.Columns.Add("clReferencia", "referência");
            dgvProdutos.Columns.Add("clcodigo", "código");
            dgvProdutos.Columns.Add("cltipo", "tipo");
            dgvProdutos.Columns.Add("clmarca", "marca");
            dgvProdutos.Columns.Add("clcor", "cor");
            dgvProdutos.Columns.Add("clpreço", "preço");

            dgvProdutos.Columns["clReferencia"].Width = 60;
            dgvProdutos.Columns["clcodigo"].Width = 50;
            dgvProdutos.Columns["cltipo"].Width = 50;
            dgvProdutos.Columns["clmarca"].Width = 50;
            dgvProdutos.Columns["clcor"].Width = 50;
            dgvProdutos.Columns["clpreço"].Width = 50;

            dgvProdutos.ReadOnly = true;
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.MultiSelect = false;
            
        }

        public FormCadastrarVenda()
        {
            InitializeComponent();
            mtbCPFParaVenda.Mask = "000.000.000-00";
            GerarDataGriedView();
        }

        private void btAdicionarCalcado_Click(object sender, EventArgs e)
        {
            /*
            if(codigos.Count == 0)
            {
                codigos.Add("código =");
                codigos.Add(tbCodigoCalcado.Text);
                qnt_codigos += 1;
            } else if (codigos.Count >= 1)
            {
                codigos.Add("or código =");
                codigos.Add(tbCodigoCalcado.Text);
                qnt_codigos += 1;
            }    */


            StringConexao conTemp = new StringConexao();

            string texto_conexao = conTemp.StringParaConexao();

            NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

            conexao.Open();

            /* string command_text = string.Format(
                 "SELECT referência, código, tipo, marca, cor, preço FROM calçado " +
                 "WHERE {0}", string.Join(" ", codigos));*/

            string command_text = string.Format(
                "SELECT referência, código, tipo, marca, cor, preço FROM calçado " +
                "WHERE código = {0}", tbCodigoCalcado.Text);

            /*
            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command_text, conexao))
            {
                using (DataTable dt = new DataTable())
                {   
                    da.Fill(dt);
                    dgvProdutos.DataSource = dt;

                    //MessageBox.Show(Convert.ToString(dt), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }*/

            using (NpgsqlCommand cmd = new NpgsqlCommand(command_text, conexao))
            {
                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    //MessageBox.Show("oi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (dr.Read())
                    {
                        Calcado objtemp_calcado = new Calcado();

                        objtemp_calcado.Referencia = dr["referência"].ToString();
                        objtemp_calcado.Codigo = Convert.ToInt32(dr["código"].ToString());
                        objtemp_calcado.Tipo = dr["tipo"].ToString();
                        objtemp_calcado.Marca = dr["marca"].ToString();
                        objtemp_calcado.Cor = dr["cor"].ToString();
                        objtemp_calcado.Preco = Convert.ToSingle(dr["preço"].ToString());
                        //MessageBox.Show(objtemp_calcado.Referencia, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        dgvProdutos.Rows.Add(objtemp_calcado.Referencia, objtemp_calcado.Codigo,
                            objtemp_calcado.Tipo, objtemp_calcado.Marca, objtemp_calcado.Cor,
                            objtemp_calcado.Preco);
                    }
                    else
                    {
                        MessageBox.Show("Não foi encontrado nenhum calçado com este código", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            conexao.Close();
            AtualizaPreco();
        }

        private void btRemoverCalcado_Click(object sender, EventArgs e)
        {
            if(dgvProdutos.Rows.Count > 0)
            {
                int index_linha_delet = Convert.ToInt32(dgvProdutos.CurrentCell.RowIndex);
                dgvProdutos.Rows.RemoveAt(index_linha_delet);
                AtualizaPreco();
                MessageBox.Show("Venda removida", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        public float CalculaPreçoDgv()
        {
            float preco = 0.0f;
            for (int i = 0; i < dgvProdutos.Rows.Count; i++)
            {
                preco += Convert.ToSingle(dgvProdutos.Rows[i].Cells[5].Value);
            }
            
            return preco;
        }

        public void AtualizaPreco()
        {
            float preco = CalculaPreçoDgv();
            lbPrecoTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", preco);
        }

        public string NomeCliente(string cpf)
        {
            string nome = string.Empty;
            StringConexao conTemp = new StringConexao();

            string texto_conexao = conTemp.StringParaConexao();

            NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

            conexao.Open();

            string command_text = string.Format(
                "SELECT nome FROM cliente " +
                "WHERE cpf = '{0}'", cpf);

            using (NpgsqlCommand cmd = new NpgsqlCommand(command_text, conexao))
            {
                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        nome = dr["nome"].ToString();
                    }
                    
                }
            }

            conexao.Close();

            return nome;
        }

        public List<string> CodigosVendidos()
        {
            List<string> codigos = new List<string>();
            for (int i = 0; i < dgvProdutos.Rows.Count; i++)
            {
                codigos.Add(Convert.ToString(dgvProdutos.Rows[i].Cells[1].Value)); 
            }

            return codigos;
        }

        private void cdCadastrarVenda_Click(object sender, EventArgs e)
        {
            //try
            //{
                Venda obj_venda = new Venda();
                obj_venda.Cpf_cliente = mtbCPFParaVenda.Text;
                obj_venda.Nome_cliente = NomeCliente(obj_venda.Cpf_cliente);

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
                
                obj_venda.Cods_calcado = CodigosVendidos();


                //Teste
                //MessageBox.Show(Convert.ToString(obj_venda.Cpf_cliente), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show(Convert.ToString(obj_venda.Nome_cliente), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show(Convert.ToString(obj_venda.Status), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show(Convert.ToString(obj_venda.Preco), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show(Convert.ToString(obj_venda.Cods_calcado[0]), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (obj_venda.Nome_cliente == string.Empty)
                {
                    MessageBox.Show("Não foi encontrado nenhum cliente com este cpf", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (obj_venda.Cpf_cliente == String.Empty ||
                    obj_venda.Status == string.Empty ||
                    obj_venda.Preco == 0.0 ||
                    obj_venda.Cods_calcado.Count == 0
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
                    
                    for (int i = 0; i < obj_venda.Cods_calcado.Count; i++)
                    {
                        string command_text = string.Format(
                        "INSERT INTO vendas(nome, cpf, status, códigos_calçados, preço) " +
                        "VALUES('{0}', '{1}', '{2}', '{3}', {4});",
                        obj_venda.Nome_cliente, obj_venda.Cpf_cliente,
                        obj_venda.Status, obj_venda.Cods_calcado[i],
                        obj_venda.Preco.ToString().Replace(".", "").Replace(",", "."));

                        using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(command_text, conexao))
                        {
                            npgsqlCommand.ExecuteNonQuery();
                        }
                    }
                     
                    
                
                    /*
                    string command_text = string.Format(
                        "INSERT INTO vendas(nome, cpf, status, códigos_calçados, preço) " +
                        "VALUES('{0}', '{1}', '{2}', '{3}', {4});",
                        obj_venda.Nome_cliente, obj_venda.Cpf_cliente, 
                        obj_venda.Status, string.Join("\n", obj_venda.Cods_calcado),
                        obj_venda.Preco);

                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(command_text, conexao))
                    {
                        npgsqlCommand.ExecuteNonQuery();
                    }
                    */

                    conexao.Close();

                    MessageBox.Show("Venda cadastrada com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //limparCadastroCalcado();
                }
            //}
            //catch (FormatException formatException)
            //{
            //  MessageBox.Show("Preencha todos os dados corretamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}







        }
    }
}
