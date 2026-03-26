using ConsoleDemo;
using NeatMapper;

var ycard = new YellowCard
{
    Name = "Oleg",
    LastName = "Ivanov",
    DateOfBirth = new DateTime(2000, 1, 1),
    Identity = new YellowCardIdentity
    {
        Number = "2121212",
        Name = "Yellow Card",
        Published = new DateTime(2025, 10, 10)
    },
    IssueName = "Dept of World",
};

var gcard = new GreenCard
{
    DocumName = "Green Card",
    Birth = "12.06.2021",
    DocumIssued = new DateTime(2021, 12, 7),
    FirstName = "Gleb",
    LastName = "Glushko",
    Id = 1001,
    Origin = "Medical Dept",
};

foreach (var card in new object[] { ycard, gcard })
{
    var ucard = new NeatMapper<UniCard>(new NeatMapperOptions { EnableLogging = true }).Map(card, typeof(ConsoleDemo.Converter));
}




