﻿
namespace DatabaseProject
{
    partial class UserServices
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
            this.TabPage = new System.Windows.Forms.TabControl();
            this.Clienti = new System.Windows.Forms.TabPage();
            this.NoleggioBiciclette_Lista = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AggiungiNoleggioButton = new System.Windows.Forms.Button();
            this.Bici = new System.Windows.Forms.TextBox();
            this.TabellaBici = new System.Windows.Forms.DataGridView();
            this.NoleggiaBiciButton = new System.Windows.Forms.Button();
            this.Dipendenti = new System.Windows.Forms.TabPage();
            this.Tour = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Pacchetto_Prezzo = new System.Windows.Forms.TextBox();
            this.Pacchetto_Sconto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Servizio_DataFine = new System.Windows.Forms.TextBox();
            this.Servizio_DataInizio = new System.Windows.Forms.TextBox();
            this.Servizio_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AggiornaButton = new System.Windows.Forms.Button();
            this.NoleggioAccessori_Lista = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AggiungiNoleggio1 = new System.Windows.Forms.Button();
            this.Accessorio = new System.Windows.Forms.TextBox();
            this.TabellaAccessori = new System.Windows.Forms.DataGridView();
            this.NoleggiaAccessorio = new System.Windows.Forms.Button();
            this.Guide_Lista = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AggiungiGuida = new System.Windows.Forms.Button();
            this.Guida = new System.Windows.Forms.TextBox();
            this.TabellaPercorsi = new System.Windows.Forms.DataGridView();
            this.CreaPercorsoGuidato = new System.Windows.Forms.Button();
            this.Percorso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TabellaGuide = new System.Windows.Forms.DataGridView();
            this.TabPage.SuspendLayout();
            this.Clienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBici)).BeginInit();
            this.Dipendenti.SuspendLayout();
            this.Tour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaAccessori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPercorsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaGuide)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPage
            // 
            this.TabPage.AccessibleName = "";
            this.TabPage.Controls.Add(this.Clienti);
            this.TabPage.Controls.Add(this.Dipendenti);
            this.TabPage.Controls.Add(this.Tour);
            this.TabPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabPage.Location = new System.Drawing.Point(154, 52);
            this.TabPage.Margin = new System.Windows.Forms.Padding(2);
            this.TabPage.Multiline = true;
            this.TabPage.Name = "TabPage";
            this.TabPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(574, 426);
            this.TabPage.TabIndex = 5;
            this.TabPage.Tag = "";
            // 
            // Clienti
            // 
            this.Clienti.Controls.Add(this.NoleggioBiciclette_Lista);
            this.Clienti.Controls.Add(this.label5);
            this.Clienti.Controls.Add(this.label4);
            this.Clienti.Controls.Add(this.AggiungiNoleggioButton);
            this.Clienti.Controls.Add(this.Bici);
            this.Clienti.Controls.Add(this.TabellaBici);
            this.Clienti.Controls.Add(this.NoleggiaBiciButton);
            this.Clienti.Location = new System.Drawing.Point(4, 22);
            this.Clienti.Margin = new System.Windows.Forms.Padding(2);
            this.Clienti.Name = "Clienti";
            this.Clienti.Padding = new System.Windows.Forms.Padding(2);
            this.Clienti.Size = new System.Drawing.Size(566, 400);
            this.Clienti.TabIndex = 0;
            this.Clienti.Text = "Noleggio Biciclette";
            this.Clienti.UseVisualStyleBackColor = true;
            // 
            // NoleggioBiciclette_Lista
            // 
            this.NoleggioBiciclette_Lista.HideSelection = false;
            this.NoleggioBiciclette_Lista.Location = new System.Drawing.Point(7, 140);
            this.NoleggioBiciclette_Lista.Name = "NoleggioBiciclette_Lista";
            this.NoleggioBiciclette_Lista.Size = new System.Drawing.Size(111, 214);
            this.NoleggioBiciclette_Lista.TabIndex = 17;
            this.NoleggioBiciclette_Lista.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Seleziona la bici:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lista bici noleggiate:";
            // 
            // AggiungiNoleggioButton
            // 
            this.AggiungiNoleggioButton.Location = new System.Drawing.Point(7, 66);
            this.AggiungiNoleggioButton.Margin = new System.Windows.Forms.Padding(2);
            this.AggiungiNoleggioButton.Name = "AggiungiNoleggioButton";
            this.AggiungiNoleggioButton.Size = new System.Drawing.Size(112, 32);
            this.AggiungiNoleggioButton.TabIndex = 12;
            this.AggiungiNoleggioButton.Text = "Aggiungi al Noleggio";
            this.AggiungiNoleggioButton.UseVisualStyleBackColor = true;
            this.AggiungiNoleggioButton.Click += new System.EventHandler(this.AggiungiNoleggioButton_Click);
            // 
            // Bici
            // 
            this.Bici.BackColor = System.Drawing.SystemColors.Window;
            this.Bici.Location = new System.Drawing.Point(7, 42);
            this.Bici.Margin = new System.Windows.Forms.Padding(2);
            this.Bici.Name = "Bici";
            this.Bici.Size = new System.Drawing.Size(111, 20);
            this.Bici.TabIndex = 11;
            this.Bici.Text = "Numero di Telaio";
            // 
            // TabellaBici
            // 
            this.TabellaBici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaBici.Location = new System.Drawing.Point(123, 5);
            this.TabellaBici.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaBici.Name = "TabellaBici";
            this.TabellaBici.ReadOnly = true;
            this.TabellaBici.RowHeadersWidth = 51;
            this.TabellaBici.RowTemplate.Height = 24;
            this.TabellaBici.Size = new System.Drawing.Size(439, 392);
            this.TabellaBici.TabIndex = 5;
            // 
            // NoleggiaBiciButton
            // 
            this.NoleggiaBiciButton.Location = new System.Drawing.Point(7, 359);
            this.NoleggiaBiciButton.Margin = new System.Windows.Forms.Padding(2);
            this.NoleggiaBiciButton.Name = "NoleggiaBiciButton";
            this.NoleggiaBiciButton.Size = new System.Drawing.Size(111, 32);
            this.NoleggiaBiciButton.TabIndex = 4;
            this.NoleggiaBiciButton.Text = "Noleggia Bici";
            this.NoleggiaBiciButton.UseVisualStyleBackColor = true;
            this.NoleggiaBiciButton.Click += new System.EventHandler(this.NoleggiaBiciButton_Click);
            // 
            // Dipendenti
            // 
            this.Dipendenti.Controls.Add(this.NoleggioAccessori_Lista);
            this.Dipendenti.Controls.Add(this.label6);
            this.Dipendenti.Controls.Add(this.label7);
            this.Dipendenti.Controls.Add(this.AggiungiNoleggio1);
            this.Dipendenti.Controls.Add(this.Accessorio);
            this.Dipendenti.Controls.Add(this.TabellaAccessori);
            this.Dipendenti.Controls.Add(this.NoleggiaAccessorio);
            this.Dipendenti.Location = new System.Drawing.Point(4, 22);
            this.Dipendenti.Margin = new System.Windows.Forms.Padding(2);
            this.Dipendenti.Name = "Dipendenti";
            this.Dipendenti.Padding = new System.Windows.Forms.Padding(2);
            this.Dipendenti.Size = new System.Drawing.Size(566, 400);
            this.Dipendenti.TabIndex = 7;
            this.Dipendenti.Text = "Noleggio Accessori";
            this.Dipendenti.UseVisualStyleBackColor = true;
            // 
            // Tour
            // 
            this.Tour.Controls.Add(this.TabellaGuide);
            this.Tour.Controls.Add(this.label10);
            this.Tour.Controls.Add(this.Percorso);
            this.Tour.Controls.Add(this.Guide_Lista);
            this.Tour.Controls.Add(this.label8);
            this.Tour.Controls.Add(this.label9);
            this.Tour.Controls.Add(this.AggiungiGuida);
            this.Tour.Controls.Add(this.Guida);
            this.Tour.Controls.Add(this.TabellaPercorsi);
            this.Tour.Controls.Add(this.CreaPercorsoGuidato);
            this.Tour.Location = new System.Drawing.Point(4, 22);
            this.Tour.Margin = new System.Windows.Forms.Padding(2);
            this.Tour.Name = "Tour";
            this.Tour.Padding = new System.Windows.Forms.Padding(2);
            this.Tour.Size = new System.Drawing.Size(566, 400);
            this.Tour.TabIndex = 8;
            this.Tour.Text = "Percorsi Guidati";
            this.Tour.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(56, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prezzo";
            // 
            // Pacchetto_Prezzo
            // 
            this.Pacchetto_Prezzo.BackColor = System.Drawing.SystemColors.Window;
            this.Pacchetto_Prezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Pacchetto_Prezzo.Location = new System.Drawing.Point(118, 16);
            this.Pacchetto_Prezzo.Name = "Pacchetto_Prezzo";
            this.Pacchetto_Prezzo.ReadOnly = true;
            this.Pacchetto_Prezzo.Size = new System.Drawing.Size(118, 24);
            this.Pacchetto_Prezzo.TabIndex = 7;
            // 
            // Pacchetto_Sconto
            // 
            this.Pacchetto_Sconto.BackColor = System.Drawing.SystemColors.Window;
            this.Pacchetto_Sconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Pacchetto_Sconto.Location = new System.Drawing.Point(350, 16);
            this.Pacchetto_Sconto.Name = "Pacchetto_Sconto";
            this.Pacchetto_Sconto.ReadOnly = true;
            this.Pacchetto_Sconto.Size = new System.Drawing.Size(118, 24);
            this.Pacchetto_Sconto.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(288, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sconto";
            // 
            // Servizio_DataFine
            // 
            this.Servizio_DataFine.Location = new System.Drawing.Point(11, 159);
            this.Servizio_DataFine.Margin = new System.Windows.Forms.Padding(2);
            this.Servizio_DataFine.Name = "Servizio_DataFine";
            this.Servizio_DataFine.Size = new System.Drawing.Size(134, 20);
            this.Servizio_DataFine.TabIndex = 12;
            this.Servizio_DataFine.Text = "Data Fine";
            this.Servizio_DataFine.Enter += new System.EventHandler(this.Servizio_DataFine_Enter);
            this.Servizio_DataFine.Leave += new System.EventHandler(this.Servizio_DataFine_Leave);
            // 
            // Servizio_DataInizio
            // 
            this.Servizio_DataInizio.Location = new System.Drawing.Point(11, 137);
            this.Servizio_DataInizio.Margin = new System.Windows.Forms.Padding(2);
            this.Servizio_DataInizio.Name = "Servizio_DataInizio";
            this.Servizio_DataInizio.Size = new System.Drawing.Size(134, 20);
            this.Servizio_DataInizio.TabIndex = 11;
            this.Servizio_DataInizio.Text = "Data Inizio";
            this.Servizio_DataInizio.Enter += new System.EventHandler(this.Servizio_DataInizio_Enter);
            this.Servizio_DataInizio.Leave += new System.EventHandler(this.Servizio_DataInizio_Leave);
            // 
            // Servizio_ID
            // 
            this.Servizio_ID.BackColor = System.Drawing.SystemColors.Window;
            this.Servizio_ID.Location = new System.Drawing.Point(11, 102);
            this.Servizio_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Servizio_ID.Name = "Servizio_ID";
            this.Servizio_ID.ReadOnly = true;
            this.Servizio_ID.Size = new System.Drawing.Size(134, 20);
            this.Servizio_ID.TabIndex = 10;
            this.Servizio_ID.Text = "ID Servizio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(41, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Info servizio";
            // 
            // AggiornaButton
            // 
            this.AggiornaButton.Location = new System.Drawing.Point(32, 202);
            this.AggiornaButton.Margin = new System.Windows.Forms.Padding(2);
            this.AggiornaButton.Name = "AggiornaButton";
            this.AggiornaButton.Size = new System.Drawing.Size(89, 32);
            this.AggiornaButton.TabIndex = 15;
            this.AggiornaButton.Text = "Aggiorna";
            this.AggiornaButton.UseVisualStyleBackColor = true;
            this.AggiornaButton.Enter += new System.EventHandler(this.AggiornaButton_Enter);
            // 
            // NoleggioAccessori_Lista
            // 
            this.NoleggioAccessori_Lista.HideSelection = false;
            this.NoleggioAccessori_Lista.Location = new System.Drawing.Point(7, 139);
            this.NoleggioAccessori_Lista.Name = "NoleggioAccessori_Lista";
            this.NoleggioAccessori_Lista.Size = new System.Drawing.Size(111, 214);
            this.NoleggioAccessori_Lista.TabIndex = 24;
            this.NoleggioAccessori_Lista.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Seleziona l\'accessorio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(7, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Lista accessori\r\nnoleggiati:";
            // 
            // AggiungiNoleggio1
            // 
            this.AggiungiNoleggio1.Location = new System.Drawing.Point(7, 65);
            this.AggiungiNoleggio1.Margin = new System.Windows.Forms.Padding(2);
            this.AggiungiNoleggio1.Name = "AggiungiNoleggio1";
            this.AggiungiNoleggio1.Size = new System.Drawing.Size(112, 32);
            this.AggiungiNoleggio1.TabIndex = 21;
            this.AggiungiNoleggio1.Text = "Aggiungi al Noleggio";
            this.AggiungiNoleggio1.UseVisualStyleBackColor = true;
            this.AggiungiNoleggio1.Click += new System.EventHandler(this.AggiungiNoleggio1_Click);
            // 
            // Accessorio
            // 
            this.Accessorio.BackColor = System.Drawing.SystemColors.Window;
            this.Accessorio.Location = new System.Drawing.Point(7, 41);
            this.Accessorio.Margin = new System.Windows.Forms.Padding(2);
            this.Accessorio.Name = "Accessorio";
            this.Accessorio.Size = new System.Drawing.Size(111, 20);
            this.Accessorio.TabIndex = 20;
            this.Accessorio.Text = "ID Accessorio";
            // 
            // TabellaAccessori
            // 
            this.TabellaAccessori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaAccessori.Location = new System.Drawing.Point(123, 4);
            this.TabellaAccessori.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaAccessori.Name = "TabellaAccessori";
            this.TabellaAccessori.ReadOnly = true;
            this.TabellaAccessori.RowHeadersWidth = 51;
            this.TabellaAccessori.RowTemplate.Height = 24;
            this.TabellaAccessori.Size = new System.Drawing.Size(439, 392);
            this.TabellaAccessori.TabIndex = 19;
            // 
            // NoleggiaAccessorio
            // 
            this.NoleggiaAccessorio.Location = new System.Drawing.Point(7, 357);
            this.NoleggiaAccessorio.Margin = new System.Windows.Forms.Padding(2);
            this.NoleggiaAccessorio.Name = "NoleggiaAccessorio";
            this.NoleggiaAccessorio.Size = new System.Drawing.Size(111, 38);
            this.NoleggiaAccessorio.TabIndex = 18;
            this.NoleggiaAccessorio.Text = "Noleggia Accessorio";
            this.NoleggiaAccessorio.UseVisualStyleBackColor = true;
            this.NoleggiaAccessorio.Click += new System.EventHandler(this.NoleggiaAccessorio_Click);
            // 
            // Guide_Lista
            // 
            this.Guide_Lista.HideSelection = false;
            this.Guide_Lista.Location = new System.Drawing.Point(6, 181);
            this.Guide_Lista.Name = "Guide_Lista";
            this.Guide_Lista.Size = new System.Drawing.Size(111, 172);
            this.Guide_Lista.TabIndex = 31;
            this.Guide_Lista.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(5, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Seleziona la guida:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(6, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Lista delle guide:";
            // 
            // AggiungiGuida
            // 
            this.AggiungiGuida.Location = new System.Drawing.Point(6, 109);
            this.AggiungiGuida.Margin = new System.Windows.Forms.Padding(2);
            this.AggiungiGuida.Name = "AggiungiGuida";
            this.AggiungiGuida.Size = new System.Drawing.Size(112, 32);
            this.AggiungiGuida.TabIndex = 28;
            this.AggiungiGuida.Text = "Aggiungi Guida";
            this.AggiungiGuida.UseVisualStyleBackColor = true;
            this.AggiungiGuida.Click += new System.EventHandler(this.AggiungiGuida_Click);
            // 
            // Guida
            // 
            this.Guida.BackColor = System.Drawing.SystemColors.Window;
            this.Guida.Location = new System.Drawing.Point(7, 85);
            this.Guida.Margin = new System.Windows.Forms.Padding(2);
            this.Guida.Name = "Guida";
            this.Guida.Size = new System.Drawing.Size(111, 20);
            this.Guida.TabIndex = 27;
            this.Guida.Text = "ID Accessorio";
            // 
            // TabellaPercorsi
            // 
            this.TabellaPercorsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaPercorsi.Location = new System.Drawing.Point(122, 4);
            this.TabellaPercorsi.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaPercorsi.Name = "TabellaPercorsi";
            this.TabellaPercorsi.ReadOnly = true;
            this.TabellaPercorsi.RowHeadersWidth = 51;
            this.TabellaPercorsi.RowTemplate.Height = 24;
            this.TabellaPercorsi.Size = new System.Drawing.Size(439, 174);
            this.TabellaPercorsi.TabIndex = 26;
            // 
            // CreaPercorsoGuidato
            // 
            this.CreaPercorsoGuidato.Location = new System.Drawing.Point(6, 357);
            this.CreaPercorsoGuidato.Margin = new System.Windows.Forms.Padding(2);
            this.CreaPercorsoGuidato.Name = "CreaPercorsoGuidato";
            this.CreaPercorsoGuidato.Size = new System.Drawing.Size(111, 38);
            this.CreaPercorsoGuidato.TabIndex = 25;
            this.CreaPercorsoGuidato.Text = "Crea Percorso Guidato";
            this.CreaPercorsoGuidato.UseVisualStyleBackColor = true;
            this.CreaPercorsoGuidato.Click += new System.EventHandler(this.CreaPercorsoGuidato_Click);
            // 
            // Percorso
            // 
            this.Percorso.BackColor = System.Drawing.SystemColors.Window;
            this.Percorso.Location = new System.Drawing.Point(7, 28);
            this.Percorso.Margin = new System.Windows.Forms.Padding(2);
            this.Percorso.Name = "Percorso";
            this.Percorso.Size = new System.Drawing.Size(111, 20);
            this.Percorso.TabIndex = 32;
            this.Percorso.Text = "ID Percorso";
            this.Percorso.Enter += new System.EventHandler(this.Percorso_Enter);
            this.Percorso.Leave += new System.EventHandler(this.Percorso_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(6, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Seleziona il percorso:";
            // 
            // TabellaGuide
            // 
            this.TabellaGuide.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaGuide.Location = new System.Drawing.Point(122, 192);
            this.TabellaGuide.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaGuide.Name = "TabellaGuide";
            this.TabellaGuide.ReadOnly = true;
            this.TabellaGuide.RowHeadersWidth = 51;
            this.TabellaGuide.RowTemplate.Height = 24;
            this.TabellaGuide.Size = new System.Drawing.Size(439, 203);
            this.TabellaGuide.TabIndex = 34;
            // 
            // UserServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 480);
            this.Controls.Add(this.AggiornaButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Servizio_DataFine);
            this.Controls.Add(this.Servizio_DataInizio);
            this.Controls.Add(this.Servizio_ID);
            this.Controls.Add(this.Pacchetto_Sconto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pacchetto_Prezzo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabPage);
            this.Name = "UserServices";
            this.Text = "UserServices";
            this.Load += new System.EventHandler(this.UserServices_Load);
            this.TabPage.ResumeLayout(false);
            this.Clienti.ResumeLayout(false);
            this.Clienti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBici)).EndInit();
            this.Dipendenti.ResumeLayout(false);
            this.Dipendenti.PerformLayout();
            this.Tour.ResumeLayout(false);
            this.Tour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaAccessori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPercorsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaGuide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage Clienti;
        private System.Windows.Forms.DataGridView TabellaBici;
        private System.Windows.Forms.Button NoleggiaBiciButton;
        private System.Windows.Forms.TabPage Dipendenti;
        private System.Windows.Forms.TabPage Tour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pacchetto_Prezzo;
        private System.Windows.Forms.TextBox Pacchetto_Sconto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Servizio_DataFine;
        private System.Windows.Forms.TextBox Servizio_DataInizio;
        private System.Windows.Forms.TextBox Servizio_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AggiungiNoleggioButton;
        private System.Windows.Forms.TextBox Bici;
        private System.Windows.Forms.Button AggiornaButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView NoleggioBiciclette_Lista;
        private System.Windows.Forms.ListView NoleggioAccessori_Lista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AggiungiNoleggio1;
        private System.Windows.Forms.TextBox Accessorio;
        private System.Windows.Forms.DataGridView TabellaAccessori;
        private System.Windows.Forms.Button NoleggiaAccessorio;
        private System.Windows.Forms.DataGridView TabellaGuide;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Percorso;
        private System.Windows.Forms.ListView Guide_Lista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AggiungiGuida;
        private System.Windows.Forms.TextBox Guida;
        private System.Windows.Forms.DataGridView TabellaPercorsi;
        private System.Windows.Forms.Button CreaPercorsoGuidato;
    }
}