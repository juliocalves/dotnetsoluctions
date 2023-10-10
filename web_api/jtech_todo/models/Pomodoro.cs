using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models;

public class Pomodoro{
    [Key]
    public int PomId { get; set; }
    public Task? PomTask { get; set; }
    public Todo? PomTodo { get; set; }
    public int PomCount { get; set; }
    public int PomGoal { get; set; }
    public DateTime PomStart { get; set; }
    public DateTime PomEnd { get; set; }
    public bool PomDone { get; set; }
}