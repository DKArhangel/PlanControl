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
            this.lb1 = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btopnfadd
            // 
            this.btopnfadd.Location = new System.Drawing.Point(789, 12);
            this.btopnfadd.Name = "btopnfadd";
            this.btopnfadd.Size = new System.Drawing.Size(75, 23);
            this.btopnfadd.TabIndex = 1;
            this.btopnfadd.Text = "Add";
            this.btopnfadd.UseVisualStyleBackColor = true;
            this.btopnfadd.Click += new System.EventHandler(this.btopnfadd_Click);
            // 
            // tbPX
            // 
            this.tbPX.Location = new System.Drawing.Point(786, 42);
            this.tbPX.Name = "tbPX";
            this.tbPX.Size = new System.Drawing.Size(100, 20);
            this.tbPX.TabIndex = 2;
            // 
            // tbPY
            // 
            this.tbPY.Location = new System.Drawing.Point(786, 69);
            this.tbPY.Name = "tbPY";
            this.tbPY.Size = new System.Drawing.Size(100, 20);
            this.tbPY.TabIndex = 3;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(786, 115);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(13, 13);
            this.lb1.TabIndex = 4;
            this.lb1.Text = "0";
            // 
            // debug
            // 
            this.debug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debug.Location = new System.Drawing.Point(12, 338);
            this.debug.Multiline = true;
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(976, 236);
            this.debug.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 586);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tbPY);
            this.Controls.Add(this.tbPX);
            this.Controls.Add(this.btopnfadd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btopnfadd;
        private System.Windows.Forms.TextBox tbPX;
        private System.Windows.Forms.TextBox tbPY;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox debug;
    }
}

