namespace CSTree.Utilities.Sample.Winform
{
    partial class BarcodeSample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxBarcodeParams = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateQRCodeWithLogo = new System.Windows.Forms.Button();
            this.rtxBarcode = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBoxBarode = new System.Windows.Forms.GroupBox();
            this.tbBarcode = new System.Windows.Forms.TableLayoutPanel();
            this.pic2D = new System.Windows.Forms.PictureBox();
            this.pic1D = new System.Windows.Forms.PictureBox();
            this.txt1DBarcodeWidth = new System.Windows.Forms.TextBox();
            this.txt2DBarcodeWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1DBarcodeHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt2DBarcodeHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxBarcodeParams.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBoxBarode.SuspendLayout();
            this.tbBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1D)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBarcodeParams
            // 
            this.groupBoxBarcodeParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBarcodeParams.Controls.Add(this.txt2DBarcodeHeight);
            this.groupBoxBarcodeParams.Controls.Add(this.label5);
            this.groupBoxBarcodeParams.Controls.Add(this.txt1DBarcodeHeight);
            this.groupBoxBarcodeParams.Controls.Add(this.label4);
            this.groupBoxBarcodeParams.Controls.Add(this.txt2DBarcodeWidth);
            this.groupBoxBarcodeParams.Controls.Add(this.label3);
            this.groupBoxBarcodeParams.Controls.Add(this.txt1DBarcodeWidth);
            this.groupBoxBarcodeParams.Controls.Add(this.label2);
            this.groupBoxBarcodeParams.Controls.Add(this.label1);
            this.groupBoxBarcodeParams.Controls.Add(this.btnGenerateQRCodeWithLogo);
            this.groupBoxBarcodeParams.Controls.Add(this.rtxBarcode);
            this.groupBoxBarcodeParams.Controls.Add(this.btnGenerate);
            this.groupBoxBarcodeParams.Location = new System.Drawing.Point(20, 25);
            this.groupBoxBarcodeParams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBarcodeParams.Name = "groupBoxBarcodeParams";
            this.groupBoxBarcodeParams.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBarcodeParams.Size = new System.Drawing.Size(1189, 384);
            this.groupBoxBarcodeParams.TabIndex = 0;
            this.groupBoxBarcodeParams.TabStop = false;
            this.groupBoxBarcodeParams.Text = "条码参数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "一维码宽度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "条码信息";
            // 
            // btnGenerateQRCodeWithLogo
            // 
            this.btnGenerateQRCodeWithLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerateQRCodeWithLogo.Location = new System.Drawing.Point(127, 317);
            this.btnGenerateQRCodeWithLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerateQRCodeWithLogo.Name = "btnGenerateQRCodeWithLogo";
            this.btnGenerateQRCodeWithLogo.Size = new System.Drawing.Size(111, 60);
            this.btnGenerateQRCodeWithLogo.TabIndex = 2;
            this.btnGenerateQRCodeWithLogo.Text = "生成带Logo的二维码";
            this.btnGenerateQRCodeWithLogo.UseVisualStyleBackColor = true;
            this.btnGenerateQRCodeWithLogo.Click += new System.EventHandler(this.btnGenerateQRCodeWithLogo_Click);
            // 
            // rtxBarcode
            // 
            this.rtxBarcode.Location = new System.Drawing.Point(127, 32);
            this.rtxBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxBarcode.Name = "rtxBarcode";
            this.rtxBarcode.Size = new System.Drawing.Size(514, 107);
            this.rtxBarcode.TabIndex = 1;
            this.rtxBarcode.Text = "123456";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(7, 317);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(101, 60);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.groupBoxBarode);
            this.pnlMain.Controls.Add(this.groupBoxBarcodeParams);
            this.pnlMain.Location = new System.Drawing.Point(14, 14);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1231, 1019);
            this.pnlMain.TabIndex = 1;
            // 
            // groupBoxBarode
            // 
            this.groupBoxBarode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBarode.Controls.Add(this.tbBarcode);
            this.groupBoxBarode.Location = new System.Drawing.Point(20, 424);
            this.groupBoxBarode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBarode.Name = "groupBoxBarode";
            this.groupBoxBarode.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBarode.Size = new System.Drawing.Size(1189, 580);
            this.groupBoxBarode.TabIndex = 1;
            this.groupBoxBarode.TabStop = false;
            this.groupBoxBarode.Text = "条码";
            // 
            // tbBarcode
            // 
            this.tbBarcode.ColumnCount = 2;
            this.tbBarcode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBarcode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBarcode.Controls.Add(this.pic2D, 1, 0);
            this.tbBarcode.Controls.Add(this.pic1D, 0, 0);
            this.tbBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBarcode.Location = new System.Drawing.Point(3, 25);
            this.tbBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.RowCount = 1;
            this.tbBarcode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBarcode.Size = new System.Drawing.Size(1183, 551);
            this.tbBarcode.TabIndex = 0;
            // 
            // pic2D
            // 
            this.pic2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic2D.Location = new System.Drawing.Point(594, 4);
            this.pic2D.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic2D.Name = "pic2D";
            this.pic2D.Size = new System.Drawing.Size(586, 543);
            this.pic2D.TabIndex = 1;
            this.pic2D.TabStop = false;
            // 
            // pic1D
            // 
            this.pic1D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic1D.Location = new System.Drawing.Point(3, 4);
            this.pic1D.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic1D.Name = "pic1D";
            this.pic1D.Size = new System.Drawing.Size(585, 543);
            this.pic1D.TabIndex = 0;
            this.pic1D.TabStop = false;
            // 
            // txt1DBarcodeWidth
            // 
            this.txt1DBarcodeWidth.Location = new System.Drawing.Point(805, 28);
            this.txt1DBarcodeWidth.Name = "txt1DBarcodeWidth";
            this.txt1DBarcodeWidth.Size = new System.Drawing.Size(100, 28);
            this.txt1DBarcodeWidth.TabIndex = 5;
            this.txt1DBarcodeWidth.Text = "300";
            // 
            // txt2DBarcodeWidth
            // 
            this.txt2DBarcodeWidth.Location = new System.Drawing.Point(805, 78);
            this.txt2DBarcodeWidth.Name = "txt2DBarcodeWidth";
            this.txt2DBarcodeWidth.Size = new System.Drawing.Size(100, 28);
            this.txt2DBarcodeWidth.TabIndex = 7;
            this.txt2DBarcodeWidth.Text = "300";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "二维码宽度";
            // 
            // txt1DBarcodeHeight
            // 
            this.txt1DBarcodeHeight.Location = new System.Drawing.Point(1062, 28);
            this.txt1DBarcodeHeight.Name = "txt1DBarcodeHeight";
            this.txt1DBarcodeHeight.Size = new System.Drawing.Size(100, 28);
            this.txt1DBarcodeHeight.TabIndex = 9;
            this.txt1DBarcodeHeight.Text = "150";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(945, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "一维码高度";
            // 
            // txt2DBarcodeHeight
            // 
            this.txt2DBarcodeHeight.Location = new System.Drawing.Point(1062, 78);
            this.txt2DBarcodeHeight.Name = "txt2DBarcodeHeight";
            this.txt2DBarcodeHeight.Size = new System.Drawing.Size(100, 28);
            this.txt2DBarcodeHeight.TabIndex = 11;
            this.txt2DBarcodeHeight.Text = "300";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(945, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "二维码高度";
            // 
            // BarcodeSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 1048);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BarcodeSample";
            this.Text = "BarcodeSample";
            this.Load += new System.EventHandler(this.BarcodeSample_Load);
            this.groupBoxBarcodeParams.ResumeLayout(false);
            this.groupBoxBarcodeParams.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.groupBoxBarode.ResumeLayout(false);
            this.tbBarcode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1D)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBarcodeParams;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox groupBoxBarode;
        private System.Windows.Forms.TableLayoutPanel tbBarcode;
        private System.Windows.Forms.PictureBox pic2D;
        private System.Windows.Forms.PictureBox pic1D;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox rtxBarcode;
        private System.Windows.Forms.Button btnGenerateQRCodeWithLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt2DBarcodeHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt1DBarcodeHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt2DBarcodeWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1DBarcodeWidth;
    }
}