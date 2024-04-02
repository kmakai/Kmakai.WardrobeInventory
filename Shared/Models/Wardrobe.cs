namespace Shared.Models;

public class Wardrobe
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public WardrobeItem? Top => Items?.Where(i => i.ItemType == ItemType.Top).FirstOrDefault();
    public WardrobeItem? Bottom => Items?.Where(i => i.ItemType == ItemType.Bottom).FirstOrDefault();
    public WardrobeItem? Footwear => Items?.Where(i => i.ItemType == ItemType.Footwear).FirstOrDefault();

    public List<WardrobeItem> Items = new List<WardrobeItem>();

}
