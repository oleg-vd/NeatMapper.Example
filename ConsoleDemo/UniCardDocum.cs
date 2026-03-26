using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo;

public class UniCardDocum
{
    public int CardNo { get; set; }
    public DateTime Issued { get; set; }
    public string Title { get; set; }

    public UniCardDocumIssue Issue { get; set; }
}

public class UniCardDocumIssue
{
    public string Name { get; set; }
}