using IronPdfPoc.Conversions;
using IronPdfPoc.Enuns;

namespace IronPdfPoc.Factories
{
    public static class ConversionFactory
    {
        public static IConversion Create(ConversionType conversionType)
        {
            switch (conversionType)
            {
                case ConversionType.HtmlFileToPDF:
                    return new HtmlFileToPDF();

                case ConversionType.HtmlToPDF:
                    return new HtmlToPDF();

                case ConversionType.PDFToHtml:
                    return new PDFToHtml();

                case ConversionType.PDFToImages:
                    return new PDFToImages();

                case ConversionType.UrlToPDF:
                    return new UrlToPDF();

                default:
                    throw new Exception("Invalid conversionType.");
            }
        }
    }
}
