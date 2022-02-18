using System;
namespace Vendas
{
    public class Bebidas
    {
        private string nome;
        private int valor;
        private int quantidade;
        private int contabilidade;

        public Bebidas()
        {
            nome = "";
            valor = 0;
            quantidade = 0;
            contabilidade = 0;
        }
        public Bebidas(string nome , int valor , int quantidade ,int contabilidade)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;   
            this.contabilidade = contabilidade;
        }

        public int getContabilidade()
        {
            return contabilidade;
        }

        public void toString(Bebidas obj)
        {
            Console.WriteLine("A Bebida " + obj.nome + " custa R$ "+obj.valor+" e ainda tem "+obj.quantidade+ " em estoque");
        }
    }
}
