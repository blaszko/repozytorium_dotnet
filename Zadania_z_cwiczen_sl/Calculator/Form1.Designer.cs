namespace Calculator
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
            this.tbResult = new System.Windows.Forms.TextBox();
            this.b7 = new System.Windows.Forms.Button();
            this.bDivide = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bMultiply = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bEqual = new System.Windows.Forms.Button();
            this.bCe = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbResult.Location = new System.Drawing.Point(14, 41);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(235, 26);
            this.tbResult.TabIndex = 0;
            this.tbResult.Text = "0";
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b7.Location = new System.Drawing.Point(14, 73);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(40, 40);
            this.b7.TabIndex = 1;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.button_click);
            // 
            // bDivide
            // 
            this.bDivide.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDivide.Location = new System.Drawing.Point(152, 73);
            this.bDivide.Name = "bDivide";
            this.bDivide.Size = new System.Drawing.Size(40, 40);
            this.bDivide.TabIndex = 2;
            this.bDivide.Text = "/";
            this.bDivide.UseVisualStyleBackColor = false;
            this.bDivide.Click += new System.EventHandler(this.operator_click_event);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b9.Location = new System.Drawing.Point(106, 73);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(40, 40);
            this.b9.TabIndex = 3;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.button_click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b8.Location = new System.Drawing.Point(60, 73);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(40, 40);
            this.b8.TabIndex = 4;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.button_click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b2.Location = new System.Drawing.Point(60, 165);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(40, 40);
            this.b2.TabIndex = 8;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.button_click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b3.Location = new System.Drawing.Point(106, 165);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(40, 40);
            this.b3.TabIndex = 7;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.button_click);
            // 
            // bMinus
            // 
            this.bMinus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMinus.Location = new System.Drawing.Point(152, 165);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(40, 40);
            this.bMinus.TabIndex = 6;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = false;
            this.bMinus.Click += new System.EventHandler(this.operator_click_event);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b1.Location = new System.Drawing.Point(14, 165);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(40, 40);
            this.b1.TabIndex = 5;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.button_click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b5.Location = new System.Drawing.Point(60, 119);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(40, 40);
            this.b5.TabIndex = 12;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.button_click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b6.Location = new System.Drawing.Point(106, 119);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(40, 40);
            this.b6.TabIndex = 11;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.button_click);
            // 
            // bMultiply
            // 
            this.bMultiply.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMultiply.Location = new System.Drawing.Point(152, 119);
            this.bMultiply.Name = "bMultiply";
            this.bMultiply.Size = new System.Drawing.Size(40, 40);
            this.bMultiply.TabIndex = 10;
            this.bMultiply.Text = "*";
            this.bMultiply.UseVisualStyleBackColor = false;
            this.bMultiply.Click += new System.EventHandler(this.operator_click_event);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b4.Location = new System.Drawing.Point(14, 119);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(40, 40);
            this.b4.TabIndex = 9;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.button_click);
            // 
            // bDot
            // 
            this.bDot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDot.Location = new System.Drawing.Point(106, 211);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(40, 40);
            this.bDot.TabIndex = 15;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = false;
            this.bDot.Click += new System.EventHandler(this.button_click);
            // 
            // bPlus
            // 
            this.bPlus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPlus.Location = new System.Drawing.Point(152, 211);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(40, 40);
            this.bPlus.TabIndex = 14;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = false;
            this.bPlus.Click += new System.EventHandler(this.operator_click_event);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b0.Location = new System.Drawing.Point(14, 211);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(86, 40);
            this.b0.TabIndex = 13;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.button_click);
            // 
            // bC
            // 
            this.bC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bC.Location = new System.Drawing.Point(198, 119);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(49, 40);
            this.bC.TabIndex = 19;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = false;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bEqual
            // 
            this.bEqual.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bEqual.Location = new System.Drawing.Point(198, 165);
            this.bEqual.Name = "bEqual";
            this.bEqual.Size = new System.Drawing.Size(49, 86);
            this.bEqual.TabIndex = 18;
            this.bEqual.Text = "=";
            this.bEqual.UseVisualStyleBackColor = false;
            this.bEqual.Click += new System.EventHandler(this.bEqual_Click);
            // 
            // bCe
            // 
            this.bCe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCe.Location = new System.Drawing.Point(198, 73);
            this.bCe.Name = "bCe";
            this.bCe.Size = new System.Drawing.Size(49, 40);
            this.bCe.TabIndex = 17;
            this.bCe.Text = "CE";
            this.bCe.UseVisualStyleBackColor = false;
            this.bCe.Click += new System.EventHandler(this.bCe_Click);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCurrentOperation.Location = new System.Drawing.Point(14, 18);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(235, 20);
            this.labelCurrentOperation.TabIndex = 20;
            this.labelCurrentOperation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 272);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bEqual);
            this.Controls.Add(this.bCe);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.bMultiply);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.bDivide);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.tbResult);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator Blazej Pospiech";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button bDivide;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bMultiply;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bEqual;
        private System.Windows.Forms.Button bCe;
        private System.Windows.Forms.Label labelCurrentOperation;
    }
}

