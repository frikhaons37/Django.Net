namespace djaginet.Models;

public class ProductViewModel
{
    public int Id { get; set; }
    public string Libelle { get; set; } = null!;
    public string Description { get; set; } = null!;
    public Categorie Categorie { get; set; } = null!;
    public double Prix { get; set; }
    public string ImagePath { get; set; } = null!;
}
