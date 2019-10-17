using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using QRCoder;
using BarcodeLib;

namespace CSTree.Utilities
{
    /// <summary>
    /// 条码工具类
    /// </summary>
    public class BarCodeHelper
    {
        #region 二维码生成
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

        // TODO:添加一些生成二维码的重载 
        #endregion

        #region 条形码生成
        // TODO:添加一些生成二维码的重载 
        public static Image Generate1DBarcode(string contents, int width, int height)
        {
            Barcode barcode = new Barcode();
            var img = barcode.Encode(BarcodeLib.TYPE.CODE128, contents, width, height);
            return img;
        }
        #endregion
    }
}
