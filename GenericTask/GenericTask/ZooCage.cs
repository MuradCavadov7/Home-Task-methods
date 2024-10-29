namespace GenericTask;

public class ZooCage<T, U> where T : Animal, new() where U : Food, new()
{
    public T Animal { get; set; }
    public U Food { get; set; }
    public ZooCage()
    {
        Animal = new T();
        Food = new U();
    }
    public ZooCage(T animal, U food)
    {
        Animal = animal;
        Food = food;
    }
}
