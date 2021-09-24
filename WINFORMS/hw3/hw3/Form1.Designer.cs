
namespace hw3 {
    partial class anketa {
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
            this.loadFile = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.contactData = new System.Windows.Forms.GroupBox();
            this.countryInput = new System.Windows.Forms.ComboBox();
            this.mailInput = new System.Windows.Forms.TextBox();
            this.indexInput = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.indexLabel = new System.Windows.Forms.Label();
            this.numPhoneInput = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.adressInput = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.RadioButton();
            this.yes = new System.Windows.Forms.RadioButton();
            this.countryYesNoLabel = new System.Windows.Forms.Label();
            this.numPhoneLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.other = new System.Windows.Forms.GroupBox();
            this.countryWorkInput = new System.Windows.Forms.ComboBox();
            this.indexWorkInput = new System.Windows.Forms.TextBox();
            this.countryWorkLabel = new System.Windows.Forms.Label();
            this.nameOfUchebInput = new System.Windows.Forms.TextBox();
            this.indexWorkLabel = new System.Windows.Forms.Label();
            this.nameOfUchebLabel = new System.Windows.Forms.Label();
            this.numPhoneWorkInput = new System.Windows.Forms.TextBox();
            this.cityWorkInput = new System.Windows.Forms.TextBox();
            this.numPhoneWorkLabel = new System.Windows.Forms.Label();
            this.adressWorkInput = new System.Windows.Forms.TextBox();
            this.cityWorkLabel = new System.Windows.Forms.Label();
            this.getterWorkInput = new System.Windows.Forms.TextBox();
            this.getterWorkAdressLabel = new System.Windows.Forms.Label();
            this.getterWorkLabel = new System.Windows.Forms.Label();
            this.occupation = new System.Windows.Forms.GroupBox();
            this.rodCombo = new System.Windows.Forms.ComboBox();
            this.rodNow = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.errors = new System.Windows.Forms.ListBox();
            this.saveToFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.contactData.SuspendLayout();
            this.other.SuspendLayout();
            this.occupation.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(668, 12);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(120, 32);
            this.loadFile.TabIndex = 0;
            this.loadFile.Text = "Загрузить";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadClickAsync);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(12, 14);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(240, 24);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Информация о заявителе";
            // 
            // contactData
            // 
            this.contactData.Controls.Add(this.countryInput);
            this.contactData.Controls.Add(this.mailInput);
            this.contactData.Controls.Add(this.indexInput);
            this.contactData.Controls.Add(this.mailLabel);
            this.contactData.Controls.Add(this.countryLabel);
            this.contactData.Controls.Add(this.indexLabel);
            this.contactData.Controls.Add(this.numPhoneInput);
            this.contactData.Controls.Add(this.cityInput);
            this.contactData.Controls.Add(this.adressInput);
            this.contactData.Controls.Add(this.no);
            this.contactData.Controls.Add(this.yes);
            this.contactData.Controls.Add(this.countryYesNoLabel);
            this.contactData.Controls.Add(this.numPhoneLabel);
            this.contactData.Controls.Add(this.cityLabel);
            this.contactData.Controls.Add(this.adressLabel);
            this.contactData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactData.Location = new System.Drawing.Point(12, 59);
            this.contactData.Name = "contactData";
            this.contactData.Size = new System.Drawing.Size(776, 147);
            this.contactData.TabIndex = 2;
            this.contactData.TabStop = false;
            this.contactData.Text = "Контактные данные";
            // 
            // countryInput
            // 
            this.countryInput.AllowDrop = true;
            this.countryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryInput.FormattingEnabled = true;
            this.countryInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.countryInput.Items.AddRange(new object[] {
            "Украина",
            "Россия",
            "Турция"});
            this.countryInput.Location = new System.Drawing.Point(601, 54);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(163, 26);
            this.countryInput.TabIndex = 5;
            this.countryInput.Text = "Выберите значение";
            this.countryInput.TextChanged += new System.EventHandler(this.verifText);
            // 
            // mailInput
            // 
            this.mailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailInput.Location = new System.Drawing.Point(601, 85);
            this.mailInput.Name = "mailInput";
            this.mailInput.Size = new System.Drawing.Size(163, 24);
            this.mailInput.TabIndex = 6;
            // 
            // indexInput
            // 
            this.indexInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexInput.Location = new System.Drawing.Point(601, 22);
            this.indexInput.Name = "indexInput";
            this.indexInput.Size = new System.Drawing.Size(163, 24);
            this.indexInput.TabIndex = 4;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailLabel.Location = new System.Drawing.Point(396, 88);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(191, 18);
            this.mailLabel.TabIndex = 11;
            this.mailLabel.Text = "Адрес электронной почты";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.Location = new System.Drawing.Point(396, 57);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(68, 18);
            this.countryLabel.TabIndex = 10;
            this.countryLabel.Text = "Страна *";
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexLabel.Location = new System.Drawing.Point(396, 29);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(132, 18);
            this.indexLabel.TabIndex = 9;
            this.indexLabel.Text = "Почтовый индекс";
            // 
            // numPhoneInput
            // 
            this.numPhoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPhoneInput.Location = new System.Drawing.Point(215, 85);
            this.numPhoneInput.Name = "numPhoneInput";
            this.numPhoneInput.Size = new System.Drawing.Size(159, 24);
            this.numPhoneInput.TabIndex = 3;
            this.numPhoneInput.TextChanged += new System.EventHandler(this.verifText);
            // 
            // cityInput
            // 
            this.cityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityInput.Location = new System.Drawing.Point(215, 54);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(159, 24);
            this.cityInput.TabIndex = 2;
            this.cityInput.TextChanged += new System.EventHandler(this.verifText);
            // 
            // adressInput
            // 
            this.adressInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressInput.Location = new System.Drawing.Point(215, 26);
            this.adressInput.Name = "adressInput";
            this.adressInput.Size = new System.Drawing.Size(159, 24);
            this.adressInput.TabIndex = 1;
            this.adressInput.TextChanged += new System.EventHandler(this.verifText);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.no.Location = new System.Drawing.Point(289, 118);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(52, 22);
            this.no.TabIndex = 8;
            this.no.Text = "Нет";
            this.no.UseVisualStyleBackColor = true;
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Checked = true;
            this.yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yes.Location = new System.Drawing.Point(227, 118);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(46, 22);
            this.yes.TabIndex = 7;
            this.yes.TabStop = true;
            this.yes.Text = "Да";
            this.yes.UseVisualStyleBackColor = true;
            // 
            // countryYesNoLabel
            // 
            this.countryYesNoLabel.AutoSize = true;
            this.countryYesNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryYesNoLabel.Location = new System.Drawing.Point(7, 120);
            this.countryYesNoLabel.Name = "countryYesNoLabel";
            this.countryYesNoLabel.Size = new System.Drawing.Size(156, 18);
            this.countryYesNoLabel.TabIndex = 3;
            this.countryYesNoLabel.Text = "Страна пребывания *";
            // 
            // numPhoneLabel
            // 
            this.numPhoneLabel.AutoSize = true;
            this.numPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPhoneLabel.Location = new System.Drawing.Point(6, 88);
            this.numPhoneLabel.Name = "numPhoneLabel";
            this.numPhoneLabel.Size = new System.Drawing.Size(139, 18);
            this.numPhoneLabel.TabIndex = 2;
            this.numPhoneLabel.Text = "Номер телефона *";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.Location = new System.Drawing.Point(6, 57);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(62, 18);
            this.cityLabel.TabIndex = 1;
            this.cityLabel.Text = "Город *";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressLabel.Location = new System.Drawing.Point(6, 29);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(60, 18);
            this.adressLabel.TabIndex = 0;
            this.adressLabel.Text = "Адрес *";
            // 
            // other
            // 
            this.other.Controls.Add(this.countryWorkInput);
            this.other.Controls.Add(this.indexWorkInput);
            this.other.Controls.Add(this.countryWorkLabel);
            this.other.Controls.Add(this.nameOfUchebInput);
            this.other.Controls.Add(this.indexWorkLabel);
            this.other.Controls.Add(this.nameOfUchebLabel);
            this.other.Controls.Add(this.numPhoneWorkInput);
            this.other.Controls.Add(this.cityWorkInput);
            this.other.Controls.Add(this.numPhoneWorkLabel);
            this.other.Controls.Add(this.adressWorkInput);
            this.other.Controls.Add(this.cityWorkLabel);
            this.other.Controls.Add(this.getterWorkInput);
            this.other.Controls.Add(this.getterWorkAdressLabel);
            this.other.Controls.Add(this.getterWorkLabel);
            this.other.Location = new System.Drawing.Point(12, 346);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(776, 164);
            this.other.TabIndex = 3;
            this.other.TabStop = false;
            this.other.Text = "Другое";
            // 
            // countryWorkInput
            // 
            this.countryWorkInput.AllowDrop = true;
            this.countryWorkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryWorkInput.FormattingEnabled = true;
            this.countryWorkInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.countryWorkInput.Items.AddRange(new object[] {
            "Украина",
            "Россия",
            "Турция"});
            this.countryWorkInput.Location = new System.Drawing.Point(601, 95);
            this.countryWorkInput.Name = "countryWorkInput";
            this.countryWorkInput.Size = new System.Drawing.Size(163, 26);
            this.countryWorkInput.TabIndex = 22;
            this.countryWorkInput.Text = "Выберите значение";
            this.countryWorkInput.TextChanged += new System.EventHandler(this.verifText);
            // 
            // indexWorkInput
            // 
            this.indexWorkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexWorkInput.Location = new System.Drawing.Point(601, 62);
            this.indexWorkInput.Name = "indexWorkInput";
            this.indexWorkInput.Size = new System.Drawing.Size(163, 24);
            this.indexWorkInput.TabIndex = 15;
            // 
            // countryWorkLabel
            // 
            this.countryWorkLabel.AutoSize = true;
            this.countryWorkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryWorkLabel.Location = new System.Drawing.Point(396, 95);
            this.countryWorkLabel.Name = "countryWorkLabel";
            this.countryWorkLabel.Size = new System.Drawing.Size(68, 18);
            this.countryWorkLabel.TabIndex = 21;
            this.countryWorkLabel.Text = "Страна *";
            // 
            // nameOfUchebInput
            // 
            this.nameOfUchebInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOfUchebInput.Location = new System.Drawing.Point(601, 30);
            this.nameOfUchebInput.Name = "nameOfUchebInput";
            this.nameOfUchebInput.Size = new System.Drawing.Size(163, 24);
            this.nameOfUchebInput.TabIndex = 14;
            // 
            // indexWorkLabel
            // 
            this.indexWorkLabel.AutoSize = true;
            this.indexWorkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexWorkLabel.Location = new System.Drawing.Point(396, 62);
            this.indexWorkLabel.Name = "indexWorkLabel";
            this.indexWorkLabel.Size = new System.Drawing.Size(132, 18);
            this.indexWorkLabel.TabIndex = 20;
            this.indexWorkLabel.Text = "Почтовый индекс";
            // 
            // nameOfUchebLabel
            // 
            this.nameOfUchebLabel.AutoSize = true;
            this.nameOfUchebLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOfUchebLabel.Location = new System.Drawing.Point(396, 30);
            this.nameOfUchebLabel.Name = "nameOfUchebLabel";
            this.nameOfUchebLabel.Size = new System.Drawing.Size(175, 18);
            this.nameOfUchebLabel.TabIndex = 19;
            this.nameOfUchebLabel.Text = "Название уч. заведения";
            // 
            // numPhoneWorkInput
            // 
            this.numPhoneWorkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPhoneWorkInput.Location = new System.Drawing.Point(215, 124);
            this.numPhoneWorkInput.Name = "numPhoneWorkInput";
            this.numPhoneWorkInput.Size = new System.Drawing.Size(159, 24);
            this.numPhoneWorkInput.TabIndex = 13;
            this.numPhoneWorkInput.TextChanged += new System.EventHandler(this.verifText);
            // 
            // cityWorkInput
            // 
            this.cityWorkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityWorkInput.Location = new System.Drawing.Point(215, 95);
            this.cityWorkInput.Name = "cityWorkInput";
            this.cityWorkInput.Size = new System.Drawing.Size(159, 24);
            this.cityWorkInput.TabIndex = 12;
            this.cityWorkInput.TextChanged += new System.EventHandler(this.verifText);
            // 
            // numPhoneWorkLabel
            // 
            this.numPhoneWorkLabel.AutoSize = true;
            this.numPhoneWorkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPhoneWorkLabel.Location = new System.Drawing.Point(6, 124);
            this.numPhoneWorkLabel.Name = "numPhoneWorkLabel";
            this.numPhoneWorkLabel.Size = new System.Drawing.Size(139, 18);
            this.numPhoneWorkLabel.TabIndex = 6;
            this.numPhoneWorkLabel.Text = "Номер телефона *";
            // 
            // adressWorkInput
            // 
            this.adressWorkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressWorkInput.Location = new System.Drawing.Point(215, 62);
            this.adressWorkInput.Name = "adressWorkInput";
            this.adressWorkInput.Size = new System.Drawing.Size(159, 24);
            this.adressWorkInput.TabIndex = 11;
            this.adressWorkInput.TextChanged += new System.EventHandler(this.verifText);
            // 
            // cityWorkLabel
            // 
            this.cityWorkLabel.AutoSize = true;
            this.cityWorkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityWorkLabel.Location = new System.Drawing.Point(6, 95);
            this.cityWorkLabel.Name = "cityWorkLabel";
            this.cityWorkLabel.Size = new System.Drawing.Size(62, 18);
            this.cityWorkLabel.TabIndex = 5;
            this.cityWorkLabel.Text = "Город *";
            // 
            // getterWorkInput
            // 
            this.getterWorkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getterWorkInput.Location = new System.Drawing.Point(215, 30);
            this.getterWorkInput.Name = "getterWorkInput";
            this.getterWorkInput.Size = new System.Drawing.Size(159, 24);
            this.getterWorkInput.TabIndex = 10;
            this.getterWorkInput.TextChanged += new System.EventHandler(this.verifText);
            // 
            // getterWorkAdressLabel
            // 
            this.getterWorkAdressLabel.AutoSize = true;
            this.getterWorkAdressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getterWorkAdressLabel.Location = new System.Drawing.Point(6, 62);
            this.getterWorkAdressLabel.Name = "getterWorkAdressLabel";
            this.getterWorkAdressLabel.Size = new System.Drawing.Size(60, 18);
            this.getterWorkAdressLabel.TabIndex = 4;
            this.getterWorkAdressLabel.Text = "Адрес *";
            // 
            // getterWorkLabel
            // 
            this.getterWorkLabel.AutoSize = true;
            this.getterWorkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getterWorkLabel.Location = new System.Drawing.Point(6, 30);
            this.getterWorkLabel.Name = "getterWorkLabel";
            this.getterWorkLabel.Size = new System.Drawing.Size(119, 18);
            this.getterWorkLabel.TabIndex = 3;
            this.getterWorkLabel.Text = "Работодатель *";
            // 
            // occupation
            // 
            this.occupation.Controls.Add(this.rodCombo);
            this.occupation.Controls.Add(this.rodNow);
            this.occupation.Location = new System.Drawing.Point(12, 231);
            this.occupation.Name = "occupation";
            this.occupation.Size = new System.Drawing.Size(776, 100);
            this.occupation.TabIndex = 4;
            this.occupation.TabStop = false;
            this.occupation.Text = "Род занятий";
            // 
            // rodCombo
            // 
            this.rodCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rodCombo.FormattingEnabled = true;
            this.rodCombo.Location = new System.Drawing.Point(215, 45);
            this.rodCombo.Name = "rodCombo";
            this.rodCombo.Size = new System.Drawing.Size(159, 26);
            this.rodCombo.TabIndex = 9;
            this.rodCombo.Text = "Выберите значение";
            this.rodCombo.TextChanged += new System.EventHandler(this.verifText);
            // 
            // rodNow
            // 
            this.rodNow.AutoSize = true;
            this.rodNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rodNow.Location = new System.Drawing.Point(7, 48);
            this.rodNow.Name = "rodNow";
            this.rodNow.Size = new System.Drawing.Size(105, 18);
            this.rodNow.TabIndex = 1;
            this.rodNow.Text = "Род занятий *";
            // 
            // saveFile
            // 
            this.saveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFile.Location = new System.Drawing.Point(532, 536);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(118, 35);
            this.saveFile.TabIndex = 17;
            this.saveFile.Text = "Сохранить";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveClick);
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send.Location = new System.Drawing.Point(670, 536);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(118, 35);
            this.send.TabIndex = 18;
            this.send.Text = "Отправить";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.sendClicked);
            // 
            // errors
            // 
            this.errors.FormattingEnabled = true;
            this.errors.Location = new System.Drawing.Point(12, 516);
            this.errors.Name = "errors";
            this.errors.Size = new System.Drawing.Size(374, 56);
            this.errors.TabIndex = 20;
            this.errors.TabStop = false;
            this.errors.Tag = "errors";
            // 
            // saveToFile
            // 
            this.saveToFile.FileName = "anketa";
            this.saveToFile.Filter = "Anketa files|*.anketa";
            this.saveToFile.InitialDirectory = "/";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Filter = "Anketa files|*.anketa";
            // 
            // anketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.errors);
            this.Controls.Add(this.send);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.occupation);
            this.Controls.Add(this.other);
            this.Controls.Add(this.contactData);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.loadFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "anketa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anketa";
            this.contactData.ResumeLayout(false);
            this.contactData.PerformLayout();
            this.other.ResumeLayout(false);
            this.other.PerformLayout();
            this.occupation.ResumeLayout(false);
            this.occupation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.GroupBox contactData;
        private System.Windows.Forms.TextBox mailInput;
        private System.Windows.Forms.TextBox indexInput;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.TextBox numPhoneInput;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.TextBox adressInput;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.Label countryYesNoLabel;
        private System.Windows.Forms.Label numPhoneLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.GroupBox other;
        private System.Windows.Forms.TextBox indexWorkInput;
        private System.Windows.Forms.Label countryWorkLabel;
        private System.Windows.Forms.TextBox nameOfUchebInput;
        private System.Windows.Forms.Label indexWorkLabel;
        private System.Windows.Forms.Label nameOfUchebLabel;
        private System.Windows.Forms.TextBox numPhoneWorkInput;
        private System.Windows.Forms.TextBox cityWorkInput;
        private System.Windows.Forms.Label numPhoneWorkLabel;
        private System.Windows.Forms.TextBox adressWorkInput;
        private System.Windows.Forms.Label cityWorkLabel;
        private System.Windows.Forms.TextBox getterWorkInput;
        private System.Windows.Forms.Label getterWorkAdressLabel;
        private System.Windows.Forms.Label getterWorkLabel;
        private System.Windows.Forms.GroupBox occupation;
        private System.Windows.Forms.ComboBox rodCombo;
        private System.Windows.Forms.Label rodNow;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.ListBox errors;
        private System.Windows.Forms.ComboBox countryInput;
        private System.Windows.Forms.ComboBox countryWorkInput;
        private System.Windows.Forms.SaveFileDialog saveToFile;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

