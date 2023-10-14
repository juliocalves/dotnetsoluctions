namespace jtech_models.config;
/// <summary>
/// Representa um template de interface de usuário.
/// </summary>
public class TemplateUi
{
    /// <summary>
    ///  Nome do template.
    /// </summary>
    public string TempUiName { get; set; }
    public List<Menu> TempUiMenus { get; set; }
    public TemplateTheme TempUiTheme {get;set;}
    
}

public enum TemplateTheme
{
    Light,
    Dark
}