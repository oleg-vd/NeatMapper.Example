using NeatMapper;

namespace ConsoleDemo;

public class YellowCard
{
    [NMap<UniCard>(nameof(UniCard.Person.FirstName))]
    public string Name { get; set; }
    
    [NMap<UniCard>(nameof(UniCard.Person.LastName))]
    public string LastName { get; set; }

    [NMap<UniCard>(nameof(UniCard.Person.BirthDate))]
    public DateTime DateOfBirth { get; set; }

    [NMap<UniCard>(nameof(UniCard.Docum))]
    public YellowCardIdentity Identity { get; set; }

    [NMap<UniCard>(nameof(UniCard.Docum.Issue.Name))]
    public string IssueName { get; set; }


}
