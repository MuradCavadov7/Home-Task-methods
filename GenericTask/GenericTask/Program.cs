namespace GenericTask;

internal class Program
{
    static void Main(string[] args)
    {
        Wolf wolf = new Wolf
        {
            Breed = "Alpha",
            HP = 1000,
            AttackDamage = 444,
            IsPrideLeader = true
        };

        Elephant elephant = new Elephant
        {
            Breed = "Asian Elephant",
            HP = 10000,
            Weight = 5420,
            IsTrained = false
        };


        wolf.Hunt(elephant);
        Console.WriteLine($"Elephant-ın qalan HP-si: {elephant.HP}");

        ZooCage<Wolf, Meat> wolfCage = new ZooCage<Wolf, Meat>
        {

            Animal = new Wolf { Breed = "Alpha", HP = 1000, AttackDamage = 444 },
            Food = new Meat { Calori = 10000, Name = "Allah xasiyyetin kessin ancaq Fil eti yeyir" }
        };
        Console.WriteLine("Wolf Cage:");
        Console.WriteLine(wolfCage.Animal);
        Console.WriteLine(wolfCage.Food);
        ZooCage<Elephant, Grass> elephantCage = new ZooCage<Elephant, Grass>
        {
            Animal = new Elephant { Breed = "Asian Elephant", HP = 180, Weight = 5500 },
            Food = new Grass { Calori = 200, Name = "Yasil ot" }

        };
        Console.WriteLine("Elephant Cage:");
        Console.WriteLine(elephantCage.Animal);
        Console.WriteLine(elephantCage.Food);
    }
}
