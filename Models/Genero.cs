namespace BackendProjetoGrupo
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Filme> Filmes { get; set; }
    }
}