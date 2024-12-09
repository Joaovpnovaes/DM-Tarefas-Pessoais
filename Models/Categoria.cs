namespace Compromisso.Model
{
    public class Categoria
    {
       
        public int Id { get; set; }
        public string? Nome { get; set; }

        public TipoTransacaoCat Tipo { get; set; }
    }

    public enum TipoTransacaoCat
    {
        Receita,
        Despesa
    }
}
