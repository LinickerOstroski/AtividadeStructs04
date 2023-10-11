using System;

class Program
{

    struct jogo
    {
        public string titulo;
        public string console;
        public int ano;
        public int ranking;
    }

    struct emprestimo
    {
        public int dataEmprestimo;
        public string nomePessoaEmprestimo;
        public char emprestado;
    }

    static void Cadastrar(List<jogo> lista)
    {
        jogo novoJogo = new jogo();

        Console.WriteLine("Qual o título do jogo:");
        novoJogo.titulo = Console.ReadLine();
        Console.WriteLine("Qual o console:");
        novoJogo.console = Console.ReadLine();
        Console.WriteLine("Qual o ano:");
        novoJogo.ano = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual o ranking:");
        novoJogo.ranking = Convert.ToInt32(Console.ReadLine());
    }
    static void Main()
    {
        List<jogo> lista = new List<jogo>();
    }

}