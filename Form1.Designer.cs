
namespace SparaLasaKontakt_ovn4_2
{
    partial class frmEnKontakt
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
            this.lblFörnamn = new System.Windows.Forms.Label();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.btnÖppna = new System.Windows.Forms.Button();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.lblEfternamn = new System.Windows.Forms.Label();
            this.tbxEpost = new System.Windows.Forms.TextBox();
            this.lblEpost = new System.Windows.Forms.Label();
            this.tbxTelefonnummer = new System.Windows.Forms.TextBox();
            this.lblTelefonnummer = new System.Windows.Forms.Label();
            this.btnSparaSom = new System.Windows.Forms.Button();
            this.dlgSparaFil = new System.Windows.Forms.SaveFileDialog();
            this.dlgÖppnaFil = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblFörnamn
            // 
            this.lblFörnamn.AutoSize = true;
            this.lblFörnamn.Location = new System.Drawing.Point(25, 24);
            this.lblFörnamn.Name = "lblFörnamn";
            this.lblFörnamn.Size = new System.Drawing.Size(64, 17);
            this.lblFörnamn.TabIndex = 0;
            this.lblFörnamn.Text = "Förnamn";
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(138, 24);
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(221, 22);
            this.tbxFörnamn.TabIndex = 1;
            // 
            // btnÖppna
            // 
            this.btnÖppna.Location = new System.Drawing.Point(384, 99);
            this.btnÖppna.Name = "btnÖppna";
            this.btnÖppna.Size = new System.Drawing.Size(102, 30);
            this.btnÖppna.TabIndex = 2;
            this.btnÖppna.Text = "Öppna";
            this.btnÖppna.UseVisualStyleBackColor = true;
            this.btnÖppna.Click += new System.EventHandler(this.btnÖppna_Click);
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(138, 67);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(221, 22);
            this.tbxEfternamn.TabIndex = 4;
            // 
            // lblEfternamn
            // 
            this.lblEfternamn.AutoSize = true;
            this.lblEfternamn.Location = new System.Drawing.Point(25, 67);
            this.lblEfternamn.Name = "lblEfternamn";
            this.lblEfternamn.Size = new System.Drawing.Size(73, 17);
            this.lblEfternamn.TabIndex = 3;
            this.lblEfternamn.Text = "Efternamn";
            // 
            // tbxEpost
            // 
            this.tbxEpost.Location = new System.Drawing.Point(138, 106);
            this.tbxEpost.Name = "tbxEpost";
            this.tbxEpost.Size = new System.Drawing.Size(221, 22);
            this.tbxEpost.TabIndex = 6;
            // 
            // lblEpost
            // 
            this.lblEpost.AutoSize = true;
            this.lblEpost.Location = new System.Drawing.Point(25, 106);
            this.lblEpost.Name = "lblEpost";
            this.lblEpost.Size = new System.Drawing.Size(49, 17);
            this.lblEpost.TabIndex = 5;
            this.lblEpost.Text = "E-post";
            // 
            // tbxTelefonnummer
            // 
            this.tbxTelefonnummer.Location = new System.Drawing.Point(138, 150);
            this.tbxTelefonnummer.Name = "tbxTelefonnummer";
            this.tbxTelefonnummer.Size = new System.Drawing.Size(221, 22);
            this.tbxTelefonnummer.TabIndex = 8;
            // 
            // lblTelefonnummer
            // 
            this.lblTelefonnummer.AutoSize = true;
            this.lblTelefonnummer.Location = new System.Drawing.Point(25, 150);
            this.lblTelefonnummer.Name = "lblTelefonnummer";
            this.lblTelefonnummer.Size = new System.Drawing.Size(107, 17);
            this.lblTelefonnummer.TabIndex = 7;
            this.lblTelefonnummer.Text = "Telefonnummer";
            // 
            // btnSparaSom
            // 
            this.btnSparaSom.Location = new System.Drawing.Point(384, 143);
            this.btnSparaSom.Name = "btnSparaSom";
            this.btnSparaSom.Size = new System.Drawing.Size(102, 30);
            this.btnSparaSom.TabIndex = 9;
            this.btnSparaSom.Text = "Spara som...";
            this.btnSparaSom.UseVisualStyleBackColor = true;
            this.btnSparaSom.Click += new System.EventHandler(this.btnSparaSom_Click);
            // 
            // frmEnKontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 197);
            this.Controls.Add(this.btnSparaSom);
            this.Controls.Add(this.tbxTelefonnummer);
            this.Controls.Add(this.lblTelefonnummer);
            this.Controls.Add(this.tbxEpost);
            this.Controls.Add(this.lblEpost);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.lblEfternamn);
            this.Controls.Add(this.btnÖppna);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.lblFörnamn);
            this.Name = "frmEnKontakt";
            this.Text = "En kontakt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFörnamn;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.Button btnÖppna;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.Label lblEfternamn;
        private System.Windows.Forms.TextBox tbxEpost;
        private System.Windows.Forms.Label lblEpost;
        private System.Windows.Forms.TextBox tbxTelefonnummer;
        private System.Windows.Forms.Label lblTelefonnummer;
        private System.Windows.Forms.Button btnSparaSom;
        private System.Windows.Forms.SaveFileDialog dlgSparaFil;
        private System.Windows.Forms.OpenFileDialog dlgÖppnaFil;
    }
}

