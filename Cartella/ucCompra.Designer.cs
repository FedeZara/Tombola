namespace Cartella
{
    partial class ucCompra
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.lblVerifica = new System.Windows.Forms.Label();
            this.pnlCartelle = new System.Windows.Forms.Panel();
            this.Pannello1 = new System.Windows.Forms.Panel();
            this.pbCartelle = new System.Windows.Forms.PictureBox();
            this.lblAvviso = new System.Windows.Forms.Label();
            this.pnlOpzioni = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRimanenti = new System.Windows.Forms.Label();
            this.lblSpesi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSaldoIniziale = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnRimuovi = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.pnlUsername.SuspendLayout();
            this.pnlCartelle.SuspendLayout();
            this.Pannello1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartelle)).BeginInit();
            this.pnlOpzioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.White;
            this.tbUsername.Location = new System.Drawing.Point(15, 29);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(226, 26);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Text = "Computer 1";
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsername.Location = new System.Drawing.Point(21, 10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.LightCyan;
            this.pnlUsername.Controls.Add(this.lblVerifica);
            this.pnlUsername.Controls.Add(this.lblUsername);
            this.pnlUsername.Controls.Add(this.tbUsername);
            this.pnlUsername.Location = new System.Drawing.Point(19, 14);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(258, 89);
            this.pnlUsername.TabIndex = 2;
            // 
            // lblVerifica
            // 
            this.lblVerifica.AutoSize = true;
            this.lblVerifica.ForeColor = System.Drawing.Color.Green;
            this.lblVerifica.Location = new System.Drawing.Point(21, 58);
            this.lblVerifica.Name = "lblVerifica";
            this.lblVerifica.Size = new System.Drawing.Size(36, 18);
            this.lblVerifica.TabIndex = 2;
            this.lblVerifica.Text = "OK!";
            // 
            // pnlCartelle
            // 
            this.pnlCartelle.BackColor = System.Drawing.Color.LightCyan;
            this.pnlCartelle.Controls.Add(this.Pannello1);
            this.pnlCartelle.Controls.Add(this.lblAvviso);
            this.pnlCartelle.Location = new System.Drawing.Point(19, 109);
            this.pnlCartelle.Name = "pnlCartelle";
            this.pnlCartelle.Size = new System.Drawing.Size(381, 290);
            this.pnlCartelle.TabIndex = 3;
            // 
            // Pannello1
            // 
            this.Pannello1.Controls.Add(this.pbCartelle);
            this.Pannello1.Location = new System.Drawing.Point(15, 18);
            this.Pannello1.Name = "Pannello1";
            this.Pannello1.Size = new System.Drawing.Size(351, 195);
            this.Pannello1.TabIndex = 1;
            // 
            // pbCartelle
            // 
            this.pbCartelle.BackColor = System.Drawing.Color.White;
            this.pbCartelle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCartelle.Image = global::Cartella.Properties.Resources._11;
            this.pbCartelle.Location = new System.Drawing.Point(0, 0);
            this.pbCartelle.Name = "pbCartelle";
            this.pbCartelle.Size = new System.Drawing.Size(351, 195);
            this.pbCartelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCartelle.TabIndex = 0;
            this.pbCartelle.TabStop = false;
            // 
            // lblAvviso
            // 
            this.lblAvviso.AutoSize = true;
            this.lblAvviso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAvviso.Location = new System.Drawing.Point(21, 243);
            this.lblAvviso.Name = "lblAvviso";
            this.lblAvviso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAvviso.Size = new System.Drawing.Size(238, 32);
            this.lblAvviso.TabIndex = 0;
            this.lblAvviso.Text = "ATTENZIONE: le schede mostrate non \r\nsono quelle che verranno ricevute!";
            // 
            // pnlOpzioni
            // 
            this.pnlOpzioni.BackColor = System.Drawing.Color.LightCyan;
            this.pnlOpzioni.Controls.Add(this.label1);
            this.pnlOpzioni.Controls.Add(this.lblRimanenti);
            this.pnlOpzioni.Controls.Add(this.lblSpesi);
            this.pnlOpzioni.Controls.Add(this.pictureBox1);
            this.pnlOpzioni.Controls.Add(this.lblSaldoIniziale);
            this.pnlOpzioni.Controls.Add(this.btnConferma);
            this.pnlOpzioni.Controls.Add(this.btnRimuovi);
            this.pnlOpzioni.Controls.Add(this.btnAggiungi);
            this.pnlOpzioni.Location = new System.Drawing.Point(408, 109);
            this.pnlOpzioni.Name = "pnlOpzioni";
            this.pnlOpzioni.Size = new System.Drawing.Size(155, 290);
            this.pnlOpzioni.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rimanenti";
            // 
            // lblRimanenti
            // 
            this.lblRimanenti.AutoSize = true;
            this.lblRimanenti.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRimanenti.Location = new System.Drawing.Point(58, 167);
            this.lblRimanenti.Name = "lblRimanenti";
            this.lblRimanenti.Size = new System.Drawing.Size(99, 25);
            this.lblRimanenti.TabIndex = 4;
            this.lblRimanenti.Text = "9.00€      ";
            this.lblRimanenti.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSpesi
            // 
            this.lblSpesi.AutoSize = true;
            this.lblSpesi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSpesi.Location = new System.Drawing.Point(65, 130);
            this.lblSpesi.Name = "lblSpesi";
            this.lblSpesi.Size = new System.Drawing.Size(76, 18);
            this.lblSpesi.TabIndex = 2;
            this.lblSpesi.Text = "1.00€    =";
            this.lblSpesi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Cartella.Properties.Resources.horizontal_line;
            this.pictureBox1.Location = new System.Drawing.Point(43, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblSaldoIniziale
            // 
            this.lblSaldoIniziale.AutoSize = true;
            this.lblSaldoIniziale.Location = new System.Drawing.Point(58, 102);
            this.lblSaldoIniziale.Name = "lblSaldoIniziale";
            this.lblSaldoIniziale.Size = new System.Drawing.Size(83, 18);
            this.lblSaldoIniziale.TabIndex = 2;
            this.lblSaldoIniziale.Text = "10.00€    -";
            this.lblSaldoIniziale.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.DarkBlue;
            this.btnConferma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConferma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferma.ForeColor = System.Drawing.Color.White;
            this.btnConferma.Location = new System.Drawing.Point(17, 227);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(123, 44);
            this.btnConferma.TabIndex = 1;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // btnRimuovi
            // 
            this.btnRimuovi.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRimuovi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRimuovi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRimuovi.ForeColor = System.Drawing.Color.White;
            this.btnRimuovi.Location = new System.Drawing.Point(38, 54);
            this.btnRimuovi.Name = "btnRimuovi";
            this.btnRimuovi.Size = new System.Drawing.Size(102, 30);
            this.btnRimuovi.TabIndex = 0;
            this.btnRimuovi.Text = "Rimuovi";
            this.btnRimuovi.UseVisualStyleBackColor = false;
            this.btnRimuovi.Click += new System.EventHandler(this.btnRimuovi_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAggiungi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.ForeColor = System.Drawing.Color.White;
            this.btnAggiungi.Location = new System.Drawing.Point(38, 18);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(102, 30);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.tbSaldo);
            this.panel1.Controls.Add(this.lblSaldo);
            this.panel1.Location = new System.Drawing.Point(300, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 89);
            this.panel1.TabIndex = 5;
            // 
            // tbSaldo
            // 
            this.tbSaldo.BackColor = System.Drawing.Color.White;
            this.tbSaldo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaldo.Location = new System.Drawing.Point(73, 18);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.ReadOnly = true;
            this.tbSaldo.Size = new System.Drawing.Size(169, 44);
            this.tbSaldo.TabIndex = 1;
            this.tbSaldo.Text = "10.00€";
            this.tbSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(16, 37);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(51, 18);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo:";
            // 
            // ucCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlOpzioni);
            this.Controls.Add(this.pnlCartelle);
            this.Controls.Add(this.pnlUsername);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucCompra";
            this.Size = new System.Drawing.Size(577, 409);
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlCartelle.ResumeLayout(false);
            this.pnlCartelle.PerformLayout();
            this.Pannello1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCartelle)).EndInit();
            this.pnlOpzioni.ResumeLayout(false);
            this.pnlOpzioni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlCartelle;
        private System.Windows.Forms.Panel pnlOpzioni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSpesi;
        private System.Windows.Forms.Label lblSaldoIniziale;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRimanenti;
        private System.Windows.Forms.Label lblVerifica;
        private System.Windows.Forms.Label lblAvviso;
        private System.Windows.Forms.Button btnRimuovi;
        private System.Windows.Forms.Panel Pannello1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCartelle;
    }
}
