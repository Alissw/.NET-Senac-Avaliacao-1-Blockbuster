using System;

namespace Entidades
{
    class Cliente
    {
        private int idCliente; // Background
        private String nomeCliente;
        private String dataNascimento;
        private String cpf;
        private int diasDevolucao;

        public Cliente(int idCliente, String nomeCliente, String dataNascimento, String cpf, int diasDevolucao)
        {
            this.idCliente = idCliente;
            this.nomeCliente = nomeCliente;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.diasDevolucao = diasDevolucao;
        }

        public void dadosCliente()
        {
            Console.WriteLine("###Dados do cliente###");
            Console.WriteLine("ID do cliente: " + this.idCliente);
            Console.WriteLine("Nome............: " + this.nomeCliente);
            Console.WriteLine("Nascido em......: " + this.dataNascimento);
            Console.WriteLine("CPF.............: " + this.cpf);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();
        }

        // Getter e Setter do idCliente
        public int GSIdCliente
        {
            get => idCliente;
            set => idCliente = value;
        }

        // Getter e Setter do idCliente
        public String GSNomeCliente
        {
            get => nomeCliente;
            set => nomeCliente = value;
        }
        public String GSDataNacimento
        {
            get => dataNascimento;
            set => dataNascimento = value;
        }
        public String GCpf
        {
            get => cpf;
        }
        public int GSDiaDevolucao
        {
            get => diasDevolucao;
            set => diasDevolucao = value;
        }
    }
}