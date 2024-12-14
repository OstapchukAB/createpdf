using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;

class Program
{
    static void Main()
    {
        string filePath = "example.pdf";

        // Создание документа
        PdfDocument document = new PdfDocument();
        document.Info.Title = "Hello PDF";

        // Добавление страницы
        PdfPage page = document.AddPage();
        XGraphics gfx = XGraphics.FromPdfPage(page);

        // Создание шрифта без указания стиля
        XFont font = new XFont("Verdana", 20);

        // Рисуем текст
        gfx.DrawString("Здравствуй МИР!", font, XBrushes.Black, 
            new XRect(0, 0, page.Width.Point, page.Height.Point),
            XStringFormats.Center);

        // Сохраняем документ
        document.Save(filePath);
        Console.WriteLine($"PDF успешно создан: {filePath}");
    }
}
