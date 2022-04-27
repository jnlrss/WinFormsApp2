namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.tbno3 = new System.Windows.Forms.TextBox();
            this.tbno2 = new System.Windows.Forms.TextBox();
            this.tbno1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbsum = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income tax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(65, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medical Insurance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(65, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "SSS Contribution";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadd.Location = new System.Drawing.Point(163, 431);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(139, 52);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Enter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // tbno3
            // 
            this.tbno3.Location = new System.Drawing.Point(241, 214);
            this.tbno3.Name = "tbno3";
            this.tbno3.Size = new System.Drawing.Size(150, 31);
            this.tbno3.TabIndex = 4;
            // 
            // tbno2
            // 
            this.tbno2.Location = new System.Drawing.Point(241, 145);
            this.tbno2.Name = "tbno2";
            this.tbno2.Size = new System.Drawing.Size(150, 31);
            this.tbno2.TabIndex = 5;
            // 
            // tbno1
            // 
            this.tbno1.Location = new System.Drawing.Point(241, 83);
            this.tbno1.Name = "tbno1";
            this.tbno1.Size = new System.Drawing.Size(150, 31);
            this.tbno1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(65, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Net Income";
            // 
            // tbsum
            // 
            this.tbsum.Enabled = false;
            this.tbsum.Location = new System.Drawing.Point(241, 349);
            this.tbsum.Name = "tbsum";
            this.tbsum.Size = new System.Drawing.Size(150, 31);
            this.tbsum.TabIndex = 8;
            this.tbsum.TextChanged += new System.EventHandler(this.tbsum_TextChanged);
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(241, 280);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(150, 31);
            this.tb4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(65, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gross Income";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(468, 532);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tbsum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbno1);
            this.Controls.Add(this.tbno2);
            this.Controls.Add(this.tbno3);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnadd;
        private TextBox tbno3;
        private TextBox tbno2;
        private TextBox tbno1;
        private Label label4;
        private TextBox tbsum;
        private TextBox tb4;
        private Label label5;
    }
}