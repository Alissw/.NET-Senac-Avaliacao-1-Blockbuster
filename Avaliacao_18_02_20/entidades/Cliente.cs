using System;

namespace Entidades
{
    class Cliente
    {
        public int idCliente { get; set; }// Background
        public String nomeCliente { get; set; }
        public String dataNascimento { get; set; }
        public String cpf { get; set; }
        public int diasDevolucao { get; set; }

        public Cliente(int idCliente, String nomeCliente, String dataNascimento, String cpf, int diasDevolucao)
        {
            this.idCliente = idCliente;
            this.nomeCliente = nomeCliente;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.diasDevolucao = diasDevolucao;
        }

        public void DadosCliente()
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
    }
}