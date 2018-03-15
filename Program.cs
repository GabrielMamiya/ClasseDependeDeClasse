using System;

namespace classeDependeDeClasse
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Fornecedor fornecedor = new Fornecedor("Gabriel", "Gabriel-tamura@hotmail.com", "4223-2342");

            Produto produto = new Produto("Televisao", 1000.00, 10, fornecedor);

            Console.WriteLine(produto);


        }
    }
}
