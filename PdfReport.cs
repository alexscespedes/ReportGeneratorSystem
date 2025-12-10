using System;
using ReportGenerator.Interfaces;

namespace ReportGenerator;

public class PdfReport : Report, IExportable, IPrintable, IEmailable
{
    public override void Generate()
    {
        Console.WriteLine("Generating PDF report...");
    }

    public void Export() => Console.WriteLine("Exporting PDF...");
    public void Print() => Console.WriteLine("Printing PDF...");
    public void SendByEmail() => Console.WriteLine("Sending PDF via email...");
}
