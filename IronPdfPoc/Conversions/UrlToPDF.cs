namespace IronPdfPoc.Conversions
{
    public class UrlToPDF : IConversion
    {
        public void ExecuteConversion()
        {
            var renderer = new ChromePdfRenderer();

            var pdf = renderer.RenderUrlAsPdf("https://ironpdf.com/");

            pdf.SaveAs("UrlToPDF-Output.pdf");
        }
    }
}
