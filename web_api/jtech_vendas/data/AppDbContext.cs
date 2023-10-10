using jtech_models.comunicacao;
using jtech_models.empresa.time;
using jtech_models.logradouro;
using jtech_models.vendas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

public class AppDbContext : DbContext
{
    public DbSet<Lead> Leads { get; set; }
    public DbSet<LeadDate> LeadDates { get; set; }      
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Vendedor> Vendedores { get; set; }
    public DbSet<Comissao> Comissoes { get; set; }
    public DbSet<Catalogo> Catalogos { get; set; }
    public DbSet<Contato> Contatos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Fornecedor> Fornecedores { get; set; } 
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Estoque> Estoques { get; set; }
    public DbSet<Servico> Servicos { get; set; }
    public DbSet<ProcessoVenda> ProcessoVendas { get; set; }
    public DbSet<Venda> Vendas { get; set; }
    public DbSet<FormaPagamentoRecebimento> FormaPagamentoRecebimentos { get; set; }
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        // optionsBuilder.UseSqlite("Data Source=app.db;Cache=Shared");
        optionsBuilder.UseMySQL("Server=localhost;Port=3307;Database=vendasservices;User=necmint;Password=@Maiden08berry;");
    }
}