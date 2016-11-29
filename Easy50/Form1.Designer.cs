namespace Easy50
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
            this.label1 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.awardsExcelText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.awardsOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.powerpointOpen = new System.Windows.Forms.Button();
            this.powerpointText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picturesOpen = new System.Windows.Forms.Button();
            this.picturesText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "This wizard will create a powerpoint presentation for awards day.\r\nIt was made by" +
    " Sam Nolan in 2016.";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(248, 235);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // awardsExcelText
            // 
            this.awardsExcelText.Location = new System.Drawing.Point(6, 19);
            this.awardsExcelText.Name = "awardsExcelText";
            this.awardsExcelText.Size = new System.Drawing.Size(197, 20);
            this.awardsExcelText.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.awardsOpen);
            this.groupBox1.Controls.Add(this.awardsExcelText);
            this.groupBox1.Location = new System.Drawing.Point(16, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Awards Excel";
            // 
            // awardsOpen
            // 
            this.awardsOpen.Location = new System.Drawing.Point(210, 19);
            this.awardsOpen.Name = "awardsOpen";
            this.awardsOpen.Size = new System.Drawing.Size(75, 23);
            this.awardsOpen.TabIndex = 4;
            this.awardsOpen.Text = "Open";
            this.awardsOpen.UseVisualStyleBackColor = true;
            this.awardsOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.powerpointOpen);
            this.groupBox2.Controls.Add(this.powerpointText);
            this.groupBox2.Location = new System.Drawing.Point(16, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Powerpoint Template";
            // 
            // powerpointOpen
            // 
            this.powerpointOpen.Location = new System.Drawing.Point(210, 19);
            this.powerpointOpen.Name = "powerpointOpen";
            this.powerpointOpen.Size = new System.Drawing.Size(75, 23);
            this.powerpointOpen.TabIndex = 4;
            this.powerpointOpen.Text = "Open";
            this.powerpointOpen.UseVisualStyleBackColor = true;
            this.powerpointOpen.Click += new System.EventHandler(this.powerpointOpen_Click);
            // 
            // powerpointText
            // 
            this.powerpointText.Location = new System.Drawing.Point(6, 19);
            this.powerpointText.Name = "powerpointText";
            this.powerpointText.Size = new System.Drawing.Size(197, 20);
            this.powerpointText.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picturesOpen);
            this.groupBox3.Controls.Add(this.picturesText);
            this.groupBox3.Location = new System.Drawing.Point(16, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 54);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Pictures";
            // 
            // picturesOpen
            // 
            this.picturesOpen.Location = new System.Drawing.Point(210, 19);
            this.picturesOpen.Name = "picturesOpen";
            this.picturesOpen.Size = new System.Drawing.Size(75, 23);
            this.picturesOpen.TabIndex = 4;
            this.picturesOpen.Text = "Open";
            this.picturesOpen.UseVisualStyleBackColor = true;
            this.picturesOpen.Click += new System.EventHandler(this.picturesOpen_Click);
            // 
            // picturesText
            // 
            this.picturesText.Location = new System.Drawing.Point(6, 19);
            this.picturesText.Name = "picturesText";
            this.picturesText.Size = new System.Drawing.Size(197, 20);
            this.picturesText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 267);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BHS Awards Day Powerpoint";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox awardsExcelText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button awardsOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button powerpointOpen;
        private System.Windows.Forms.TextBox powerpointText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button picturesOpen;
        private System.Windows.Forms.TextBox picturesText;
    }
}

