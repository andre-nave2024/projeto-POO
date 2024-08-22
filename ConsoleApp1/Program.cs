class Program
{
    static void Main()
    {
        ConsoleKeyInfo opcao = new ConsoleKeyInfo();
        BancoDeDados banco = new BancoDeDados();

        while (opcao.Key != ConsoleKey.D3)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao meu Primeiro Banco de Dados!");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Cadastrar uma Pessoa");
            Console.WriteLine("2 - Listar Pessoas");
            Console.WriteLine("3 - Sair");

            opcao = Console.ReadKey();

            if (opcao.Key == ConsoleKey.D1)
            {
                Console.Clear();

                Console.WriteLine("Digite o nome da Pessoa:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o sobrenome da Pessoa:");
                string sobrenome = Console.ReadLine();
                string sexo = "";
                Console.WriteLine("Escolha o sexo:");
                Console.WriteLine("1 - Masculino");
                Console.WriteLine("2 - Feminino");
                Console.WriteLine("3 - outro");

                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        sexo = "Masculino";
                        break;

                    case 2:
                        sexo = "Femino";
                        break;

                    case 3:
                        sexo = Console.ReadLine();
                        break;
                }

                Console.WriteLine("Digite a idade:");
                int idade = int.Parse(Console.ReadLine());

                Pessoa pessoa = new Pessoa(nome, sexo, idade, sobrenome);
                banco.SalvarPessoa(pessoa);
            }
            else if (opcao.Key == ConsoleKey.D2)
            {
                Console.Clear();
                banco.ListarPessoas();
                System.Threading.Thread.Sleep(10000);
            }
        }
    }
}