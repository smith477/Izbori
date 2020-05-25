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
            this.cmdOneToMany = new System.Windows.Forms.Button();
            this.cmdPrimedbe = new System.Windows.Forms.Button();
            this.cmdEmailAktiviste = new System.Windows.Forms.Button();
            this.cmdTelefonAktiviste = new System.Windows.Forms.Button();
            this.cmdGMRezultati = new System.Windows.Forms.Button();
            this.cmdKoordinatorOpstine = new System.Windows.Forms.Button();
            this.cmdKreirajKoordinatora = new System.Windows.Forms.Button();
            this.cmdAkcija = new System.Windows.Forms.Button();
            this.cmdDodajLetke = new System.Windows.Forms.Button();
            this.cmdGetSusreti = new System.Windows.Forms.Button();
            this.cmdDodajMitingNaZatvorenom = new System.Windows.Forms.Button();
            this.cmdManyToMany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdUcitavanjeIzbora
            // 
            this.cmdUcitavanjeIzbora.Location = new System.Drawing.Point(12, 12);
            this.cmdUcitavanjeIzbora.Name = "cmdUcitavanjeIzbora";
            this.cmdUcitavanjeIzbora.Size = new System.Drawing.Size(268, 23);
            this.cmdUcitavanjeIzbora.TabIndex = 0;
            this.cmdUcitavanjeIzbora.Text = "Ucitavanje aktiviste";
            this.cmdUcitavanjeIzbora.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeIzbora.Click += new System.EventHandler(this.cmdUcitavanjeIzbora_Click);
            // 
            // cmdDodavanjeAktiviste
            // 
            this.cmdDodavanjeAktiviste.Location = new System.Drawing.Point(12, 41);
            this.cmdDodavanjeAktiviste.Name = "cmdDodavanjeAktiviste";
            this.cmdDodavanjeAktiviste.Size = new System.Drawing.Size(268, 23);
            this.cmdDodavanjeAktiviste.TabIndex = 1;
            this.cmdDodavanjeAktiviste.Text = "Dodavanje novog aktiviste";
            this.cmdDodavanjeAktiviste.UseVisualStyleBackColor = true;
            this.cmdDodavanjeAktiviste.Click += new System.EventHandler(this.cmdDodavanjeAktiviste_Click);
            // 
            // cmdManyToOne
            // 
            this.cmdManyToOne.Location = new System.Drawing.Point(12, 70);
            this.cmdManyToOne.Name = "cmdManyToOne";
            this.cmdManyToOne.Size = new System.Drawing.Size(268, 26);
            this.cmdManyToOne.TabIndex = 2;
            this.cmdManyToOne.Text = "Aktivista i Glasacko mesto";
            this.cmdManyToOne.UseVisualStyleBackColor = true;
            this.cmdManyToOne.Click += new System.EventHandler(this.cmdManyToOne_Click);
            // 
            // cmdDodavanjeGlasackogMesta
            // 
            this.cmdDodavanjeGlasackogMesta.Location = new System.Drawing.Point(12, 102);
            this.cmdDodavanjeGlasackogMesta.Name = "cmdDodavanjeGlasackogMesta";
            this.cmdDodavanjeGlasackogMesta.Size = new System.Drawing.Size(268, 23);
            this.cmdDodavanjeGlasackogMesta.TabIndex = 3;
            this.cmdDodavanjeGlasackogMesta.Text = "Dodavanje novog glasackog mesta";
            this.cmdDodavanjeGlasackogMesta.UseVisualStyleBackColor = true;
            this.cmdDodavanjeGlasackogMesta.Click += new System.EventHandler(this.cmdDodavanjeGlasackogMesta_Click);
            // 
            // cmdOneToMany
            // 
            this.cmdOneToMany.Location = new System.Drawing.Point(12, 131);
            this.cmdOneToMany.Name = "cmdOneToMany";
            this.cmdOneToMany.Size = new System.Drawing.Size(268, 23);
            this.cmdOneToMany.TabIndex = 5;
            this.cmdOneToMany.Text = "Veza OneToMany Vrati Aktiviste Za GM";
            this.cmdOneToMany.UseVisualStyleBackColor = true;
            this.cmdOneToMany.Click += new System.EventHandler(this.cmdOneToMany_Click);
            // 
            // cmdPrimedbe
            // 
            this.cmdPrimedbe.Location = new System.Drawing.Point(12, 160);
            this.cmdPrimedbe.Name = "cmdPrimedbe";
            this.cmdPrimedbe.Size = new System.Drawing.Size(268, 23);
            this.cmdPrimedbe.TabIndex = 6;
            this.cmdPrimedbe.Text = "Glasacka Mesta I Primedbe";
            this.cmdPrimedbe.UseVisualStyleBackColor = true;
            this.cmdPrimedbe.Click += new System.EventHandler(this.cmdPrimedbe_Click);
            // 
            // cmdEmailAktiviste
            // 
            this.cmdEmailAktiviste.Location = new System.Drawing.Point(12, 189);
            this.cmdEmailAktiviste.Name = "cmdEmailAktiviste";
            this.cmdEmailAktiviste.Size = new System.Drawing.Size(268, 23);
            this.cmdEmailAktiviste.TabIndex = 7;
            this.cmdEmailAktiviste.Text = "E-mail aktiviste";
            this.cmdEmailAktiviste.UseVisualStyleBackColor = true;
            this.cmdEmailAktiviste.Click += new System.EventHandler(this.cmdEmailAktiviste_Click);
            // 
            // cmdTelefonAktiviste
            // 
            this.cmdTelefonAktiviste.Location = new System.Drawing.Point(12, 218);
            this.cmdTelefonAktiviste.Name = "cmdTelefonAktiviste";
            this.cmdTelefonAktiviste.Size = new System.Drawing.Size(268, 23);
            this.cmdTelefonAktiviste.TabIndex = 8;
            this.cmdTelefonAktiviste.Text = "Telefon aktiviste";
            this.cmdTelefonAktiviste.UseVisualStyleBackColor = true;
            this.cmdTelefonAktiviste.Click += new System.EventHandler(this.cmdTelefonAktiviste_Click);
            // 
            // cmdGMRezultati
            // 
            this.cmdGMRezultati.Location = new System.Drawing.Point(12, 247);
            this.cmdGMRezultati.Name = "cmdGMRezultati";
            this.cmdGMRezultati.Size = new System.Drawing.Size(268, 23);
            this.cmdGMRezultati.TabIndex = 9;
            this.cmdGMRezultati.Text = "Glasacka Mesta Rezultati";
            this.cmdGMRezultati.UseVisualStyleBackColor = true;
            this.cmdGMRezultati.Click += new System.EventHandler(this.cmdGMRezultati_Click);
            // 
            // cmdKoordinatorOpstine
            // 
            this.cmdKoordinatorOpstine.Location = new System.Drawing.Point(12, 276);
            this.cmdKoordinatorOpstine.Name = "cmdKoordinatorOpstine";
            this.cmdKoordinatorOpstine.Size = new System.Drawing.Size(268, 23);
            this.cmdKoordinatorOpstine.TabIndex = 10;
            this.cmdKoordinatorOpstine.Text = "Ucitavanje Koordinatora Opstine";
            this.cmdKoordinatorOpstine.UseVisualStyleBackColor = true;
            this.cmdKoordinatorOpstine.Click += new System.EventHandler(this.cmdKoordinatorOpstine_Click);
            // 
            // cmdKreirajKoordinatora
            // 
            this.cmdKreirajKoordinatora.Location = new System.Drawing.Point(12, 305);
            this.cmdKreirajKoordinatora.Name = "cmdKreirajKoordinatora";
            this.cmdKreirajKoordinatora.Size = new System.Drawing.Size(268, 27);
            this.cmdKreirajKoordinatora.TabIndex = 11;
            this.cmdKreirajKoordinatora.Text = "Kreiraj Koordinatora Opstine";
            this.cmdKreirajKoordinatora.UseVisualStyleBackColor = true;
            this.cmdKreirajKoordinatora.Click += new System.EventHandler(this.cmdKreirajKoordinatora_Click);
            // 
            // cmdAkcija
            // 
            this.cmdAkcija.Location = new System.Drawing.Point(12, 338);
            this.cmdAkcija.Name = "cmdAkcija";
            this.cmdAkcija.Size = new System.Drawing.Size(268, 23);
            this.cmdAkcija.TabIndex = 12;
            this.cmdAkcija.Text = "Vrati Akciju Deljenje_Letki";
            this.cmdAkcija.UseVisualStyleBackColor = true;
            this.cmdAkcija.Click += new System.EventHandler(this.cmdAkcija_Click);
            // 
            // cmdDodajLetke
            // 
            this.cmdDodajLetke.Location = new System.Drawing.Point(12, 367);
            this.cmdDodajLetke.Name = "cmdDodajLetke";
            this.cmdDodajLetke.Size = new System.Drawing.Size(268, 23);
            this.cmdDodajLetke.TabIndex = 13;
            this.cmdDodajLetke.Text = "Dodaj Novu Letku";
            this.cmdDodajLetke.UseVisualStyleBackColor = true;
            this.cmdDodajLetke.Click += new System.EventHandler(this.cmdDodajLetke_Click);
            // 
            // cmdGetSusreti
            // 
            this.cmdGetSusreti.Location = new System.Drawing.Point(12, 396);
            this.cmdGetSusreti.Name = "cmdGetSusreti";
            this.cmdGetSusreti.Size = new System.Drawing.Size(268, 23);
            this.cmdGetSusreti.TabIndex = 14;
            this.cmdGetSusreti.Text = "GET Susrete Kandidata I Gradjana";
            this.cmdGetSusreti.UseVisualStyleBackColor = true;
            this.cmdGetSusreti.Click += new System.EventHandler(this.cmdGetSusreti_Click);
            // 
            // cmdDodajMitingNaZatvorenom
            // 
            this.cmdDodajMitingNaZatvorenom.Location = new System.Drawing.Point(286, 12);
            this.cmdDodajMitingNaZatvorenom.Name = "cmdDodajMitingNaZatvorenom";
            this.cmdDodajMitingNaZatvorenom.Size = new System.Drawing.Size(268, 23);
            this.cmdDodajMitingNaZatvorenom.TabIndex = 15;
            this.cmdDodajMitingNaZatvorenom.Text = "Dodaj Miting Na Zatvorenom";
            this.cmdDodajMitingNaZatvorenom.UseVisualStyleBackColor = true;
            this.cmdDodajMitingNaZatvorenom.Click += new System.EventHandler(this.cmdDodajMitingNaZatvorenom_Click);
            // 
            // cmdManyToMany
            // 
            this.cmdManyToMany.Location = new System.Drawing.Point(286, 41);
            this.cmdManyToMany.Name = "cmdManyToMany";
            this.cmdManyToMany.Size = new System.Drawing.Size(268, 23);
            this.cmdManyToMany.TabIndex = 16;
            this.cmdManyToMany.Text = "Many-To-Many Veza";
            this.cmdManyToMany.UseVisualStyleBackColor = true;
            this.cmdManyToMany.Click += new System.EventHandler(this.cmdManyToMany_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdManyToMany);
            this.Controls.Add(this.cmdDodajMitingNaZatvorenom);
            this.Controls.Add(this.cmdGetSusreti);
            this.Controls.Add(this.cmdDodajLetke);
            this.Controls.Add(this.cmdAkcija);
            this.Controls.Add(this.cmdKreirajKoordinatora);
            this.Controls.Add(this.cmdKoordinatorOpstine);
            this.Controls.Add(this.cmdGMRezultati);
            this.Controls.Add(this.cmdTelefonAktiviste);
            this.Controls.Add(this.cmdEmailAktiviste);
            this.Controls.Add(this.cmdPrimedbe);
            this.Controls.Add(this.cmdOneToMany);
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
        private System.Windows.Forms.Button cmdOneToMany;
        private System.Windows.Forms.Button cmdPrimedbe;
        private System.Windows.Forms.Button cmdEmailAktiviste;
        private System.Windows.Forms.Button cmdTelefonAktiviste;
        private System.Windows.Forms.Button cmdGMRezultati;
        private System.Windows.Forms.Button cmdKoordinatorOpstine;
        private System.Windows.Forms.Button cmdKreirajKoordinatora;
        private System.Windows.Forms.Button cmdAkcija;
        private System.Windows.Forms.Button cmdDodajLetke;
        private System.Windows.Forms.Button cmdGetSusreti;
        private System.Windows.Forms.Button cmdDodajMitingNaZatvorenom;
        private System.Windows.Forms.Button cmdManyToMany;
    }
}

