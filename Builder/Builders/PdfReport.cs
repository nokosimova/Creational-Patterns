public class PdfReport : ReportBuilder
{
    public override void SetReportContent()
    {
        reportObject.ReportContent = "Pdf Content Section";
    }

    public override void SetReportType()
    {
        reportObject.ReportType = "PDF";
    }

    public override void SetReportHeader()
    {
        reportObject.ReportHeader = "Pdf Header";
    }

    public override void SetReportFooter()
    {
        reportObject.ReportFooter = "Pdf Footer";
    }
}