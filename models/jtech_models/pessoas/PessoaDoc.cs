using System.ComponentModel.DataAnnotations;

namespace jtech_models.pessoas;

/// <summary>
/// Representa a documentação associada a uma pessoa.
/// </summary>
public class PessoaDoc
{
    /// <summary>
    /// Identificador único da documentação da pessoa.
    /// </summary>
    [Key]
    public int PDocID { get; set; }

    /// <summary>
    /// Estado civil da pessoa.
    /// </summary>
    public EstadoCivil PDocEstadoCivil { get; set; }

    /// <summary>
    /// Número do RG da pessoa.
    /// </summary>
    public string? PDocRG { get; set; }

    /// <summary>
    /// Número do CPF da pessoa.
    /// </summary>
    public string? PDocCPF { get; set; }

    /// <summary>
    /// Número do título de eleitor da pessoa.
    /// </summary>
    public string? PDocTITULO { get; set; }

    /// <summary>
    /// Número do PIS da pessoa.
    /// </summary>
    public string? PDocPIS { get; set; }

    /// <summary>
    /// Número da carteira de trabalho (CLT) da pessoa.
    /// </summary>
    public string? PDocCLT { get; set; }

    /// <summary>
    /// Número da certidão da pessoa.
    /// </summary>
    public string? PDocCertidao { get; set; }

    /// <summary>
    /// Comprovante de endereço da pessoa em formato binário.
    /// </summary>
    public byte[]? PDocCompEnd { get; set; }

    /// <summary>
    /// Comprovante de renda da pessoa em formato binário.
    /// </summary>
    public byte[]? PDocCompRend { get; set; }

    /// <summary>
    /// Data de nascimento da pessoa.
    /// </summary>
    public DateTime PessoaDataNascimento { get; set; }

    
    public bool ValidaCpf()
    {
        if (PDocCPF == null)
        {
            return false;
        }
        else
        {
            string cpf = PDocCPF;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) *
                multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;

            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) *
                multiplicador2[i];
            resto = soma % 11;

            if (resto < 2)
                resto = 0;

            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }

}

/// <summary>
/// Enumeração que representa o estado civil.
/// </summary>
public enum EstadoCivil
{
    Solteiro,
    Casado,
    Divorciado,
    Viuvo,
    Separado,
    UniaoEstavel
}
