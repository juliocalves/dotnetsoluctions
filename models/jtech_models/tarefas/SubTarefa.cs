using System.ComponentModel.DataAnnotations;
namespace jtech_models.tarefas;

/// <summary>
/// Representa uma sub tarefa associada a uma tarefa principal.
/// </summary>
public class SubTarefa : Tarefa
{
    /// <summary>
    /// Identificador único da sub tarefa.
    /// </summary>
    public Guid STarId { get; set; }

    /// <summary>
    /// Título da sub tarefa.
    /// </summary>
    public string STarTitulo { get; set; }

    /// <summary>
    /// Indica se a sub tarefa está concluída.
    /// </summary>
    public bool STarConcluido { get; set; } = false;

    /// <summary>
    /// Lista de datas associadas à sub tarefa.
    /// </summary>
    public List<TarefaSubTarefaData> STarData { get; set; }
    
}
