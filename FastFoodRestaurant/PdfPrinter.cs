using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace FastFoodRestaurant
{
    internal static class PdfPrinter
    {
        public static void PrintToPdf(DataGridView dataGridView)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    using (PdfWriter writer = new PdfWriter(stream))
                    {
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            using (Document document = new Document(pdf))
                            {
                                AddHeader(document);
                                AddDataToPdf(document, dataGridView);
                                AddFooter(document);
                            }
                        }
                    }

                    ShowPdfInDefaultViewer(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void AddHeader(Document document)
        {
            document.Add(new Paragraph("JisuBee Order History")
                .SetFontSize(18)
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

            document.Add(new Paragraph("Dear esteemed customer,\n\nWe extend our heartfelt gratitude for choosing JisuBee Fast Food Restaurant for your recent dining experience. As we value your patronage, we want to express our sincere appreciation for the opportunity to serve you.\n\nIn this detailed summary, we aim to provide you with an elaborate overview of your recent orders. Each item listed represents our commitment to offering you a diverse and flavorful menu crafted with the finest ingredients. We take pride in ensuring that every dish reflects the passion and dedication of our culinary team.\n\nYour satisfaction is of utmost importance to us, and we hope this summary enhances your understanding of the delightful culinary journey you embarked upon with JisuBee. Should you have any specific preferences, dietary considerations, or special requests for your future visits, please do not hesitate to share them with us. We are here to tailor our services to meet your unique expectations.\n\nAs we strive for continuous improvement, your feedback plays a crucial role in shaping the quality of our offerings. Feel free to share your thoughts, suggestions, or any aspect of your experience that stood out to you. Your insights are invaluable in our pursuit of excellence.\n\nOnce again, thank you for choosing JisuBee Fast Food Restaurant. We look forward to the pleasure of serving you again in the future. May your day be filled with joy and satisfaction.\n\nWarm regards,\nThe JisuBee Fast Food Team")
                .SetFontSize(12)
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT));
        }

        private static void AddDataToPdf(Document document, DataGridView dataGridView)
        {
            iText.Layout.Element.Table table = new iText.Layout.Element.Table(dataGridView.ColumnCount);

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                table.AddCell(new Cell().Add(new Paragraph(column.HeaderText))
                    .SetBackgroundColor(new DeviceRgb(140, 221, 8))); 
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString() ?? ""))
                        .SetBackgroundColor(new DeviceRgb(255, 255, 255))); 
                }
            }

            document.Add(table);
        }

        private static void AddFooter(Document document)
        {
            document.Add(new Paragraph("\n================ Nothing follows ================")
                .SetFontSize(12)
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
        }

        private static void ShowPdfInDefaultViewer(MemoryStream stream)
        {
            string tempFilePath = Path.GetTempFileName() + ".pdf";
            File.WriteAllBytes(tempFilePath, stream.ToArray());
            System.Diagnostics.Process.Start(tempFilePath);
        }
    }
}
