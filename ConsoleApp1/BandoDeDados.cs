class BancoDeDados
{
    List<Pessoa> pessoas = new List<Pessoa>();

    public BancoDeDados()
    {
        Pessoa pessoa = new Pessoa("Andre", "123.456.789-10", 17);
        SalvarPessoa(pessoa);
        pessoa = new Pessoa("Caio", "321.654.978-01", 20);
        SalvarPessoa(pessoa);
        pessoa = new Pessoa("Patrick", "134.456.100-20", 19);
        SalvarPessoa(pessoa);
    }

    public void SalvarPessoa(Pessoa pessoa)
    {
        pessoas.Add(pessoa);
    }

    public void RemoverPessoa(Pessoa pessoa)
    {
        pessoas.Remove(pessoa);
    }

    public void ListarPessoas()
    {
        Console.Clear();
        for (int i = 0; i < pessoas.Count; i++)
        {
            Console.WriteLine("Pessoa " + (i + 1));
            Console.WriteLine("Nome: " + pessoas[i].nome);
            Console.WriteLine("CPF: " + pessoas[i].cpf);
            Console.WriteLine("Idade: " + pessoas[i].idade);
            Console.WriteLine();
        }
    }

    public List<Pessoa> getPessoas()
    {
        return pessoas;
    }
}