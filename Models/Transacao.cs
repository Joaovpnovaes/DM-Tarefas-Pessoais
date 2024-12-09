using System;

namespace Compromisso.Model
{
    public class Transacao
    {
       
        public int Id { get; set; }

     
        public string? Descricao { get; set; }

       
        public decimal Valor { get; set; }

        
        public DateTime Data { get; set; }

      
        public Categoria? Categoria { get; set; }

       
        public TipoTransacao Tipo { get; set; }
    }

   
    public enum TipoTransacao
    {
        Receita,
        Despesa
    }
}
