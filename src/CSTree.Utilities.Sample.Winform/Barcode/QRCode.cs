using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSTree.Utilities.Sample.Winform
{
    public partial class QRCode : Form
    {
        public QRCode()
        {
            InitializeComponent();
        }

        private void QRCode_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = BarCodeHelper.GenerateQRCode("123", 5);
        }
    }
}
