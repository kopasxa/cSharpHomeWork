using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2v2 {
    public partial class game : Form {
        public game() {
            InitializeComponent();
        }

        private void go(object sender, MouseEventArgs e) {
            Random rnd = new Random();

            int randX = rnd.Next(0, this.Size.Width - this.clickMe.Width * 2);
            int randY = rnd.Next(0, this.Size.Height - this.clickMe.Height * 2);
            Point newPoint = new Point(randX, randY);
            this.clickMe.Location = newPoint;
        }

        private void clecked(object sender, EventArgs e) {
            MessageBox.Show("ТЫ ВОЛШЕБНИК!");
        }
    }
}
