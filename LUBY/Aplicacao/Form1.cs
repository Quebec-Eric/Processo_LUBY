using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacao;

namespace Aplicacao
    
{
    public partial class Form1 : Form
    {
        SqlDataAdapter da;
        SqlDataReader dr;
        Bebidas bebidas = new Bebidas();
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-C3CIN40\SQLEXPRESS;Initial Catalog=Maquina;Integrated Security=True");

        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

         private  void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
          
               MessageBox.Show("Bem Vindo a nossa Maquina de bebidas!!\n\n " + "Hoje Temos essas Bebidas" + "\n 1) Coca-Cola" + " \n 2) Dolly" + "\n 3) Suco de Uva" + " \n 4) Guarana" +
           "\n 5) Parte adiministrativa " + "\n Qual gostaria ? Digite o nomero correspondendo ou 0 para finaliza, \n Na caaixa de testo abaixo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int opcao = Int32.Parse(textBox1.Text);
            if (opcao == 0)
            {
                MessageBox.Show("Obrigado volte sempre");
            }
            else if (opcao == 5)
            {
                Bebidas adm=new Bebidas();
              

                string sql = "SELECT * FROM estoque";
                string testeSupremo = "";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();

                dr = comando.ExecuteReader();
                int ContabilidadeTotal = 0;

                for (int i = 0; i < 4; i=i+1)
                {

                    while (dr.Read())
                    {
                        testeSupremo=(Convert.ToString(dr["nome"]));
                        adm.setNome( testeSupremo);
                        adm.setValor(Convert.ToInt32(dr["valor"]));
                        adm.setQuantidade(Convert.ToInt32(dr["quantidade"]));
                        adm.setcontabilidade(Convert.ToInt32(dr["contabilidade"]));

                        ContabilidadeTotal+=adm.getContabilidade()*adm.getValor();

                        MessageBox.Show("A bebida: " + adm.getNome() + " teve o total ["
                        +adm.getContabilidade() + "] Vendas  \n\n Ainda sobrando em estoque "+adm.getQuantidade());


                    }
                   
                }
                

                MessageBox.Show("A Contabilidade total foi de R$" + ContabilidadeTotal+".00");
                


            }
            else
            {
                string sql = "SELECT * FROM estoque WHERE id="+opcao;
                
                SqlCommand comando = new SqlCommand(sql, conexao);
                
                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    bebidas.setNome( (string)dr["nome"]);
                    bebidas.setValor(Convert.ToInt32(dr["valor"]));
                    bebidas.setQuantidade(Convert.ToInt32(dr["quantidade"]));
                    bebidas.setcontabilidade(Convert.ToInt32(dr["contabilidade"]));

                    
                }
                DialogResult comprarOuNao= new DialogResult();
               comprarOuNao= MessageBox.Show(opcao+") "+bebidas.getNome()+"\n"+
                    "R$ " + bebidas.getValor() +"\n\n"+ "Gostaria de comprar??","",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(comprarOuNao == DialogResult.OK)
                {
                    
                    mostrarmensagemTela("Coloque o valor na caixa de texto e Aperte comprar");
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Finalizando a compra");
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void mostrarmensagemTela(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void alterarOBD(Bebidas obj) 
        {
            try
            {
                conexao.Open();
                int quantidadeNova = obj.getQuantidade() - 1;
                int contabilidadeNova = obj.getContabilidade() + 1;
                SqlCommand comando1 = new SqlCommand("UPDATE estoque set quantidade =" + quantidadeNova + ",contabilidade=" + contabilidadeNova + " WHERE   id=1", conexao);
                comando1.ExecuteNonQuery();

              
                conexao.Close();


                MessageBox.Show("Obrigado por comprar , volte sempre");
            }
            catch (Exception ex)
            {
                
            }   
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Maquina maquina = new Maquina();
            int valor = Int32.Parse(textBox1.Text);
            maquina.venderProduto(bebidas,valor);
        }

        


    }

   
}