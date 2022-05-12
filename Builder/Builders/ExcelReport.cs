public class ExcelReport : ReportBuilder
{
    public override void SetReportContent()
    {
        reportObject.ReportContent = "Excel Content Section";
    }

    public override void SetReportType()
    {
        reportObject.ReportType = "EXCEL";
    }

    public override void SetReportHeader()
    {
        reportObject.ReportHeader = "Excel Header";
    }

    public override void SetReportFooter()
    {
        reportObject.ReportFooter = "Excel Footer";
    }
}