using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.Models;

namespace TodoApi.Endpoints;
public class TodoEndpoints {
    public static void MapEndpoints(WebApplication app,  Version version){
        app.MapPost(version+"/todos", async (AppDbContext context, Todo todo) => {
            
            todo.Dates.Add(new Date(){
                TDate = DateTime.Now,
                Action = (DateType)0
            });
            await context.Todos.AddAsync(todo);
            await context.SaveChangesAsync();
            return Results.Created($"/v1/todos/{todo.Id}", todo);
        }).Produces<Todo>(StatusCodes.Status201Created);

        app.MapGet(version+"/todos", (AppDbContext context) => {
            return Results.Ok(context.Todos);
        }).Produces<Todo>(StatusCodes.Status200OK);

        app.MapGet(version+"/todos/{id}", (AppDbContext context, Guid id) => {
            var todo = context.Todos.Find(id);
            if (todo is null) return Results.NotFound();
            return Results.Ok(todo);
        });

        app.MapPut(version+"/todos/{id}", async (AppDbContext context, Guid id, Todo todo) => {
            var todoToUpdate = context.Todos.Find(id);
            if (todoToUpdate is null) return Results.NotFound();
            todoToUpdate.Title = todo.Title;
            todoToUpdate.Done = todo.Done;
            todoToUpdate.Deleted = todo.Deleted;
            todoToUpdate.Dates = todo.Dates;
            
            todoToUpdate.Dates.Add(new Date(){
                TDate = DateTime.Now,
                Action = (DateType)1
            });

            if (todoToUpdate.Done){
                todoToUpdate.Dates.Add(new Date(){
                    TDate = DateTime.Now,
                    Action = (DateType)2
                });
            }

            context.Entry(todoToUpdate).State = EntityState.Modified;           
           
            await context.SaveChangesAsync();
            return Results.Ok(todoToUpdate);
        });

        app.MapDelete(version+"/todos/{id}", async (AppDbContext context, Guid id) => {
            var todoToDelete = context.Todos.Find(id);
            if (todoToDelete is null) return Results.NotFound();
            context.Todos.Remove(todoToDelete);
            await context.SaveChangesAsync();
            return Results.NoContent();
        });
    }
}