public class CartService
{
    public List<CartItem> Items = new List<CartItem>();

    // Read-only computed total (sum of price * quantity)
    public int Total => Items.Sum(i => i.Price * i.Quantity);

    public void AddToCart(string name, int quantity, string image, int price)
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
                Image = image,
                Price = price
            });
        }
    }
}

public class CartItem
{
    public string Name;
    public int Quantity;
    public string Image;
    public int Price;
}
