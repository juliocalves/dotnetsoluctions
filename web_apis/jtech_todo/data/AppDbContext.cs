using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
namespace TodoApi.Data;
public class AppDbContext : DbContext {
    
    public DbSet<Todo> Todos { get; set; }

    public DbSet<Models.Task> Tasks { get; set; }

    public DbSet<Date> Dates { get; set; }

    public DbSet<Pomodoro> Pomodoros { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        // optionsBuilder.UseSqlite("Data Source=app.db;Cache=Shared");
        optionsBuilder.UseMySQL("Server=localhost;Port=3307;Database=todo;User=necmint;Password=@Maiden08berry;");
    }
}
