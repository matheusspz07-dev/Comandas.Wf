
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comandas.Wf.Modelos;

public class CardapioItem
{
    [Key] // Diz que a propriedade é a chave primária da tabela.
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Diz que o valor dessa coluna será gerado automaticamente pelo banco.
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public bool PossuiPreparo { get; set; }
}
