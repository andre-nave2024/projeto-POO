using System.Security.Cryptography.X509Certificates;

class Pessoa
{
    public string nome;
    public string sexo;
    public int idade;
    public string roupa;

    public Pessoa(string nome, string sexo, int idade, string roupa)
    {
        this.nome = nome;
        this.sexo = sexo;
        this.idade = idade;
        this.roupa = roupa;
    }
}