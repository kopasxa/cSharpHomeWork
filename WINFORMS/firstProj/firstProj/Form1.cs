using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstProj {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button_result(object sender, EventArgs e) {
            NameProgram.Text = "Button is pressed!";
            MessageBox.Show("You pressed is buton of named \"Click me!\"", "main", MessageBoxButtons.YesNoCancel);
        }
    }
}
