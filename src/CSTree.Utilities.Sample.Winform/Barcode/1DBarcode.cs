using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSTree.Utilities;

namespace CSTree.Utilities.Sample.Winform
{
    public partial class _1DBarcode : Form
    {
        public _1DBarcode()
        {
            InitializeComponent();
        }

        private void _1DBarcode_Load(object sender, EventArgs e)
        {
            BarCode barCode = new BarCode();
            var img = barCode.Generate(ZXing.BarcodeFormat.CODE_128, "123456", 150, 75);
            pictureBox1.Image = img;
        }
    }
}
