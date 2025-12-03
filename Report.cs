using System;

namespace ReportGenerator;

public class Report
{
    public virtual void Generate()
    {
        Console.WriteLine("Generating base report...");
    }
}
