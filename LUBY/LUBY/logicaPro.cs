using System;

//Programa feito por Eric Azevedo de Olieira 
//Processo seletivo de .net LUBY
class LogicaPro
{

    public static void Main()
    {
        Mostraropcoes();
    }



    public static void CalcularFatorial(int numero)
    {
        int fatorial = 1;
        Console.Write(numero+"! =");
        for (; numero > 1; numero--)
        {
            fatorial = (fatorial * numero);
            
        }
        Console.WriteLine(fatorial);
    }

    public static void CalcularPremio(double valor , string tipo, int fator )
    {
        double calculo = 0;
        if(valor > 0) {
            if (tipo.Equals("basic"))
            {
                if (fator != null&& fator >0)
                {
                    calculo = valor*fator;
                }
                else
                {
                    calculo = valor;
                }
            }
            else if (tipo.Equals("vip"))
            {
                if (fator != null && fator > 0)
                {
                    calculo = valor * fator;
                }
                else
                {
                    calculo = valor * 1.2;
                }

            }
            else if (tipo.Equals("premium"))
            {
                if (fator != null && fator > 0)
                {
                    calculo = valor * fator;
                }
                else
                {
                    calculo = valor * 1.5;
                }

            }
            else if (tipo.Equals("deluxe"))
            {
                if (fator != null && fator > 0)
                {
                    calculo = valor * fator;
                }
                else
                {
                    calculo = valor * 1.8;
                }
            }
            else
            {
                if (fator != null && fator > 0)
                {
                    calculo = valor * fator;
                }
                else
                {
                    calculo = valor * 2;
                }

            }

            Console.WriteLine("O calculo do premio"+tipo+" = "+calculo);
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Valor nao permitido");
            Console.WriteLine("");
        }
    }

    public static void ContarNumerosPrimos(int numero)
    {
        int quantidadePrimos = 0;
        while (numero!=0)
        {
            int contador = 0;
            for(int i = numero; i > 0; i--)
            {
                if(numero % i == 0)
                {
                    contador++;
                }
            }
            if (contador == 2)
            {
                quantidadePrimos++;
            }
            numero--;
        }
        Console.WriteLine("A quantidade de numero primos e = "+quantidadePrimos);

        
    }

    public static void CalcularVogais(string frase)
    {
        int quantidade = 0;
        for (int i = 0; i < frase.Length; i++)
        {
            if ((frase[i] == 'a') || (frase[i] == 'A') || (frase[i] == 'i') || (frase[i] == 'I') || (frase[i] == 'e') || (frase[i] == 'E') ||
                (frase[i] == 'o') || (frase[i] == 'O') || (frase[i] == 'u')|| (frase[i] == 'U'))
             {
                quantidade++;
             }
        }
        Console.WriteLine("A quantidade de vogais e == " + quantidade);
    }

    public static void CalcularValorComDescontoFormatado(ref string valor , string desconto)
    {
        string descontoLimpo = "";
        for (int i = 0; i < desconto.Length; i++)
        {
            if(desconto[i] != '%')
            {
                descontoLimpo += desconto[i];
            }
        }
       // Console.WriteLine(descontoLimpo);
        string valorLimpo = "";

        for (int i = 0; i < valor.Length; i++)
        {
            if(valor[i]!='R' && valor[i]!='$')
            {
               
               
                    valorLimpo += valor[i];
                
               
            }
        }
        
        Console.WriteLine(valorLimpo.Trim());

        double valorT=Double.Parse(valorLimpo);
        double porcentagem=Double.Parse(descontoLimpo);
        double descontoTotal = valorT - ((porcentagem / 100) * valorT);
        string tratarParaMostrar = descontoTotal.ToString();
        string mostrarNaTela = "";
        if (tratarParaMostrar.Length > 3)
        {
            mostrarNaTela += "R$";
            for (int i =0; i< tratarParaMostrar.Length; i++) 
            {
                mostrarNaTela += tratarParaMostrar[i];
                if (i<1)
                {
                    mostrarNaTela += '.';
                }
            }
        }
        else
        {
            mostrarNaTela += "R$";
            mostrarNaTela += tratarParaMostrar;
        }
        Console.WriteLine("O Valor total com o desconto sera  =" + mostrarNaTela );
       
        

    }


