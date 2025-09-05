
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comandas.Wf.Modelos;

public class Comanda
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } // Essa linha cria uma propriedade inteira chamada Id (Cria a coluna Id no banco de dados)
    public int NumeroMesa { get; set; } // Mesmod e cima
    public string NomeCliente { get; set; } // Mesmod e cima
    public int SituacaoComanda { get; set; } // Mesmod e cima
    public virtual ICollection <ComandaItem> ComandaItens{ get; set; } // Não estou criando uma tabela, estou dizendo que uma comanda tem vários itens 
}
