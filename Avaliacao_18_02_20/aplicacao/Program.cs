using System;
using Entidades;

namespace Avaliação
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente[] clientes = new Cliente[3];
            Filme[] filmes = new Filme[4];
            Locacao[] locacaos = new Locacao[4];
            int opc = 0;

            clientes[0] = new Cliente(1, "Gustavo Delatis", "09/02/1993", "111.222.333-44", 8);
            clientes[1] = new Cliente(2, "Felipe Horbes", "14/08/1988", "055.432.563-09", 5);
            clientes[2] = new Cliente(3, "James Broken", "25/05/1988", "055.432.563-09", 10);

            filmes[0] = new Filme(1, "Velozes e furiosos", "22/06/2001", "Policial infiltrado blablablabla", 15.00f, 5, 2);
            filmes[1] = new Filme(2, "Bad Boys para sempre", "30/01/2020", "Os policiais Mike Lowery e Marcus Burnett se juntam para derrubar o líder...", 25.50f, 6, 1);
            filmes[2] = new Filme(3, "Desconhecido", "25/02/2011", "Depois de um acidente de carro em Berlim, o médico Martin Harris acorda do coma num mundo em caos: sua esposa não o reconhece, outro homem assumiu sua identidade e assassinos misteriosos o perseguem...", 18f, 10, 3);
            filmes[3] = new Filme(4, "O acordo", "19/04/2013", "Aos 18 anos de idade, Jason é condenado a dez anos de prisão por posse de um pacote de drogas...", 10f, 1, 1);

            //Locações do cliente 1
            locacaos[0] = new Locacao(1, clientes[0]);
            locacaos[0].AdicionarFilme(filmes[0]);
            locacaos[0].AdicionarFilme(filmes[1]);

            //Locações do cliente 2
            locacaos[1] = new Locacao(2, clientes[1]);
            locacaos[1].AdicionarFilme(filmes[3]);
            locacaos[1].AdicionarFilme(filmes[2]);
            locacaos[1].AdicionarFilme(filmes[1]);

            //Locações do cliente 3 
            locacaos[2] = new Locacao(3, clientes[2]);
            locacaos[2].AdicionarFilme(filmes[0]);
            locacaos[2].AdicionarFilme(filmes[3]);
            locacaos[2].AdicionarFilme(filmes[1]);
            locacaos[2].AdicionarFilme(filmes[2]);

            do
            {
                Console.WriteLine("Clientes que fizeram locações");
                Console.WriteLine("[1]" + clientes[0].nomeCliente);
                Console.WriteLine("[2]" + clientes[1].nomeCliente);
                Console.WriteLine("[3]" + clientes[2].nomeCliente);
                Console.WriteLine("[4] Sair do sistema");
                Console.Write("Qual cliente você deseja pesquisar: ");
                opc = Convert.ToInt16(Console.ReadLine());
                Console.Clear();

                switch (opc)
                {
                    case 1:
                        clientes[0].DadosCliente();
                        locacaos[0].DadosLocacao();
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 2:
                        clientes[1].DadosCliente();
                        locacaos[1].DadosLocacao();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        clientes[2].DadosCliente();
                        locacaos[2].DadosLocacao();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opc != 4);
        }
    }
}
