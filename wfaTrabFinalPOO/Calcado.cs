using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrabFinalPOO
{
    internal class Calcado
    {
        private string tipo;
        private string referencia;
        private int codigo;
        private string cor;
        private string marca;
        private string tamanho;
        private int qnt_estoque;
        private int qnt_vendida;
        private int qnt_condicional;
        private float preco;

        

        public Calcado() { }

        public Calcado(string tipo, string referencia, int codigo, string cor, string marca,
            string tamanho, int qnt_estoque, int qnt_vendida, int qnt_condicional, float preco)
        {
            this.Tipo = tipo;
            this.Referencia = referencia;
            this.Codigo = codigo;
            this.Cor = cor;
            this.Marca = marca;
            this.Tamanho = tamanho;
            this.Qnt_estoque = qnt_estoque;
            this.Qnt_vendida = qnt_vendida;
            this.Qnt_condicional = qnt_condicional;
            this.Preco = preco;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Referencia { get => referencia; set => referencia = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Tamanho { get => tamanho; set => tamanho = value; }
        public int Qnt_estoque { get => qnt_estoque; set => qnt_estoque = value; }
        public int Qnt_vendida { get => qnt_vendida; set => qnt_vendida = value; }
        public int Qnt_condicional { get => qnt_condicional; set => qnt_condicional = value; }
        public float Preco { get => preco; set => preco = value; }
    }
}
