class BancoDeDados
{
    List<Pessoa> pessoas = new List<Pessoa>();
    List<Livro> livros = new List<Livro>();

    public BancoDeDados()
    {
        Pessoa pessoa = new Pessoa("André", "123.456.789-10", 17);
        SalvarPessoa2(pessoa);
        pessoa = new Pessoa("Caio", "321.654.978-01", 20);
        SalvarPessoa2(pessoa);
        pessoa = new Pessoa("Robson", "134.456.100-20", 19);
        SalvarPessoa2(pessoa);
        Livro livro = new Livro("Amigo Imaginário", "Stephen Chbosky", 2019, "Terror");
        SalvarLivro(livro);
        livro = new Livro("A Garota do Lago", "Charlie Donlea", 2016, "Suspense, Ficção Policial");
        SalvarLivro(livro);
        livro = new Livro("A revolução dos bichos", "George Orwell", 1945, "Fábula, Sátira");
        SalvarLivro(livro);
        livro = new Livro("Entendendo Algoritmos", "Aditya Y. Bhargava", 2017, "Programação");
        SalvarLivro(livro);
        livro = new Livro("Sapiens - Uma breve História da Humanidade", "Yuval Harari", 2011, "História");
        SalvarLivro(livro);
    }

    public void SalvarPessoa(Pessoa pessoa)
    {
        if (pessoa.isValid() == true)
        {
            pessoas.Add(pessoa);
            Console.Clear();
            Console.WriteLine("Pessoa adicionada com sucesso!");
            System.Threading.Thread.Sleep(1000);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Cpf inválido. Pessoa não adicionada!");
            System.Threading.Thread.Sleep(1000);
        }
    }

    public void SalvarPessoa2(Pessoa pessoa)
    {
        pessoas.Add(pessoa);
    }

    public void SalvarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void RemoverPessoa(Pessoa pessoa)
    {
        pessoas.Remove(pessoa);
    }

    public void RemoverLivro(Livro livro)
    {
        livros.Remove(livro);
    }

    public void ListarPessoas()
    {
        Console.Clear();
        for (int i = 0; i < pessoas.Count; i++)
        {
            Console.WriteLine("Pessoa " + (i + 1));
            Console.WriteLine("Nome: " + pessoas[i].nome);
            Console.WriteLine("CPF: " + pessoas[i].GetCpf());
            Console.WriteLine("Idade: " + pessoas[i].idade);
             Console.WriteLine("Lendo: " + pessoas[i].livro);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
        }
    }
    public void ListarLivros()
    {
        Console.Clear();
        for (int i = 0; i < livros.Count; i++)
        {
            Console.WriteLine("Livro " + (i + 1));
            Console.WriteLine("ID: " + livros[i].ID);
            Console.WriteLine("Título: " + livros[i].titulo);
            Console.WriteLine("Status: " + livros[i].status);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }
    }

    public void ListarDisponiveis()
    {
        for (int i = 0; i < livros.Count; i++)
        {
            if (livros[i].status == "Disponível")
            {
                Console.WriteLine("Livro " + (i + 1));
                Console.WriteLine("Título: " + livros[i].titulo);
                Console.WriteLine("Autor: " + livros[i].autor);
                Console.WriteLine("Ano de Publicação: " + livros[i].anoDePublicacao);
                Console.WriteLine("Categoria: " + livros[i].categoria);
                Console.WriteLine();
            }
        }
    }

    public void AtualizarStatus(Livro livro, Pessoa pessoa)
    {
        livro.status = $"Emprestado para {pessoa.nome}";
        pessoa.livro = $"{livro.titulo}";
    }

    public void DevolverLivro(Livro livro, Pessoa pessoa)
    {
        livro.status = "Disponível";
        pessoa.livro = "...";
    }
    public List<Pessoa> getPessoas()
    {
        return pessoas;
    }

    public List<Livro> GetLivros()
    {
        return livros;
    }
}