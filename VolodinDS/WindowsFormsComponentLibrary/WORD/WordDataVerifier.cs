using System;

namespace WindowsFormsComponentLibrary.WORD
{
    public static class WordDataVerifier
    {
        public static void CheckData(WordDocData docData)
        {
            if (docData.Data == null)
            {
                throw new NullReferenceException("Ссылка на таблицу содержит значение null");
            }
            if (docData.Data.Rows == null && docData.Data.Columns == null)
            {
                throw new NullReferenceException("Ссылка на коллекцию строк или " +
                    "коллекцию столбцов таблицы содержит значение null");
            }
            if (docData.Data.Rows.Count == 0 && docData.Data.Columns.Count == 0)
            {
                throw new Exception("Таблица должна содержать хотя бы " +
                    "один столбец и хотя бы одну строку");
            }
            if (docData.CategoryNames == null)
            {
                throw new NullReferenceException("Ссылка на массив с именами содержит значение null");
            }
            if (docData.CategoryNames.Length != docData.Data.Rows.Count)
            {
                throw new Exception("Количество имен в массиве категорий не " +
                    "совпадает с числом строк в таблице");
            }
        }
    }
}
