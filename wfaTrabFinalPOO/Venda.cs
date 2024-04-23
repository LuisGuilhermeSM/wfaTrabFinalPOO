using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrabFinalPOO
{
    internal class Venda
    {
        private string cpf_cliente;
        private string nome_cliente;
        private List<string> cods_calcado = new List<string>();
        private float preco;
        private string status; //venda ou condicional
        //public DateTime Dia_compra; 

        

        public Venda() { }

        public Venda(string cpf_cliente, string nome_cliente, List<string> cods_calcado,
            float preco, string status)
        {
            this.Cpf_cliente = cpf_cliente;
            this.Nome_cliente = nome_cliente;
            this.Cods_calcado = cods_calcado;
            this.Preco = preco;
            this.Status = status;
        }

        public string Cpf_cliente { get => cpf_cliente; set => cpf_cliente = value.Replace(",", "."); }
        public string Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public List<string> Cods_calcado { get => cods_calcado; set => cods_calcado = value; }
        public float Preco { get => preco; set => preco = value; }
        public string Status { get => status; set => status = value; }
    }
}
