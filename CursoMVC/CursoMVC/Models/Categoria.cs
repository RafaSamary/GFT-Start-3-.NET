namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public int Descricao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
