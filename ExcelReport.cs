using System;

namespace ReportGenerator;

public class ExcelReport : Report
{
    public override void Generate()
    {
        Console.WriteLine("Generating Excel report...");
    }
}
