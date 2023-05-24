using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;
using System.Drawing.Imaging;
using System.Drawing;
using Size = System.Windows.Size;

namespace ParkCinema.Models
{
    public class SendEmail
    {
        //private static byte[] ConvertToPdf(UserControl userControl)
        //{
        //    // Step 1: Render the UserControl to a BitmapSource
        //    var bitmapSource = RenderToBitmap(userControl);

        //    // Step 2: Create a new PDF document
        //    using (var stream = new MemoryStream())
        //    {
        //        var document = new Document(new Rectangle(bitmapSource.PixelWidth, bitmapSource.PixelHeight));
        //        var writer = PdfWriter.GetInstance(document, stream);
        //        document.Open();

        //        // Step 3: Add the BitmapSource as an image to the PDF document
        //        var pdfContentByte = writer.DirectContent;
        //        var image = iTextSharp.text.Image.GetInstance(bitmapSource.ToBitmapImage(), BaseColor.WHITE);
        //        pdfContentByte.AddImage(image);

        //        document.Close();

        //        // Step 4: Return the PDF bytes
        //        return stream.ToArray();
        //    }
        //}

        //private static BitmapSource RenderToBitmap(UIElement element)
        //{
        //    var renderTargetBitmap = new RenderTargetBitmap(
        //        (int)element.RenderSize.Width, (int)element.RenderSize.Height, 96, 96, PixelFormats.Pbgra32);
        //    element.Measure(new Size((int)element.RenderSize.Width, (int)element.RenderSize.Height));
        //    element.Arrange(new Rect(new Size((int)element.RenderSize.Width, (int)element.RenderSize.Height)));
        //    renderTargetBitmap.Render(element);
        //    return renderTargetBitmap;
        //}

        //private static BitmapImage ToBitmapImage(this Bitmap bitmap)
        //{
        //    using (var memory = new MemoryStream())
        //    {
        //        bitmap.Save(memory, ImageFormat.Bmp);
        //        memory.Position = 0;
        //        var bitmapImage = new BitmapImage();
        //        bitmapImage.BeginInit();
        //        bitmapImage.StreamSource = memory;
        //        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
        //        bitmapImage.EndInit();
        //        return bitmapImage;
        //    }
        //}
        //public SendEmail(UIElement userControl)
        //{
        //    using (var stream = new MemoryStream())
        //    {
        //        var document = new Document();
        //        var writer = PdfWriter.GetInstance(document, stream);
        //        document.Open();
        //        var pdfContentByte = writer.DirectContent;

        //        var pdfReader = new PdfReader(GetPdfBytes(RenderToBitmap(userControl)));
        //        for (int i = 1; i <= pdfReader.NumberOfPages; i++)
        //        {
        //            var pdfImportedPage = writer.GetImportedPage(pdfReader, i);
        //            pdfContentByte.AddTemplate(pdfImportedPage, 0, 0);
        //            document.NewPage();
        //        }

        //        document.Close();

        //        // Step 2: Save the PDF to a temporary file
        //        var tempFilePath = Path.GetTempFileName();
        //        File.WriteAllBytes(tempFilePath, stream.ToArray());

        //        // Step 3: Attach the PDF to an email
        //        var message = new MailMessage();
        //        message.From = new MailAddress("your-email@example.com");
        //        message.To.Add(new MailAddress("recipient-email@example.com"));
        //        message.Subject = "PDF Report";
        //        message.Body = "Please find attached the PDF report.";
        //        var attachment = new Attachment(tempFilePath);
        //        message.Attachments.Add(attachment);

        //        // Step 4: Send the email
        //        using (var client = new SmtpClient("smtp.example.com"))
        //        {
        //            client.Send(message);
        //        }
        //    }


        //}
    }
}
