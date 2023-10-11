using System;

class Program
{

    struct jogo
    {
        public string titulo;
        public string console;
        public int ano;
        public int ranking;
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

        lista.Add(novoJogo);
        Console.WriteLine("Jogo cadastrado com sucesso!");
    }

    static void Emprestimo(List<jogo> lista)
    {
        Console.WriteLine("Qual jogo deseja realizar empréstimo?");
        string nomeBusca = Console.ReadLine();
        char confirma;
        int qtd = lista.Count();
        jogo emprestimo = new jogo();

        for (int i = 0;i<qtd; i++)
        {
            if (lista[i].titulo.ToUpper().Contains(nomeBusca.ToUpper()))
            {
                Console.WriteLine($"Deseja mesmo realizar emprestimo de {nomeBusca}? S/N");
                confirma = Convert.ToChar(Console.ReadLine());

                if(confirma == 's' || confirma == 'S')
                {
                    Console.WriteLine("Qual a data do emprestimo:");
                    emprestimo.dataEmprestimo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Qual o nome da pessoa:");
                    emprestimo.nomePessoaEmprestimo = Console.ReadLine();
                    emprestimo.emprestado = 'S';
                }
                else
                {
                    Console.WriteLine("Operação cancelada");
                    emprestimo.emprestado = 'N';
                }
                

            }
        }
    }
    static void Main()
    {
        List<jogo> lista = new List<jogo>();



    }

}