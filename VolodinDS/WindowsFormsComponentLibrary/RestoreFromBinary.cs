using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsComponentLibrary
{
    public partial class RestoreFromBinary : Component
    {
        public RestoreFromBinary()
        {
            InitializeComponent();
        }

        public RestoreFromBinary(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


    }
}
