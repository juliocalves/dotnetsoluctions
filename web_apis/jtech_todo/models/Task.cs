namespace TodoApi.Models;

/// <summary>
/// A task is a task
/// </summary>
/// <param name="Id">The id of the task</param>
/// <param name="Title">The title of the task</param>
/// <param name="Todos">The todos of the task</param>
/// <param name="Done">Whether the task is done or not</param>
/// <param name="Deleted">Whether the task is deleted or not</param>
/// <param name="Dates">The dates of the task</param>
public class Task{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public List<Todo> Todos { get; set; }
    public bool Done { get; set; } = false;
    public bool Deleted { get; set; } = false;
    public List<Date> Dates { get; set; }
    
}