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
    public partial class FormEditaCliente : Form
    {

        string cpf_cliente;
        public FormEditaCliente(string cpf_cliente)
        {
            InitializeComponent();
            this.cpf_cliente = cpf_cliente;
            visualFormEditClient();
            if (this.cpf_cliente != string.Empty )
            {
                GetCliente(this.cpf_cliente);
            }


        }
    
        private void visualFormEditClient()
        {
            mtbCpfCliente.Mask = "000.000.000-00";
            mtbTelefone.Mask = "(00) 0000-0000";
            mtbDataNascimento.Mask = "00/00/0000";
            mtbCEP.Mask = "00000-000";

            string[] installs = new string[] { "Masculino", "Feminino" };
            cbSexoCliente.Items.AddRange(installs);

        }

        private void GetCliente(string cpf)
        {
            StringConexao conTemp = new StringConexao();

            string texto_conexao = conTemp.StringParaConexao();

            NpgsqlConnection conexao = new NpgsqlConnection(texto_conexao);

            conexao.Open();


            string command_text = string.Format(
                "SELECT * FROM cliente " +
                "WHERE cpf = '{0}'", cpf);


            using (NpgsqlCommand cmd = new NpgsqlCommand(command_text, conexao))
            {
                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    //MessageBox.Show("oi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (dr.Read())
                    {
                        tbNomeCliente.Text = dr["nome"].ToString();
                        mtbCpfCliente.Text = dr["cpf"].ToString();
                        mtbRG.Text = dr["rg"].ToString();
                        cbSexoCliente.Text = dr["sexo"].ToString();
                        mtbTelefone.Text = dr["telefone"].ToString();
                        mtbDataNascimento.Text = dr["data_de_nascimento"].ToString();
                        tbRua.Text = dr["Rua"].ToString();
                        tbNumero.Text = dr["Número"].ToString();
                        tbCidade.Text = dr["Cidade"].ToString();
                        tbUF.Text = dr["uf"].ToString();
                        mtbCEP.Text = dr["cep"].ToString();     
                    }
                    
                }
            }

            conexao.Close();
        }

        private void btEditaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente obj_cliente = new Cliente();
                obj_cliente.Nome = tbNomeCliente.Text;
                obj_cliente.Cpf = mtbCpfCliente.Text;
                obj_cliente.Rg = mtbRG.Text;
                obj_cliente.Sexo = cbSexoCliente.Text;
                obj_cliente.Telefone = mtbTelefone.Text;
                obj_cliente.Data_nascimento = mtbDataNascimento.Text;
                obj_cliente.Rua = tbRua.Text;
                obj_cliente.Num_endereço = Convert.ToInt32(tbNumero.Text);
                obj_cliente.Cidade = tbCidade.Text;
                obj_cliente.Uf = tbUF.Text;
                obj_cliente.Cep = mtbCEP.Text;

                if (obj_cliente.Nome == string.Empty || obj_cliente.Cpf == string.Empty ||
                   obj_cliente.Rg == string.Empty || obj_cliente.Sexo == string.Empty ||
                   obj_cliente.Telefone == string.Empty || obj_cliente.Data_nascimento == string.Empty ||
                   obj_cliente.Rua == string.Empty || obj_cliente.Num_endereço == 0 ||
                   obj_cliente.Cidade == string.Empty || obj_cliente.Uf == string.Empty ||
                   obj_cliente.Cep == string.Empty)
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
                        "Update cliente SET nome = '{0}', cpf = '{1}', rg = '{2}', sexo = '{3}', " +
                        "telefone = '{4}', data_de_nascimento = '{5}', rua = '{6}', " +
                        "número = {7}, cidade = '{8}', uf = '{9}', cep = '{10}' " +
                        "WHERE cpf = '{11}';",
                        obj_cliente.Nome, obj_cliente.Cpf, obj_cliente.Rg,
                        obj_cliente.Sexo, obj_cliente.Telefone, obj_cliente.Data_nascimento, obj_cliente.Rua,
                        Convert.ToString(obj_cliente.Num_endereço), obj_cliente.Cidade, obj_cliente.Uf, obj_cliente.Cep,
                        this.cpf_cliente
                        );

                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(command_text, conexao))
                    {
                        npgsqlCommand.ExecuteNonQuery();
                    }

                    conexao.Close();

                    MessageBox.Show("Dados do cliente atualizados com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Preencha todos os dados corretamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
