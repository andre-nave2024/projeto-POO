class BancoDeDados
{
    List<Pessoa> pessoas = new List<Pessoa>();

    public void SalvarPessoa(Pessoa pessoa)
    {
        pessoas.Add(pessoa);
    }

    public void ListarPessoas()
    {
        for (int i = 0; i < pessoas.Count; i++)
        {
            Console.WriteLine("Pessoa: " + (i + 1));
            Console.WriteLine("Nome: " + pessoas[i].nome);
            Console.WriteLine("Sexo: " + pessoas[i].sexo);
            Console.WriteLine("Idade: " + pessoas[i].idade);
            Console.WriteLine("Roupa: " + pessoas[i].roupa);
            Console.WriteLine();
        }
    }
}