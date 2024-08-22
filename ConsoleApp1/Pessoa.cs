using System.Security.Cryptography.X509Certificates;

class Pessoa
{
    public string nome;
    public string sobrenome;
    public string sexo;
    public int idade;

    public Pessoa(string nome, string sexo, int idade, string sobrenome)
    {
        this.nome = nome;
        this.sexo = sexo;
        this.idade = idade;
        this.sobrenome = sobrenome;
    }
}