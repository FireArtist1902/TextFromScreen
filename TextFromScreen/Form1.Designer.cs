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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            OpenScreenshotFormBtn = new Button();
            TakeScreeenshotBtn = new Button();
            imageList1 = new ImageList(components);
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // OpenScreenshotFormBtn
            // 
            OpenScreenshotFormBtn.AutoSize = true;
            OpenScreenshotFormBtn.Location = new Point(15, 77);
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
            TakeScreeenshotBtn.Location = new Point(3, 12);
            TakeScreeenshotBtn.Name = "TakeScreeenshotBtn";
            TakeScreeenshotBtn.Size = new Size(129, 30);
            TakeScreeenshotBtn.TabIndex = 1;
            TakeScreeenshotBtn.Text = "Зробити знімок";
            TakeScreeenshotBtn.UseVisualStyleBackColor = true;
            TakeScreeenshotBtn.Click += TakeScreeenshotBtn_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "free-icon-font-add-image-13727439.png");
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(138, 14);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(590, 95);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(734, 115);
            Controls.Add(richTextBox1);
            Controls.Add(TakeScreeenshotBtn);
            Controls.Add(OpenScreenshotFormBtn);
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenScreenshotFormBtn;
        private Button TakeScreeenshotBtn;
        private ImageList imageList1;
        private RichTextBox richTextBox1;
    }
}