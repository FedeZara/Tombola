namespace Cartella
{
    partial class formSchermataPrincipale
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSchermataPrincipale));
            this.pnlRiquadroCartelle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlInformazioni = new System.Windows.Forms.Panel();
            this.pnlStorico = new System.Windows.Forms.Panel();
            this.lblStorico = new System.Windows.Forms.Label();
            this.tlpStorico = new System.Windows.Forms.TableLayoutPanel();
            this.lblPremio0 = new System.Windows.Forms.Label();
            this.lblPremio1 = new System.Windows.Forms.Label();
            this.lblPremio2 = new System.Windows.Forms.Label();
            this.lblPremio3 = new System.Windows.Forms.Label();
            this.lblVincitori0 = new System.Windows.Forms.Label();
            this.lblVincitori1 = new System.Windows.Forms.Label();
            this.lblVincitori2 = new System.Windows.Forms.Label();
            this.lblVincitori3 = new System.Windows.Forms.Label();
            this.lblPremio4 = new System.Windows.Forms.Label();
            this.lblPremio5 = new System.Windows.Forms.Label();
            this.lblVincitori4 = new System.Windows.Forms.Label();
            this.lblVincitori5 = new System.Windows.Forms.Label();
            this.pnlNumero = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblConto = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlInformazioni.SuspendLayout();
            this.pnlStorico.SuspendLayout();
            this.tlpStorico.SuspendLayout();
            this.pnlNumero.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRiquadroCartelle
            // 
            this.pnlRiquadroCartelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlRiquadroCartelle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRiquadroCartelle.Location = new System.Drawing.Point(227, 101);
            this.pnlRiquadroCartelle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRiquadroCartelle.Name = "pnlRiquadroCartelle";
            this.pnlRiquadroCartelle.Size = new System.Drawing.Size(1037, 581);
            this.pnlRiquadroCartelle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-2, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Il numero attuale è";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Georgia", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 174);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInformazioni
            // 
            this.pnlInformazioni.BackColor = System.Drawing.Color.LightBlue;
            this.pnlInformazioni.Controls.Add(this.pnlStorico);
            this.pnlInformazioni.Controls.Add(this.pnlNumero);
            this.pnlInformazioni.Location = new System.Drawing.Point(0, 101);
            this.pnlInformazioni.Name = "pnlInformazioni";
            this.pnlInformazioni.Size = new System.Drawing.Size(234, 581);
            this.pnlInformazioni.TabIndex = 3;
            // 
            // pnlStorico
            // 
            this.pnlStorico.BackColor = System.Drawing.Color.White;
            this.pnlStorico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStorico.Controls.Add(this.lblStorico);
            this.pnlStorico.Controls.Add(this.tlpStorico);
            this.pnlStorico.Location = new System.Drawing.Point(3, 228);
            this.pnlStorico.Name = "pnlStorico";
            this.pnlStorico.Size = new System.Drawing.Size(221, 340);
            this.pnlStorico.TabIndex = 3;
            // 
            // lblStorico
            // 
            this.lblStorico.Font = new System.Drawing.Font("Georgia", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lblStorico.Location = new System.Drawing.Point(4, 10);
            this.lblStorico.Name = "lblStorico";
            this.lblStorico.Size = new System.Drawing.Size(204, 42);
            this.lblStorico.TabIndex = 1;
            this.lblStorico.Text = "Storico premi";
            this.lblStorico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpStorico
            // 
            this.tlpStorico.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpStorico.ColumnCount = 2;
            this.tlpStorico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStorico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStorico.Controls.Add(this.lblPremio0, 0, 0);
            this.tlpStorico.Controls.Add(this.lblPremio1, 0, 1);
            this.tlpStorico.Controls.Add(this.lblPremio2, 0, 2);
            this.tlpStorico.Controls.Add(this.lblPremio3, 0, 3);
            this.tlpStorico.Controls.Add(this.lblVincitori0, 1, 0);
            this.tlpStorico.Controls.Add(this.lblVincitori1, 1, 1);
            this.tlpStorico.Controls.Add(this.lblVincitori2, 1, 2);
            this.tlpStorico.Controls.Add(this.lblVincitori3, 1, 3);
            this.tlpStorico.Controls.Add(this.lblPremio4, 0, 4);
            this.tlpStorico.Controls.Add(this.lblPremio5, 0, 5);
            this.tlpStorico.Controls.Add(this.lblVincitori4, 1, 4);
            this.tlpStorico.Controls.Add(this.lblVincitori5, 1, 5);
            this.tlpStorico.Location = new System.Drawing.Point(4, 55);
            this.tlpStorico.Name = "tlpStorico";
            this.tlpStorico.RowCount = 6;
            this.tlpStorico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpStorico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpStorico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpStorico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpStorico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpStorico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpStorico.Size = new System.Drawing.Size(207, 278);
            this.tlpStorico.TabIndex = 0;
            // 
            // lblPremio0
            // 
            this.lblPremio0.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremio0.Location = new System.Drawing.Point(5, 2);
            this.lblPremio0.Name = "lblPremio0";
            this.lblPremio0.Size = new System.Drawing.Size(94, 43);
            this.lblPremio0.TabIndex = 0;
            this.lblPremio0.Text = "Ambo";
            this.lblPremio0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPremio1
            // 
            this.lblPremio1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremio1.Location = new System.Drawing.Point(5, 47);
            this.lblPremio1.Name = "lblPremio1";
            this.lblPremio1.Size = new System.Drawing.Size(94, 43);
            this.lblPremio1.TabIndex = 0;
            this.lblPremio1.Text = "Terna";
            this.lblPremio1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPremio2
            // 
            this.lblPremio2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremio2.Location = new System.Drawing.Point(5, 92);
            this.lblPremio2.Name = "lblPremio2";
            this.lblPremio2.Size = new System.Drawing.Size(94, 43);
            this.lblPremio2.TabIndex = 0;
            this.lblPremio2.Text = "Quaterna";
            this.lblPremio2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPremio3
            // 
            this.lblPremio3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremio3.Location = new System.Drawing.Point(5, 137);
            this.lblPremio3.Name = "lblPremio3";
            this.lblPremio3.Size = new System.Drawing.Size(94, 43);
            this.lblPremio3.TabIndex = 0;
            this.lblPremio3.Text = "Cinquina";
            this.lblPremio3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVincitori0
            // 
            this.lblVincitori0.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVincitori0.Location = new System.Drawing.Point(107, 2);
            this.lblVincitori0.Name = "lblVincitori0";
            this.lblVincitori0.Size = new System.Drawing.Size(95, 43);
            this.lblVincitori0.TabIndex = 0;
            this.lblVincitori0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVincitori1
            // 
            this.lblVincitori1.Font = new System.Drawing.Font("Georgia", 9F);
            this.lblVincitori1.Location = new System.Drawing.Point(107, 47);
            this.lblVincitori1.Name = "lblVincitori1";
            this.lblVincitori1.Size = new System.Drawing.Size(95, 43);
            this.lblVincitori1.TabIndex = 0;
            this.lblVincitori1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVincitori2
            // 
            this.lblVincitori2.Font = new System.Drawing.Font("Georgia", 9F);
            this.lblVincitori2.Location = new System.Drawing.Point(107, 92);
            this.lblVincitori2.Name = "lblVincitori2";
            this.lblVincitori2.Size = new System.Drawing.Size(95, 43);
            this.lblVincitori2.TabIndex = 0;
            this.lblVincitori2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVincitori3
            // 
            this.lblVincitori3.Font = new System.Drawing.Font("Georgia", 9F);
            this.lblVincitori3.Location = new System.Drawing.Point(107, 137);
            this.lblVincitori3.Name = "lblVincitori3";
            this.lblVincitori3.Size = new System.Drawing.Size(95, 43);
            this.lblVincitori3.TabIndex = 0;
            this.lblVincitori3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPremio4
            // 
            this.lblPremio4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremio4.Location = new System.Drawing.Point(5, 182);
            this.lblPremio4.Name = "lblPremio4";
            this.lblPremio4.Size = new System.Drawing.Size(94, 43);
            this.lblPremio4.TabIndex = 0;
            this.lblPremio4.Text = "Tombola";
            this.lblPremio4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPremio5
            // 
            this.lblPremio5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremio5.Location = new System.Drawing.Point(2, 227);
            this.lblPremio5.Margin = new System.Windows.Forms.Padding(0);
            this.lblPremio5.Name = "lblPremio5";
            this.lblPremio5.Size = new System.Drawing.Size(100, 49);
            this.lblPremio5.TabIndex = 0;
            this.lblPremio5.Text = "Tombolino";
            this.lblPremio5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVincitori4
            // 
            this.lblVincitori4.Font = new System.Drawing.Font("Georgia", 9F);
            this.lblVincitori4.Location = new System.Drawing.Point(107, 182);
            this.lblVincitori4.Name = "lblVincitori4";
            this.lblVincitori4.Size = new System.Drawing.Size(95, 43);
            this.lblVincitori4.TabIndex = 0;
            this.lblVincitori4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVincitori5
            // 
            this.lblVincitori5.Font = new System.Drawing.Font("Georgia", 9F);
            this.lblVincitori5.Location = new System.Drawing.Point(107, 227);
            this.lblVincitori5.Name = "lblVincitori5";
            this.lblVincitori5.Size = new System.Drawing.Size(95, 49);
            this.lblVincitori5.TabIndex = 0;
            this.lblVincitori5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNumero
            // 
            this.pnlNumero.BackColor = System.Drawing.Color.LightCyan;
            this.pnlNumero.Controls.Add(this.label1);
            this.pnlNumero.Controls.Add(this.label2);
            this.pnlNumero.Location = new System.Drawing.Point(12, 19);
            this.pnlNumero.Name = "pnlNumero";
            this.pnlNumero.Size = new System.Drawing.Size(204, 189);
            this.pnlNumero.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 103);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlUsername);
            this.panel1.Location = new System.Drawing.Point(583, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 97);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.lblConto);
            this.panel3.Controls.Add(this.lblSaldo);
            this.panel3.Location = new System.Drawing.Point(333, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 89);
            this.panel3.TabIndex = 7;
            // 
            // lblConto
            // 
            this.lblConto.AccessibleDescription = "";
            this.lblConto.BackColor = System.Drawing.Color.White;
            this.lblConto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConto.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lblConto.Location = new System.Drawing.Point(107, 19);
            this.lblConto.Name = "lblConto";
            this.lblConto.Size = new System.Drawing.Size(174, 60);
            this.lblConto.TabIndex = 1;
            this.lblConto.Text = "10.00€";
            this.lblConto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(21, 37);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(80, 29);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo:";
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.LightCyan;
            this.pnlUsername.Controls.Add(this.lblNome);
            this.pnlUsername.Controls.Add(this.lblUsername);
            this.pnlUsername.Location = new System.Drawing.Point(52, 4);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(258, 89);
            this.pnlUsername.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNome.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lblNome.Location = new System.Drawing.Point(24, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(211, 53);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Computer 1";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cartella.Properties.Resources.Sfondo;
            this.pictureBox1.Location = new System.Drawing.Point(-47, -88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // formSchermataPrincipale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlRiquadroCartelle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlInformazioni);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formSchermataPrincipale";
            this.Text = "TOMBOLA - Cartelle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSchermataPrincipale_FormClosing);
            this.Shown += new System.EventHandler(this.formSchermataPrincipale_Shown);
            this.pnlInformazioni.ResumeLayout(false);
            this.pnlStorico.ResumeLayout(false);
            this.tlpStorico.ResumeLayout(false);
            this.pnlNumero.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlRiquadroCartelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInformazioni;
        private System.Windows.Forms.Panel pnlNumero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblConto;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlStorico;
        private System.Windows.Forms.Label lblStorico;
        private System.Windows.Forms.TableLayoutPanel tlpStorico;
        private System.Windows.Forms.Label lblPremio0;
        private System.Windows.Forms.Label lblPremio1;
        private System.Windows.Forms.Label lblPremio2;
        private System.Windows.Forms.Label lblPremio3;
        private System.Windows.Forms.Label lblVincitori0;
        private System.Windows.Forms.Label lblVincitori1;
        private System.Windows.Forms.Label lblVincitori2;
        private System.Windows.Forms.Label lblVincitori3;
        private System.Windows.Forms.Label lblPremio4;
        private System.Windows.Forms.Label lblPremio5;
        private System.Windows.Forms.Label lblVincitori4;
        private System.Windows.Forms.Label lblVincitori5;
    }
}

