using System.Drawing;
using System.Windows.Forms;

namespace HrunykLab {
    public partial class Form1 : Form {
        private int x = 100;
        private int y = 100;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            Draw(e.Graphics);
        }

        private void Draw(Graphics g, int x = 100, int y = 100) {
            var pen = new Pen(Color.Black);

            g.DrawEllipse(pen, x, y, 150, 150);
            g.DrawLine(pen, x + 75, y - 20, x + 75, y + 30);
            g.DrawLine(pen, x + 50, y + 30, x + 100, y + 30);
            g.DrawLine(pen, x - 10, y + 75, x + 20, y + 75);
            g.DrawLine(pen, x + 30, y + 75, x + 50, y + 75);
            g.DrawLine(pen, x + 60, y + 75, x + 80, y + 75);
            g.DrawLine(pen, x + 90, y + 75, x + 110, y + 75);
            g.DrawArc(pen, x + 63, y + 140, 20, 20, 0, -180);
            g.DrawLine(pen, x + 63, y + 147, x + 63, y + 180);
            g.DrawLine(pen, x + 83, y + 147, x + 83, y + 180);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
            Graphics g = Graphics.FromHwnd(this.Handle);
            g.Clear(Color.White);
            if (e.KeyChar == 'w') {
                Draw(g, x, y);
                y -= 5;
            } else if (e.KeyChar == 's') {
                Draw(g, x, y);
                y += 5;
            } else if (e.KeyChar == 'd') {
                Draw(g, x, y);
                x += 5;
            } else if (e.KeyChar == 'a') {
                Draw(g, x, y);
                x -= 5;
            }

        }
    }
}
