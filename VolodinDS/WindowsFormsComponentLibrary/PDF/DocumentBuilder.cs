using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsComponentLibrary.PDF
{
    public class DocumentBuilder
    {
        public static void BuildDoc(DocParams docParams)
        {
            CheckData(docParams);
            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(docParams.Path));
            Document document = new Document(pdfDocument);
            Queue<string> headers = new Queue<string>();
            for (int i = 0; i < docParams.Data.Rows.Count; i++)
            {
                if (!string.IsNullOrEmpty(docParams.Data.Rows[i].ItemArray[0].ToString())) {
                    headers.Enqueue(docParams.Data.Rows[i].ItemArray[0].ToString());
                }
            }
            Table table = new Table(docParams.Data.Columns.Count);
            table.UseAllAvailableWidth();
            int currentRow = 0;
            foreach (var unifiedRow in docParams.CellsToUnify)
            {
                Cell headerCell = new Cell(unifiedRow, 1);
                headerCell.Add(new Paragraph(headers.Dequeue()));
                table.AddCell(headerCell);
                for (int i = 0; i < unifiedRow; i++)
                {
                    for (int j = 1; j < docParams.Data.Columns.Count; j++)
                    {
                        table.AddCell(docParams.Data.Rows[currentRow].ItemArray[j].ToString());
                    }
                    currentRow++;
                }
            }
            document.Add(table);
            document.Close();
        }

        private static void CheckData(DocParams docParams)
        {
            if (docParams.Data == null && docParams.CellsToUnify == null 
                && string.IsNullOrEmpty(docParams.Path))
            {
                throw new NullReferenceException("Один из параметров сохранения " +
                    "документа не ссылается на объект");
            }
            if (docParams.Data.Rows == null && docParams.Data.Columns == null)
            {
                throw new NullReferenceException("Ссылка на коллекцию строк или " +
                    "коллекцию столбцов таблицы равна null");
            }
            if (docParams.Data.Rows.Count == 0 && docParams.Data.Columns.Count == 0)
            {
                throw new Exception("Таблица должна содержать хотя бы " +
                    "один столбец и хотя бы одну строку");
            }
            if (docParams.CellsToUnify.Sum() != docParams.Data.Rows.Count)
            {
                throw new Exception("Сумма строк в заголовках не " +
                    "равна сумме строк в остальной части таблицы");
            }
        }
    }
}
