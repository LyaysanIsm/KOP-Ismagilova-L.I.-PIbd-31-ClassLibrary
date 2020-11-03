using System.Data;

namespace WindowsFormsComponentLibrary.PDF
{
    public class DocParams
    {
        public string Path { get; set; }
        public DataTable Data { get; set; }
        public int[] CellsToUnify { get; set; }
    }
}
