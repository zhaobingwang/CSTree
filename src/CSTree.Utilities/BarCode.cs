using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using ZXing;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;
using ZXing.Common;
using System.Drawing.Imaging;
using ZXing.QrCode.Internal;

namespace CSTree.Utilities
{
    /// <summary>
    /// 条码工具类
    /// </summary>
    public class BarCode
    {
        public BarCode()
        {

        }
        #region 条码生成

        public Bitmap Generate(BarcodeFormat format, string text, int width, int height)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = format;
            if (Is2DBarcode(format))
            {
                QrCodeEncodingOptions options = new QrCodeEncodingOptions();
                options.DisableECI = true;  // 设置内容编码
                options.CharacterSet = "UTF-8"; // 设置二维码的宽度和高度
                options.Margin = 1; // 设置二维码的边距,单位不是固定像素
            }
            else
            {
                EncodingOptions options = new EncodingOptions();
                options.Width = width;
                options.Height = height;
                options.Margin = 1;
                writer.Options = options;
            }

            Bitmap bitmap = writer.Write(text);
            return bitmap;
        }

        /// <summary>
        /// 生成带Logo的二维码
        /// </summary>
        /// <param name="text">内容</param>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        public Bitmap GenerateQRCodeWithLogo(Bitmap logo, string text, int width, int height)
        {
            // 构造二维码写码器
            MultiFormatWriter writer = new MultiFormatWriter();
            Dictionary<EncodeHintType, object> hint = new Dictionary<EncodeHintType, object>();
            hint.Add(EncodeHintType.CHARACTER_SET, "UTF-8");
            hint.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            hint.Add(EncodeHintType.MARGIN, 2); // 旧版本不起作用，需要手动去除白边

            // 生成二维码 
            BitMatrix bm = writer.encode(text, BarcodeFormat.QR_CODE, width + 30, height + 30, hint);
            bm = DeleteWhite(bm);
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            Bitmap qrCode = barcodeWriter.Write(bm);

            // 获取二维码实际尺寸（去掉二维码两边空白后的实际尺寸）
            int[] rectangle = bm.getEnclosingRectangle();

            // 计算插入图片的大小和位置
            int middleW = Math.Min((int)(rectangle[2] / 3), logo.Width);
            int middleH = Math.Min((int)(rectangle[3] / 3), logo.Height);
            int middleL = (qrCode.Width - middleW) / 2;
            int middleT = (qrCode.Height - middleH) / 2;

            Bitmap qrCodeWithLogo = new Bitmap(qrCode.Width, qrCode.Height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(qrCodeWithLogo))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.DrawImage(qrCode, 0, 0, width, height);
                // 白底将二维码插入图片
                g.FillRectangle(Brushes.White, middleL, middleT, middleW, middleH);
                g.DrawImage(logo, middleL, middleT, middleW, middleH);
            }
            return qrCodeWithLogo;
        }
        #endregion

        /// <summary>
        /// 是否是二维码
        /// </summary>
        /// <param name="format">条码码制</param>
        /// <returns></returns>
        private bool Is2DBarcode(BarcodeFormat format)
        {
            if (format == BarcodeFormat.AZTEC || format == BarcodeFormat.DATA_MATRIX
                || format == BarcodeFormat.MAXICODE || format == BarcodeFormat.QR_CODE)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 删除默认对应的空白
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        private static BitMatrix DeleteWhite(BitMatrix matrix)
        {
            int[] rec = matrix.getEnclosingRectangle();
            int resWidth = rec[2] + 1;
            int resHeight = rec[3] + 1;

            BitMatrix resMatrix = new BitMatrix(resWidth, resHeight);
            resMatrix.clear();
            for (int i = 0; i < resWidth; i++)
            {
                for (int j = 0; j < resHeight; j++)
                {
                    if (matrix[i + rec[0], j + rec[1]])
                        resMatrix[i, j] = true;
                }
            }
            return resMatrix;
        }

        #region Obsolete
        //#region 二维码生成
        // Nuget:QRCoder
        ///// <summary>
        ///// 创建一个二维码图片
        ///// </summary>
        ///// <param name="contents">二维码内容信息</param>
        ///// <param name="pixelsPerModule">每个模块像素大小</param>
        ///// <returns></returns>
        //public static Bitmap GenerateQRCode(string contents, int pixelsPerModule = 5)
        //{
        //    QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
        //    QRCodeData qrCodeData = qrCodeGenerator.CreateQrCode(contents, QRCodeGenerator.ECCLevel.Q);
        //    QRCode qrCode = new QRCode(qrCodeData);
        //    Bitmap qrCodeImage = qrCode.GetGraphic(pixelsPerModule);
        //    return qrCodeImage;
        //}

        //// TODO:添加一些生成二维码的重载 
        //#endregion

        //#region 条形码生成
        // Nuget:BarcodeLib
        //// TODO:添加一些生成二维码的重载 
        //public static Image Generate1DBarcode(string contents, int width, int height)
        //{
        //    Barcode barcode = new Barcode();
        //    barcode.IncludeLabel = true;
        //    var img = barcode.Encode(TYPE.UPCA, contents, width, height);
        //    return img;
        //}
        //#endregion 
        #endregion
    }
}
