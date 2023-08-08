# IronPdfPoc
POC em .Net Core testando alguns recursos da lib IronPDF

# Tipos de conversão utilizados
A lib IronPDF possui muitos recursos de conversão. Nesta POC específica, que tem como objetivo testes básicos para o entendimento inicial da lib, foram utilizados os seguintes tipos de conversão:
1. HtmlFileToPDF
2. HtmlToPDF
3. PDFToHtml
4. PDFToImages
5. UrlToPDF

# Utilizando o projeto
Ao executar o projeto IronPdfPoc, você verá o seguinte console:

![image](https://github.com/IgorCavalcantiCianniPrado/IronPdfPoc/assets/86272097/91425048-0ecd-4fbb-a64b-528b9c46cdbd)

Escolhendo o tipo de conversão no console, você estará definindo o **ConversionType**, que será usado para construir o objeto de conversão correto no **ConversionFactory**.

Insira um breakpoint no **Program.cs**, na linha onde a **ConversionFactory** será utilizada, para verificar o fluxo do programa. 

# Arquivos de saída
Após a execução de todos os tipos de conversão, os seguintes arquivos de saída são gerados, na pasta onde se encontra o **.exe** da aplicação:
1. HtmlFileToPDF:
   - HtmlFileToPDF-Output.pdf
3. HtmlToPDF:
   - HtmlToPDF-Output.pdf
5. PDFToHtml:
   - PDFToHtml-Output.html
   - PDFToHtml-OutputFormatted.html
6. PDFToImages:
   - PDFToImagesOutput_1.png
   - PDFToImagesOutput_2.png
   - PDFToImagesOutput_3.png
   - PDFToImagesOutput_4.png
   - PDFToImagesOutputFormatted_1.jpg
   - PDFToImagesOutputFormatted_2.jpg
   - PDFToImagesOutputFormatted_3.jpg
   - PDFToImagesOutputFormatted_4.jpg
7. UrlToPDF:
   - UrlToPDF-Output.pdf



