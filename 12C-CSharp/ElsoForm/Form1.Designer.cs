namespace ElsoForm
{
    partial class MainForm
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
            this.btnKattints = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKattints
            // 
            this.btnKattints.Location = new System.Drawing.Point(107, 124);
            this.btnKattints.Name = "btnKattints";
            this.btnKattints.Size = new System.Drawing.Size(152, 71);
            this.btnKattints.TabIndex = 0;
            this.btnKattints.Text = "Kattints rám!";
            this.btnKattints.UseVisualStyleBackColor = true;
            this.btnKattints.Click += new System.EventHandler(this.btnKattints_Click);
            this.btnKattints.MouseLeave += new System.EventHandler(this.btnKattints_MouseLeave);
            this.btnKattints.MouseHover += new System.EventHandler(this.btnKattints_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(428, 351);
            this.Controls.Add(this.btnKattints);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MainForm";
            this.Text = "Próbálgatás";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKattints;
    }
}

