namespace jtech_models.config;

/// <summary>
/// representa um menu de um template de interface de usuário.
/// </summary>
public class Menu{
    public Guid MenuId { get; set; }
    public string Name { get; set; }
    public string BrandIconPath { get; set; }
    public MenuStyle MenuStyle { get; set; }
    public List<MenuItem> MenuItems { get; set; }
}
public enum MenuStyle
{
    Sidebar,
    Topbar,
}