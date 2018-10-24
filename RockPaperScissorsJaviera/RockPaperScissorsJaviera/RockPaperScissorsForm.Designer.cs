namespace RockPaperScissorsJaviera
{
    partial class frmRockPaperScissors
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
            this.picImageOne = new System.Windows.Forms.PictureBox();
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblDeclareOutcome = new System.Windows.Forms.Label();
            this.grbUsersChoice = new System.Windows.Forms.GroupBox();
            this.radUserRoxk = new System.Windows.Forms.RadioButton();
            this.radUserPaper = new System.Windows.Forms.RadioButton();
            this.radUserScissors = new System.Windows.Forms.RadioButton();
            this.grbCompChoice = new System.Windows.Forms.GroupBox();
            this.radCompScissors = new System.Windows.Forms.RadioButton();
            this.radCompPaper = new System.Windows.Forms.RadioButton();
            this.radCompRock = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picImageOne)).BeginInit();
            this.mnuFile.SuspendLayout();
            this.grbUsersChoice.SuspendLayout();
            this.grbCompChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImageOne
            // 
            this.picImageOne.Image = global::RockPaperScissorsJaviera.Properties.Resources.rockpaperscissors;
            this.picImageOne.Location = new System.Drawing.Point(86, 387);
            this.picImageOne.Name = "picImageOne";
            this.picImageOne.Size = new System.Drawing.Size(494, 333);
            this.picImageOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImageOne.TabIndex = 0;
            this.picImageOne.TabStop = false;
            this.picImageOne.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(662, 24);
            this.mnuFile.TabIndex = 1;
            this.mnuFile.Text = "menuStrip1";
            this.mnuFile.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuFile_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Monotxt_IV50", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(286, 248);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(107, 39);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblDeclareOutcome
            // 
            this.lblDeclareOutcome.AutoSize = true;
            this.lblDeclareOutcome.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeclareOutcome.Location = new System.Drawing.Point(206, 73);
            this.lblDeclareOutcome.Name = "lblDeclareOutcome";
            this.lblDeclareOutcome.Size = new System.Drawing.Size(247, 24);
            this.lblDeclareOutcome.TabIndex = 3;
            this.lblDeclareOutcome.Text = "Please choose a button!";
            // 
            // grbUsersChoice
            // 
            this.grbUsersChoice.Controls.Add(this.radUserScissors);
            this.grbUsersChoice.Controls.Add(this.radUserPaper);
            this.grbUsersChoice.Controls.Add(this.radUserRoxk);
            this.grbUsersChoice.Font = new System.Drawing.Font("Monotxt_IV50", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUsersChoice.Location = new System.Drawing.Point(55, 136);
            this.grbUsersChoice.Name = "grbUsersChoice";
            this.grbUsersChoice.Size = new System.Drawing.Size(171, 245);
            this.grbUsersChoice.TabIndex = 4;
            this.grbUsersChoice.TabStop = false;
            this.grbUsersChoice.Text = "Choose a button";
            // 
            // radUserRoxk
            // 
            this.radUserRoxk.AutoSize = true;
            this.radUserRoxk.Font = new System.Drawing.Font("Monotxt_IV50", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUserRoxk.Location = new System.Drawing.Point(38, 47);
            this.radUserRoxk.Name = "radUserRoxk";
            this.radUserRoxk.Size = new System.Drawing.Size(94, 30);
            this.radUserRoxk.TabIndex = 0;
            this.radUserRoxk.TabStop = true;
            this.radUserRoxk.Text = "Rock";
            this.radUserRoxk.UseVisualStyleBackColor = true;
            // 
            // radUserPaper
            // 
            this.radUserPaper.AutoSize = true;
            this.radUserPaper.Font = new System.Drawing.Font("Monotxt_IV50", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUserPaper.Location = new System.Drawing.Point(38, 112);
            this.radUserPaper.Name = "radUserPaper";
            this.radUserPaper.Size = new System.Drawing.Size(110, 30);
            this.radUserPaper.TabIndex = 1;
            this.radUserPaper.TabStop = true;
            this.radUserPaper.Text = "Paper";
            this.radUserPaper.UseVisualStyleBackColor = true;
            // 
            // radUserScissors
            // 
            this.radUserScissors.AutoSize = true;
            this.radUserScissors.Font = new System.Drawing.Font("Monotxt_IV50", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUserScissors.Location = new System.Drawing.Point(11, 174);
            this.radUserScissors.Name = "radUserScissors";
            this.radUserScissors.Size = new System.Drawing.Size(158, 30);
            this.radUserScissors.TabIndex = 2;
            this.radUserScissors.TabStop = true;
            this.radUserScissors.Text = "Scissors";
            this.radUserScissors.UseVisualStyleBackColor = true;
            // 
            // grbCompChoice
            // 
            this.grbCompChoice.Controls.Add(this.radCompScissors);
            this.grbCompChoice.Controls.Add(this.radCompPaper);
            this.grbCompChoice.Controls.Add(this.radCompRock);
            this.grbCompChoice.Font = new System.Drawing.Font("Monotxt_IV50", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCompChoice.Location = new System.Drawing.Point(440, 136);
            this.grbCompChoice.Name = "grbCompChoice";
            this.grbCompChoice.Size = new System.Drawing.Size(171, 245);
            this.grbCompChoice.TabIndex = 5;
            this.grbCompChoice.TabStop = false;
            this.grbCompChoice.Text = "Computer\'s choice";
            // 
            // radCompScissors
            // 
            this.radCompScissors.AutoSize = true;
            this.radCompScissors.Font = new System.Drawing.Font("Monotxt_IV50", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCompScissors.Location = new System.Drawing.Point(11, 174);
            this.radCompScissors.Name = "radCompScissors";
            this.radCompScissors.Size = new System.Drawing.Size(158, 30);
            this.radCompScissors.TabIndex = 2;
            this.radCompScissors.TabStop = true;
            this.radCompScissors.Text = "Scissors";
            this.radCompScissors.UseVisualStyleBackColor = true;
            // 
            // radCompPaper
            // 
            this.radCompPaper.AutoSize = true;
            this.radCompPaper.Font = new System.Drawing.Font("Monotxt_IV50", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCompPaper.Location = new System.Drawing.Point(38, 112);
            this.radCompPaper.Name = "radCompPaper";
            this.radCompPaper.Size = new System.Drawing.Size(110, 30);
            this.radCompPaper.TabIndex = 1;
            this.radCompPaper.TabStop = true;
            this.radCompPaper.Text = "Paper";
            this.radCompPaper.UseVisualStyleBackColor = true;
            // 
            // radCompRock
            // 
            this.radCompRock.AutoSize = true;
            this.radCompRock.Font = new System.Drawing.Font("Monotxt_IV50", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCompRock.Location = new System.Drawing.Point(46, 42);
            this.radCompRock.Name = "radCompRock";
            this.radCompRock.Size = new System.Drawing.Size(94, 30);
            this.radCompRock.TabIndex = 0;
            this.radCompRock.TabStop = true;
            this.radCompRock.Text = "Rock";
            this.radCompRock.UseVisualStyleBackColor = true;
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(662, 732);
            this.Controls.Add(this.grbCompChoice);
            this.Controls.Add(this.grbUsersChoice);
            this.Controls.Add(this.lblDeclareOutcome);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picImageOne);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock, Paper, Scissors by Javiera Diaz";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImageOne)).EndInit();
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.grbUsersChoice.ResumeLayout(false);
            this.grbUsersChoice.PerformLayout();
            this.grbCompChoice.ResumeLayout(false);
            this.grbCompChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageOne;
        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblDeclareOutcome;
        private System.Windows.Forms.GroupBox grbUsersChoice;
        private System.Windows.Forms.RadioButton radUserScissors;
        private System.Windows.Forms.RadioButton radUserPaper;
        private System.Windows.Forms.RadioButton radUserRoxk;
        private System.Windows.Forms.GroupBox grbCompChoice;
        private System.Windows.Forms.RadioButton radCompScissors;
        private System.Windows.Forms.RadioButton radCompPaper;
        private System.Windows.Forms.RadioButton radCompRock;
    }
}

