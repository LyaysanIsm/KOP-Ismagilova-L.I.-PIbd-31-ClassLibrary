using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryListBox2
{
    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Items { get; set; }
        public int Course { get; set; }
        public int Age { get; set; }

    }
}