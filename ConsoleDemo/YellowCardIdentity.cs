using NeatMapper;

namespace ConsoleDemo;

public class YellowCardIdentity
{
    [NMap<UniCard>(nameof(UniCardDocum.CardNo), nameof(Converter.StrToInt))]
    public string Number { get; set; }
    
    [NMap<UniCard>(nameof(UniCardDocum.Title))]
    public string Name { get; set; }

    [NMap<UniCard>(nameof(UniCardDocum.Issued))]
    public DateTime Published { get; set; } 
}
