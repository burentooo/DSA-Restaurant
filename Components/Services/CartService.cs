public class CartService
{
    public List<CartItem> Items = new List<CartItem>();

    public void ClearCart()
    {
        Items.Clear();
    }
    public void AddToCart(string name, int quantity, string image, int price)
    {
        var existing = Items.FirstOrDefault(x => x.Name == name);

        if (existing != null)
        {
            existing.Quantity += quantity;
        }
        else
        {
            Items.Insert(0,new CartItem
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
    public string Name = "";
    public int Quantity = 1;
    public string Image = "";
    public int Price;
}
