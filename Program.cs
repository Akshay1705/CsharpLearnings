decimal CalculateTotalValue(decimal price, int quantity)
{
    return price * quantity;
}

string GetStockStatus(int quantity)
{
    if (quantity == 0)
    {
        return "Out of Stock!";
    }
    else if (quantity < 5)
    {
        return "Low Stock!";
    }
    else if (quantity <= 20)
    {
        return $"{quantity} units available";
    }
    else
    {
        return "Good stock";
    }
}

Console.WriteLine("=== Product Entry System ===");

Product product = new Product();

Console.Write("Enter product name: ");
product.Name = Console.ReadLine() ?? "<Unnamed Product>";

Console.Write("Enter product price: ");

bool priceValid = decimal.TryParse(
    Console.ReadLine(),
    out decimal price
);

while (!priceValid || price < 0)
{
    Console.WriteLine("Please enter a valid price (0 or greater).");
    Console.Write("Enter product price: ");

    priceValid = decimal.TryParse(
        Console.ReadLine(),
        out price
    );
}

product.Price = price;

Console.Write("Enter product quantity: ");

bool quantityValid = int.TryParse(
    Console.ReadLine(),
    out int quantity
);

while (!quantityValid || quantity < 0)
{
    Console.WriteLine("Please enter a valid quantity (0 or greater).");
    Console.Write("Enter product quantity: ");

    quantityValid = int.TryParse(
        Console.ReadLine(),
        out quantity
    );
}

product.Quantity = quantity;

decimal totalValue = CalculateTotalValue(
    product.Price,
    product.Quantity
);

Console.WriteLine();

Console.WriteLine("=== Product Details ===");

Console.WriteLine($"Product: {product.Name}");
Console.WriteLine($"Price: ₹{product.Price}");
Console.WriteLine($"Quantity: {product.Quantity}");
Console.WriteLine($"Total Value: ₹{totalValue}");
Console.WriteLine(
    $"Stock Status: {GetStockStatus(product.Quantity)}"
);