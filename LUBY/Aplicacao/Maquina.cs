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
       
      
              
        public  void venderProduto(Bebidas obj,int dinheiro) // receber o objeto
        {
            Form1 form1 = new Form1();
            if (obj.getValor() == dinheiro)
            {
                if (obj.getQuantidade() > 1)
                {
                    form1.mostrarmensagemTela("Compra feita com sucesso");
                    form1.alterarOBD(obj);
                }
                else
                {
                    form1.mostrarmensagemTela("Desculpa o produto esta em falta");
                }
               
                
            }
            else if(obj.getValor() > dinheiro)
            {
                int faltante=obj.getValor()-dinheiro;
                form1.mostrarmensagemTela("Esta faltando R$ "+ faltante);
            }
            else
            {
                int troco = dinheiro- obj.getValor();
                


                if (obj.getQuantidade() > 1)
                {
                    form1.mostrarmensagemTela("Compra feira seu troco e R$ " + troco);
                    form1.alterarOBD(obj);
                }
                else
                {
                    form1.mostrarmensagemTela("Desculpa o produto esta em falta");
                }

            }
        }

      

      


    }
}
