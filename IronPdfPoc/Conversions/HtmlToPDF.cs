namespace IronPdfPoc.Conversions
{
    public class HtmlToPDF : IConversion
    {
        public void ExecuteConversion()
        {
            var renderer = new ChromePdfRenderer();

            var pdf = renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");

            pdf.SaveAs("HtmlToPDF-Output.pdf");
        }
    }
}
