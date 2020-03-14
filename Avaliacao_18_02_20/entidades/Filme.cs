using System;

namespace Entidades
{
    class Filme
    {
       private int idFilme;
       private String nomeFilme;
       private String dataLancamento;
       private String sinopse;
       private float valorLocacao;
       private int estoque;
       private int qtdLocado;

        public Filme(int idFilme, String nomeFilme, String dataLancamento, String sinopse, float valorLocacao, int estoque, int qtdLocado)
        {
            this.idFilme = idFilme;
            this.nomeFilme = nomeFilme;
            this.dataLancamento = dataLancamento;
            this.sinopse = sinopse;
            this.valorLocacao = valorLocacao;
            this.estoque = estoque;
            this.qtdLocado = 0;
        }
        //Controla a quantidade em estoque
        public void filmeLocado()
        {
            this.estoque -= 1;
            this.qtdLocado += 1;
        }

        // Getter e Setter do idCliente

        public int GSIdFilme
        {
            get => idFilme;
            set => idFilme = value;
        }
        public String GSNomeFilme
        {
            get => nomeFilme;
            set => nomeFilme = value;
        }

        // Getter e Setter do idCliente
        public String GSDataLancamento
        {
            get => dataLancamento;
            set => dataLancamento = value;
        }
        public String GSSinopse
        {
            get => sinopse;
            set => sinopse = value;
        }
        public float GSvalorLocacao
        {
            get => valorLocacao;
            set => valorLocacao = value;
        }
        public int GSEstoque
        {
            get => estoque;
            set => estoque = value;
        }
        public int GSQtdLocado
        {
            get => qtdLocado;
            set => qtdLocado = value;
        }
    }
}