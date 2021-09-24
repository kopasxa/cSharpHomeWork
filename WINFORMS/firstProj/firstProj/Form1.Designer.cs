
namespace firstProj {
    partial class Form1 {
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
            this.Reult = new System.Windows.Forms.Button();
            this.NameProgram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reult
            // 
            this.Reult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Reult.Location = new System.Drawing.Point(90, 226);
            this.Reult.Name = "Reult";
            this.Reult.Size = new System.Drawing.Size(75, 23);
            this.Reult.TabIndex = 0;
            this.Reult.Text = "Click me!";
            this.Reult.UseVisualStyleBackColor = true;
            this.Reult.Click += new System.EventHandler(this.button_result);
            // 
            // NameProgram
            // 
            this.NameProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameProgram.Location = new System.Drawing.Point(82, 61);
            this.NameProgram.MinimumSize = new System.Drawing.Size(35, 13);
            this.NameProgram.Name = "NameProgram";
            this.NameProgram.Size = new System.Drawing.Size(98, 27);
            this.NameProgram.TabIndex = 1;
            this.NameProgram.Text = "label1";
            this.NameProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 368);
            this.Controls.Add(this.NameProgram);
            this.Controls.Add(this.Reult);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Reult;
        private System.Windows.Forms.Label NameProgram;
    }
}

