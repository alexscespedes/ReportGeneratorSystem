using System;
using ReportGenerator.Interfaces;

namespace ReportGenerator;

public class ExcelReport : Report, IExportable, IPrintable
{
    public override void Generate()
    {
        Console.WriteLine("Generating Excel report...");
    }

    public void Export() => Console.WriteLine("Exporting Excel file...");
    public void Print() => Console.WriteLine("Printing Excel sheet...");
}