    public static void CalcularDiferencaData(string data1 , string data2)
    {
        
        string dataReformada1="";
        string dataReformada2= "";

        int contador=0;
        for(int i = 0; i < data1.Length; i++)
        {
           
            if (i%2==0 && contador != 2 &&i!=0)
          {
                dataReformada1 += "/";
                dataReformada2 += "/";
                contador++;

          }
            dataReformada1 += data1[i];
            dataReformada2 += data2[i];

        }
        //Console.WriteLine(dataReformada1);
       // Console.WriteLine(dataReformada2);

        int totalDias = (DateTime.Parse(dataReformada2).Subtract(DateTime.Parse(dataReformada1))).Days;

        Console.WriteLine("A diferenca entra as duas datas sao = " + totalDias);
    }


    public static int[] ObterElementosPares(int[] vetor)
    {
        int contador = 0;
        int variavel = 0;
        for(int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 == 0)
            {
                contador++;
            }
        }
        int[] vetorPares = new int[contador];
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 == 0)
            {
                vetorPares[variavel]=vetor[i];
                variavel++;
            
            }
        }
        return vetorPares;
    }


    public static void BuscarPessoa(string[] vector , string nome)
    {
        int contador = 0;
        int variavel = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i].Contains(nome))
            {
                contador++;
            }
        }
        string [] vetorNovo=new string[contador];
        if (contador != 0)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i].Contains(nome))
                {
                    vetorNovo[variavel++]+=vector[i];
                }
            }
            Console.Write("Esse nome existe em = { ");
            for (int i = 0; i < vetorNovo.Length; i++)
            {
                Console.Write(vetorNovo[i]+" ");
            }
            Console.Write(" }\n");
        }
        else
        {
            Console.WriteLine("Nao existe ninguem com esse nome");
        }
    }

    public static void TransformarEmMatriz(string vetor)
    {
        int contador = 0;
        string [] semVirgula = new string[6];
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] != ',')
            {
                semVirgula[contador]+=vetor[i];
                contador++;
            }
        }
      // Console.WriteLine(semVirgula);
        contador = contador / 2;
        int [,] matrix = new int[contador,2];
        int passagem = 0;
        for (int i = 0; i < contador; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                matrix[i, j] = Int32.Parse(semVirgula[passagem]);
                passagem++;
            }
        }

        for (int i = 0; i < contador; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matrix[i,j]+"\t");
            }
            Console.WriteLine("");
        }
    }


    public static void ObterElementosFaltantes(int[] vetor1, int[] vetor2)
    {
        int contador = 0;
        if (vetor1.Length >= vetor2.Length)
        {
            for (int i = 0; i < vetor1.Length; i++)
            {
                bool saber = false;
                for (int z = 0; z < vetor2.Length; z++)
                {
                    if (vetor1[i].Equals(vetor2[z]))
                    {
                        saber = true;
                    }
                }

                if (saber == false)
                {
                    contador++;
                }

            }
            int[] final = new int[contador];


            for (int i = 0; i < vetor2.Length; i++)
            {

                for (int z = 0; z < vetor1.Length; z++)
                {
                    if (vetor2[i].Equals(vetor1[z]))
                    {
                        vetor2[i] = 0;
                        vetor1[z] = 0;
                    }
                }
            }
            int saberQuantidade = 0;
            for (int i = 0; i < vetor2.Length; i++)
            {

                if (vetor2[i] != 0)
                {
                    final[saberQuantidade] = vetor2[i];
                    saberQuantidade++;
                }


            }

            for (int z = 0; z < vetor1.Length; z++)
            {

                if (vetor1[z] != 0)
                {
                    final[saberQuantidade] = vetor1[z];
                    saberQuantidade++;
                }
            }


            for (int i = 0; i < final.Length; i++)
            {
                Console.Write(final[i]+" ");
            }
        }
        else
        {
            for (int i = 0; i < vetor2.Length; i++)
            {
                bool saber = false;
                for (int z = 0; z < vetor1.Length; z++)
                {
                    if (vetor2[i].Equals(vetor1[z]))
                    {
                        saber = true;
                    }
                }

                if (saber == false)
                {
                    contador++;
                }

            }

            int[] final = new int[contador];

            for (int i = 0; i < vetor2.Length; i++)
            {

                for (int z = 0; z < vetor1.Length; z++)
                {
                    if (vetor2[i].Equals(vetor1[z]))
                    {
                        vetor2[i] = 0;
                        vetor1[z] = 0;
                    }
                }
            }
            int saberQuantidade = 0;
            for (int i = 0; i < vetor2.Length; i++)
            {

                if (vetor2[i] != 0)
                {
                    final[saberQuantidade] = vetor2[i];
                    saberQuantidade++;
                }


            }

            for (int z = 0; z < vetor1.Length; z++)
            {

                if (vetor1[z] != 0)
                {
                    final[saberQuantidade] = vetor2[z];
                    saberQuantidade++;
                }
            }

            for (int i = 0; i < final.Length; i++)
            {
                Console.Write(final[i]+" ");
            }



        }
        


    }

    public static void Mostraropcoes()
    {
        int parar = 0;
        do
        {
           //
            Console.WriteLine("\nLogica de Programacao");
            Console.WriteLine("1- Calcular Fatorial");
            Console.WriteLine("2-Calcular o valor total do Premio");
            Console.WriteLine("3-Contar os numeros primos");
            Console.WriteLine("4-Contar a quantidade de vogais dentro da String");
            Console.WriteLine("5-Aplicar uma porcentagem de desconto");
            Console.WriteLine("6-Ordenar e calcular a diferenca de duas datas");
            Console.WriteLine("7-Retornar vetor com todos os elementos pares");
            Console.WriteLine("8-Nuscar elementos que contem o valor informado");
            Console.WriteLine("9-Array de array");
            Console.WriteLine("10-Comparacao de vetores e criar um novo com elementos faltantes");
            Console.WriteLine("0-Sair");
            Console.WriteLine("Gostaria de ver qual exercicio? ");
            parar = Convert.ToInt32(Console.ReadLine());
            switch (parar)
            {
                case 0:
                    Console.WriteLine("Fim do Programa");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Gostaria de calcular que fatorial? ");
                    CalcularFatorial(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Qual o valor do Premio?  ");
                    double valorPremio=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Qual o tipo de Premio ");
                    string tipo=Console.ReadLine();
                    Console.WriteLine("Algum fator para o calculo? Se nao coloque 0");
                    CalcularPremio(valorPremio,tipo,Convert.ToInt32(Console.ReadLine()));
                    break;


                case 3:
                    Console.Clear();
                    Console.WriteLine("Numero para verificar ");
                    ContarNumerosPrimos(Convert.ToInt32(Console.ReadLine()));

                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("String para ser verificada ");
                    CalcularVogais(Console.ReadLine());

                    break;

                case 5:
                    Console.Clear();
                    string teste = "R$ 6.800,00";
                    CalcularValorComDescontoFormatado(ref teste, "30%");

                    break;


                case 6:
                    Console.Clear();
                    CalcularDiferencaData("10122020", "25122020");
                    break;

                case 7:
                    Console.Clear();
                    int[] vetor = new int[] { 1, 2, 3, 4, 5 };
                    int [] vetorPar = ObterElementosPares(vetor);
                    Console.Write("Os valores pares do vetor sao = {");
                    for (int i = 0; i < vetorPar.Length; i++)
                    {
                        Console.Write(vetorPar[i] + " ");
                    }
                    Console.WriteLine("}");

                    break;



                case 8:
                    Console.Clear();
                    string[] vetorString = new string[] { "John Doe", "Jane Doe", "Alice Jones", "Bobby Louis", "Lisa Romero" };
                    BuscarPessoa(vetorString, "Doe");
                    BuscarPessoa(vetorString, "Alice");
                    BuscarPessoa(vetorString, "James");
                    break;





                case 9:
                    Console.Clear();
                    TransformarEmMatriz("1,2,3,4,5,6");
                    break;

                case 10:
                    Console.Clear();
                    int[] vetor1 = new int[] { 1, 2, 3,4,5 };
                    int[] vetor2 = new int[] { 1, 2, 3 };
                    ObterElementosFaltantes(vetor1, vetor2);
                    break;

            }
        } while (parar != 0);
       
    }
}
