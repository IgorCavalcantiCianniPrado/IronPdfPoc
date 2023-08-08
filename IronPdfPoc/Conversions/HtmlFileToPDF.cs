namespace IronPdfPoc.Conversions
{
    public class HtmlFileToPDF : IConversion
    {
        public void ExecuteConversion()
        {
            var renderer = new ChromePdfRenderer();

            var pdf = renderer.RenderHtmlFileAsPdf("HTML-Input.html");

            pdf.SaveAs("HtmlFileToPDF-Output.pdf");
        }
    }
}
