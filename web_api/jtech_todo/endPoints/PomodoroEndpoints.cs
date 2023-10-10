using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.Models;

namespace TodoApi.Endpoints;
public class PomodoroEndpoints{
    public static void MapEndpoints(WebApplication app, Version version){
        app.MapPost(version+"/Pomodoros", async (AppDbContext context, TodoApi.Models.Pomodoro Pomodoro) => {
            await context.Pomodoros.AddAsync(Pomodoro);
            await context.SaveChangesAsync();
            return Results.Created($"/v1/Pomodoros/{Pomodoro.PomId}", Pomodoro);
        }).Produces<Pomodoro>(StatusCodes.Status201Created);

        app.MapGet(version+"/Pomodoros", (AppDbContext context) => {
            return Results.Ok(context.Pomodoros);
        }).Produces<Pomodoro>(StatusCodes.Status200OK);

        app.MapGet(version+"/Pomodoros/{id}", (AppDbContext context, Guid id) => {
            var Pomodoro = context.Pomodoros.Find(id);
            if (Pomodoro is null) return Results.NotFound();
            return Results.Ok(Pomodoro);
        });

        app.MapPut(version+"/Pomodoros/{id}", async (AppDbContext context, Guid id, TodoApi.Models.Pomodoro Pomodoro) => {
            var PomodoroToUpdate = context.Pomodoros.Find(id);
            if (PomodoroToUpdate is null) return Results.NotFound();
            PomodoroToUpdate.PomCount = Pomodoro.PomCount;
            PomodoroToUpdate.PomGoal = Pomodoro.PomGoal;
            PomodoroToUpdate.PomStart = Pomodoro.PomStart;
            PomodoroToUpdate.PomEnd = Pomodoro.PomEnd;
            PomodoroToUpdate.PomDone = Pomodoro.PomDone;
            PomodoroToUpdate.PomTask = Pomodoro.PomTask;
            PomodoroToUpdate.PomTodo = Pomodoro.PomTodo;
            context.Entry(PomodoroToUpdate).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Results.Ok(PomodoroToUpdate);
        });

        app.MapDelete(version+"/Pomodoros/{id}", async (AppDbContext context, Guid id) => {
            var PomodoroToDelete = context.Pomodoros.Find(id);
            if (PomodoroToDelete is null) return Results.NotFound();
            context.Pomodoros.Remove(PomodoroToDelete);
            await context.SaveChangesAsync();
            return Results.NoContent();
        });
    }
}
