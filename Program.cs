using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_ListasRepeticao
{
    class Program
    {

        
        static void Main(string[] args)
        {
            List<string> nome = new List<String>();
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");
            nome.Add("Miltom");

            int contador = 0;
                while (contador < nome.Count)
            {
                Console.WriteLine($"O nome é {nome[contador]}");
                contador++;
            }


            Console.ReadKey();
        }
        void RepeticaoWhile()
        {
            //repetições (loop)

            double contador = 0;

            while (contador < 15)
            {
                Console.WriteLine($"Radovid chupa pau mole.");
                //Para acumular valores em uma variável
                contador = contador + 1; // repete o valor que tinha antes + o novo
                contador += 1; // acrescenta um valor na variável que já existe
                contador++; // adiciona 1, mas apenas 
             
                // Também é possível usar outros operadores matemáticos ANTES do igual
                contador = contador / 2;
                contador /= 2;
                contador -= 2;
                contador *= 2;
            }


            Console.ReadKey();
        }
   
        void ARREIZ()
        {
            
            string[] nomez = new string[3];
            int[] salamanca = { 3, 4, 5, 6, 7 };

            nomez[0] = "";
            nomez[1] = "Victor";
            nomez[2] = "Victor";
            Console.WriteLine("BOTA O NOME");
            nomez[0] = Console.ReadLine();

            Console.WriteLine($"{nomez[0]}, {nomez[1]}, {nomez[2]}");

            Console.ReadKey();
        }

        void LISTAS()
        {
            List<string> nomes = new List<string>();

            nomes.Add("Corando Salamanca");
            nomes.Add("Conrado Fring");
            nomes.Add("Conrado White");
            nomes.RemoveAt(0);
            //nomes.RemoveAt(X) -> Remove e reorganiza itens de uma lista na posição especificada
            Console.WriteLine($"Primeiro nome: {nomes[0]}");
            Console.WriteLine($"Segundo nome: {nomes[1]}");
            //Console.WriteLine($"Terceito nome: {nomes[2]}");

            int quant = nomes.Count;
            Console.WriteLine($"Os nomes são dog = {quant}");
            
            Console.ReadKey();

        }
    }
}
