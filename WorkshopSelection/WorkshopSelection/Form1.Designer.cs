namespace WorkshopSelection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.workshopListBox = new System.Windows.Forms.ListBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.lodgingLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "select two options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.workshopListBox);
            this.groupBox1.Location = new System.Drawing.Point(79, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.locationListBox);
            this.groupBox2.Location = new System.Drawing.Point(529, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 186);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // workshopListBox
            // 
            this.workshopListBox.FormattingEnabled = true;
            this.workshopListBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.workshopListBox.Location = new System.Drawing.Point(57, 44);
            this.workshopListBox.Name = "workshopListBox";
            this.workshopListBox.Size = new System.Drawing.Size(120, 95);
            this.workshopListBox.TabIndex = 0;
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.locationListBox.Location = new System.Drawing.Point(60, 44);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(120, 95);
            this.locationListBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lodging:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total:";
            // 
            // registrationLabel
            // 
            this.registrationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationLabel.Location = new System.Drawing.Point(304, 367);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(218, 23);
            this.registrationLabel.TabIndex = 6;
            this.registrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lodgingLabel
            // 
            this.lodgingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lodgingLabel.Location = new System.Drawing.Point(305, 425);
            this.lodgingLabel.Name = "lodgingLabel";
            this.lodgingLabel.Size = new System.Drawing.Size(217, 23);
            this.lodgingLabel.TabIndex = 7;
            this.lodgingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(305, 464);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(217, 23);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(170, 518);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(559, 518);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 590);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.lodgingLabel);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox workshopListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label lodgingLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

