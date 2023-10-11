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
        public string tituloJogo;
        public int dataEmprestimo;
        public string nomePessoaEmprestimo;
        public char emprestado;
    }

    static void listarJogos(List<jogo> lista)
    {

        foreach(jogo j in lista)
        {
            Console.WriteLine("Nome do jogo:" + j.titulo);
            Console.WriteLine("Console:" + j.console);
            Console.WriteLine("Ano de lançamento:" + j.ano);
            Console.WriteLine("Ranking:" + j.ranking);
        }

    }

    static void listarEmprestimo(List<emprestimo> lista)
    {
        foreach (emprestimo m in lista)
        {
            Console.WriteLine("Nome do jogo:" + m.tituloJogo);
            Console.WriteLine("Data do empréstimo:" + m.dataEmprestimo);
            Console.WriteLine("Nome da pessoa:" + m.nomePessoaEmprestimo);
            Console.WriteLine("Emprestado? " + m.emprestado);
        }
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

    static void Emprestimo(List<jogo> lista, List<emprestimo> listaEmp)
    {
        Console.WriteLine("Qual jogo deseja realizar empréstimo?");
        string nomeBusca = Console.ReadLine();
        char confirma;
        int qtd = lista.Count();
        emprestimo emp = new emprestimo();

        for (int i = 0;i<qtd; i++)
        {
            if (lista[i].titulo.ToUpper().Contains(nomeBusca.ToUpper()))
            {
                Console.WriteLine($"Deseja mesmo realizar emprestimo de {nomeBusca}? S/N");
                confirma = Convert.ToChar(Console.ReadLine());

                if(confirma == 's' || confirma == 'S')
                {
                    Console.WriteLine("Qual a data do emprestimo:");
                    emp.dataEmprestimo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Qual o nome da pessoa:");
                    emp.nomePessoaEmprestimo = Console.ReadLine();
                    emp.emprestado = 'S';
                    Console.WriteLine($"Emprestimo de {nomeBusca} realizado com sucesso!");
                    emp.tituloJogo = nomeBusca;

                    listaEmp.Add(emp);
                }
                
                else if(confirma == 'n' || confirma == 'N')
                {
                    Console.WriteLine("Operação cancelada.");
                }

                else
                {
                    Console.WriteLine("Operação cancelada.");
                }
                

            }
        }
    }

    static int Menu()
    {
        int op;

        Console.WriteLine("1 - Cadastrar");
        Console.WriteLine("2 - Listar");
        Console.WriteLine("3 - Realizar emprestimo");
        Console.WriteLine("4 - Listar Emprestimos");
        Console.WriteLine("5 - Procurar por título");
        Console.WriteLine("6 - Listar todos os jogos de um console");

        op = Convert.ToInt32(Console.ReadLine());
        return op;
    }
    static void Main()
    {
        List<jogo> lista = new List<jogo>();
        List<emprestimo> listaEmprestimo = new List<emprestimo>();

        bool programa = true;
        int operador;
        do
        {
            operador = Menu();
            switch (operador)
            {
                case 1:
                    Cadastrar(lista);
                    break;
                case 2:
                    listarJogos(lista);
                    break;
                case 3:
                    Emprestimo(lista, listaEmprestimo);
                    break;
                case 4:
                    listarEmprestimo(listaEmprestimo);
                    break;
            }

            Console.ReadKey();
            Console.Clear();

        } while (programa);

    }

}