using System;
using Compromisso.Model;


namespace Models;


public class Conta
{

    public int Id { get; set; }


    public string Nome { get; set; }


    public decimal SaldoAtual { get; set; }

 
    public ICollection<Transacao> Transacoes { get; set; } = new List<Transacao>();
}


public enum TipoTransacao
{
    Receita,
    Despesa
}