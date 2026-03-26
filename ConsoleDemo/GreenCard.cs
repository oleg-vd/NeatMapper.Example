using NeatMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo;

public class GreenCard
{
    [NMap<UniCard>(nameof(UniCard.Docum.CardNo))]
    public int Id { get; set; }

    [NMap<UniCard>(nameof(UniCard.Person.BirthDate), nameof(Converter.StrToDate))]
    public string Birth { get; set; }

    [NMap<UniCard>(nameof(UniCard.Person.FirstName))]
    public string FirstName { get; set; }

    [NMap<UniCard>(nameof(UniCard.Person.LastName))]
    public string LastName { get; set; }

    [NMap<UniCard>(nameof(UniCard.Docum.Title))]
    public string DocumName { get; set; }

    [NMap<UniCard>(nameof(UniCard.Docum.Issued))]
    public DateTime DocumIssued { get; set; }

    [NMap<UniCard>(nameof(UniCard.Docum.Issue.Name))]
    public string Origin { get; set; }
}
