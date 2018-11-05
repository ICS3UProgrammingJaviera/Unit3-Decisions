namespace ForEachCtrlObJav
{
    partial class frmForEachCtrlObJav
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
            this.lblFirstLabel = new System.Windows.Forms.Label();
            this.lblSecondLabel = new System.Windows.Forms.Label();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.clickMeToMakeMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstLabel
            // 
            this.lblFirstLabel.AutoSize = true;
            this.lblFirstLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFirstLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFirstLabel.Location = new System.Drawing.Point(144, 131);
            this.lblFirstLabel.Name = "lblFirstLabel";
            this.lblFirstLabel.Size = new System.Drawing.Size(267, 28);
            this.lblFirstLabel.TabIndex = 0;
            this.lblFirstLabel.Text = "Clicl me to turn me blue!";
            // 
            // lblSecondLabel
            // 
            this.lblSecondLabel.AutoSize = true;
            this.lblSecondLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSecondLabel.Font = new System.Drawing.Font("Monotxt_IV50", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSecondLabel.Location = new System.Drawing.Point(56, 365);
            this.lblSecondLabel.Name = "lblSecondLabel";
            this.lblSecondLabel.Size = new System.Drawing.Size(444, 24);
            this.lblSecondLabel.TabIndex = 1;
            this.lblSecondLabel.Text = "Click me to make me turn green!";
            // 
            // btnClickMe
            // 
            this.btnClickMe.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClickMe.Font = new System.Drawing.Font("Stylus BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickMe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClickMe.Location = new System.Drawing.Point(175, 224);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(210, 65);
            this.btnClickMe.TabIndex = 2;
            this.btnClickMe.Text = "Click me to make me blush!";
            this.btnClickMe.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.clickMeToMakeMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 34);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 30);
            this.mnuFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // clickMeToMakeMeToolStripMenuItem
            // 
            this.clickMeToMakeMeToolStripMenuItem.Font = new System.Drawing.Font("Simplex_IV50", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickMeToMakeMeToolStripMenuItem.Name = "clickMeToMakeMeToolStripMenuItem";
            this.clickMeToMakeMeToolStripMenuItem.Size = new System.Drawing.Size(355, 30);
            this.clickMeToMakeMeToolStripMenuItem.Text = "Click me to make me purple!";
            this.clickMeToMakeMeToolStripMenuItem.Click += new System.EventHandler(this.clickMeToMakeMeToolStripMenuItem_Click);
            // 
            // frmForEachCtrlObJav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(563, 457);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.lblSecondLabel);
            this.Controls.Add(this.lblFirstLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmForEachCtrlObJav";
            this.Text = "For Each Control Object by Javiera Diaz";
            this.Load += new System.EventHandler(this.frmForEachCtrlObJav_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstLabel;
        private System.Windows.Forms.Label lblSecondLabel;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem clickMeToMakeMeToolStripMenuItem;
    }
}

