using System.Drawing.Text;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach (var font in fonts.Families)
            {
                listBox1.Items.Add(font.Name);
            }
        }
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

            string fontName = listBox1.Items[e.Index].ToString();

            e.DrawBackground();

            Font f = new Font(fontName, 16f); 

            e.Graphics.DrawString(fontName, f, Brushes.Black, e.Bounds);

            e.DrawFocusRectangle();
        }

    }
}
