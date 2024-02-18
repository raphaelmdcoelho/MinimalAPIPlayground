namespace MinimalApiPlayground.Modes;

public class User
{
    public Guid Id { get; init; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string Name { 
        get 
        {
            return $"{FirstName} {LastName}";
        } 
    }
}