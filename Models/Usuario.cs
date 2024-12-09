using System;
using Models;

namespace Models;

public class Usuario
{
    public int UsuarioId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public string Senha { get; set; }

    public Usuario(int usuarioId, string nome, string email, string cpf, string senha)
    {
        UsuarioId = usuarioId;
        Nome = nome;
        Email = email;
        Cpf = cpf;
        Senha = senha;
    }

     public Usuario()
    {
    }


}
