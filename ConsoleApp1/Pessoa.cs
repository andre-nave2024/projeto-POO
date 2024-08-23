using System.Security.Cryptography.X509Certificates;

class Pessoa
{
    public string nome;
    public string cpf;
    public string sexo;
    public int idade;

    public Pessoa(string nome, string cpf, string sexo, int idade)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.sexo = sexo;
        this.idade = idade;
    }
}