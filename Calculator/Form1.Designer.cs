namespace Calculator
{
    partial class Calculator
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
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.bEsit = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bTopla = new System.Windows.Forms.Button();
            this.bVirgul = new System.Windows.Forms.Button();
            this.bCıkar = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bCarp = new System.Windows.Forms.Button();
            this.bBol = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(35, 52);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(284, 20);
            this.txtSonuc.TabIndex = 0;
            this.txtSonuc.Text = "0";
            // 
            // bEsit
            // 
            this.bEsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.bEsit.Location = new System.Drawing.Point(259, 221);
            this.bEsit.Name = "bEsit";
            this.bEsit.Size = new System.Drawing.Size(60, 110);
            this.bEsit.TabIndex = 1;
            this.bEsit.Text = "=";
            this.bEsit.UseVisualStyleBackColor = true;
            this.bEsit.Click += new System.EventHandler(this.bEsit_Click);
            // 
            // bC
            // 
            this.bC.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.bC.Location = new System.Drawing.Point(259, 105);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(60, 110);
            this.bC.TabIndex = 1;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bTopla
            // 
            this.bTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bTopla.Location = new System.Drawing.Point(203, 277);
            this.bTopla.Name = "bTopla";
            this.bTopla.Size = new System.Drawing.Size(50, 50);
            this.bTopla.TabIndex = 2;
            this.bTopla.Text = "+";
            this.bTopla.UseVisualStyleBackColor = true;
            this.bTopla.Click += new System.EventHandler(this.OptOlay);
            // 
            // bVirgul
            // 
            this.bVirgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bVirgul.Location = new System.Drawing.Point(147, 277);
            this.bVirgul.Name = "bVirgul";
            this.bVirgul.Size = new System.Drawing.Size(50, 50);
            this.bVirgul.TabIndex = 2;
            this.bVirgul.Text = ",";
            this.bVirgul.UseVisualStyleBackColor = true;
            this.bVirgul.Click += new System.EventHandler(this.bVirgul_Click);
            // 
            // bCıkar
            // 
            this.bCıkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bCıkar.Location = new System.Drawing.Point(203, 221);
            this.bCıkar.Name = "bCıkar";
            this.bCıkar.Size = new System.Drawing.Size(50, 50);
            this.bCıkar.TabIndex = 2;
            this.bCıkar.Text = "-";
            this.bCıkar.UseVisualStyleBackColor = true;
            this.bCıkar.Click += new System.EventHandler(this.OptOlay);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b3.Location = new System.Drawing.Point(147, 221);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(50, 50);
            this.b3.TabIndex = 2;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.RakamOlay);
            // 
            // bCarp
            // 
            this.bCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bCarp.Location = new System.Drawing.Point(203, 165);
            this.bCarp.Name = "bCarp";
            this.bCarp.Size = new System.Drawing.Size(50, 50);
            this.bCarp.TabIndex = 2;
            this.bCarp.Text = "*";
            this.bCarp.UseVisualStyleBackColor = true;
            this.bCarp.Click += new System.EventHandler(this.OptOlay);
            // 
            // bBol
            // 
            this.bBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bBol.Location = new System.Drawing.Point(203, 109);
            this.bBol.Name = "bBol";
            this.bBol.Size = new System.Drawing.Size(50, 50);
            this.bBol.TabIndex = 2;
            this.bBol.Text = "/";
            this.bBol.UseVisualStyleBackColor = true;
            this.bBol.Click += new System.EventHandler(this.OptOlay);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b6.Location = new System.Drawing.Point(147, 165);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(50, 50);
            this.b6.TabIndex = 2;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b9.Location = new System.Drawing.Point(147, 109);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(50, 50);
            this.b9.TabIndex = 2;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b2.Location = new System.Drawing.Point(91, 221);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(50, 50);
            this.b2.TabIndex = 2;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b5.Location = new System.Drawing.Point(91, 165);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(50, 50);
            this.b5.TabIndex = 2;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b1.Location = new System.Drawing.Point(35, 221);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(50, 50);
            this.b1.TabIndex = 2;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b4.Location = new System.Drawing.Point(35, 165);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(50, 50);
            this.b4.TabIndex = 2;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b8.Location = new System.Drawing.Point(91, 109);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(50, 50);
            this.b8.TabIndex = 2;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b7.Location = new System.Drawing.Point(35, 109);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(50, 50);
            this.b7.TabIndex = 2;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b0.Location = new System.Drawing.Point(35, 277);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(106, 50);
            this.b0.TabIndex = 3;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.RakamOlay);
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Location = new System.Drawing.Point(32, 36);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(0, 13);
            this.lbSonuc.TabIndex = 4;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 343);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.bVirgul);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.bBol);
            this.Controls.Add(this.bCarp);
            this.Controls.Add(this.bCıkar);
            this.Controls.Add(this.bTopla);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bEsit);
            this.Controls.Add(this.txtSonuc);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button bEsit;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bTopla;
        private System.Windows.Forms.Button bVirgul;
        private System.Windows.Forms.Button bCıkar;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bCarp;
        private System.Windows.Forms.Button bBol;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Label lbSonuc;
    }
}

