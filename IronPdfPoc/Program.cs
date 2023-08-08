using IronPdfPoc.Enuns;
using IronPdfPoc.Factories;

Console.WriteLine(
@"Escolha o sample de conversão:
1. HtmlFileToPDF,
2. HtmlToPDF, 
3. PDFToHtml,
4. PDFToImages,
5. UrlToPDF");

var option = int.Parse(Console.ReadKey().KeyChar.ToString());

var conversion = ConversionFactory.Create((ConversionType)option);

conversion.ExecuteConversion();