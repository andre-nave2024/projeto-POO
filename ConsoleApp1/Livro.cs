class Livro
{
    public string ID;
    public string titulo;
    public string autor;
    public int anoDePublicacao;
    public string categoria;
    public string status = "Disponível";

    public Livro(string titulo, string autor, int anoDePublicacao, string categoria)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.anoDePublicacao = anoDePublicacao;
        this.categoria = categoria;
        ID = Guid.NewGuid().ToString();
    }
}