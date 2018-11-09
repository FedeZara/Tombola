namespace Tabellone
{
    partial class formFinePartita
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
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnNuovaPartita = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.DarkBlue;
            this.btnConferma.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnConferma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConferma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferma.ForeColor = System.Drawing.Color.White;
            this.btnConferma.Location = new System.Drawing.Point(227, 88);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(159, 44);
            this.btnConferma.TabIndex = 2;
            this.btnConferma.Text = "Nuova lobby";
            this.btnConferma.UseVisualStyleBackColor = false;
            // 
            // btnNuovaPartita
            // 
            this.btnNuovaPartita.BackColor = System.Drawing.Color.DarkBlue;
            this.btnNuovaPartita.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnNuovaPartita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuovaPartita.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuovaPartita.ForeColor = System.Drawing.Color.White;
            this.btnNuovaPartita.Location = new System.Drawing.Point(26, 88);
            this.btnNuovaPartita.Name = "btnNuovaPartita";
            this.btnNuovaPartita.Size = new System.Drawing.Size(159, 44);
            this.btnNuovaPartita.TabIndex = 2;
            this.btnNuovaPartita.Text = "Nuova partita";
            this.btnNuovaPartita.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnConferma);
            this.panel1.Controls.Add(this.btnNuovaPartita);
            this.panel1.Location = new System.Drawing.Point(22, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 160);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "PARTITA CONCLUSA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formFinePartita
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(462, 219);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formFinePartita";
            this.ShowIcon = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnNuovaPartita;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}