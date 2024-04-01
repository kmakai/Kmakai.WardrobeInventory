namespace Shared.Models;

public class Wardrobe
{
    public int Id { get; set; }
    public string? Name { get; set; }

    private WardrobeItem? Top => Items?.Where(i => i.ItemType == ItemType.Top).FirstOrDefault();
    private WardrobeItem? Bottom => Items?.Where(i => i.ItemType == ItemType.Bottom).FirstOrDefault();
    private WardrobeItem? Footwear => Items?.Where(i => i.ItemType == ItemType.Footwear).FirstOrDefault();

    public List<WardrobeItem> Items { get; set; } = new List<WardrobeItem>();

}
