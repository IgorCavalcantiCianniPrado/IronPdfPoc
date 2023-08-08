using IronSoftware.Drawing;

namespace IronPdfPoc.Conversions
{
    public class PDFToImages : IConversion
    {
        public void ExecuteConversion()
        {
            var pdf = PdfDocument.FromFile("PDFToImages.pdf");

            // Extract all pages to a folder as image files
            pdf.RasterizeToImageFiles(@"PDFToImagesOutput_*.png");

            // Dimensions and page ranges may be specified
            pdf.RasterizeToImageFiles(@"PDFToImagesOutputFormatted_*.jpg", 100, 80);

            // Extract all pages as AnyBitmap objects
            AnyBitmap[] pdfBitmaps = pdf.ToBitmap();
        }
    }
}
