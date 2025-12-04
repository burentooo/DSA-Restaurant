public class CartService
{
    public List<CartItem> Items = new List<CartItem>();

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
    public string Name;
    public int Quantity;
    public string Image;
}
