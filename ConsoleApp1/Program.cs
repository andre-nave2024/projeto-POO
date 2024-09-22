class Program
{
    static ConsoleKeyInfo opcao = new ConsoleKeyInfo();
    static BancoDeDados banco = new BancoDeDados();

    static void Main()
    {

        while (opcao.Key != ConsoleKey.Escape)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo(a)!");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Gerenciar Pessoas");
            Console.WriteLine("2 - Gerenciar Biblioteca");
            Console.WriteLine("ESC - Sair");

            opcao = Console.ReadKey();

            if (opcao.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar Pessoa");
                Console.WriteLine("2 - Remover Pessoa");
                Console.WriteLine("3 - Listar Pessoas");
                Console.WriteLine("4 - Voltar");

                opcao = Console.ReadKey();

                switch (opcao.Key)
                {
                    case ConsoleKey.D1:
                        AdicionarPessoa();
                        break;

                    case ConsoleKey.D2:
                        RemoverPessoa();
                        break;

                    case ConsoleKey.D3:
                        banco.ListarPessoas();
                        Console.ReadKey();
                        break;
                }
            }
            else if (opcao.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar Livro");
                Console.WriteLine("2 - Remover Livro");
                Console.WriteLine("3 - Listar Livros");
                Console.WriteLine("4 - Pegar Livro emprestado");
                Console.WriteLine("5 - Devolver Livro");
                Console.WriteLine("6 - Voltar");

                opcao = Console.ReadKey();

                switch (opcao.Key)
                {
                    case ConsoleKey.D1:
                        AdicionarLivros();
                        break;

                    case ConsoleKey.D2:
                        RemoverLivros();
                        break;

                    case ConsoleKey.D3:
                        banco.ListarLivros();
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D4:
                        EmprestarLivro();
                        break;

                    case ConsoleKey.D5:
                        DevolverLivro();
                        break;
                }

            }
        }
    }

    static void AdicionarPessoa()
    {
        Console.Clear();
        Console.WriteLine("Digite o nome da Pessoa:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o CPF:");
        string cpf = Console.ReadLine();
        Console.WriteLine("Digite a idade:");
        int idade = int.Parse(Console.ReadLine());

        Pessoa pessoa = new Pessoa(nome, cpf, idade);
        banco.SalvarPessoa(pessoa);
    }

    static void RemoverPessoa()
    {
        Console.Clear();
        Console.WriteLine("Digite o cpf da pessoa que você deseja remover:");
        string cpf = Console.ReadLine();

        Pessoa pessoa = banco.getPessoas().Find(pessoa => pessoa.GetCpf() == cpf);

        if (pessoa == null)
        {
            Console.WriteLine("Pessoa não encontrada");
            System.Threading.Thread.Sleep(1000);
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"{pessoa.nome} removido(a) com sucesso");
            banco.RemoverPessoa(pessoa);
            System.Threading.Thread.Sleep(2000);
        }
    }

    static void RemoverLivro()
    {
        Console.Clear();
        Console.WriteLine("Digite o ID do Livro que você deseja remover:");
        string Id = Console.ReadLine();

        Livro livro = banco.GetLivros().Find(livro => livro.ID == Id);

         if (livro == null)
        {
            Console.WriteLine("Livro não encontrado!");
            System.Threading.Thread.Sleep(1000);
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"{livro.titulo} Removido com sucesso!");
            banco.RemoverLivro(livro);
            System.Threading.Thread.Sleep(2000);
        }
    }

    static void AdicionarLivros()
    {
        Console.Clear();
        Console.WriteLine("Digite o Título do livro:");
        string titulo = Console.ReadLine();
        Console.WriteLine("Digite o nome do Autor do livro:");
        string autor = Console.ReadLine();
        Console.WriteLine("Digite o Ano de Publicação:");
        int anoDePublicacao = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a categoria:");
        string categoria = Console.ReadLine();

        Livro livro = new Livro(titulo, autor, anoDePublicacao, categoria);
        banco.SalvarLivro(livro);
    }

    static void RemoverLivros()
    {
        Console.Clear();
        Console.WriteLine("Digite o Id do livro que você deseja remover:");
        string id = Console.ReadLine();

        Livro livro = banco.GetLivros().Find(livro => livro.ID == id);

        if (livro == null)
        {
            Console.WriteLine("Livro não encontrado");
            System.Threading.Thread.Sleep(1000);
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"{livro.titulo} foi removido com sucesso");
            banco.RemoverLivro(livro);
            System.Threading.Thread.Sleep(2000);
        }
    }

    static void EmprestarLivro()
    {
        Console.Clear();
        Console.WriteLine("Digite seu CPF:");
        string cpf = Console.ReadLine();

        Pessoa pessoa = banco.getPessoas().Find(pessoa => pessoa.GetCpf() == cpf);

        if (pessoa == null)
        {
            Console.Clear();
            Console.WriteLine("Desculpe seu CPF não está cadastrado no banco de dados.");
            System.Threading.Thread.Sleep(2000);
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Olá {pessoa.nome}! Aqui estão os livros disponíveis:");
            Console.WriteLine();
            banco.ListarDisponiveis();

            Console.WriteLine("Digite o título do livro que você deseja:");
            string title = Console.ReadLine();

            Livro livro = banco.GetLivros().Find(livro => livro.titulo == title);

            if (livro == null)
            {
                Console.WriteLine("Desculpe, livro não encontrado");
                System.Threading.Thread.Sleep(1000);
            }

            else if (livro.status != "Disponível")
            {
                Console.Clear();
                Console.WriteLine("Oh não! parece que este Livro já foi emprestado");
                System.Threading.Thread.Sleep(3000);
            }

            else
            {
                Console.Clear();
                Console.WriteLine($"Ótima escolha {pessoa.nome}!");
                Console.WriteLine($"{livro.titulo} foi emprestado com sucesso!");
                banco.AtualizarStatus(livro, pessoa);
                System.Threading.Thread.Sleep(2000);
            }
        }
    }

    static void DevolverLivro()
    {
        Console.Clear();
        Console.WriteLine("Digite seu CPF:");
        string cpf = Console.ReadLine();

        Pessoa pessoa = banco.getPessoas().Find(pessoa => pessoa.GetCpf() == cpf);

        if (pessoa == null)
        {
            Console.Clear();
            Console.WriteLine("Desculpe seu CPF não está cadastrado no banco de dados.");
            System.Threading.Thread.Sleep(2000);
        }

        else
        {
            Livro livro = banco.GetLivros().Find(livro => livro.titulo == pessoa.livro);
            
            if (livro == null)
            {
                Console.Clear();
                Console.WriteLine("Você não está lendo nenhum livro!");
                System.Threading.Thread.Sleep(2000);
            }

            else 
            {
                Console.Clear();
                Console.WriteLine($"{pessoa.livro} foi devolvido com sucesso!");
                banco.DevolverLivro(livro, pessoa);
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}