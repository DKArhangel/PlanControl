namespace Plan
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btopnfadd = new System.Windows.Forms.Button();
            this.tbPX = new System.Windows.Forms.TextBox();
            this.tbPY = new System.Windows.Forms.TextBox();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btopnfadd
            // 
            this.btopnfadd.Location = new System.Drawing.Point(504, 15);
            this.btopnfadd.Name = "btopnfadd";
            this.btopnfadd.Size = new System.Drawing.Size(75, 23);
            this.btopnfadd.TabIndex = 1;
            this.btopnfadd.Text = "Add";
            this.btopnfadd.UseVisualStyleBackColor = true;
            this.btopnfadd.Click += new System.EventHandler(this.btopnfadd_Click);
            // 
            // tbPX
            // 
            this.tbPX.Location = new System.Drawing.Point(501, 45);
            this.tbPX.Name = "tbPX";
            this.tbPX.Size = new System.Drawing.Size(100, 20);
            this.tbPX.TabIndex = 2;
            // 
            // tbPY
            // 
            this.tbPY.Location = new System.Drawing.Point(501, 72);
            this.tbPY.Name = "tbPY";
            this.tbPY.Size = new System.Drawing.Size(100, 20);
            this.tbPY.TabIndex = 3;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 509);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPY);
            this.Controls.Add(this.tbPX);
            this.Controls.Add(this.btopnfadd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btopnfadd;
        private System.Windows.Forms.TextBox tbPX;
        private System.Windows.Forms.TextBox tbPY;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

