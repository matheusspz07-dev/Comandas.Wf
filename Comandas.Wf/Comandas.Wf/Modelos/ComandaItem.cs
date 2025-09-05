
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comandas.Wf.Modelos;

public class ComandaItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int CardapioItemId { get; set; } // Criei a coluna CardapioItemId no banco
    public virtual CardapioItem CardapioItem { get; set; } // De forma simples estou dizendo q o valor da coluna "CardapioItemId" será o id do meu CardapioItem.cs
    public int ComandaId { get; set; } // Criei a coluna ComandaId no banco
    public virtual Comanda Comanda { get; set; } // De forma simples estou dizendo q o valor da coluna "ComandaId" será o id do meu Comanda.cs
}
