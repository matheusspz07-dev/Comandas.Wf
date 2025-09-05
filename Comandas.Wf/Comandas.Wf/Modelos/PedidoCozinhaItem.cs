
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comandas.Wf.Modelos;

public class PedidoCozinhaItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int PedidoCozinhaId { get; set; }
    public virtual PedidoCozinha PedidoCozinha { get; set; } // De forma simples estou dizendo q o valor da coluna "PedidoCozinhaId" será o id do meu PedidoCozinha.cs
    public int ComandaItemId { get; set; }
    public virtual ComandaItem ComandaItem { get; set; } // De forma simples estou dizendo q o valor da coluna "ComandaItemId" será o id do meu ComandaItem.cs
}
