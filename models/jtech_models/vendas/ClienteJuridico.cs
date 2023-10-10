using jtech_models.empresas;
using jtech_models.vendas;

public class ClienteJuridico : Cliente{
    /// <summary>
    /// Representa uma pessoa jurídica associada ao cliente.
    /// </summary>
    public PessoaJuridica PessoaJuridica { get; set; }

    /// <summary>
    /// Construtor padrão.
    /// </summary>
    /// <param name="pessoaJuridica">Objeto que representa pessoa jurídica</param>
    public ClienteJuridico(PessoaJuridica pessoaJuridica)
    {
        PessoaJuridica = pessoaJuridica;
    }
}