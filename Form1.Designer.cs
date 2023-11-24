namespace FingerPrint
{
    partial class Form1
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
            System.Windows.Forms.Button btnExtract;
            System.Windows.Forms.Button btnSaveImage;
            System.Windows.Forms.Button btnInit;
            System.Windows.Forms.Button btnClear;
            System.Windows.Forms.Button btnCaptureSingle;
            this.lbScannerList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImageFrame = new System.Windows.Forms.PictureBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            btnExtract = new System.Windows.Forms.Button();
            btnSaveImage = new System.Windows.Forms.Button();
            btnInit = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnCaptureSingle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            btnExtract.Location = new System.Drawing.Point(12, 271);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new System.Drawing.Size(126, 24);
            btnExtract.TabIndex = 11;
            btnExtract.Text = "ذخیره در بانک اطلاعاتی";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnSaveImage
            // 
            btnSaveImage.Location = new System.Drawing.Point(12, 301);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new System.Drawing.Size(126, 24);
            btnSaveImage.TabIndex = 17;
            btnSaveImage.Text = "دریافت تصویر";
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnInit
            // 
            btnInit.Location = new System.Drawing.Point(257, 16);
            btnInit.Name = "btnInit";
            btnInit.Size = new System.Drawing.Size(334, 31);
            btnInit.TabIndex = 9;
            btnInit.Text = "آماده سازی اسکنر";
            btnInit.UseVisualStyleBackColor = true;
            btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(257, 171);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(44, 93);
            btnClear.TabIndex = 15;
            btnClear.Text = "خالی کردن";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbScannerList
            // 
            this.lbScannerList.FormattingEnabled = true;
            this.lbScannerList.Location = new System.Drawing.Point(257, 90);
            this.lbScannerList.Name = "lbScannerList";
            this.lbScannerList.Size = new System.Drawing.Size(333, 43);
            this.lbScannerList.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "لیست اسکنرها:";
            // 
            // pbImageFrame
            // 
            this.pbImageFrame.BackColor = System.Drawing.SystemColors.Control;
            this.pbImageFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImageFrame.Location = new System.Drawing.Point(12, 12);
            this.pbImageFrame.Name = "pbImageFrame";
            this.pbImageFrame.Size = new System.Drawing.Size(228, 252);
            this.pbImageFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageFrame.TabIndex = 10;
            this.pbImageFrame.TabStop = false;
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(307, 171);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMessage.Size = new System.Drawing.Size(283, 93);
            this.tbxMessage.TabIndex = 14;
            this.tbxMessage.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "رویدادها:";
            // 
            // btnCaptureSingle
            // 
            btnCaptureSingle.Location = new System.Drawing.Point(144, 271);
            btnCaptureSingle.Name = "btnCaptureSingle";
            btnCaptureSingle.Size = new System.Drawing.Size(96, 54);
            btnCaptureSingle.TabIndex = 10;
            btnCaptureSingle.Text = "شروع اسکن";
            btnCaptureSingle.UseVisualStyleBackColor = true;
            btnCaptureSingle.Click += new System.EventHandler(this.btnCaptureSingle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(btnClear);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(btnSaveImage);
            this.Controls.Add(btnExtract);
            this.Controls.Add(this.lbScannerList);
            this.Controls.Add(btnCaptureSingle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImageFrame);
            this.Controls.Add(btnInit);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اسکن اثر انگشت";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbScannerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImageFrame;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Label label2;
    }
}

