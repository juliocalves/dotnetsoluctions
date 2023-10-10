using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using jtech_models.pessoas;

namespace jtech_models.usuarios;

[Table("Usuarios")]
public class Usuario : PessoaFisica
{
    [Key]
    public int UsuaID { get; set; }
    public string UsuaNome { get; set; }
    [EmailAddress]
    public string UsuaEmail { get; set; }
    public bool UsuaAtivo { get; set; }
    public string UsuaSenha { get; set; }
    public GrupoUsuario GrupoUsuario { get; set; }
    public List<int> UsuaNumClieCad {get;set;}
    public DateTime UsuaDataCadastro { get; set; } = DateTime.Now;
    //public virtual ICollection<Cliente> Clientes { get; set; }
}




