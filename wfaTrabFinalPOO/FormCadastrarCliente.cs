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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wfaTrabFinalPOO
{
    public partial class FormCadastrarCliente : Form
    {
        public FormCadastrarCliente()
        {
            InitializeComponent();
            visualFormCadClient();
        }

        private void visualFormCadClient()
        {
            mtbCpfCliente.Mask = "000.000.000-00";
            mtbTelefone.Mask = "(00) 0000-0000";
            mtbDataNascimento.Mask = "00/00/0000";
            mtbCEP.Mask = "00000-000";

            string[] installs = new string[] { "Masculino", "Feminino"};
            cbSexoCliente.Items.AddRange(installs);
            
        }

        //Só permite escrever numeros no tbNumero
        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void LimparCadastroCliente()
        {
            tbNomeCliente.Text = string.Empty;
            mtbCpfCliente.Text = string.Empty;
            mtbRG.Text = string.Empty;
            cbSexoCliente.Text = string.Empty;
            mtbTelefone.Text = string.Empty;
            mtbDataNascimento.Text = string.Empty;
            tbRua.Text = string.Empty;
            tbNumero.Text = string.Empty;
            tbCidade.Text = string.Empty;
            tbUF.Text = string.Empty;
            mtbCEP.Text = string.Empty;
        }

        private void btLimparDadosCadastrarCliente_Click(object sender, EventArgs e)
        {
            LimparCadastroCliente();
        }

        private void btCadastrarCliente_Click(object sender, EventArgs e)
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
                        "INSERT INTO cliente(nome, cpf, rg, sexo, telefone, data_de_nascimento, rua, " +
                        "número, cidade, uf, cep) " +
                        "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7}, '{8}', '{9}', '{10}');",
                        obj_cliente.Nome, obj_cliente.Cpf, obj_cliente.Rg,
                        obj_cliente.Sexo, obj_cliente.Telefone, obj_cliente.Data_nascimento, obj_cliente.Rua,
                        Convert.ToString(obj_cliente.Num_endereço), obj_cliente.Cidade, obj_cliente.Uf, obj_cliente.Cep
                        );

                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(command_text, conexao))
                    {
                        npgsqlCommand.ExecuteNonQuery();
                    }

                    conexao.Close();

                    MessageBox.Show("Cliente cadastrado com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCadastroCliente();
                }
            } catch(FormatException formatException)
            {
                MessageBox.Show("Preencha todos os dados corretamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           


        }
    }
}
