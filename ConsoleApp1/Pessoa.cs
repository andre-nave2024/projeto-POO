using System.Security.Cryptography.X509Certificates;

class Pessoa
{
    public string nome;
    public string cpf;
    public int idade;

    public Pessoa(string nome, string cpf, int idade)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
    }
}