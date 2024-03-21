using Modules;
using System.Collections;
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Hello, World!");
static void PrintCollectionItems(IEnumerable collection)
{
    foreach (var item in collection)
    {
        Console.WriteLine($"{item}");
    }
}
List<Product> products = new List<Product>()
{
    new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
    new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
    new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
    new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
    new Product(5, "Huawei P30", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
    new Product(6, "MacBook Pro", "MacBook Pro 2021 with mini-LED display may launch between September, November", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
    new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
    new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
    new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
    new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
    new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
    new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
    new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
    new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
    new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
    new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
    new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
    new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
    new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
    new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
    new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
    new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
    new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries)
};

Console.WriteLine("\nAll products with a price greater than $500\n");
List<string> priceOver500 = products.Where(product => product.Price > 500).Select(prod => prod.Title).ToList();
PrintCollectionItems(priceOver500);
Console.WriteLine("\n All Skincare Products.\n");
List<string> skincareProducts = products.Where(product => product.Category == ProductCategory.Skincare).Select(prod => prod.Title).ToList();
PrintCollectionItems(skincareProducts);
Console.WriteLine("\nAll products Titles!\n");
List<string> allTitles = products.Select(product => product.Title).ToList();
PrintCollectionItems(allTitles);
Console.WriteLine("\nTitles of all the products in the Laptops category!\n");
List<string> laptopCategory = products.Where(product => product.Category == ProductCategory.Laptops).Select(prod => prod.Title).ToList();
PrintCollectionItems(laptopCategory);
Console.WriteLine("\nDescriptions of all products with a stock of less than 50!\n");
List<string> lessThan50 = products.Where(product => product.Stock < 50).Select(product => product.Description).ToList();
PrintCollectionItems(lessThan50);
Console.WriteLine("\nTitles of all the products with a rating above 4.5!\n");
List<string> ratingAbove = products.Where(prod => prod.Rating > 4.5).Select(product => product.Title).ToList();
PrintCollectionItems(ratingAbove);
Console.WriteLine("\nTitles of all the products with a price between $100 and $200!\n");
List<string> between100And200 = products.Where(product => product.Price >= 100 && product.Price <= 200).Select(prod => prod.Title).ToList();
PrintCollectionItems(between100And200);
Console.WriteLine("\nTitles of all the products from the Frangrances category with a rating above 4.6!\n");
List<string> fragrancesRatings = products.Where(prod => prod.Category == ProductCategory.Fragrances && prod.Rating > 4.6).Select(prod => prod.Title).ToList();
PrintCollectionItems(fragrancesRatings);
Console.WriteLine("\nBrands of all the products with a price above $1000!\n");
List<string> brandsPricedAbove100 = products.Where(product => product.Price > 1000).Select(prod => prod.Brand).ToList();
PrintCollectionItems(brandsPricedAbove100);
Console.WriteLine("\nTitles of all the products with the word perfume!\n");
List<string> perfumeInWord = products.Where(product => product.Title.Contains("perfume")).Select(prod => prod.Title).ToList();
PrintCollectionItems(perfumeInWord);
Console.WriteLine("\nThe last grocery product!\n");
Product lastGroceryProduct = products.LastOrDefault(prod => prod.Category == ProductCategory.Groceries);
Console.WriteLine($"The last product in the grocery category is: {lastGroceryProduct.Title}");
Console.WriteLine("\nFirst product with a price above 1000!\n");
Product firstPricedAbove1000 = products.FirstOrDefault(prod => prod.Price > 1000);
Console.WriteLine($"The first item in the list priced above $1000 is: {firstPricedAbove1000.Title}");
Console.WriteLine("\nTitles of all products from Groceries category with a stock above 150\n");
List<string> groceriesStockAbove150 = products.Where(product => product.Category == ProductCategory.Groceries && product.Stock > 150).Select(product => product.Title).ToList();
PrintCollectionItems(groceriesStockAbove150);
Console.WriteLine("\nFirst item from the brand Hemani Tea\n");
Product firstHemaniTea = products.First(product => product.Brand == "Hemani Tea");
Console.WriteLine($"The Item named: {firstHemaniTea.Title} is the first item in the list from the bran Hermani Tea with the price of: {firstHemaniTea.Price}");
Console.WriteLine("\n All the ratings of the products with a stock between 30 and 50 \n");
List<double> stockBetween30And50 = products.Where(product => product.Stock >= 30 && product.Stock <= 50).Select(product => product.Rating).ToList();
PrintCollectionItems(stockBetween30And50);
/////////////////////////////////////////////////////////////////////////////BONUSES!
Console.WriteLine("==========BONUSES==========");
Console.WriteLine("Finding the average price of all products");
List<double> averagePrices = products.Select(product => product.Price).ToList();
double result = 0;
double finalResult = 0;
foreach (double item in averagePrices)
{
    result += item;
}
finalResult = result / averagePrices.Count;
Console.WriteLine(finalResult);
Console.WriteLine("\nFinding the total stock of all the products.\n");
int stock = 0;
List<int> totalStock = products.Select(prod => prod.Stock).ToList();
foreach (int stockAmmount in totalStock)
{
    stock += stockAmmount;
}
Console.WriteLine(stock);
Console.WriteLine("\nChecking if there is a product with a price over $2000!\n");
try
{
    List<string> priceOver200 = products.Where(prod => prod.Price > 2000).Select(prod => prod.Title).ToList();
    if (priceOver200.Count > 0)
    {
        foreach (string price in priceOver200)
        {
            Console.WriteLine($"The Item {price} has a price over 2000");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("\nThe most Expensive Laptop. \n");
double mostExpensiveLaptop = 0;
List<Product> everyLaptop = products.Where(prod => prod.Category == ProductCategory.Laptops).ToList();
if (everyLaptop.Count > 0)
{
    mostExpensiveLaptop = everyLaptop.Max(prod => prod.Price);
}
Console.WriteLine(mostExpensiveLaptop);
Console.WriteLine("\n Titles and Descriptions of all products from the Skincare category \n");
var skinCareProduct = from product in products
                      where product.Category == ProductCategory.Skincare
                      select product;
foreach (var product in skinCareProduct)
{
    Console.WriteLine($"Title: {product.Title}, Description: {product.Description}");
}