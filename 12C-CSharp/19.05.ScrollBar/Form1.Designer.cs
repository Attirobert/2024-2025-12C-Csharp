namespace ScrollBar
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
            this.scbOldalHossz = new System.Windows.Forms.HScrollBar();
            this.lblNegyzetMeretCimke = new System.Windows.Forms.Label();
            this.lblNegyzet = new System.Windows.Forms.Label();
            this.scbPiros = new System.Windows.Forms.HScrollBar();
            this.scbKek = new System.Windows.Forms.HScrollBar();
            this.scbZold = new System.Windows.Forms.HScrollBar();
            this.lblPiros = new System.Windows.Forms.Label();
            this.lblKek = new System.Windows.Forms.Label();
            this.lblZold = new System.Windows.Forms.Label();
            this.lblHossz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scbOldalHossz
            // 
            this.scbOldalHossz.Location = new System.Drawing.Point(90, 56);
            this.scbOldalHossz.Maximum = 120;
            this.scbOldalHossz.Minimum = 10;
            this.scbOldalHossz.Name = "scbOldalHossz";
            this.scbOldalHossz.Size = new System.Drawing.Size(513, 17);
            this.scbOldalHossz.TabIndex = 0;
            this.scbOldalHossz.Value = 50;
            this.scbOldalHossz.ValueChanged += new System.EventHandler(this.scbOldalHossz_ValueChanged);
            // 
            // lblNegyzetMeretCimke
            // 
            this.lblNegyzetMeretCimke.AutoSize = true;
            this.lblNegyzetMeretCimke.Location = new System.Drawing.Point(87, 19);
            this.lblNegyzetMeretCimke.Name = "lblNegyzetMeretCimke";
            this.lblNegyzetMeretCimke.Size = new System.Drawing.Size(91, 13);
            this.lblNegyzetMeretCimke.TabIndex = 1;
            this.lblNegyzetMeretCimke.Text = "A négyzet oldala: ";
            // 
            // lblNegyzet
            // 
            this.lblNegyzet.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNegyzet.Location = new System.Drawing.Point(90, 103);
            this.lblNegyzet.Name = "lblNegyzet";
            this.lblNegyzet.Size = new System.Drawing.Size(50, 50);
            this.lblNegyzet.TabIndex = 2;
            this.lblNegyzet.Text = "label2";
            // 
            // scbPiros
            // 
            this.scbPiros.Location = new System.Drawing.Point(177, 233);
            this.scbPiros.Maximum = 255;
            this.scbPiros.Name = "scbPiros";
            this.scbPiros.Size = new System.Drawing.Size(359, 17);
            this.scbPiros.TabIndex = 3;
            this.scbPiros.Value = 30;
            this.scbPiros.ValueChanged += new System.EventHandler(this.scbPiros_ValueChanged);
            // 
            // scbKek
            // 
            this.scbKek.Location = new System.Drawing.Point(177, 281);
            this.scbKek.Maximum = 255;
            this.scbKek.Name = "scbKek";
            this.scbKek.Size = new System.Drawing.Size(359, 17);
            this.scbKek.TabIndex = 4;
            this.scbKek.Value = 30;
            this.scbKek.ValueChanged += new System.EventHandler(this.scbKek_ValueChanged);
            // 
            // scbZold
            // 
            this.scbZold.Location = new System.Drawing.Point(177, 326);
            this.scbZold.Maximum = 255;
            this.scbZold.Name = "scbZold";
            this.scbZold.Size = new System.Drawing.Size(359, 17);
            this.scbZold.TabIndex = 5;
            this.scbZold.Value = 30;
            this.scbZold.ValueChanged += new System.EventHandler(this.scbZold_ValueChanged);
            // 
            // lblPiros
            // 
            this.lblPiros.AutoSize = true;
            this.lblPiros.Location = new System.Drawing.Point(90, 233);
            this.lblPiros.Name = "lblPiros";
            this.lblPiros.Size = new System.Drawing.Size(36, 13);
            this.lblPiros.TabIndex = 6;
            this.lblPiros.Text = "Piros: ";
            // 
            // lblKek
            // 
            this.lblKek.AutoSize = true;
            this.lblKek.Location = new System.Drawing.Point(90, 281);
            this.lblKek.Name = "lblKek";
            this.lblKek.Size = new System.Drawing.Size(32, 13);
            this.lblKek.TabIndex = 7;
            this.lblKek.Text = "Kék: ";
            // 
            // lblZold
            // 
            this.lblZold.AutoSize = true;
            this.lblZold.Location = new System.Drawing.Point(90, 326);
            this.lblZold.Name = "lblZold";
            this.lblZold.Size = new System.Drawing.Size(34, 13);
            this.lblZold.TabIndex = 8;
            this.lblZold.Text = "Zöld: ";
            // 
            // lblHossz
            // 
            this.lblHossz.AutoSize = true;
            this.lblHossz.Location = new System.Drawing.Point(185, 19);
            this.lblHossz.Name = "lblHossz";
            this.lblHossz.Size = new System.Drawing.Size(13, 13);
            this.lblHossz.TabIndex = 9;
            this.lblHossz.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHossz);
            this.Controls.Add(this.lblZold);
            this.Controls.Add(this.lblKek);
            this.Controls.Add(this.lblPiros);
            this.Controls.Add(this.scbZold);
            this.Controls.Add(this.scbKek);
            this.Controls.Add(this.scbPiros);
            this.Controls.Add(this.lblNegyzet);
            this.Controls.Add(this.lblNegyzetMeretCimke);
            this.Controls.Add(this.scbOldalHossz);
            this.Name = "Form1";
            this.Text = "Színkeverés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar scbOldalHossz;
        private System.Windows.Forms.Label lblNegyzetMeretCimke;
        private System.Windows.Forms.Label lblNegyzet;
        private System.Windows.Forms.HScrollBar scbPiros;
        private System.Windows.Forms.HScrollBar scbKek;
        private System.Windows.Forms.HScrollBar scbZold;
        private System.Windows.Forms.Label lblPiros;
        private System.Windows.Forms.Label lblKek;
        private System.Windows.Forms.Label lblZold;
        private System.Windows.Forms.Label lblHossz;
    }
}

