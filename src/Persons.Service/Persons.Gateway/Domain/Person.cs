namespace Persons.Gateway.Domain;

public class Person
{
    public int Id { get; set; }
    
    public string Name { get; set; } = null!;

    public string? Address { get; set; }
    
    public string? Work { get; set; }
    
    public int? Age { get; set; }
}