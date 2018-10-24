namespace RandomNumberJav
{
    partial class frmRandomNumber
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
            this.picQuestionMark = new System.Windows.Forms.PictureBox();
            this.lblGetNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRandomNumber = new System.Windows.Forms.Button();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestionMark)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picQuestionMark
            // 
            this.picQuestionMark.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picQuestionMark.Image = global::RandomNumberJav.Properties.Resources.questionMark;
            this.picQuestionMark.Location = new System.Drawing.Point(442, 376);
            this.picQuestionMark.Name = "picQuestionMark";
            this.picQuestionMark.Size = new System.Drawing.Size(133, 175);
            this.picQuestionMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQuestionMark.TabIndex = 0;
            this.picQuestionMark.TabStop = false;
            // 
            // lblGetNumber
            // 
            this.lblGetNumber.AutoSize = true;
            this.lblGetNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGetNumber.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetNumber.Location = new System.Drawing.Point(259, 47);
            this.lblGetNumber.Name = "lblGetNumber";
            this.lblGetNumber.Size = new System.Drawing.Size(471, 28);
            this.lblGetNumber.TabIndex = 1;
            this.lblGetNumber.Text = "Click the button to get a number between 1 and 10:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // btnRandomNumber
            // 
            this.btnRandomNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRandomNumber.Font = new System.Drawing.Font("Monotxt_IV50", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomNumber.Location = new System.Drawing.Point(382, 137);
            this.btnRandomNumber.Name = "btnRandomNumber";
            this.btnRandomNumber.Size = new System.Drawing.Size(262, 94);
            this.btnRandomNumber.TabIndex = 3;
            this.btnRandomNumber.Text = "Generate Random Number";
            this.btnRandomNumber.UseVisualStyleBackColor = false;
            this.btnRandomNumber.Click += new System.EventHandler(this.btnRandomNumber_Click);
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRandomNumber.Font = new System.Drawing.Font("Monotxt_IV50", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomNumber.Location = new System.Drawing.Point(482, 314);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(67, 30);
            this.lblRandomNumber.TabIndex = 4;
            this.lblRandomNumber.Text = "Num";
            this.lblRandomNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmRandomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::RandomNumberJav.Properties.Resources.RandomImage;
            this.ClientSize = new System.Drawing.Size(1056, 550);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.btnRandomNumber);
            this.Controls.Add(this.lblGetNumber);
            this.Controls.Add(this.picQuestionMark);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRandomNumber";
            this.Text = "Random Number by Javiera Diaz";
            this.Load += new System.EventHandler(this.frmRandomNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQuestionMark)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picQuestionMark;
        private System.Windows.Forms.Label lblGetNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Button btnRandomNumber;
        private System.Windows.Forms.Label lblRandomNumber;
    }
}

