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
        }

        private void OpenScreenshotFormBtn_Click(object sender, EventArgs e)
        {
            TakeScreeenshotBtn.Enabled = true;

            take.Enabled = true;
            take.Visible = true;
        }

        private void TakeScreeenshotBtn_Click(object sender, EventArgs e)
        {
            Bitmap screen = new Bitmap(take.Width, take.Height);
            using (Graphics g = Graphics.FromImage(screen))
            {
                g.CopyFromScreen(take.Location.X, take.Location.Y, take.Location.X + screen.Width, take.Location.Y + screen.Height, screen.Size);
                pictureBox1.Image = screen;
            }
            take.Enabled = false;
            take.Visible = false;
            TakeScreeenshotBtn.Enabled = false;
        }
    }
}