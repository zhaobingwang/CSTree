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
            BarCode barCode = new BarCode();
            barCode.BarCodeConfig = new BarCodeConfig { Width = 200, Height = 200 };
            //pictureBox1.Image = barCode.Generate(ZXing.BarcodeFormat.QR_CODE, "123456", 100, 100);
            var avatarPath = AppDomain.CurrentDomain.BaseDirectory + "images/avatar.jpg";
            Bitmap avatar = new Bitmap(avatarPath);
            //pictureBox1.Image = barCode.GenerateQRCodeWithLogo(avatar, "123456", 100, 100);
            pictureBox1.Image = barCode.Generate(ZXing.BarcodeFormat.QR_CODE, "123");

            BarCode barCode1 = new BarCode(100, 100);
            //pictureBox1.Image = barCode1.Generate(ZXing.BarcodeFormat.QR_CODE, "123");
        }
    }
}
