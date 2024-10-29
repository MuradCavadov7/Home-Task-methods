namespace GenericTask;

public abstract class Animal
{
    public int AvgLifeTime { get; set; }

    public enum AnimalGender
    {
        Male,
        Female
    }
    public AnimalGender Gender { get; set; }
    public string Breed { get; set; }
    public int HP { get; set; }
}

public class Wolf : Animal
{
    public bool IsPrideLeader { get; set; }
    public int AttackDamage { get; set; }
    public override string ToString()
    {
        return $"Breed:{Breed}, Gender:{Gender}, AttackDamage:{AttackDamage} , HP:{HP}";
    }
    public void Hunt<T>(T animal) where T : Animal
    {
        animal.HP -= AttackDamage;

        if (animal.HP <= 0)
        {
            Console.WriteLine("FATALITY");
        }
    }
}
public class Elephant : Animal
{
    public double Weight { get; set; }
    public bool IsTrained { get; set; }

    public override string ToString()
    {
        return $"Breed:{Breed} ,Weight:{Weight}, HP:{HP}";
    }
}