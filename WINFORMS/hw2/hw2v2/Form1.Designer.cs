﻿
namespace hw2v2 {
    partial class game {
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
            this.clickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickMe
            // 
            this.clickMe.Location = new System.Drawing.Point(293, 180);
            this.clickMe.Name = "clickMe";
            this.clickMe.Size = new System.Drawing.Size(133, 42);
            this.clickMe.TabIndex = 0;
            this.clickMe.Text = "НАЖМИ НА МЕНЯ!";
            this.clickMe.UseVisualStyleBackColor = true;
            this.clickMe.Click += new System.EventHandler(this.clecked);
            this.clickMe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.go);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 420);
            this.Controls.Add(this.clickMe);
            this.MinimumSize = new System.Drawing.Size(487, 293);
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickMe;
    }
}

