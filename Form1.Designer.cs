namespace Izbori
{
    partial class Form1
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
            this.cmdUcitavanjeIzbora = new System.Windows.Forms.Button();
            this.cmdDodavanjeAktiviste = new System.Windows.Forms.Button();
            this.cmdManyToOne = new System.Windows.Forms.Button();
            this.cmdDodavanjeGlasackogMesta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdUcitavanjeIzbora
            // 
            this.cmdUcitavanjeIzbora.Location = new System.Drawing.Point(12, 12);
            this.cmdUcitavanjeIzbora.Name = "cmdUcitavanjeIzbora";
            this.cmdUcitavanjeIzbora.Size = new System.Drawing.Size(244, 23);
            this.cmdUcitavanjeIzbora.TabIndex = 0;
            this.cmdUcitavanjeIzbora.Text = "Ucitavanje aktiviste";
            this.cmdUcitavanjeIzbora.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeIzbora.Click += new System.EventHandler(this.cmdUcitavanjeIzbora_Click);
            // 
            // cmdDodavanjeAktiviste
            // 
            this.cmdDodavanjeAktiviste.Location = new System.Drawing.Point(12, 41);
            this.cmdDodavanjeAktiviste.Name = "cmdDodavanjeAktiviste";
            this.cmdDodavanjeAktiviste.Size = new System.Drawing.Size(244, 23);
            this.cmdDodavanjeAktiviste.TabIndex = 1;
            this.cmdDodavanjeAktiviste.Text = "Dodavanje novog aktiviste";
            this.cmdDodavanjeAktiviste.UseVisualStyleBackColor = true;
            this.cmdDodavanjeAktiviste.Click += new System.EventHandler(this.cmdDodavanjeAktiviste_Click);
            // 
            // cmdManyToOne
            // 
            this.cmdManyToOne.Location = new System.Drawing.Point(12, 70);
            this.cmdManyToOne.Name = "cmdManyToOne";
            this.cmdManyToOne.Size = new System.Drawing.Size(244, 26);
            this.cmdManyToOne.TabIndex = 2;
            this.cmdManyToOne.Text = "Aktivista i Glasacko mesto";
            this.cmdManyToOne.UseVisualStyleBackColor = true;
            this.cmdManyToOne.Click += new System.EventHandler(this.cmdManyToOne_Click);
            // 
            // cmdDodavanjeGlasackogMesta
            // 
            this.cmdDodavanjeGlasackogMesta.Location = new System.Drawing.Point(12, 102);
            this.cmdDodavanjeGlasackogMesta.Name = "cmdDodavanjeGlasackogMesta";
            this.cmdDodavanjeGlasackogMesta.Size = new System.Drawing.Size(244, 23);
            this.cmdDodavanjeGlasackogMesta.TabIndex = 3;
            this.cmdDodavanjeGlasackogMesta.Text = "Dodavanje novog glasackog mesta";
            this.cmdDodavanjeGlasackogMesta.UseVisualStyleBackColor = true;
            this.cmdDodavanjeGlasackogMesta.Click += new System.EventHandler(this.cmdDodavanjeGlasackogMesta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Glasacko mesto i primedbe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdDodavanjeGlasackogMesta);
            this.Controls.Add(this.cmdManyToOne);
            this.Controls.Add(this.cmdDodavanjeAktiviste);
            this.Controls.Add(this.cmdUcitavanjeIzbora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdUcitavanjeIzbora;
        private System.Windows.Forms.Button cmdDodavanjeAktiviste;
        private System.Windows.Forms.Button cmdManyToOne;
        private System.Windows.Forms.Button cmdDodavanjeGlasackogMesta;
        private System.Windows.Forms.Button button1;
    }
}

