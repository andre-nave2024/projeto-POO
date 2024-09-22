class Pessoa
{
    public string nome;
    private string cpf;
    public int idade;
    public string livro = "...";

    public Pessoa(string nome, string cpf, int idade)
    {
        this.nome = nome;
        SetCpf(cpf);
        this.idade = idade;
    }

    public string GetCpf()
    {
        return cpf;
    }

    public void SetCpf(string cpf)
    {
        if (cpf.Length == 14)
        {
            for (int i = 0; i < cpf.Length; i++)
            {
                try
                {
                    int numero;
                    if (cpf[i] != '.' && cpf[i] != '-')
                    {
                        numero = int.Parse(cpf[i].ToString());
                    }

                }
                catch (System.Exception)
                {
                    return;
                }
            }
            this.cpf = cpf;
        }
        else
        {
            return;
        }
    }
    public bool isValid()
    {
        if (cpf == null)
        {
            return false;
        }
        return true;
    }
}