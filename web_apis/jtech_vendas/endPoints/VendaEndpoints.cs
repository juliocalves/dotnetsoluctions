using jtech_models.vendas;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
public class VendaEndpoints{
    public static void MapEndpoints(WebApplication app){
       
        app.MapGet("api/vendas/pesquisar", async (AppDbContext context) => {
            return Results.Ok(await context.Vendas.ToListAsync());
        }).Produces<List<Venda>>(StatusCodes.Status200OK);

        app.MapGet("api/vendas/pesquisar/{id}", async (AppDbContext context, Guid id) => {
            var venda = await context.Vendas.FindAsync(id);
            if(venda is null) return Results.NotFound("Venda não encontrada");
            return Results.Ok(venda);
        }).Produces<Venda>(StatusCodes.Status200OK);

        app.MapPost("api/vendas/incluir", async (AppDbContext context, Venda venda) => {
            await context.Vendas.AddAsync(venda);
            await context.SaveChangesAsync();
            return Results.Created($"/vendas/{venda.VendId}", venda);
        }).Produces<Venda>(StatusCodes.Status201Created);

        app.MapPut("api/vendas/editar/{id}", async (AppDbContext context, Guid id, Venda venda) => {
            var vendaDb = await context.Vendas.FindAsync(id);
            if (vendaDb is null) return Results.NotFound("Venda não encontrada");
            if (vendaDb.VendId != venda.VendId) return Results.BadRequest("Divergencias nos Ids");
            try{
                context.Entry(vendaDb).CurrentValues.SetValues(venda); 
                await context.SaveChangesAsync();
                return Results.Ok(venda);           
            }catch(Exception ex){
                return Results.BadRequest($"Erro ao atualizar a venda :\n\r {ex}");
            }
        }).Produces<Venda>(StatusCodes.Status200OK);

        app.MapDelete("api/vendas/deletar/{id}", async (AppDbContext context, Guid id) => {
            var venda = await context.Vendas.FindAsync(id);
            if (venda is null) return Results.NotFound("Venda não encontrada");
            context.Vendas.Remove(venda);
            await context.SaveChangesAsync();
            return Results.NoContent();
        }).Produces(StatusCodes.Status204NoContent);
    
    }
}