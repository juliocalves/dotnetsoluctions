using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();

var version = new Version(1, 0, 0);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    // swag => swag.SwaggerDoc($"{version}", new OpenApiInfo{
    //     Title = "Vendas API",
    //     Version = $"v{version}",
    //     Description = "API de vendas"})
    );

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(); 

#region  implementação anterior
//VendaEndpoints.MapEndpoints(app); // implementação de cada classe
//implementação com herança
// VendedorEndpoints<Vendedor>.MapEndpoints(app, "api", Guid.NewGuid());
// VendaEndpoints<Venda>.MapEndpoints(app, "api", Guid.NewGuid());
// ProdutoEndpoints<Produto>.MapEndpoints(app, "api", Guid.NewGuid());
// ServicoEndpoints<Servico>.MapEndpoints(app, "api", Guid.NewGuid());
// ClienteEndpoints<Cliente>.MapEndpoints(app, "api", Guid.NewGuid());
// ProcessoVendaEndpoints<ProcessoVenda>.MapEndpoints(app, "api", Guid.NewGuid());
// LeadDateEndpoints<LeadDate>.MapEndpoints(app, "api", Guid.NewGuid());
// LeadEndpoints<Lead>.MapEndpoints(app, "api", Guid.NewGuid());
// FornecedoresEndpoints<Fornecedor>.MapEndpoints(app, "api", Guid.NewGuid());
// EstoqueEndpoints<Estoque>.MapEndpoints(app, "api", Guid.NewGuid());
// EnderecoEndpoints<Endereco>.MapEndpoints(app, "api", Guid.NewGuid());
// ContatoEndpoints<Contato>.MapEndpoints(app, "api", Guid.NewGuid());
// ComissaoEndpoints<Comissao>.MapEndpoints(app, "api", Guid.NewGuid());
// CatalogoEndpoints<Catalogo>.MapEndpoints(app, "api", Guid.NewGuid());
// FormaPagamentoEndpoints<FormaPagamentoRecebimento>.MapEndpoints(app, "api", Guid.NewGuid());

#endregion 

// implementação direta
Endpoints<jtech_models.vendas.Venda>.MapEndpoints(app, "api", Guid.NewGuid());
Endpoints<jtech_models.vendas.Produto>.MapEndpoints(app, "api", Guid.NewGuid());
Endpoints<jtech_models.vendas.Servico>.MapEndpoints(app, "api", Guid.NewGuid());
Endpoints<jtech_models.vendas.Cliente>.MapEndpoints(app, "api", Guid.NewGuid());
VendaEndpoints<jtech_models.vendas.ProcessoVenda>.MapEndpoints(app, "api", Guid.NewGuid());
Endpoints<jtech_models.vendas.LeadDate>.MapEndpoints(app, "api", Guid.NewGuid());
Endpoints<jtech_models.vendas.Lead>.MapEndpoints(app, "api", Guid.NewGuid());
Endpoints<jtech_models.vendas.Fornecedor>.MapEndpoints(app, "api", Guid.NewGuid());
Endpoints<jtech_models.vendas.Estoque>.MapEndpoints(app, "api", Guid.NewGuid());
Endpoints<jtech_models.logradouro.Endereco>.MapEndpoints(app, "api", Guid.NewGuid());
Endpoints<jtech_models.comunicacao.Contato>.MapEndpoints(app, "api", Guid.NewGuid());
Endpoints<jtech_models.vendas.Comissao>.MapEndpoints(app, "api", Guid.NewGuid());
Endpoints<jtech_models.vendas.Catalogo>.MapEndpoints(app, "api", Guid.NewGuid());
Endpoints<jtech_models.vendas.FormaPagamentoRecebimento>.MapEndpoints(app, "api", Guid.NewGuid());

app.Run();
