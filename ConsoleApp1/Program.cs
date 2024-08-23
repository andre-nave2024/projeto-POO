class Program
{
    static ConsoleKeyInfo opcao = new ConsoleKeyInfo();
    static BancoDeDados banco = new BancoDeDados();

    static void Main()
    {

        while (opcao.Key != ConsoleKey.Escape)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao meu Primeiro Banco de Dados!");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Gerenciar Pessoas");
            //Console.WriteLine("2 - Gerenciar ");
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
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        banco.ListarPessoas();
                        Console.ReadKey();
                        break;
                }
            }
            /*else if (opcao.Key == ConsoleKey.D2)
            {
                Console.Clear();
                banco.ListarPessoas();
                Console.ReadKey();
            }
            */
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

        Pessoa pessoa = banco.getPessoas().Find(pessoa => pessoa.cpf == cpf);

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
        }
    }
}