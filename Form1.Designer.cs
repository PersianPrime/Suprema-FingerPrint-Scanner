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
            System.Windows.Forms.Button btnAutoCapture;
            System.Windows.Forms.Button btnCaptureSingle;
            System.Windows.Forms.Button btnAbortCapturing;
            System.Windows.Forms.Button btnExtract;
            System.Windows.Forms.Button btnSaveImage;
            System.Windows.Forms.Button btnStartCapturing;
            System.Windows.Forms.Button btnInit;
            System.Windows.Forms.Button btnClear;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbScannerList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImageFrame = new System.Windows.Forms.PictureBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            btnAutoCapture = new System.Windows.Forms.Button();
            btnCaptureSingle = new System.Windows.Forms.Button();
            btnAbortCapturing = new System.Windows.Forms.Button();
            btnExtract = new System.Windows.Forms.Button();
            btnSaveImage = new System.Windows.Forms.Button();
            btnStartCapturing = new System.Windows.Forms.Button();
            btnInit = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAutoCapture
            // 
            btnAutoCapture.Location = new System.Drawing.Point(213, 16);
            btnAutoCapture.Name = "btnAutoCapture";
            btnAutoCapture.Size = new System.Drawing.Size(96, 24);
            btnAutoCapture.TabIndex = 18;
            btnAutoCapture.Text = "Auto Capture";
            btnAutoCapture.UseVisualStyleBackColor = true;
            // 
            // btnCaptureSingle
            // 
            btnCaptureSingle.Location = new System.Drawing.Point(8, 46);
            btnCaptureSingle.Name = "btnCaptureSingle";
            btnCaptureSingle.Size = new System.Drawing.Size(96, 24);
            btnCaptureSingle.TabIndex = 14;
            btnCaptureSingle.Text = "Capture Single";
            btnCaptureSingle.UseVisualStyleBackColor = true;
            // 
            // btnAbortCapturing
            // 
            btnAbortCapturing.Location = new System.Drawing.Point(213, 46);
            btnAbortCapturing.Name = "btnAbortCapturing";
            btnAbortCapturing.Size = new System.Drawing.Size(96, 24);
            btnAbortCapturing.TabIndex = 13;
            btnAbortCapturing.Text = "Abort";
            btnAbortCapturing.UseVisualStyleBackColor = true;
            // 
            // btnExtract
            // 
            btnExtract.Location = new System.Drawing.Point(12, 271);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new System.Drawing.Size(126, 24);
            btnExtract.TabIndex = 11;
            btnExtract.Text = "ذخیره در بانک اطلاعاتی";
            btnExtract.UseVisualStyleBackColor = true;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Location = new System.Drawing.Point(12, 301);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new System.Drawing.Size(126, 24);
            btnSaveImage.TabIndex = 17;
            btnSaveImage.Text = "دریافت تصویر";
            btnSaveImage.UseVisualStyleBackColor = true;
            // 
            // btnStartCapturing
            // 
            btnStartCapturing.Location = new System.Drawing.Point(144, 271);
            btnStartCapturing.Name = "btnStartCapturing";
            btnStartCapturing.Size = new System.Drawing.Size(96, 24);
            btnStartCapturing.TabIndex = 10;
            btnStartCapturing.Text = "شروع اسکن";
            btnStartCapturing.UseVisualStyleBackColor = true;
            // 
            // btnInit
            // 
            btnInit.Location = new System.Drawing.Point(478, 12);
            btnInit.Name = "btnInit";
            btnInit.Size = new System.Drawing.Size(112, 24);
            btnInit.TabIndex = 9;
            btnInit.Text = "آماده سازی اسکنر";
            btnInit.UseVisualStyleBackColor = true;
            btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(275, 271);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(44, 93);
            btnClear.TabIndex = 15;
            btnClear.Text = "خالی کردن";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(btnAutoCapture);
            this.groupBox2.Controls.Add(btnCaptureSingle);
            this.groupBox2.Controls.Add(btnAbortCapturing);
            this.groupBox2.Location = new System.Drawing.Point(275, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 80);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Use Scanner";
            // 
            // lbScannerList
            // 
            this.lbScannerList.FormattingEnabled = true;
            this.lbScannerList.Location = new System.Drawing.Point(275, 93);
            this.lbScannerList.Name = "lbScannerList";
            this.lbScannerList.Size = new System.Drawing.Size(315, 43);
            this.lbScannerList.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "انتخاب اسکنر:";
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
            this.tbxMessage.Location = new System.Drawing.Point(324, 271);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMessage.Size = new System.Drawing.Size(266, 93);
            this.tbxMessage.TabIndex = 14;
            this.tbxMessage.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "رویدادها:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(btnClear);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(btnSaveImage);
            this.Controls.Add(btnExtract);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbScannerList);
            this.Controls.Add(btnStartCapturing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImageFrame);
            this.Controls.Add(btnInit);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اسکن اثر انگشت";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbScannerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImageFrame;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Label label2;
    }
}

