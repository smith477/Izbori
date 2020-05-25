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
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdTransakcija = new System.Windows.Forms.Button();
            this.cmdLINQ = new System.Windows.Forms.Button();
            this.cmdLINQ1 = new System.Windows.Forms.Button();
            this.cmdLINQ2 = new System.Windows.Forms.Button();
            this.cmdPregledAktivista = new System.Windows.Forms.Button();
            this.btnScalar = new System.Windows.Forms.Button();
            this.btnPaging = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.cmdKreiranjeUpita = new System.Windows.Forms.Button();
            this.cmdKreiranjeUpita1 = new System.Windows.Forms.Button();
            this.cmdKreiranjeUpitaSaParametrima = new System.Windows.Forms.Button();
            this.cmdKreiranjeUpitaSaImenovanimParametrima = new System.Windows.Forms.Button();
            this.cmdKreiranjeUpitaSaImenovanimParametrima1 = new System.Windows.Forms.Button();
            this.cmdKoriscenjeEnumerable = new System.Windows.Forms.Button();
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
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(286, 73);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(268, 23);
            this.cmdUpdate.TabIndex = 17;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(286, 102);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(268, 23);
            this.cmdDelete.TabIndex = 18;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdTransakcija
            // 
            this.cmdTransakcija.Location = new System.Drawing.Point(286, 131);
            this.cmdTransakcija.Name = "cmdTransakcija";
            this.cmdTransakcija.Size = new System.Drawing.Size(268, 23);
            this.cmdTransakcija.TabIndex = 19;
            this.cmdTransakcija.Text = "Transakcija";
            this.cmdTransakcija.UseVisualStyleBackColor = true;
            this.cmdTransakcija.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdLINQ
            // 
            this.cmdLINQ.Location = new System.Drawing.Point(286, 160);
            this.cmdLINQ.Name = "cmdLINQ";
            this.cmdLINQ.Size = new System.Drawing.Size(268, 23);
            this.cmdLINQ.TabIndex = 20;
            this.cmdLINQ.Text = "LINQ";
            this.cmdLINQ.UseVisualStyleBackColor = true;
            this.cmdLINQ.Click += new System.EventHandler(this.cmdLINQ_Click);
            // 
            // cmdLINQ1
            // 
            this.cmdLINQ1.Location = new System.Drawing.Point(286, 189);
            this.cmdLINQ1.Name = "cmdLINQ1";
            this.cmdLINQ1.Size = new System.Drawing.Size(268, 23);
            this.cmdLINQ1.TabIndex = 21;
            this.cmdLINQ1.Text = "LINQ 1";
            this.cmdLINQ1.UseVisualStyleBackColor = true;
            this.cmdLINQ1.Click += new System.EventHandler(this.cmdLINQ1_Click);
            // 
            // cmdLINQ2
            // 
            this.cmdLINQ2.Location = new System.Drawing.Point(286, 218);
            this.cmdLINQ2.Name = "cmdLINQ2";
            this.cmdLINQ2.Size = new System.Drawing.Size(268, 23);
            this.cmdLINQ2.TabIndex = 22;
            this.cmdLINQ2.Text = "LINQ 2";
            this.cmdLINQ2.UseVisualStyleBackColor = true;
            this.cmdLINQ2.Click += new System.EventHandler(this.cmdLINQ2_Click);
            // 
            // cmdPregledAktivista
            // 
            this.cmdPregledAktivista.Location = new System.Drawing.Point(286, 247);
            this.cmdPregledAktivista.Name = "cmdPregledAktivista";
            this.cmdPregledAktivista.Size = new System.Drawing.Size(268, 23);
            this.cmdPregledAktivista.TabIndex = 23;
            this.cmdPregledAktivista.Text = "Pregled Aktivista";
            this.cmdPregledAktivista.UseVisualStyleBackColor = true;
            this.cmdPregledAktivista.Click += new System.EventHandler(this.cmdPregledAktivista_Click);
            // 
            // btnScalar
            // 
            this.btnScalar.Location = new System.Drawing.Point(287, 276);
            this.btnScalar.Name = "btnScalar";
            this.btnScalar.Size = new System.Drawing.Size(267, 23);
            this.btnScalar.TabIndex = 24;
            this.btnScalar.Text = "Scalar";
            this.btnScalar.UseVisualStyleBackColor = true;
            this.btnScalar.Click += new System.EventHandler(this.btnScalar_Click_1);
            // 
            // btnPaging
            // 
            this.btnPaging.Location = new System.Drawing.Point(286, 305);
            this.btnPaging.Name = "btnPaging";
            this.btnPaging.Size = new System.Drawing.Size(267, 23);
            this.btnPaging.TabIndex = 25;
            this.btnPaging.Text = "Paging";
            this.btnPaging.UseVisualStyleBackColor = true;
            this.btnPaging.Click += new System.EventHandler(this.btnPaging_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Criteria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "QueryOver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "NativSql";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Location = new System.Drawing.Point(561, 12);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(258, 23);
            this.cmdRefresh.TabIndex = 29;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdKreiranjeUpita
            // 
            this.cmdKreiranjeUpita.Location = new System.Drawing.Point(561, 40);
            this.cmdKreiranjeUpita.Name = "cmdKreiranjeUpita";
            this.cmdKreiranjeUpita.Size = new System.Drawing.Size(258, 23);
            this.cmdKreiranjeUpita.TabIndex = 30;
            this.cmdKreiranjeUpita.Text = "Kreiranje upita";
            this.cmdKreiranjeUpita.UseVisualStyleBackColor = true;
            this.cmdKreiranjeUpita.Click += new System.EventHandler(this.cmdKreiranjeUpita_Click);
            // 
            // cmdKreiranjeUpita1
            // 
            this.cmdKreiranjeUpita1.Location = new System.Drawing.Point(561, 73);
            this.cmdKreiranjeUpita1.Name = "cmdKreiranjeUpita1";
            this.cmdKreiranjeUpita1.Size = new System.Drawing.Size(258, 23);
            this.cmdKreiranjeUpita1.TabIndex = 31;
            this.cmdKreiranjeUpita1.Text = "Kreiranje upita 1";
            this.cmdKreiranjeUpita1.UseVisualStyleBackColor = true;
            this.cmdKreiranjeUpita1.Click += new System.EventHandler(this.cmdKreiranjeUpita1_Click);
            // 
            // cmdKreiranjeUpitaSaParametrima
            // 
            this.cmdKreiranjeUpitaSaParametrima.Location = new System.Drawing.Point(561, 102);
            this.cmdKreiranjeUpitaSaParametrima.Name = "cmdKreiranjeUpitaSaParametrima";
            this.cmdKreiranjeUpitaSaParametrima.Size = new System.Drawing.Size(258, 23);
            this.cmdKreiranjeUpitaSaParametrima.TabIndex = 32;
            this.cmdKreiranjeUpitaSaParametrima.Text = "Kreiranje upita sa parametrima";
            this.cmdKreiranjeUpitaSaParametrima.UseVisualStyleBackColor = true;
            this.cmdKreiranjeUpitaSaParametrima.Click += new System.EventHandler(this.cmdKreiranjeUpitaSaParametrima_Click);
            // 
            // cmdKreiranjeUpitaSaImenovanimParametrima
            // 
            this.cmdKreiranjeUpitaSaImenovanimParametrima.Location = new System.Drawing.Point(561, 131);
            this.cmdKreiranjeUpitaSaImenovanimParametrima.Name = "cmdKreiranjeUpitaSaImenovanimParametrima";
            this.cmdKreiranjeUpitaSaImenovanimParametrima.Size = new System.Drawing.Size(258, 23);
            this.cmdKreiranjeUpitaSaImenovanimParametrima.TabIndex = 33;
            this.cmdKreiranjeUpitaSaImenovanimParametrima.Text = "Kreiranje upita sa imenovanim parametrima";
            this.cmdKreiranjeUpitaSaImenovanimParametrima.UseVisualStyleBackColor = true;
            this.cmdKreiranjeUpitaSaImenovanimParametrima.Click += new System.EventHandler(this.cmdKreiranjeUpitaSaImenovanimParametrima_Click);
            // 
            // cmdKreiranjeUpitaSaImenovanimParametrima1
            // 
            this.cmdKreiranjeUpitaSaImenovanimParametrima1.Location = new System.Drawing.Point(561, 159);
            this.cmdKreiranjeUpitaSaImenovanimParametrima1.Name = "cmdKreiranjeUpitaSaImenovanimParametrima1";
            this.cmdKreiranjeUpitaSaImenovanimParametrima1.Size = new System.Drawing.Size(258, 23);
            this.cmdKreiranjeUpitaSaImenovanimParametrima1.TabIndex = 34;
            this.cmdKreiranjeUpitaSaImenovanimParametrima1.Text = "Kreiranje upita sa imenovanim parametrima 1";
            this.cmdKreiranjeUpitaSaImenovanimParametrima1.UseVisualStyleBackColor = true;
            this.cmdKreiranjeUpitaSaImenovanimParametrima1.Click += new System.EventHandler(this.cmdKreiranjeUpitaSaImenovanimParametrima1_Click);
            // 
            // cmdKoriscenjeEnumerable
            // 
            this.cmdKoriscenjeEnumerable.Location = new System.Drawing.Point(561, 188);
            this.cmdKoriscenjeEnumerable.Name = "cmdKoriscenjeEnumerable";
            this.cmdKoriscenjeEnumerable.Size = new System.Drawing.Size(258, 23);
            this.cmdKoriscenjeEnumerable.TabIndex = 35;
            this.cmdKoriscenjeEnumerable.Text = "Koriscenje Enumerable";
            this.cmdKoriscenjeEnumerable.UseVisualStyleBackColor = true;
            this.cmdKoriscenjeEnumerable.Click += new System.EventHandler(this.cmdKoriscenjeEnumerable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.cmdKoriscenjeEnumerable);
            this.Controls.Add(this.cmdKreiranjeUpitaSaImenovanimParametrima1);
            this.Controls.Add(this.cmdKreiranjeUpitaSaImenovanimParametrima);
            this.Controls.Add(this.cmdKreiranjeUpitaSaParametrima);
            this.Controls.Add(this.cmdKreiranjeUpita1);
            this.Controls.Add(this.cmdKreiranjeUpita);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPaging);
            this.Controls.Add(this.btnScalar);
            this.Controls.Add(this.cmdPregledAktivista);
            this.Controls.Add(this.cmdLINQ2);
            this.Controls.Add(this.cmdLINQ1);
            this.Controls.Add(this.cmdLINQ);
            this.Controls.Add(this.cmdTransakcija);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdUpdate);
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
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdTransakcija;
        private System.Windows.Forms.Button cmdLINQ;
        private System.Windows.Forms.Button cmdLINQ1;
        private System.Windows.Forms.Button cmdLINQ2;
        private System.Windows.Forms.Button cmdPregledAktivista;
        private System.Windows.Forms.Button btnScalar;
        private System.Windows.Forms.Button btnPaging;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Button cmdKreiranjeUpita;
        private System.Windows.Forms.Button cmdKreiranjeUpita1;
        private System.Windows.Forms.Button cmdKreiranjeUpitaSaParametrima;
        private System.Windows.Forms.Button cmdKreiranjeUpitaSaImenovanimParametrima;
        private System.Windows.Forms.Button cmdKreiranjeUpitaSaImenovanimParametrima1;
        private System.Windows.Forms.Button cmdKoriscenjeEnumerable;
    }
}

