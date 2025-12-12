namespace Bai04
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            int[] fontSize = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name);
            }

            foreach (int size in fontSize)
            {
                comboBox2.Items.Add(size.ToString());
            }

            comboBox1.SelectedItem = textBox1.Font.FontFamily.Name;

            comboBox2.SelectedItem = ((int)textBox1.Font.Size).ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Bold);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style & ~FontStyle.Bold);
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Italic);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style & ~FontStyle.Italic);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Underline);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style & ~FontStyle.Underline);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog.Color;
                button1.BackColor = colorDialog.Color;
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.TextAlign = HorizontalAlignment.Left;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox1.TextAlign = HorizontalAlignment.Right;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, int.Parse(comboBox2.SelectedItem.ToString()), textBox1.Font.Style);
        }
        private void ApplyFontChange()
        {
            if (int.TryParse(comboBox2.Text, out int size))
            {
                if (size > 0)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily,
                    size,
                    textBox1.Font.Style);
                }
                else
                {
                    MessageBox.Show("Font size phải lớn hơn 0.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 32, textBox1.Font.Style);
                    comboBox2.Text = "32";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Font = new Font(textBox1.Font.FontFamily, 32, textBox1.Font.Style);
                comboBox2.Text = "32";
            }
        }
        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                ApplyFontChange();
                e.SuppressKeyPress = true;
            }

        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            ApplyFontChange();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(comboBox1.SelectedItem.ToString(), textBox1.Font.Size, textBox1.Font.Style);
        }
    }
}
