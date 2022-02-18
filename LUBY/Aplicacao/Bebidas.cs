using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacao;

namespace Aplicacao
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
            public Bebidas(string nome, int valor, int quantidade, int contabilidade)
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
        public int getQuantidade()
        {
            return quantidade;
        }

        public int getValor()
        {
            return valor;
        }
        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
            {
             this.nome=nome;
            }
            public void setValor(int valor)
            {
              this.valor = valor;
            }
            public void setQuantidade(int quantidade)
            {
              this.quantidade = quantidade;
            }
            public void setcontabilidade(int contabilidade)
            {
             this.contabilidade = contabilidade;
            }



        public string toString()
            {
                return("A Bebida " + this.nome + " custa R$ " + this.valor + " e ainda tem " + this.quantidade + " em estoque");
            }
        }
    

}
