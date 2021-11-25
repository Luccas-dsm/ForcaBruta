/*using System;
using System.Collections.Generic;

namespace ForçaBruta
{
    class Program
    {
             /*
             Seja um conjunto M contendo n moedas (n >1), sendo que 
             (n−1) são idênticas (válidas) e uma é falsa. Suponha que
             as moedas válidas pesam 1g e a falsa pesa 0,5g. O problema
             consiste em detectar a moeda falsa no conjunto M.

             Escreva um algoritmo de divisão e conquista para determinar
             uma solução do problema.
             */

/* static double ForcaBruta(double[] moedas)
 {
     int pos =0;
     for (int i = 0; i<moedas.Length; i++)
     {
         if (moedas[i] == 0.5)
         {
             pos =i;
             break;
         }      
     }
     return pos;
 }

 static int DivisaoeConquista(int ini,int fim, double[]moeda)
 {
     int meio = ini + fim / 2;
     if (moeda[meio] == 0.5)
         return meio;
     else
     {
         fim = meio;
         return DivisaoeConquista(ini, fim, moeda);
     }
 }

 static void Main(string[] args)
 {
     double[] moedas = { 1, 1, 1, 1, 0.5, 1, 1 };
     //Console.WriteLine("a posicao da moeda falça é : " + ForcaBruta(moedas));
     Console.WriteLine("a posicao da moeda falça é : " + DivisaoeConquista(0,moedas.Length,moedas));
     Console.ReadLine();
 }
}
}*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace ForçaBruta
{
    class Program
    {




        /*
          int[]vet={ 10, 15, 20, 20, 30, 35, 40, 50 };

       public void entregaTroco()//faz o calculo do troco.
        {
            int x = 0;
            Console.WriteLine("Moedas no Caixa: R$100 , R$25, R$10, R$5, R$1"+ "\n");
            for (int i = 0;i<vet.Length;i++)
            {
                for (int j = 0;vet[i]!=0; j++)
                {
                    Console.Write("R${0},00 - moeda(R${1},00)", vet[i],valor(vet[i]));
                    vet[i]-= valor(vet[i]);
                    x = j;
                }

                Console.WriteLine();
                Console.WriteLine("{0}º loop gastou {1} moedas",i+1,x+1);
            }
        }
        int valor(int valor) // algoritmo guloso, verifica se o valor de entrada
                            // e maior que os valores prepostos
        {
            int val=0;
           
             if (100 <= valor) {val = 100; }
             else if (25 <= valor) { val = 25; }
             else if (10 <= valor) { val = 10; }
             else if (5 <= valor) { val = 5; }
             else if (1 <= valor) { val = 1; }
          
            return val;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Troco troco = new Troco();
            troco.entregaTroco();
            Console.ReadKey();
        }
    }*/

        static void Main(string[] args)
        {

            int[] itens = { 10, 15, 20, 20, 30, 35, 40, 50 };

            int capacidade = 90; //Capacidade do pendrive

            AlgoritmoGuloso(itens, capacidade);
            Console.ReadKey();
        }



       /* int valor(int valor) // algoritmo guloso, verifica se o valor de entrada
                             // e maior que os valores prepostos
        {
            int val = 0;

            if (50 <= valor) { val = 50; }
            else if (40 <= valor) { val = 40; }
            else if (35 <= valor) { val = 35; }
            else if (30 <= valor) { val = 30; }
            else if (20 <= valor) { val = 20; }

            return val;
        }*/



       static bool verifica( int[] itens)
        {
            bool verdadeiro = false;
            for (int i = 0; i < itens.Length; i++)
            {
                if (itens[i] != 0)
                    verdadeiro = true;
            }
            return verdadeiro;
        }
        static void AlgoritmoGuloso(int[] itens, int capacidade)
        {

            Array.Sort(itens); //Vetor ordenados



            while(verifica(itens)&&capacidade!=0)
            {

                for (int i = 0; i < itens.Length; i++)
                {
                    capacidade -= itens[i];
                    if (itens[i] < capacidade && itens[i]!=0);
                    {
                        
                           
                            Console.WriteLine("a capacidade que falta é {0} e o item retirado foi:{1}", capacidade, itens[i]);
                            itens[i] = 0;
                        
                    }
                }


            }





           /* for (int i = 0; i < itens.Length; i++)
            {
                
               if ()

                for (int j = 0; itens[i] != 0; j++)
                {
                    //Console.Write(", vet[i], valor(vet[i]));

                    capacidade -= itens[i];
                    Console.WriteLine("a capacidade que falta é {0} e o item retirado foi: " , capacidade,itens[i]);
                    itens[i] = 0;
                    if (capacidade == )
                        break;
                   
                }



                Console.WriteLine();
                //Console.WriteLine("{0}º loop gastou {1} moedas", i + 1, x + 1);
            }*/
        }
    }
}
