namespace jtech_models.config;

public class MenuItem
{
    public Guid MenuItemId { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public string Path { get; set; }
    public string Component { get; set; }
    public List<MenuItem> Children { get; set; }
    public bool IsSecondary { get; set; } = false;
}

