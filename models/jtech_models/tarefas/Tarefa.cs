namespace jtech_models.tarefas;

/// <summary>
/// Representa uma tarefa.
/// </summary>
/// <param name="TareId">O identificador único da tarefa</param>
/// <param name="TareTitulo">O título da tarefa</param>
/// <param name="TareSubTare">As subtarefas associadas à tarefa</param>
/// <param name="TareConcluido">Indica se a tarefa está concluída ou não</param>
/// <param name="TareData">As datas relacionadas à tarefa</param>
public class Tarefa {
    /// <summary>
    /// Identificador único da tarefa.
    /// </summary>
    public Guid TareId { get; set; }

    /// <summary>
    /// Título da tarefa.
    /// </summary>
    public required string TareTitulo { get; set; }

    /// <summary>
    /// Lista de subtarefas associadas à tarefa.
    /// </summary>
    public List<SubTarefa> TareSubTare { get; set; }

    /// <summary>
    /// Indica se a tarefa está concluída ou não.
    /// </summary>
    public bool TareConcluido { get; set; } = false;

    /// <summary>
    /// Lista de datas relacionadas à tarefa.
    /// </summary>
    public List<TarefaSubTarefaData> TareData { get; set; }
}