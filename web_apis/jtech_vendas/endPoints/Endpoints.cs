using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.OpenApi;

public class Endpoints<T> where T : class
{
    public static void MapEndpoints(WebApplication app, string baseUrl,Guid id)
    {
        string baseEndpoint = $"{baseUrl}/{typeof(T).Name.ToLower()}";
        app.MapGet($"{baseEndpoint}/pesquisar", async (AppDbContext context) =>
        {
            return Results.Ok(await context.Set<T>().ToListAsync());
        }).Produces<List<T>>(StatusCodes.Status200OK).WithTags(typeof(T).Name.ToLower());

        app.MapGet($"{baseEndpoint}/pesquisar/{{id}}", async (AppDbContext context,  Guid id) =>
        {
            var entity = await context.Set<T>().FindAsync(id);
            if (entity is null) return Results.NotFound($"{typeof(T).Name} não encontrad{(typeof(T).Name.EndsWith("s") ? "o" : "a")}");
            return Results.Ok(entity);
        }).Produces<T>(StatusCodes.Status200OK).WithTags(typeof(T).Name.ToLower());

        app.MapPost($"{baseEndpoint}/incluir", async (AppDbContext context,  T entity) =>
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
            return Results.Created($"{baseEndpoint}/{id}", entity);
        }).Produces<T>(StatusCodes.Status201Created).WithTags(typeof(T).Name.ToLower());

        app.MapPut($"{baseEndpoint}/editar/{{id}}", async (AppDbContext context, Guid id, T entity) =>
        {
            var entityDb = await context.Set<T>().FindAsync(id);
            if (entityDb is null) return Results.NotFound($"{typeof(T).Name} não encontrad{(typeof(T).Name.EndsWith("s") ? "o" : "a")}");
            // TODO: Implemente a lógica para atualização da entidade
            // ...

            return Results.Ok(entity);
        }).Produces<T>(StatusCodes.Status200OK).WithTags(typeof(T).Name.ToLower());

        app.MapDelete($"{baseEndpoint}/deletar/{{id}}", async (AppDbContext context, Guid id) =>
        {
            var entity = await context.Set<T>().FindAsync(id);
            if (entity is null) return Results.NotFound($"{typeof(T).Name} não encontrad{(typeof(T).Name.EndsWith("s") ? "o" : "a")}");
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
            return Results.NoContent();
        }).Produces(StatusCodes.Status204NoContent).WithTags(typeof(T).Name.ToLower());
    }
}

public class VendaEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class ServicoEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class ProdutoEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class ClienteEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class CatalogoEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class ComissaoEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class ContatoEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class EnderecoEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class EstoqueEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class FormaPagamentoEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class FornecedoresEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class LeadEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class LeadDateEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class ProcessoVendaEndpoints<T>: Endpoints<T> where T : class
{
    
}
public class VendedorEndpoints<T>: Endpoints<T> where T : class
{
    
}