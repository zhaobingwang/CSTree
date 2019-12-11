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
    public partial class BarcodeSample : Form
    {
        BarCode barCode1D = null;
        BarCode barCode2D = null;
        BarCodeConfig barCodeConfig1D = null;
        BarCodeConfig barCodeConfig2D = null;
        QrCodeEncodingConfig qrCodeEncodingConfig = null;
        string barCodeContents = null;
        public BarcodeSample()
        {
            InitializeComponent();
            barCode1D = new BarCode();
            barCode2D = new BarCode();

            InitConfig();
        }

        private void BarcodeSample_Load(object sender, EventArgs e)
        {
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            InitConfig();

            barCodeContents = rtxBarcode.Text;

            // 一维码
            barCode1D.BarCodeConfig = barCodeConfig1D;
            var bitmap1DBarcode = barCode1D.Generate(ZXing.BarcodeFormat.CODE_128, barCodeContents);
            pic1D.Image = bitmap1DBarcode;

            // 二维码
            barCode2D.BarCodeConfig = barCodeConfig2D;
            var bitmap2DBarcode = barCode2D.Generate(ZXing.BarcodeFormat.QR_CODE, barCodeContents);
            pic2D.Image = bitmap2DBarcode;
        }

        private void btnGenerateQRCodeWithLogo_Click(object sender, EventArgs e)
        {
            InitConfig();

            //barCodeContents = rtxBarcode.Text;

            //var logo = new Bitmap($"{AppDomain.CurrentDomain.BaseDirectory}images/avatar.jpg");
            //barCode2D.BarCodeConfig = qrCodeEncodingConfig;
            //var bitmap2DBarcode = barCode2D.GenerateQRCodeWithLogo(logo, barCodeContents);
            //pic2D.Image = bitmap2DBarcode;
        }

        private void InitConfig()
        {
            barCodeConfig1D = new BarCodeConfig()
            {
                Width = int.Parse(txt1DBarcodeWidth.Text),
                Height = int.Parse(txt1DBarcodeHeight.Text)
            };

            barCodeConfig2D = new BarCodeConfig()
            {
                Width = int.Parse(txt2DBarcodeWidth.Text),
                Height = int.Parse(txt2DBarcodeHeight.Text),
                Margin = 1,
            };
            //qrCodeEncodingConfig = new QrCodeEncodingConfig()
            //{
            //    Width = int.Parse(txt2DBarcodeWidth.Text),
            //    Height = int.Parse(txt2DBarcodeHeight.Text)
            //};
        }
    }
}
