
namespace IktatoMySql
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iktatóKönyvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelezésiTémákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iktatásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iktatásTallózóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.személyekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osztályokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beosztásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kimutatásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.címzettekLeveleiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelekDátumSzerintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelekSzűréseNaptárralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iktatóKönyvToolStripMenuItem,
            this.személyekToolStripMenuItem,
            this.osztályokToolStripMenuItem,
            this.beosztásokToolStripMenuItem,
            this.kimutatásokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iktatóKönyvToolStripMenuItem
            // 
            this.iktatóKönyvToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelezésiTémákToolStripMenuItem,
            this.iktatásToolStripMenuItem,
            this.iktatásTallózóToolStripMenuItem});
            this.iktatóKönyvToolStripMenuItem.Name = "iktatóKönyvToolStripMenuItem";
            this.iktatóKönyvToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.iktatóKönyvToolStripMenuItem.Text = "Iktató könyv";
            // 
            // levelezésiTémákToolStripMenuItem
            // 
            this.levelezésiTémákToolStripMenuItem.Name = "levelezésiTémákToolStripMenuItem";
            this.levelezésiTémákToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.levelezésiTémákToolStripMenuItem.Text = "Levelezési témák";
            // 
            // iktatásToolStripMenuItem
            // 
            this.iktatásToolStripMenuItem.Name = "iktatásToolStripMenuItem";
            this.iktatásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iktatásToolStripMenuItem.Text = "Iktatás";
            // 
            // iktatásTallózóToolStripMenuItem
            // 
            this.iktatásTallózóToolStripMenuItem.Name = "iktatásTallózóToolStripMenuItem";
            this.iktatásTallózóToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iktatásTallózóToolStripMenuItem.Text = "Iktatás tallózó";
            // 
            // személyekToolStripMenuItem
            // 
            this.személyekToolStripMenuItem.Name = "személyekToolStripMenuItem";
            this.személyekToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.személyekToolStripMenuItem.Text = "Személyek";
            // 
            // osztályokToolStripMenuItem
            // 
            this.osztályokToolStripMenuItem.Name = "osztályokToolStripMenuItem";
            this.osztályokToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.osztályokToolStripMenuItem.Text = "Osztályok";
            this.osztályokToolStripMenuItem.Click += new System.EventHandler(this.osztályokToolStripMenuItem_Click);
            // 
            // beosztásokToolStripMenuItem
            // 
            this.beosztásokToolStripMenuItem.Name = "beosztásokToolStripMenuItem";
            this.beosztásokToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.beosztásokToolStripMenuItem.Text = "Beosztások";
            this.beosztásokToolStripMenuItem.Click += new System.EventHandler(this.beosztásokToolStripMenuItem_Click);
            // 
            // kimutatásokToolStripMenuItem
            // 
            this.kimutatásokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.címzettekLeveleiToolStripMenuItem,
            this.levelekDátumSzerintToolStripMenuItem,
            this.levelekSzűréseNaptárralToolStripMenuItem});
            this.kimutatásokToolStripMenuItem.Name = "kimutatásokToolStripMenuItem";
            this.kimutatásokToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.kimutatásokToolStripMenuItem.Text = "Kimutatások";
            // 
            // címzettekLeveleiToolStripMenuItem
            // 
            this.címzettekLeveleiToolStripMenuItem.Name = "címzettekLeveleiToolStripMenuItem";
            this.címzettekLeveleiToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.címzettekLeveleiToolStripMenuItem.Text = "Címzettek levelei";
            // 
            // levelekDátumSzerintToolStripMenuItem
            // 
            this.levelekDátumSzerintToolStripMenuItem.Name = "levelekDátumSzerintToolStripMenuItem";
            this.levelekDátumSzerintToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.levelekDátumSzerintToolStripMenuItem.Text = "Levelek szűrése iktatási dátum szerint";
            // 
            // levelekSzűréseNaptárralToolStripMenuItem
            // 
            this.levelekSzűréseNaptárralToolStripMenuItem.Name = "levelekSzűréseNaptárralToolStripMenuItem";
            this.levelekSzűréseNaptárralToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.levelekSzűréseNaptárralToolStripMenuItem.Text = "Levelek szűrése naptárral";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Iktatás MySql adatbázissal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iktatóKönyvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelezésiTémákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iktatásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iktatásTallózóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem személyekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osztályokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beosztásokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kimutatásokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem címzettekLeveleiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelekDátumSzerintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelekSzűréseNaptárralToolStripMenuItem;
    }
}

