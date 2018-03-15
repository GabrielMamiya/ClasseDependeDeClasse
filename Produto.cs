using System;
namespace classeDependeDeClasse
{
    public class Produto
    {

        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }
        public Fornecedor fornecedor { get; private set; }

        public Produto(string nome,double preco,int quantidade, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
            this.fornecedor = fornecedor;
        }

        public override string ToString()
        {
            return string.Format("[Produto: nome={0}, preco={1}, quantidade={2}, fornecedor={3}]", nome, preco, quantidade, fornecedor);
        }
    }
}
