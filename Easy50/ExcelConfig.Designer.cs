using System;

namespace Easy50
{
    partial class ExcelConfig
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
            this.headingsBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentNameSelector = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentFormSelector = new System.Windows.Forms.NumericUpDown();
            this.studentCodeSelector = new System.Windows.Forms.NumericUpDown();
            this.studentAwardSelector = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exampleStudentAwardLabel = new System.Windows.Forms.Label();
            this.exampleStudentCodeLabel = new System.Windows.Forms.Label();
            this.exampleStudentFormLabel = new System.Windows.Forms.Label();
            this.exampleStudentNameLabel = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentNameSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFormSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCodeSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAwardSelector)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here we will determine how to pull information out of the awards day excel sheet";
            // 
            // headingsBox
            // 
            this.headingsBox.AutoSize = true;
            this.headingsBox.Location = new System.Drawing.Point(213, 103);
            this.headingsBox.Name = "headingsBox";
            this.headingsBox.Size = new System.Drawing.Size(120, 17);
            this.headingsBox.TabIndex = 1;
            this.headingsBox.Text = "Sheet has headings";
            this.headingsBox.UseVisualStyleBackColor = true;
            this.headingsBox.CheckedChanged += new System.EventHandler(this.headingsBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name";
            // 
            // studentNameSelector
            // 
            this.studentNameSelector.Location = new System.Drawing.Point(35, 59);
            this.studentNameSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.studentNameSelector.Name = "studentNameSelector";
            this.studentNameSelector.Size = new System.Drawing.Size(33, 20);
            this.studentNameSelector.TabIndex = 3;
            this.studentNameSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.studentNameSelector.ValueChanged += new System.EventHandler(this.studentNameSelector_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Form";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Student Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Award";
            // 
            // studentFormSelector
            // 
            this.studentFormSelector.Location = new System.Drawing.Point(141, 59);
            this.studentFormSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.studentFormSelector.Name = "studentFormSelector";
            this.studentFormSelector.Size = new System.Drawing.Size(33, 20);
            this.studentFormSelector.TabIndex = 7;
            this.studentFormSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.studentFormSelector.ValueChanged += new System.EventHandler(this.studentFormSelector_ValueChanged);
            // 
            // studentCodeSelector
            // 
            this.studentCodeSelector.Location = new System.Drawing.Point(262, 59);
            this.studentCodeSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.studentCodeSelector.Name = "studentCodeSelector";
            this.studentCodeSelector.Size = new System.Drawing.Size(33, 20);
            this.studentCodeSelector.TabIndex = 8;
            this.studentCodeSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.studentCodeSelector.ValueChanged += new System.EventHandler(this.studentCodeSelector_ValueChanged);
            // 
            // studentAwardSelector
            // 
            this.studentAwardSelector.Location = new System.Drawing.Point(363, 59);
            this.studentAwardSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.studentAwardSelector.Name = "studentAwardSelector";
            this.studentAwardSelector.Size = new System.Drawing.Size(33, 20);
            this.studentAwardSelector.TabIndex = 9;
            this.studentAwardSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.studentAwardSelector.ValueChanged += new System.EventHandler(this.studentAwardSelector_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exampleStudentAwardLabel);
            this.groupBox1.Controls.Add(this.exampleStudentCodeLabel);
            this.groupBox1.Controls.Add(this.exampleStudentFormLabel);
            this.groupBox1.Controls.Add(this.exampleStudentNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(19, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 81);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Example Student";
            // 
            // exampleStudentAwardLabel
            // 
            this.exampleStudentAwardLabel.AutoSize = true;
            this.exampleStudentAwardLabel.Location = new System.Drawing.Point(6, 59);
            this.exampleStudentAwardLabel.Name = "exampleStudentAwardLabel";
            this.exampleStudentAwardLabel.Size = new System.Drawing.Size(40, 13);
            this.exampleStudentAwardLabel.TabIndex = 3;
            this.exampleStudentAwardLabel.Text = "Award:";
            // 
            // exampleStudentCodeLabel
            // 
            this.exampleStudentCodeLabel.AutoSize = true;
            this.exampleStudentCodeLabel.Location = new System.Drawing.Point(7, 46);
            this.exampleStudentCodeLabel.Name = "exampleStudentCodeLabel";
            this.exampleStudentCodeLabel.Size = new System.Drawing.Size(35, 13);
            this.exampleStudentCodeLabel.TabIndex = 2;
            this.exampleStudentCodeLabel.Text = "Code:";
            // 
            // exampleStudentFormLabel
            // 
            this.exampleStudentFormLabel.AutoSize = true;
            this.exampleStudentFormLabel.Location = new System.Drawing.Point(7, 33);
            this.exampleStudentFormLabel.Name = "exampleStudentFormLabel";
            this.exampleStudentFormLabel.Size = new System.Drawing.Size(33, 13);
            this.exampleStudentFormLabel.TabIndex = 1;
            this.exampleStudentFormLabel.Text = "Form:";
            // 
            // exampleStudentNameLabel
            // 
            this.exampleStudentNameLabel.AutoSize = true;
            this.exampleStudentNameLabel.Location = new System.Drawing.Point(7, 20);
            this.exampleStudentNameLabel.Name = "exampleStudentNameLabel";
            this.exampleStudentNameLabel.Size = new System.Drawing.Size(38, 13);
            this.exampleStudentNameLabel.TabIndex = 0;
            this.exampleStudentNameLabel.Text = "Name:";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(348, 160);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 11;
            this.doneButton.Text = "Next";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // ExcelConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 195);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studentAwardSelector);
            this.Controls.Add(this.studentCodeSelector);
            this.Controls.Add(this.studentFormSelector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentNameSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.headingsBox);
            this.Controls.Add(this.label1);
            this.Name = "ExcelConfig";
            this.Text = "Excel Configuration";
            this.Load += new System.EventHandler(this.ExcelConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentNameSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFormSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCodeSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAwardSelector)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox headingsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown studentNameSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown studentFormSelector;
        private System.Windows.Forms.NumericUpDown studentCodeSelector;
        private System.Windows.Forms.NumericUpDown studentAwardSelector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label exampleStudentAwardLabel;
        private System.Windows.Forms.Label exampleStudentCodeLabel;
        private System.Windows.Forms.Label exampleStudentFormLabel;
        private System.Windows.Forms.Label exampleStudentNameLabel;
        private System.Windows.Forms.Button doneButton;
    }
}