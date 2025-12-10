using System;
using ReportGenerator.Interfaces;

namespace ReportGenerator;

public class WordReport : Report, IPrintable
{
    public override void Generate()
    {
        Console.WriteLine("Generating Word report...");
    }

    public void Print() => Console.WriteLine("Printing Word document...");
}
