using ReportGenerator;
using ReportGenerator.Interfaces;

List<Report> reports = new List<Report>
{
    new PdfReport(),
    new ExcelReport(),
    new WordReport(),
};

foreach (var report in reports)
{
    report.Generate();

    if (report is IExportable ex) ex.Export();
    if (report is IPrintable pr) pr.Print();
    if (report is IEmailable em) em.SendByEmail();

    Console.WriteLine("-----");
}