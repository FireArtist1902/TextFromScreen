using Aspose.OCR;
using System.Net.Http.Headers;
using Tesseract;
using IronOcr;

namespace TextFromScreen
{
    public partial class Form1 : Form
    {

        TakeScreenshot take = new TakeScreenshot();

        public Form1()
        {
            InitializeComponent();
            take.Show();
            take.Enabled = false;
            take.Visible = false;
            Aspose.Cells.License license = new Aspose.Cells.License();
            //license.SetLicense(@"IronOcr2024.3.4\netstandard2.0\IronOcr.xml");
            IronOcr.License.LicenseKey = "IRONSUITE.VADYM.VRACHENKO.LYCEUM3.MK.UA.28994-C45BDE8A51-PLNNB-4I7TUJHTQSKF-7MQD3FH4PSVI-KUF6RIP3DW7P-XZA3ITGP2QJK-JVAEGTKZIUGJ-WOSIPMFMVEIK-Q6OZPD-T66I25E7YQKMEA-DEPLOYMENT.TRIAL-ESFLVS.TRIAL.EXPIRES.17.APR.2024";
        }

        private void OpenScreenshotFormBtn_Click(object sender, EventArgs e)
        {
            TakeScreeenshotBtn.Enabled = true;

            take.Enabled = true;
            take.Visible = true;
        }

        private void TakeScreeenshotBtn_Click(object sender, EventArgs e)
        {

            Visible = false;
            take.Visible = false;
            Thread.Sleep(10);
            Rectangle bounds = take.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                bitmap.Save("test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            Visible = true;
            take.Enabled = false;
            TakeScreeenshotBtn.Enabled = false;
            IronTesseract ocr = new IronTesseract();
            ocr.AddSecondaryLanguage(OcrLanguage.Russian);
            ocr.AddSecondaryLanguage(OcrLanguage.Ukrainian);
            using (var Input = new IronOcr.OcrInput("test.jpg"))
            {
                OcrResult result = ocr.Read(Input);
                richTextBox1.Text = result.Text;
            }
            Clipboard.SetText(richTextBox1.Text);
        }

        private void ToBufferBtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}