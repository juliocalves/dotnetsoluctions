namespace jtech_models.tarefas;

/// <summary>
/// Representa uma data associada a uma tarefa e sub tarefa.
/// </summary>
/// <param name="TareSubTareId">Identificador único da data</param>
/// <param name="TareSubTareData">A data</param>
/// <param name="TareSubTareAcao">A ação relacionada à data</param>
/// <param name="TareSubTareTarefa">A tarefa associada à data</param>
/// <param name="TareSubTareSubTarefa">A sub tarefa associada à data</param>
public class TarefaSubTarefaData
{
    public int TareSubTareId { get; set; }
    public DateTime TareSubTareData { get; set; }
    public DateType TareSubTareAcao { get; set; }
    public Tarefa? TareSubTareTarefa { get; set; }
    public SubTarefa? TareSubTareSubTarefa { get; set; }
}

/// <summary>
/// Enumeração que representa o tipo de data.
/// </summary>
/// <param name="CriadoEm">Data de criação</param>
/// <param name="AtualizadoEm">Data de atualização</param>
/// <param name="ConluidoEm">Data de conclusão</param>
/// <param name="DeletadoEm">Data de exclusão</param>
public enum DateType
{
    CriadoEm,
    AtualizadoEm,
    ConluidoEm,
    DeletadoEm
}