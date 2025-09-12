using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comandas.Wf.Modelos;

public class Usuario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Senha { get; set; }
    public string Email { get; set; }
    public int PerfilUsuarioId { get; set; }
    public virtual PerfilUsuario PerfilUsuario { get; set; }
}
public class PerfilUsuario
{
    public int Id { get; set; }
    public string Descricao { get; set; }
}