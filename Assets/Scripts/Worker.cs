public class Worker
{
    private string name;
    public string Name { get; set; }  // ENCAPSULATION

    public virtual string Work()
    {
        return "";
    }
}

public class Designer : Worker  // INHERITANCE
{
    public override string Work()  // POLYMORPHISM
    {
        return Design();  // ABSTRACTION
    }
    
    private string Design()
    {
        var result = new[] {"cool UI", "fantastic model", "nothing"};
        return result[UnityEngine.Random.Range(0, result.Length)];
    }
}

public class Developer : Worker  // INHERITANCE
{
    public override string Work()  // POLYMORPHISM
    {
        return Develop();  // ABSTRACTION
    }

    private string Develop()
    {
        var result = new[] {"cool scripts", "super algorithm", "bugs"};
        return result[UnityEngine.Random.Range(0, result.Length)];
    }
}