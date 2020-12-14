using ClassLibraryPlugins.Interfaces;
using ClassLibraryPlugins.Models;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using PluginWaybill.HelperModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.IO;
using MigraDoc.Rendering;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginWaybill
{
    [Export(typeof(IWaybill<Product>))]
    public class CreateWaybill : IWaybill<Product>
    {
        public string Name => "Формирование накладной";
        public void Create(Product obj)
        {
            Document document = new Document();
            DefineStyles(document);
            Section section = document.AddSection();
            Paragraph paragraph = section.AddParagraph("Накладная");
            paragraph.Format.SpaceAfter = "1cm";
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.Style = "NormalTitle";
            var table = document.LastSection.AddTable();
            List<string> columns = new List<string> { "3cm", "6cm", "3cm", "5cm" };
            foreach (var elem in columns)
            {
                table.AddColumn(elem);
            }
            CreateRow(new PdfRowParameters
            {
                Table = table,
                Texts = new List<string> { "Название", "Категория", "Количество", "Качество" },
                Style = "NormalTitle",
                ParagraphAlignment = ParagraphAlignment.Center
            });
            CreateRow(new PdfRowParameters
            {
                Table = table,
                Texts = new List<string> {
                        obj.Name,
                        obj.Category.ToString(),
                        obj.Count.ToString(),
                        obj.KindOfProduct.ToString(),
                    },
                Style = "Normal",
                ParagraphAlignment = ParagraphAlignment.Left
            });
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true,
           PdfSharp.Pdf.PdfFontEmbedding.Always)
            {
                Document = document
            };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(new FileStream(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins", "Pdf.pdf"), FileMode.OpenOrCreate));
            Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins", "Pdf.pdf"));
        }
        private static void DefineStyles(Document document)
        {
            Style style = document.Styles["Normal"];
            style.Font.Name = "Times New Roman";
            style.Font.Size = 14;
            style = document.Styles.AddStyle("NormalTitle", "Normal");
            style.Font.Bold = true;
        }
        private static void CreateRow(PdfRowParameters rowParameters)
        {
            Row row = rowParameters.Table.AddRow();
            for (int i = 0; i < rowParameters.Texts.Count; ++i)
            {
                FillCell(new PdfCellParameters
                {
                    Cell = row.Cells[i],
                    Text = rowParameters.Texts[i],
                    Style = rowParameters.Style,
                    BorderWidth = 0.5,
                    ParagraphAlignment = rowParameters.ParagraphAlignment
                });
            }
        }
        private static void FillCell(PdfCellParameters cellParameters)
        {
            cellParameters.Cell.AddParagraph(cellParameters.Text);
            if (!string.IsNullOrEmpty(cellParameters.Style))
            {
                cellParameters.Cell.Style = cellParameters.Style;
            }
            cellParameters.Cell.Borders.Left.Width = cellParameters.BorderWidth;
            cellParameters.Cell.Borders.Right.Width = cellParameters.BorderWidth;
            cellParameters.Cell.Borders.Top.Width = cellParameters.BorderWidth;
            cellParameters.Cell.Borders.Bottom.Width = cellParameters.BorderWidth;
            cellParameters.Cell.Format.Alignment = cellParameters.ParagraphAlignment;
            cellParameters.Cell.VerticalAlignment = VerticalAlignment.Center;
        }
    }
}