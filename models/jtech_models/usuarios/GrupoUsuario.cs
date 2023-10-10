using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jtech_models.usuarios;


[Table("GrupoUsuarios")]
public class GrupoUsuario
{
    [Key]
    public int GUsuaID { get; set; }
    public string GUsuaNome { get; set; }
    
}



