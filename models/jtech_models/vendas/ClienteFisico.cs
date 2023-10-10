using jtech_models.pessoas;

namespace jtech_models.vendas;

public class ClienteFisico : Cliente{
    /// <summary>
    /// Representa uma pessoa física associada ao cliente.
    /// </summary>
    public PessoaFisica PessoaFisica { get; set; }

    /// <summary>
    /// Construtor padrão.
    /// </summary>
    /// <param name="pessoaFisica">Objeto que representa pessoa fisica</param>
    public ClienteFisico(PessoaFisica pessoaFisica)
    {
        PessoaFisica = pessoaFisica;
    }
}