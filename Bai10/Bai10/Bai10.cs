using System.Drawing.Drawing2D;

namespace Bai10
{
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }

        private void Bai10_Load(object sender, EventArgs e)
        {
            cmbDashStyle.DataSource = Enum.GetValues(typeof(DashStyle));
            cmbLineJoin.DataSource = Enum.GetValues(typeof(LineJoin));
            cmbDashCap.DataSource = Enum.GetValues(typeof(DashCap));
            cmbStartCap.DataSource = Enum.GetValues(typeof(LineCap));
            cmbEndCap.DataSource = Enum.GetValues(typeof(LineCap));

            for (int i = 1; i <= 20; i++)
                cmbWidth.Items.Add(i);
            cmbWidth.SelectedIndex = 4;

            cmbDashStyle.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cmbWidth.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cmbLineJoin.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cmbDashCap.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cmbStartCap.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cmbEndCap.SelectedIndexChanged += ComboBox_SelectedIndexChanged;


        }

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            DashStyle dash = (DashStyle)cmbDashStyle.SelectedItem;
            LineJoin join = (LineJoin)cmbLineJoin.SelectedItem;
            DashCap dashCap = (DashCap)cmbDashCap.SelectedItem;
            LineCap startCap = (LineCap)cmbStartCap.SelectedItem;
            LineCap endCap = (LineCap)cmbEndCap.SelectedItem;
            float width = float.Parse(cmbWidth.SelectedItem.ToString());

            Pen p = new Pen(Color.Red, width);

            p.DashStyle = dash;
            p.LineJoin = join;
            p.DashCap = dashCap;
            p.StartCap = startCap;
            p.EndCap = endCap;

            if (dash == DashStyle.Custom)
                p.DashPattern = new float[] { 2, 2, 5, 2 };

            g.DrawLine(p, 20, 40, panelDraw.Width - 30, 100);

            PointF[] pts =
            {
                new PointF(50,150),
                new PointF(150,250),
                new PointF(250,150)
            };
            g.DrawLines(p, pts);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDraw.Invalidate(); 
        }

    }
}
