using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace hw4 {
    public struct config {
        public string name,
            surname,
            middleName,
            city,
            street,
            monitor,
            vidokarta,
            proccesor,
            ozyMemory,
            blockP,
            materintka;

        public override string ToString() => $"{name}\n{surname}\n{middleName}\n{city}\n{street}\n{monitor}\n{materintka}\n{vidokarta}\n{proccesor}\n{ozyMemory}\n{blockP}\n";
    }
    public partial class mainForm : Form {
        public mainForm() {
            InitializeComponent();
        }

        config load;

        private void contactDataClick(object sender, EventArgs e) {
            mainTabControl.SelectedTab = contactDataPage;
        }

        private void configClick(object sender, EventArgs e) {
            mainTabControl.SelectedTab = configPage;
        }
        bool not = false;
        int err = 0;
        private void check() {
            if (!not) {
                configMenuText.Enabled = false;
                nextStep.Enabled = false;
            }
            err = 0;
            TextBox[] dict = { userName, userSurname, userMiddlename, userCity, UserStreet };

            foreach (TextBox item in dict) {
                if (item.Text == " " || item.Text == "") {
                    err++;
                }
            }
            if (err == 0) {
                not = true;
            }

            if (not) {
                configMenuText.Enabled = true;
                nextStep.Enabled = true;
                not = false;
            }
        }
        bool not2 = false;
        int err2 = 0;
        private void check2() {
            if (!not2) {
                save.Enabled = false;
            }
            err2 = 0;
            ComboBox[] dict = { monik, viduha, proc, ozy, mat, bp };

            foreach (ComboBox item in dict) {
                if (item.Text == " " || item.Text == "") {
                    err2++;
                }
            }
            if (err2 == 0) {
                not2 = true;
            }

            if (not2) {
                save.Enabled = true;
                not2 = false;
            }
        }
        private void paintForm(object sender, PaintEventArgs e) {
            check();
        }

        private void nextStep_Click(object sender, EventArgs e) {
            mainTabControl.SelectedTab = configPage;
        }

        private void changed(object sender, EventArgs e) {
            check();
        }

        private void changeCombo(object sender, EventArgs e) {
            check2();
        }

        private void save_Click(object sender, EventArgs e) {
            load.name = this.userName.Text;
            load.surname = this.userSurname.Text;
            load.middleName = this.userMiddlename.Text;
            load.city = this.userCity.Text;
            load.street = this.UserStreet.Text;
            load.monitor = this.monik.Text;
            load.vidokarta = this.viduha.Text;
            load.proccesor = this.proc.Text;
            load.ozyMemory = this.ozy.Text;
            load.materintka = this.mat.Text;
            load.blockP = this.bp.Text;

            if (saveToFile.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveToFile.FileName;

            System.IO.File.WriteAllText(filename, load.ToString());
            MessageBox.Show("Файл сохранен");
        }

        private async void clickLoadAsync(object sender, EventArgs e) {
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFile.FileName;

            using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default)) {
                this.userName.Text = await sr.ReadLineAsync();
                this.userSurname.Text = await sr.ReadLineAsync();
                this.userMiddlename.Text = await sr.ReadLineAsync();
                this.userCity.Text = await sr.ReadLineAsync();
                this.UserStreet.Text = await sr.ReadLineAsync();
                this.monik.Text = await sr.ReadLineAsync();
                this.viduha.Text = await sr.ReadLineAsync();
                this.proc.Text = await sr.ReadLineAsync();
                this.ozy.Text = await sr.ReadLineAsync();
                this.mat.Text = await sr.ReadLineAsync();
                this.bp.Text = await sr.ReadLineAsync();
            }

            MessageBox.Show("Файл открыт");
        }
    }
}
