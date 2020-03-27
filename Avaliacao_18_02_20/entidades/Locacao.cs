using System;
using System.Collections.Generic;

namespace Entidades
{
    class Locacao
    {
        public int idLocacao { get; set; }
        public Cliente cliente;
        public DateTime dataLocacao = DateTime.Now;
        List<Filme> filmes = new List<Filme>();
        public Locacao(int idLocacao, Cliente cliente)
        {
            this.idLocacao = idLocacao;
            this.cliente = cliente;
        }
        //Mostra os dados da locação
        public void DadosLocacao()
        {

            Console.WriteLine("###Locações feitas###");
            Console.WriteLine("ID locação " + this.idLocacao);
            Console.WriteLine("Data da locação: " + this.dataLocacao.ToString("dd/MM/yyyy"));
            Console.WriteLine("Data da devolução: " + DevolverFilme());
            Console.WriteLine("Dias locados: " + cliente.diasDevolucao);
            Console.WriteLine("Quantidade de filmes locados: " + QtdFilmeLocados());
            Console.WriteLine();
            Console.WriteLine("###Filmes###");
            MostrarFilme();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Total a pagar: R$ " + ValorTotal().ToString("F"));
        }
        //Adiciona um filme
        public void AdicionarFilme(Filme filme)
        {
            filmes.Add(filme);
        }
        //Mostra dados breve do(s) filme(s) locado(s)
        public void MostrarFilme()
        {
            System.Text.StringBuilder txt = new System.Text.StringBuilder();
            foreach (Filme filme in filmes)
            {
                Console.WriteLine(filme.nomeFilme + ", R$ " + filme.valorLocacao.ToString("F"));
            }
        }
        //Mostra quantidade de filmes locados 
        public int QtdFilmeLocados()
        {
            return this.filmes.Count;
        }
        //Calcula data de devolução
        public String DevolverFilme()
        {

            DateTime data = DateTime.Now;
            return data.AddDays(cliente.diasDevolucao).ToString("dd/MM/yyyy");
        }
        //Calcula valor total do(s) filme(s) locado(s)
        public float ValorTotal()
        {
            float valorTotal = 0;
            foreach (Filme filme in filmes)
            {
                valorTotal += filme.valorLocacao;
            }
            return valorTotal;
        }
        public DateTime GSDataLocacao
        {
            get => dataLocacao;
            set => dataLocacao = value;
        }
    }
}