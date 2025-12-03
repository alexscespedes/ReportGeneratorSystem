using ReportGenerator;

List<Report> reports = new List<Report>
{
    new PdfReport(),
    new ExcelReport(),
    new WordReport(),
};

foreach (var report in reports)
{
    report.Generate();
}