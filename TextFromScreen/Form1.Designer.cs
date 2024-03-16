namespace TextFromScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OpenScreenshotFormBtn = new Button();
            TakeScreeenshotBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OpenScreenshotFormBtn
            // 
            OpenScreenshotFormBtn.AutoSize = true;
            OpenScreenshotFormBtn.Location = new Point(12, 30);
            OpenScreenshotFormBtn.Name = "OpenScreenshotFormBtn";
            OpenScreenshotFormBtn.Size = new Size(104, 30);
            OpenScreenshotFormBtn.TabIndex = 0;
            OpenScreenshotFormBtn.Text = "Межі знімку";
            OpenScreenshotFormBtn.UseVisualStyleBackColor = true;
            OpenScreenshotFormBtn.Click += OpenScreenshotFormBtn_Click;
            // 
            // TakeScreeenshotBtn
            // 
            TakeScreeenshotBtn.AutoSize = true;
            TakeScreeenshotBtn.Enabled = false;
            TakeScreeenshotBtn.Location = new Point(122, 30);
            TakeScreeenshotBtn.Name = "TakeScreeenshotBtn";
            TakeScreeenshotBtn.Size = new Size(129, 30);
            TakeScreeenshotBtn.TabIndex = 1;
            TakeScreeenshotBtn.Text = "Зробити знімок";
            TakeScreeenshotBtn.UseVisualStyleBackColor = true;
            TakeScreeenshotBtn.Click += TakeScreeenshotBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(293, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 131);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 195);
            Controls.Add(pictureBox1);
            Controls.Add(TakeScreeenshotBtn);
            Controls.Add(OpenScreenshotFormBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenScreenshotFormBtn;
        private Button TakeScreeenshotBtn;
        private PictureBox pictureBox1;
    }
}