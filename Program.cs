using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_ListasRepeticao
{
    class Program
    {
        static List<string> nomes = new List<string>();
        static int posicao;
        static int quant = nomes.Count;
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bem vindo ao sistema de usuários.\n======================");
            Console.WriteLine("Escolha o que deseja fazer:\n1- Cadastrar novo usuário\n2- Buscar usuário existente.");
            string opcao = Console.ReadLine();
            if (opcao == "1")
            {
                Console.WriteLine("Digite o novo cadastro:  ");
                nomes.Add(Console.ReadLine());
                Console.WriteLine("==========Nome Cadastrado com Sucesso!==========");
                Console.ReadKey();
                Console.Clear();
                Main(args);
                return;

            }
            if(opcao == "2")
            {

                Console.WriteLine("Insira a posição em que deseja buscar: ");
                posicao = int.Parse(Console.ReadLine());
                Console.WriteLine($"Nome: {nomes[posicao]}");

                if ()
                {

                }

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
