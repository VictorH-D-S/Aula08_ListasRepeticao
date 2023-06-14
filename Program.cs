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

            List<string> nomes = new List<string>();

            nomes.Add("Corando Salamanca");
            nomes.Add("Conrado Fring");
            nomes.Add("Conrado White");
            nomes.RemoveAt(0);
            //nomes.RemoveAt(X) -> Remove itens de uma lista na posição especificada
            Console.WriteLine($"Primeiro nome: {nomes[0]}");
            Console.WriteLine($"Segundo nome: {nomes[1]}");
            //Console.WriteLine($"Terceito nome: {nomes[2]}");

            int quant = nomes.Count;
            Console.WriteLine($"Os nomes são dog = {quant}");
            
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
    }
}
