using System;

namespace ReportGenerator;

public class PdfReport : Report
{
    public override void Generate()
    {
        Console.WriteLine("Generating PDF report...");
    }
}
