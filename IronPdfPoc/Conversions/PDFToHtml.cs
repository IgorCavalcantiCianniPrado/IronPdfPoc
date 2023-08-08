namespace IronPdfPoc.Conversions
{
    public class PDFToHtml : IConversion
    {
        public void ExecuteConversion()
        {
            PdfDocument pdf = PdfDocument.FromFile("Foto.pdf");

            // Convert PDF to HTML string
            string html = pdf.ToHtmlString();
            Console.WriteLine(html);

            // Convert PDF to HTML file
            pdf.SaveAsHtml("PDFToHtml-Output.html");

            // PDF to HTML configuration options
            HtmlFormatOptions htmlformat = new HtmlFormatOptions();
            htmlformat.BackgroundColor = Color.White;
            htmlformat.H1Color = Color.Blue;
            htmlformat.H1FontSize = 25;
            htmlformat.H1TextAlignment = TextAlignment.Center;
            htmlformat.PdfPageMargin = 10;

            // Convert PDF to HTML file using configuration options
            pdf.SaveAsHtml("PDFToHtml-OutputFormatted.html", true, "IronPDF Sample - PDFToHtml", htmlFormatOptions: htmlformat);
        }
    }
}
