namespace ChocolateBoxesJav
{
    partial class frmChocolBoxes
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
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.btnGetReward = new System.Windows.Forms.Button();
            this.txtNumBoxes = new System.Windows.Forms.TextBox();
            this.lblReward = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEnterNumber.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNumber.Location = new System.Drawing.Point(12, 80);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(297, 28);
            this.lblEnterNumber.TabIndex = 0;
            this.lblEnterNumber.Text = "Enter the number of boxes sold:";
            // 
            // btnGetReward
            // 
            this.btnGetReward.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGetReward.Font = new System.Drawing.Font("Adobe Naskh Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetReward.Location = new System.Drawing.Point(186, 334);
            this.btnGetReward.Name = "btnGetReward";
            this.btnGetReward.Size = new System.Drawing.Size(123, 43);
            this.btnGetReward.TabIndex = 1;
            this.btnGetReward.Text = "Get Reward";
            this.btnGetReward.UseVisualStyleBackColor = false;
            this.btnGetReward.Click += new System.EventHandler(this.btnGetReward_Click);
            // 
            // txtNumBoxes
            // 
            this.txtNumBoxes.Location = new System.Drawing.Point(315, 88);
            this.txtNumBoxes.Name = "txtNumBoxes";
            this.txtNumBoxes.Size = new System.Drawing.Size(100, 20);
            this.txtNumBoxes.TabIndex = 2;
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.BackColor = System.Drawing.Color.Silver;
            this.lblReward.Font = new System.Drawing.Font("Adobe Arabic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReward.Location = new System.Drawing.Point(209, 461);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(86, 29);
            this.lblReward.TabIndex = 3;
            this.lblReward.Text = "You get_";
            // 
            // frmChocolBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChocolateBoxesJav.Properties.Resources.chocolate;
            this.ClientSize = new System.Drawing.Size(484, 537);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.txtNumBoxes);
            this.Controls.Add(this.btnGetReward);
            this.Controls.Add(this.lblEnterNumber);
            this.Name = "frmChocolBoxes";
            this.Text = "Chocolate Boxes by Javiera";
            this.Load += new System.EventHandler(this.frmChocolBoxes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.Button btnGetReward;
        private System.Windows.Forms.TextBox txtNumBoxes;
        private System.Windows.Forms.Label lblReward;
    }
}

