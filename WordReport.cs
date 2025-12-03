using System;

namespace ReportGenerator;

public class WordReport : Report
{
    public override void Generate()
    {
        Console.WriteLine("Generating Word report...");
    }
}
