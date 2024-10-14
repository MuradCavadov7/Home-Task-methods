namespace firstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[]
            {
                new Product("Clothes", "Colin's", 235.65),
                 new Product("Trousers", "Dolce&Gabbana", 340.45),
                 new Product("Shoes", "NIKE", 200.25),
                 new Product("Jacket","Burberry",1935.20),
                 new Product("Coat","FURSAC",739.39),
                 new Product("Watch","HUBLOD",15600.75)

            };
            magazineSystem(product, 300.50, 5000.100);
        }

         static void magazineSystem( Product[] product, double minPrice, double maxPrice)
        {
            Console.WriteLine($"Mehsul {minPrice} - {maxPrice} arasindadir \n ");
            foreach (var products in product) 
            {
                if (products.Price>=minPrice && products.Price <= maxPrice)
                {
                    Console.WriteLine($"Mehsul:{products.Name} Qiymeti:{products.Price}$");
                }
                else
                {
                    
                    Console.WriteLine("Mehsul uygun deyil");
                }
            }

        }
    }
}
