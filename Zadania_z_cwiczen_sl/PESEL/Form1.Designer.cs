namespace PESEL
{
    partial class PeselWalidator
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
            this.tbPesel = new System.Windows.Forms.TextBox();
            this.labelPodajNrPesel = new System.Windows.Forms.Label();
            this.labelDataUrodzenia = new System.Windows.Forms.Label();
            this.labelPlec = new System.Windows.Forms.Label();
            this.labelSprwadzPesel = new System.Windows.Forms.Label();
            this.bSprawdzPesel = new System.Windows.Forms.Button();
            this.bWyczyscFormularz = new System.Windows.Forms.Button();
            this.tbDataUrodzenia = new System.Windows.Forms.TextBox();
            this.tbPlec = new System.Windows.Forms.TextBox();
            this.tbSprawdzPesel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPesel
            // 
            this.tbPesel.Location = new System.Drawing.Point(18, 33);
            this.tbPesel.Name = "tbPesel";
            this.tbPesel.Size = new System.Drawing.Size(232, 20);
            this.tbPesel.TabIndex = 0;
            // 
            // labelPodajNrPesel
            // 
            this.labelPodajNrPesel.AutoSize = true;
            this.labelPodajNrPesel.Location = new System.Drawing.Point(15, 17);
            this.labelPodajNrPesel.Name = "labelPodajNrPesel";
            this.labelPodajNrPesel.Size = new System.Drawing.Size(75, 13);
            this.labelPodajNrPesel.TabIndex = 1;
            this.labelPodajNrPesel.Text = "Podaj nr Pesel";
            // 
            // labelDataUrodzenia
            // 
            this.labelDataUrodzenia.AutoSize = true;
            this.labelDataUrodzenia.Location = new System.Drawing.Point(9, 133);
            this.labelDataUrodzenia.Name = "labelDataUrodzenia";
            this.labelDataUrodzenia.Size = new System.Drawing.Size(79, 13);
            this.labelDataUrodzenia.TabIndex = 2;
            this.labelDataUrodzenia.Text = "Data urodzenia";
            // 
            // labelPlec
            // 
            this.labelPlec.AutoSize = true;
            this.labelPlec.Location = new System.Drawing.Point(9, 185);
            this.labelPlec.Name = "labelPlec";
            this.labelPlec.Size = new System.Drawing.Size(28, 13);
            this.labelPlec.TabIndex = 3;
            this.labelPlec.Text = "Plec";
            // 
            // labelSprwadzPesel
            // 
            this.labelSprwadzPesel.AutoSize = true;
            this.labelSprwadzPesel.Location = new System.Drawing.Point(9, 234);
            this.labelSprwadzPesel.Name = "labelSprwadzPesel";
            this.labelSprwadzPesel.Size = new System.Drawing.Size(120, 13);
            this.labelSprwadzPesel.TabIndex = 4;
            this.labelSprwadzPesel.Text = "Czy pesel jest poprawny";
            // 
            // bSprawdzPesel
            // 
            this.bSprawdzPesel.Location = new System.Drawing.Point(18, 85);
            this.bSprawdzPesel.Name = "bSprawdzPesel";
            this.bSprawdzPesel.Size = new System.Drawing.Size(111, 23);
            this.bSprawdzPesel.TabIndex = 5;
            this.bSprawdzPesel.Text = "Sprawdz Pesel";
            this.bSprawdzPesel.UseVisualStyleBackColor = true;
            this.bSprawdzPesel.Click += new System.EventHandler(this.bSprawdzPesel_Click);
            // 
            // bWyczyscFormularz
            // 
            this.bWyczyscFormularz.Location = new System.Drawing.Point(142, 85);
            this.bWyczyscFormularz.Name = "bWyczyscFormularz";
            this.bWyczyscFormularz.Size = new System.Drawing.Size(108, 23);
            this.bWyczyscFormularz.TabIndex = 6;
            this.bWyczyscFormularz.Text = "Wyczysc formularz";
            this.bWyczyscFormularz.UseVisualStyleBackColor = true;
            this.bWyczyscFormularz.Click += new System.EventHandler(this.bWyczyscFormularz_Click);
            // 
            // tbDataUrodzenia
            // 
            this.tbDataUrodzenia.Location = new System.Drawing.Point(12, 149);
            this.tbDataUrodzenia.Name = "tbDataUrodzenia";
            this.tbDataUrodzenia.Size = new System.Drawing.Size(155, 20);
            this.tbDataUrodzenia.TabIndex = 7;
            // 
            // tbPlec
            // 
            this.tbPlec.Location = new System.Drawing.Point(12, 201);
            this.tbPlec.Name = "tbPlec";
            this.tbPlec.Size = new System.Drawing.Size(155, 20);
            this.tbPlec.TabIndex = 8;
            // 
            // tbSprawdzPesel
            // 
            this.tbSprawdzPesel.Location = new System.Drawing.Point(12, 250);
            this.tbSprawdzPesel.Name = "tbSprawdzPesel";
            this.tbSprawdzPesel.Size = new System.Drawing.Size(155, 20);
            this.tbSprawdzPesel.TabIndex = 9;
            // 
            // PeselWalidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 298);
            this.Controls.Add(this.tbSprawdzPesel);
            this.Controls.Add(this.tbPlec);
            this.Controls.Add(this.tbDataUrodzenia);
            this.Controls.Add(this.bWyczyscFormularz);
            this.Controls.Add(this.bSprawdzPesel);
            this.Controls.Add(this.labelSprwadzPesel);
            this.Controls.Add(this.labelPlec);
            this.Controls.Add(this.labelDataUrodzenia);
            this.Controls.Add(this.labelPodajNrPesel);
            this.Controls.Add(this.tbPesel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PeselWalidator";
            this.Text = "Pesel Walidator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbPesel;
        private System.Windows.Forms.Label labelPodajNrPesel;
        private System.Windows.Forms.Label labelDataUrodzenia;
        private System.Windows.Forms.Label labelPlec;
        private System.Windows.Forms.Label labelSprwadzPesel;
        private System.Windows.Forms.Button bSprawdzPesel;
        private System.Windows.Forms.Button bWyczyscFormularz;
        public System.Windows.Forms.TextBox tbDataUrodzenia;
        public System.Windows.Forms.TextBox tbPlec;
        public System.Windows.Forms.TextBox tbSprawdzPesel;
    }
}

