using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrabFinalPOO
{
    internal class Cliente
    {
        private string nome;
        private string cpf;
        private string rg;
        private string sexo;
        private string data_nascimento;
        private string rua;
        private int num_endereço;
        private string uf;
        private string telefone;
        private string cidade;
        private string cep;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value.Replace(",", "."); }
        public string Rg { get => rg; set => rg = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Num_endereço { get => num_endereço; set => num_endereço = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Cep { get => cep; set => cep = value; }

        public Cliente() { }

        public Cliente(string nome, string cpf, string rg, string sexo, string data_nascimento,
            string rua, int num_endereço, string uf, string telefone, string cidade, string cep)
        {
            this.Nome = nome;
            this.Cpf = cpf.Replace(",", ".");
            this.Rg = rg;
            this.Sexo = sexo;
            this.Data_nascimento = data_nascimento;
            this.Rua = rua;
            this.Num_endereço = num_endereço;
            this.Uf = uf;
            this.Telefone = telefone;
            this.Cidade = cidade;
            this.Cep = cep;
        }
    }
}
