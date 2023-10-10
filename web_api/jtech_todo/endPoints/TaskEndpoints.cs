using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.Models;

namespace TodoApi.Endpoints;
public class TaskEndpoints{
    public static void MapEndpoints(WebApplication app, Version version){
        app.MapPost(version+"/tasks", async (AppDbContext context, TodoApi.Models.Task task) => {
            await context.Tasks.AddAsync(task);
            await context.SaveChangesAsync();
            return Results.Created($"/v1/tasks/{task.Id}", task);
        }).Produces<Models.Task>(StatusCodes.Status201Created);

        app.MapGet(version+"/tasks", (AppDbContext context) => {
            return Results.Ok(context.Tasks);
        }).Produces<Models.Task>(StatusCodes.Status200OK);

        app.MapGet(version+"/tasks/{id}", (AppDbContext context, Guid id) => {
            var task = context.Tasks.Find(id);
            if (task is null) return Results.NotFound();
            return Results.Ok(task);
        });

        app.MapPut(version+"/tasks/{id}", async (AppDbContext context, Guid id, TodoApi.Models.Task task) => {
            var taskToUpdate = context.Tasks.Find(id);
            if (taskToUpdate is null) return Results.NotFound();
            taskToUpdate.Title = task.Title;
            taskToUpdate.Todos = task.Todos;
            taskToUpdate.Done = task.Done;
            taskToUpdate.Deleted = task.Deleted;
            taskToUpdate.Dates = task.Dates;
            context.Entry(taskToUpdate).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Results.Ok(taskToUpdate);
        });

        app.MapDelete(version+"/tasks/{id}", async (AppDbContext context, Guid id) => {
            var taskToDelete = context.Tasks.Find(id);
            if (taskToDelete is null) return Results.NotFound();
            context.Tasks.Remove(taskToDelete);
            await context.SaveChangesAsync();
            return Results.NoContent();
        });
    }
}
