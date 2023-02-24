using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESVision
{
    public partial class FileOptionView : Form
    {
        public FileOptionSetup FileOption { get; set; }
        public FileOptionView()
        {
            InitializeComponent();
        }

        private void FileOptionView_Load(object sender, EventArgs e)
        {
            prgFileOption.SelectedObject = FileOption;
        }
    }
}
