using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2v3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void run(object sender, PaintEventArgs e) {
            Point newPoint = new Point(this.Width / 2 - this.time.Width / 2, this.Height / 2 - this.time.Height / 2 - 20);
            this.time.Location = newPoint;
        }

        private void run(object sender, EventArgs e) {
            Point newPoint = new Point(this.Width / 2 - this.time.Width / 2, this.Height / 2 - this.time.Height / 2 - 20);
            this.time.Location = newPoint;
        }

        private void tick(object sender, EventArgs e) {
            DateTime NewYear = new DateTime(DateTime.Now.Year + 1, 1, 1, 0, 0, 0);
            if (DateTime.Now < NewYear) {
                TimeSpan interval = NewYear - DateTime.Now;
                time.Text = $"{interval.Days}:{interval.Hours}:{interval.Minutes}:{interval.Seconds}";
            }
            else {
                MessageBox.Show("HAPPY NEW YEAR!");
            }
        }
    }
}
