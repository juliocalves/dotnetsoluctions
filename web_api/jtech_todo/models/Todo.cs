namespace TodoApi.Models;
// public record Todo(Guid Id, string Title, bool Done);

/// <summary>
/// A todo is a todo
/// </summary>
/// <param name="Id">The id of the todo</param>
/// <param name="Title">The title of the todo</param>
/// <param name="Done">Whether the todo is done or not</param>
/// <param name="Deleted">Whether the todo is deleted or not</param>
/// <param name="Dates">The dates of the todo</param>
public class Todo {
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public bool Done { get; set; } = false;
    public bool Deleted { get; set; } = false;
    public List<Date> Dates { get; set; }

}
