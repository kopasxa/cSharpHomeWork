
namespace hw4 {
    partial class mainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.contactDataPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UserStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userMiddlename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nextStep = new System.Windows.Forms.Button();
            this.configPage = new System.Windows.Forms.TabPage();
            this.save = new System.Windows.Forms.Button();
            this.bp = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mat = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ozy = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.proc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.viduha = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.monik = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.rand = new System.Windows.Forms.Label();
            this.contactMenuText = new System.Windows.Forms.ToolStripMenuItem();
            this.configMenuText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.saveToFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.contactDataPage.SuspendLayout();
            this.configPage.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadConfig});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(947, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "manu";
            // 
            // loadConfig
            // 
            this.loadConfig.Name = "loadConfig";
            this.loadConfig.Size = new System.Drawing.Size(206, 25);
            this.loadConfig.Text = "Загрузить конфигурацию";
            this.loadConfig.Click += new System.EventHandler(this.clickLoadAsync);
            // 
            // mainTabControl
            // 
            this.mainTabControl.AllowDrop = true;
            this.mainTabControl.Controls.Add(this.contactDataPage);
            this.mainTabControl.Controls.Add(this.configPage);
            this.mainTabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainTabControl.Location = new System.Drawing.Point(269, 0);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(664, 485);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabControl.TabIndex = 1;
            // 
            // contactDataPage
            // 
            this.contactDataPage.Controls.Add(this.label7);
            this.contactDataPage.Controls.Add(this.label6);
            this.contactDataPage.Controls.Add(this.UserStreet);
            this.contactDataPage.Controls.Add(this.label5);
            this.contactDataPage.Controls.Add(this.userCity);
            this.contactDataPage.Controls.Add(this.label4);
            this.contactDataPage.Controls.Add(this.userMiddlename);
            this.contactDataPage.Controls.Add(this.label3);
            this.contactDataPage.Controls.Add(this.userSurname);
            this.contactDataPage.Controls.Add(this.label2);
            this.contactDataPage.Controls.Add(this.userName);
            this.contactDataPage.Controls.Add(this.label1);
            this.contactDataPage.Controls.Add(this.nextStep);
            this.contactDataPage.Location = new System.Drawing.Point(4, 24);
            this.contactDataPage.Name = "contactDataPage";
            this.contactDataPage.Padding = new System.Windows.Forms.Padding(3);
            this.contactDataPage.Size = new System.Drawing.Size(656, 457);
            this.contactDataPage.TabIndex = 0;
            this.contactDataPage.Text = "tabPage1";
            this.contactDataPage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(250, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Контактные данные";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Заполните все полня";
            // 
            // UserStreet
            // 
            this.UserStreet.Location = new System.Drawing.Point(484, 217);
            this.UserStreet.Name = "UserStreet";
            this.UserStreet.Size = new System.Drawing.Size(116, 21);
            this.UserStreet.TabIndex = 10;
            this.UserStreet.TextChanged += new System.EventHandler(this.changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Улица";
            // 
            // userCity
            // 
            this.userCity.Location = new System.Drawing.Point(484, 159);
            this.userCity.Name = "userCity";
            this.userCity.Size = new System.Drawing.Size(116, 21);
            this.userCity.TabIndex = 8;
            this.userCity.TextChanged += new System.EventHandler(this.changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Город";
            // 
            // userMiddlename
            // 
            this.userMiddlename.Location = new System.Drawing.Point(201, 272);
            this.userMiddlename.Name = "userMiddlename";
            this.userMiddlename.Size = new System.Drawing.Size(116, 21);
            this.userMiddlename.TabIndex = 6;
            this.userMiddlename.TextChanged += new System.EventHandler(this.changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // userSurname
            // 
            this.userSurname.Location = new System.Drawing.Point(201, 217);
            this.userSurname.Name = "userSurname";
            this.userSurname.Size = new System.Drawing.Size(116, 21);
            this.userSurname.TabIndex = 4;
            this.userSurname.TextChanged += new System.EventHandler(this.changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(201, 159);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(116, 21);
            this.userName.TabIndex = 2;
            this.userName.TextChanged += new System.EventHandler(this.changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // nextStep
            // 
            this.nextStep.Enabled = false;
            this.nextStep.Location = new System.Drawing.Point(530, 389);
            this.nextStep.Name = "nextStep";
            this.nextStep.Size = new System.Drawing.Size(87, 27);
            this.nextStep.TabIndex = 0;
            this.nextStep.Text = "Дальше";
            this.nextStep.UseVisualStyleBackColor = true;
            this.nextStep.Click += new System.EventHandler(this.nextStep_Click);
            // 
            // configPage
            // 
            this.configPage.Controls.Add(this.save);
            this.configPage.Controls.Add(this.bp);
            this.configPage.Controls.Add(this.label14);
            this.configPage.Controls.Add(this.mat);
            this.configPage.Controls.Add(this.label13);
            this.configPage.Controls.Add(this.ozy);
            this.configPage.Controls.Add(this.label12);
            this.configPage.Controls.Add(this.proc);
            this.configPage.Controls.Add(this.label11);
            this.configPage.Controls.Add(this.viduha);
            this.configPage.Controls.Add(this.label10);
            this.configPage.Controls.Add(this.monik);
            this.configPage.Controls.Add(this.label9);
            this.configPage.Controls.Add(this.label8);
            this.configPage.Location = new System.Drawing.Point(4, 24);
            this.configPage.Name = "configPage";
            this.configPage.Padding = new System.Windows.Forms.Padding(3);
            this.configPage.Size = new System.Drawing.Size(656, 457);
            this.configPage.TabIndex = 1;
            this.configPage.Text = "tabPage2";
            this.configPage.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(525, 396);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(81, 23);
            this.save.TabIndex = 13;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // bp
            // 
            this.bp.FormattingEnabled = true;
            this.bp.Items.AddRange(new object[] {
            "БП1",
            "БП2",
            "БП3",
            "БП4"});
            this.bp.Location = new System.Drawing.Point(411, 154);
            this.bp.Name = "bp";
            this.bp.Size = new System.Drawing.Size(121, 23);
            this.bp.TabIndex = 12;
            this.bp.TextChanged += new System.EventHandler(this.changeCombo);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(338, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "БП";
            // 
            // mat
            // 
            this.mat.FormattingEnabled = true;
            this.mat.Items.AddRange(new object[] {
            "Мать1",
            "Мать2",
            "Мать3",
            "Мать4"});
            this.mat.Location = new System.Drawing.Point(411, 97);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(121, 23);
            this.mat.TabIndex = 10;
            this.mat.TextChanged += new System.EventHandler(this.changeCombo);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(338, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Материнка";
            // 
            // ozy
            // 
            this.ozy.FormattingEnabled = true;
            this.ozy.Items.AddRange(new object[] {
            "ОЗУ1",
            "ОЗУ2",
            "ОЗУ3",
            "ОЗУ4"});
            this.ozy.Location = new System.Drawing.Point(116, 276);
            this.ozy.Name = "ozy";
            this.ozy.Size = new System.Drawing.Size(121, 23);
            this.ozy.TabIndex = 8;
            this.ozy.TextChanged += new System.EventHandler(this.changeCombo);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "ОЗУшка";
            // 
            // proc
            // 
            this.proc.FormattingEnabled = true;
            this.proc.Items.AddRange(new object[] {
            "Проц1",
            "Проц2",
            "Проц3",
            "Проц4"});
            this.proc.Location = new System.Drawing.Point(116, 214);
            this.proc.Name = "proc";
            this.proc.Size = new System.Drawing.Size(121, 23);
            this.proc.TabIndex = 6;
            this.proc.TextChanged += new System.EventHandler(this.changeCombo);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Проц";
            // 
            // viduha
            // 
            this.viduha.FormattingEnabled = true;
            this.viduha.Items.AddRange(new object[] {
            "Видюха1",
            "Видюха2",
            "Видюха3",
            "Видюха4"});
            this.viduha.Location = new System.Drawing.Point(116, 154);
            this.viduha.Name = "viduha";
            this.viduha.Size = new System.Drawing.Size(121, 23);
            this.viduha.TabIndex = 4;
            this.viduha.TextChanged += new System.EventHandler(this.changeCombo);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Видюха";
            // 
            // monik
            // 
            this.monik.FormattingEnabled = true;
            this.monik.Items.AddRange(new object[] {
            "Монитор1",
            "Монитор2",
            "Монитор3",
            "Монитор4"});
            this.monik.Location = new System.Drawing.Point(116, 97);
            this.monik.Name = "monik";
            this.monik.Size = new System.Drawing.Size(121, 23);
            this.monik.TabIndex = 2;
            this.monik.TextChanged += new System.EventHandler(this.changeCombo);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Монитор";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(230, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Конфигурация компютера";
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "configuration";
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Filter = "ConfiguratePc files|*.configPc";
            this.openFile.ValidateNames = false;
            // 
            // rand
            // 
            this.rand.AutoSize = true;
            this.rand.Location = new System.Drawing.Point(158, 377);
            this.rand.Name = "rand";
            this.rand.Size = new System.Drawing.Size(41, 15);
            this.rand.TabIndex = 12;
            this.rand.Text = "label7";
            // 
            // contactMenuText
            // 
            this.contactMenuText.Name = "contactMenuText";
            this.contactMenuText.Size = new System.Drawing.Size(165, 25);
            this.contactMenuText.Text = "Контактные данные";
            this.contactMenuText.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.contactMenuText.Click += new System.EventHandler(this.contactDataClick);
            // 
            // configMenuText
            // 
            this.configMenuText.Enabled = false;
            this.configMenuText.Name = "configMenuText";
            this.configMenuText.Size = new System.Drawing.Size(221, 25);
            this.configMenuText.Text = "Конфигурация компьютера";
            this.configMenuText.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.configMenuText.Click += new System.EventHandler(this.configClick);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactMenuText,
            this.configMenuText});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip2.Location = new System.Drawing.Point(0, 29);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(228, 471);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "manu";
            this.menuStrip2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // saveToFile
            // 
            this.saveToFile.DefaultExt = "configuration";
            this.saveToFile.Filter = "ConfiguratePc files|*.configPc";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 500);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.rand);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.paintForm);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.contactDataPage.ResumeLayout(false);
            this.contactDataPage.PerformLayout();
            this.configPage.ResumeLayout(false);
            this.configPage.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadConfig;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage contactDataPage;
        private System.Windows.Forms.TabPage configPage;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button nextStep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UserStreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userMiddlename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rand;
        private System.Windows.Forms.ToolStripMenuItem contactMenuText;
        private System.Windows.Forms.ToolStripMenuItem configMenuText;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox bp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox mat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ozy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox proc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox viduha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox monik;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SaveFileDialog saveToFile;
    }
}

