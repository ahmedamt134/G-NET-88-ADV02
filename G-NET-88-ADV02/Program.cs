namespace G_NET_88_ADV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
            {
                     new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
                     new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
                     new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
                     new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
                     new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
                     new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
                     new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
                     new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
                     new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
                     new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
            };
            #region Task1
            //    static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
            //    {
            //        List<Product> result = new List<Product>();

            //        foreach (Product product in products)
            //        {
            //            if (filter(product))
            //            {
            //                result.Add(product);
            //            }
            //        }

            //        return result;
            //    }

            //    Console.WriteLine("--- Electronics ---");

            //    List<Product> electronics = SearchProducts(
            //        catalog,
            //        p => p.Category == "Electronics"
            //    );

            //    foreach (Product p in electronics)
            //    {
            //        Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            //    }


            //    Console.WriteLine("\n--- Under $50 ---");

            //    List<Product> under50 = SearchProducts(
            //        catalog,
            //        p => p.Price < 50
            //    );

            //    foreach (Product p in under50)
            //    {
            //        Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            //    }


            //    Console.WriteLine("\n--- In Stock ---");

            //    List<Product> inStock = SearchProducts(
            //        catalog,
            //        p => p.Stock > 0
            //    );

            //    foreach (Product p in inStock)
            //    {
            //        Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            //    }


            //    Console.WriteLine("\n--- Clothing Under $100 ---");

            //    List<Product> clothingUnder100 = SearchProducts(
            //        catalog,
            //        p => p.Category == "Clothing" && p.Price < 100
            //    );

            //    foreach (Product p in clothingUnder100)
            //    {
            //        Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            //    }
            //} 
            #endregion


            #region Task3
            //static void PrintReport(List<Product> products, Action<Product> action)
            //{
            //    foreach (Product product in products)
            //    {
            //        action(product);
            //    }
            //}

            //static List<string> TransformProducts(List<Product> products, Func<Product, string> transform)
            //{
            //    List<string> result = new List<string>();

            //    foreach (Product product in products)
            //    {
            //        result.Add(transform(product));
            //    }

            //    return result;
            //}

            //static List<Product> FilterProducts(List<Product> products, Predicate<Product> condition)
            //{
            //    List<Product> result = new List<Product>();

            //    foreach (Product product in products)
            //    {
            //        if (condition(product))
            //        {
            //            result.Add(product);
            //        }
            //    }

            //    return result;
            //}

            //Console.WriteLine("--- Short Report ---");

            //PrintReport(catalog, p =>
            //{
            //    Console.WriteLine($"{p.Name} - ${p.Price}");
            //});


            //Console.WriteLine("\n--- Detailed Report ---");

            //PrintReport(catalog, p =>
            //{
            //    Console.WriteLine(
            //        $"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"
            //    );
            //});

            //Console.WriteLine("\n--- Summary List ---");

            //List<string> summary = TransformProducts(
            //    catalog,
            //    p => $"{p.Name} (${p.Price})"
            //);

            //foreach (string item in summary)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("\n--- Price Labels ---");

            //List<string> labels = TransformProducts(
            //    catalog,
            //    p => p.Price > 100 ? "Expensive!" : "Affordable"
            //);

            //for (int i = 0; i < catalog.Count; i++)
            //{
            //    Console.WriteLine($"{catalog[i].Name}: {labels[i]}");
            //}

            //Console.WriteLine("\n--- Low-Stock Alert ---");

            //List<Product> lowStock = FilterProducts(
            //    catalog,
            //    p => p.Stock < 20
            //);

            //foreach (Product p in lowStock)
            //{
            //    Console.WriteLine($"[LOW STOCK] {p.Name}: only {p.Stock} left!");
            //}

            #endregion
        }
    }
}
