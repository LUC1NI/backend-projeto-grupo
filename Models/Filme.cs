public class Filme
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public int Ano { get; set; }
    public int GeneroId { get; set; }

    public Genero Genero { get; set; }
}
