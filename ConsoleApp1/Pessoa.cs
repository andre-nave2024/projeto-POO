using System.Security.Cryptography.X509Certificates;

class Pessoa
{
    public string nome;
    public string sexo;
    public int idade;

    public Pessoa(string nome, string sexo, int idade)
    {
        this.nome = nome;
        this.sexo = sexo;
        this.idade = idade;
    }
}