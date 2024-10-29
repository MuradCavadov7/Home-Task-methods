namespace GenericTask;

public abstract class Food
{
    public int Calori { get; set; }
}
public class Meat : Food
{
    public string Name { get; set; }
    public override string ToString()
    {
        return $"FoodName:{Name},Calori:{Calori}";
    }
}

public class Grass : Food
{
    public string Name { get; set; }
    public override string ToString()
    {
        return $"FoodName:{Name},Calori:{Calori}";
    }
}

