namespace PatrimonioSenaiTaguatinga.Entities;

public class Usuario
{
    public Usuario(string nome, string sobreNome, string login, string senha, int idNivel)
    {
        Nome = nome;
        Sobrenome = sobreNome;
        Login = login;
        Senha = senha;
        IdNivel = idNivel;
    }
    public int Id { get; set; }
    public string nome { get; set; }
    public string SobreNome { get; set; }
    public string Login { get; set; }
    public string Senha { get; set; }
    public int IdNivel { get; set; }
    public Nivel Nivel { get; set; } = null!;
}