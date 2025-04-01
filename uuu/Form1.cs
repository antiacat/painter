using System.Drawing.Imaging;
namespace uuu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 線條樣式ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        
        Pen p = new Pen(Color.Black, 3);

        int x, y; //計畫滑鼠位置

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                g.DrawLine(p, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
                pictureBox1.Refresh();
            }
        }

        private void 藍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void 綠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void 黃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void 紫ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.MediumPurple;
        }

        private void 粉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.LightPink;
        }

        private void 黑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void 細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 1;
        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 3;
        }

        private void 粗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        private void 點短虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void 長短虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void 長虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            p.DashPattern = new float[] { 6.0F, 3.0F };
        }

        private void 直線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void 储存檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(@"C:\Users\User\Desktop\1.jpg", ImageFormat.Png);
                MessageBox.Show("存檔成功");
            }
            catch
            {
                MessageBox.Show("存檔失敗");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}