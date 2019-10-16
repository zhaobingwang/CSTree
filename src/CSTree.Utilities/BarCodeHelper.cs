using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using QRCoder;

namespace CSTree.Utilities
{
    /// <summary>
    /// 条码工具类
    /// </summary>
    public class BarCodeHelper
    {
        /// <summary>
        /// 创建一个二维码图片
        /// </summary>
        /// <param name="contents">二维码内容信息</param>
        /// <param name="pixelsPerModule">每个模块像素大小</param>
        /// <returns></returns>
        public static Bitmap GenerateQRCode(string contents, int pixelsPerModule = 5)
        {
            QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrCodeGenerator.CreateQrCode(contents, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(pixelsPerModule);
            return qrCodeImage;
        }
    }
}
