namespace Cartella
{
    partial class ucCartella
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
            this.tlpCartella = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSfondo = new System.Windows.Forms.Panel();
            this.pbScritta = new System.Windows.Forms.PictureBox();
            this.pnlSfondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScritta)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpCartella
            // 
            this.tlpCartella.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(84)))));
            this.tlpCartella.ColumnCount = 9;
            this.tlpCartella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCartella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCartella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCartella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCartella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCartella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCartella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCartella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCartella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCartella.Location = new System.Drawing.Point(10, 110);
            this.tlpCartella.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCartella.Name = "tlpCartella";
            this.tlpCartella.RowCount = 3;
            this.tlpCartella.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCartella.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCartella.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCartella.Size = new System.Drawing.Size(900, 300);
            this.tlpCartella.TabIndex = 0;
            // 
            // pnlSfondo
            // 
            this.pnlSfondo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSfondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(84)))));
            this.pnlSfondo.Controls.Add(this.pbScritta);
            this.pnlSfondo.Location = new System.Drawing.Point(4, 4);
            this.pnlSfondo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSfondo.Name = "pnlSfondo";
            this.pnlSfondo.Size = new System.Drawing.Size(913, 413);
            this.pnlSfondo.TabIndex = 1;
            // 
            // pbScritta
            // 
            this.pbScritta.Image = global::Cartella.Properties.Resources.Sfondo;
            this.pbScritta.Location = new System.Drawing.Point(16, -33);
            this.pbScritta.Name = "pbScritta";
            this.pbScritta.Size = new System.Drawing.Size(489, 177);
            this.pbScritta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScritta.TabIndex = 0;
            this.pbScritta.TabStop = false;
            // 
            // ucCartella
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpCartella);
            this.Controls.Add(this.pnlSfondo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucCartella";
            this.Size = new System.Drawing.Size(920, 420);
            this.pnlSfondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbScritta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCartella;
        private System.Windows.Forms.Panel pnlSfondo;
        private System.Windows.Forms.PictureBox pbScritta;
    }
}
