using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3 {
    public struct dataAnketa {
        public string adress,
            city,
            phoneNum,
            index,
            country,
            mail,
            rodZ,
            getterWork,
            adressWork,
            cityWork,
            phoneNumWork,
            nameOfUcheb,
            indexWork,
            countryWork;

        public bool countryP;
        public override string ToString() => $"{adress}\n{city}\n{phoneNum}\n{index}\n{country}\n{mail}\n{countryP}\n{rodZ}\n{getterWork}\n{adressWork}\n{cityWork}\n{phoneNumWork}\n{nameOfUcheb}\n{indexWork}\n{countryWork}\n";
    }
    public partial class anketa : Form {
        public anketa() {
            InitializeComponent();
        }

        dataAnketa load;
        private void verifText(object sender, EventArgs e) {
            if (sender.GetType().Name == "TextBox") {
                TextBox textBox = (TextBox)sender;

                string err = $"Заполните {textBox.Name}";
                if (textBox.Text == "" || textBox.Text == " ") {
                    if (!errors.Items.Contains(err)) {
                        errors.Items.Add(err);
                    }
                }
                else {
                    try {
                        errors.Items.Remove(err);
                    }
                    catch {

                    }
                }
            }
            else if (sender.GetType().Name == "ComboBox") {
                ComboBox textBox = (ComboBox)sender;

                string err = $"Заполните {textBox.Name}";
                if (textBox.Text == "Выберите значение" || textBox.Text == " " || textBox.Text == "") {
                    if (!errors.Items.Contains(err)) {
                        errors.Items.Add(err);
                    }
                }
                else {
                    try {
                        errors.Items.Remove(err);
                    }
                    catch {

                    }
                }
            }
        }
        private bool checkInputs() {
            if (this.adressInput.Text != " " && this.cityInput.Text != " " && this.numPhoneInput.Text != " " && this.countryInput.Text == "Выберите значение" && this.rodCombo.Text == "Выберите значение" && this.getterWorkInput.Text != " " && this.adressWorkInput.Text != " " && this.cityWorkInput.Text != " " && this.numPhoneWorkInput.Text != " " && this.countryWorkInput.Text == "Выберите значение") {
                MessageBox.Show("Заполните все поля с *");
                return false;
            }
            else {
                return true;
            }
        }
        private void saveClick(object sender, EventArgs e) {
            if (checkInputs()) {
                load.adress = this.adressInput.Text;
                load.adressWork = this.adressWorkInput.Text;
                load.city = this.cityInput.Text;
                load.cityWork = this.cityWorkInput.Text;
                load.country = this.countryInput.Text;
                load.countryWork = this.countryWorkInput.Text;
                load.getterWork = this.getterWorkInput.Text;
                load.index = this.indexInput.Text;
                load.indexWork = this.indexWorkInput.Text;
                load.mail = this.mailInput.Text;
                load.nameOfUcheb = this.nameOfUchebInput.Text;
                load.phoneNum = this.numPhoneInput.Text;
                load.phoneNumWork = this.numPhoneWorkInput.Text;
                load.rodZ = this.rodCombo.Text;

                bool res;
                if (this.yes.Checked) res = true;
                else res = false;

                load.countryP = res;

                if (saveToFile.ShowDialog() == DialogResult.Cancel)
                    return;

                string filename = saveToFile.FileName;

                System.IO.File.WriteAllText(filename, load.ToString());
                MessageBox.Show("Файл сохранен");
            }
        }

        private async void loadClickAsync(object sender, EventArgs e) {
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFile.FileName;

            using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default)) {
                this.adressInput.Text = await sr.ReadLineAsync();
                this.cityInput.Text = await sr.ReadLineAsync();
                this.numPhoneInput.Text = await sr.ReadLineAsync();
                this.indexInput.Text = await sr.ReadLineAsync();
                this.countryInput.Text = await sr.ReadLineAsync();
                this.mailInput.Text = await sr.ReadLineAsync();

                if (await sr.ReadLineAsync() == "True") {
                    this.yes.Checked = true;
                }
                else {
                    this.no.Checked = true;
                }

                this.rodCombo.Text = await sr.ReadLineAsync();
                this.getterWorkInput.Text = await sr.ReadLineAsync();
                this.adressWorkInput.Text = await sr.ReadLineAsync();
                this.cityWorkInput.Text = await sr.ReadLineAsync();
                this.numPhoneWorkInput.Text = await sr.ReadLineAsync();
                this.nameOfUchebInput.Text = await sr.ReadLineAsync();
                this.indexWorkInput.Text = await sr.ReadLineAsync();
                this.countryWorkInput.Text = await sr.ReadLineAsync();
            }

            MessageBox.Show("Файл открыт");
        }

        private void sendClicked(object sender, EventArgs e) {
            if (checkInputs()) {
                MessageBox.Show("Отправлено!");

                this.adressInput.Text = "";
                this.cityInput.Text = "";
                this.numPhoneInput.Text = "";
                this.indexInput.Text = "";
                this.countryInput.Text = "";
                this.mailInput.Text = "";
                this.rodCombo.Text = "";
                this.getterWorkInput.Text = "";
                this.adressWorkInput.Text = "";
                this.cityWorkInput.Text = "";
                this.numPhoneWorkInput.Text = "";
                this.nameOfUchebInput.Text = "";
                this.indexWorkInput.Text = "";
                this.countryWorkInput.Text = "";
            }
        }
    }
}
