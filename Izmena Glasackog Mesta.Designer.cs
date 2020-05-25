namespace Izbori
{
    partial class Izmena_Glasackog_Mesta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_brm = new System.Windows.Forms.TextBox();
            this.textBox_naz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(360, 275);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Snimi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Broj mesta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Naziv";
            // 
            // textBox_brm
            // 
            this.textBox_brm.Location = new System.Drawing.Point(424, 199);
            this.textBox_brm.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_brm.Name = "textBox_brm";
            this.textBox_brm.Size = new System.Drawing.Size(167, 22);
            this.textBox_brm.TabIndex = 9;
            this.textBox_brm.TextChanged += new System.EventHandler(this.textBox_brm_TextChanged);
            // 
            // textBox_naz
            // 
            this.textBox_naz.Location = new System.Drawing.Point(233, 199);
            this.textBox_naz.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_naz.Name = "textBox_naz";
            this.textBox_naz.Size = new System.Drawing.Size(167, 22);
            this.textBox_naz.TabIndex = 7;
            this.textBox_naz.TextChanged += new System.EventHandler(this.textBox_naz_TextChanged);
            // 
            // Izmena_Glasackog_Mesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_brm);
            this.Controls.Add(this.textBox_naz);
            this.Name = "Izmena_Glasackog_Mesta";
            this.Text = "Izmena_Glasackog_Mesta";
            this.Load += new System.EventHandler(this.Izmena_Glasackog_Mesta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_brm;
        private System.Windows.Forms.TextBox textBox_naz;
    }
}