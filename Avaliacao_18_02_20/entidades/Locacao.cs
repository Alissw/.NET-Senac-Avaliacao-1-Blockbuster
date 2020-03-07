using System;
using System.Collections.Generic;

namespace Entidades
{
    class Locacao
    {
        private int idLocacao;
        Cliente cliente;
        private DateTime dataLocacao = DateTime.Now;
        List<Filme> filmes = new List<Filme>();
        public Locacao(int idLocacao, Cliente cliente)
        {
            this.idLocacao = idLocacao;
            this.cliente = cliente;
        }
        //Mostra os dados da locação
        public void dadosLocacao()
        {

            Console.WriteLine("###Locações feitas###");
            Console.WriteLine("ID locação " + this.idLocacao);
            Console.WriteLine("Data da locação: " + this.dataLocacao.ToString("dd/MM/yyyy"));
            Console.WriteLine("Data da devolução: " + Devolver());
            Console.WriteLine("Dias locados: " + cliente.GSDiaDevolucao);
            Console.WriteLine("Quantidade de filmes locados: " + QtdFilmeLocados());
            Console.WriteLine();
            Console.WriteLine("###Filmes###");
            mostrarFilme();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Total a pagar: R$ " + valorTotal().ToString("F"));
        }
        //Adiciona um filme
        public void addFilme(Filme filme)
        {
            filmes.Add(filme);
        }
        //Mostra dados breve do(s) filme(s) locado(s)
        public void mostrarFilme()
        {
            System.Text.StringBuilder txt = new System.Text.StringBuilder();
            foreach (Filme filme in filmes)
            {
                Console.WriteLine(filme.GSNomeFilme + ", R$ " + filme.GSvalorLocacao.ToString("F"));
            }
        }
       //Mostra quantidade de filmes locados 
        public int QtdFilmeLocados()
        {
            return this.filmes.Count;
        }
        //Calcula data de devolução
        public String Devolver()
        {

            DateTime data = DateTime.Now;
            return data.AddDays(cliente.GSDiaDevolucao).ToString("dd/MM/yyyy");
        }
        //Calcula valor total do(s) filme(s) locado(s)
        public float valorTotal()
        {
            float valorTotal = 0;
            foreach (Filme filme in filmes)
            {
                valorTotal += filme.GSvalorLocacao;
            }
            return valorTotal;
        }

        public int GSIdLocacao
        {
            get => idLocacao;
            set => idLocacao = value;
        }
        public DateTime GSDataLocacao
        {
            get => dataLocacao;
            set => dataLocacao = value;
        }
    }
}