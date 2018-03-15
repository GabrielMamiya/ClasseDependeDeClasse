using System;
namespace classeDependeDeClasse
{
    public class Fornecedor
    {

        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        public Fornecedor(string nome, string email, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }

        public override string ToString()
        {
            return string.Format("[Fornecedor: nome={0}, email={1}, telefone={2}]", nome, email, telefone);
        }
    }
}
