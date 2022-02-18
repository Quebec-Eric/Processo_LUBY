using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacao;

namespace Aplicacao
{
    public class Maquina
    {
       
      
        public static  string inicioDoUsuario()
        {
            return ("Bem Vindo a nossa Maquina de bebidas!!\n\n " + "Hoje Temos essas Bebidas" + "\n 1) Coca-Cola" + " \n 2) Dolly" + "\n 3) Suco de Uva" + " \n 4) Guarana" +
           "\n 5) Parte adiministrativa " + "\n Qual gostaria ? Digite o nomero correspondendo ou 0 para finaliza ");
            
                         
        }

      

        public static int mostrarProduto(int produtor)
        {
            //pegar o produtor do banco de dados e mostrar a quantidade e o preco do produto
            Console.WriteLine("Gostaria de Comprar o produto ou retornar? 1 comprar 0 retornar");
                int ondeIr=Convert.ToInt32(Console.ReadLine());

            if(ondeIr ==0)
            {
                return 1;
            }

            
            return venderProduto(produtor);//aki passar o objeto 
        }
        public static int venderProduto(int produto) // receber o objeto
        {
            // if para verificar se existe estoque do produto
            // aki colocar quanto ele tera que pagar 
            //outro if para confirmar que o dinheiro esta correto se nao estiver pedir novemente 
            //depois que o dinhjeiro for contabilizado 

            reformularOBD(produto);// passar aki o objeto dnv
            return 1;// retornar 1 se o pagamento e se nao tiver no estoque e 0 para se tiver
        }

        public static void reformularOBD(int produto)
        {
            // aki iremos mudar as informacoes que estao no bd como a quantidade no estoque e a contabilidade
        }

        public static void saberTroco() // aki iremos passar o dinheiro que o cara colocou e se ira precisar de troco 
        {

        }


    }
}
