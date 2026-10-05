Console.WriteLine("=== Product Entry System ===");

Console.Write("Enter product name: ");
string productName = Console.ReadLine() ?? "<Unnamed Product>";

Console.Write("Enter product price: ");

bool priceValid = decimal.TryParse(
    Console.ReadLine(),
    out decimal price
);

if (!priceValid)
{
    price = 0;
}

Console.Write("Enter product quantity: ");

bool quantityValid = int.TryParse(
    Console.ReadLine(),
    out int quantity
);

if (!quantityValid)
{
    quantity = 0;
}

decimal totalValue = price * quantity;

Console.WriteLine();
Console.WriteLine("=== Product Details ===");
Console.WriteLine($"Product: {productName}");
Console.WriteLine($"Price: ₹{price}");
Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Total Value: ₹{totalValue}");

if (quantity == 0)
{
    Console.WriteLine("Stock Status: Out of Stock!");
}
else if (quantity < 5)
{
    Console.WriteLine("Stock Status: Low Stock!");
}
else if (quantity <= 20)
{
    Console.WriteLine($"Stock Status: {quantity} units available");
}
else
{
    Console.WriteLine("Stock Status: good stock");
}