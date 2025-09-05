
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comandas.Wf.Modelos;

public class PedidoCozinha
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int ComandaId { get; set; }
    public virtual Comanda Comanda { get; set; }
    public int SituacaoId { get; set; }
    public virtual ICollection <PedidoCozinhaItem> PedidoCozinhaItems{ get; set; } // Não estou criando uma tabela, estou dizendo que um pedido tem vários itens
}
