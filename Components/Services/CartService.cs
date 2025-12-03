public class CartService
{
    public List<CartItem> Items { get; set; } = new List<CartItem>();

    public void AddToCart(string name, int quantity, string image)
    {
        var existing = Items.FirstOrDefault(x => x.Name == name);

        if (existing != null)
        {
            existing.Quantity += quantity;
        }
        else
        {
            Items.Add(new CartItem
            {
                Name = name,
                Quantity = quantity,
                Image = image
            });
        }
    }
}

public class CartItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string Image { get; set; }
}