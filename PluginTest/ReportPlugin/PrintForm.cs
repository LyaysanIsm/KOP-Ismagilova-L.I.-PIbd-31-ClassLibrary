using ReportPlugin.Models;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ReportPlugin
{
    public partial class PrintForm : Form
    {
        private readonly ReportPlugin plugin;
        private PrintData printData;
        private readonly Font boldFont;
        private readonly Font regularFont;
        private readonly Brush reportBrush;
        private readonly Pen reportPen;

        public PrintForm(ReportPlugin plugin)
        {
            InitializeComponent();
            this.plugin = plugin;
            boldFont = new Font(FontFamily.GenericMonospace, 20, FontStyle.Bold);
            regularFont = new Font(FontFamily.GenericMonospace, 20, FontStyle.Regular);
            reportPen = Pens.Black;
            reportBrush = Brushes.Black;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            printData = plugin.GetPrintData();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle
            {
                X = 0,
                Y = 0,
                Height = 500,
                Width = e.PageBounds.Width
            });

            e.Graphics.DrawString($"Накладная {printData.InvoiceNumber}", boldFont, reportBrush, 50, 50);

            e.Graphics.DrawString("Дата отгрузки:", boldFont, reportBrush, 50, 100);
            e.Graphics.DrawString($"{printData.DateOfSupply}", regularFont, reportBrush, 300, 100);

            e.Graphics.DrawString($"Заказчик:", boldFont, reportBrush, 50, 150);
            e.Graphics.DrawString($"{printData.CustomerName}", regularFont, reportBrush, 220, 150);

            e.Graphics.DrawString($"Адрес:", boldFont, reportBrush, 50, 200);
            e.Graphics.DrawString($"{printData.CustomerAddress}", regularFont, reportBrush, 170, 200);

            e.Graphics.DrawLine(reportPen, 0, 250, e.PageBounds.Right, 250);

            e.Graphics.DrawString($"Информация о товаре:", boldFont, reportBrush, 250, 300);

            e.Graphics.DrawLine(reportPen, 0, 350, e.PageBounds.Right, 350);

            e.Graphics.DrawString($"Название:", boldFont, reportBrush, 50, 375);
            e.Graphics.DrawString($"{printData.ProductName}", regularFont, reportBrush, 220, 375);

            e.Graphics.DrawLine(reportPen, 0, 425, e.PageBounds.Right, 425);

            e.Graphics.DrawString($"Единица измерения:", boldFont, reportBrush, 50, 450);
            e.Graphics.DrawString($"{printData.ProductUnit}", regularFont, reportBrush, 370, 450);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDialog.Document.Print();
            }
        }
    }
}
