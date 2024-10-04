using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [Phone]
    public string Telefone { get; set; }

    [Required]
    public string Usuario { get; set; }

    [Required]
    [MinLength(8)]
    public string Senha { get; set; }

    public string TipoConta { get; set; } = "Simples"; // Master, Gerente ou Simples
}
