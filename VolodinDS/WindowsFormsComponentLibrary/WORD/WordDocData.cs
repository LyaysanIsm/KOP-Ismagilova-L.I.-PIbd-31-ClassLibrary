using System.Data;

namespace WindowsFormsComponentLibrary.WORD
{
    public class WordDocData
    {
        public string Path { get; set; }
        public string DiagramName { get; set; }
        public DataTable Data { get; set; }
        public string[] CategoryNames { get; set; }
    }
}
