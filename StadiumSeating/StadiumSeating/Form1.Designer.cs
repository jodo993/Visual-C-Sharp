namespace StadiumSeating
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ticketSoldClassCTextBox = new System.Windows.Forms.TextBox();
            this.ticketSoldClassBTextBox = new System.Windows.Forms.TextBox();
            this.ticketSoldClassATextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.revenueGeneratedTotal = new System.Windows.Forms.Label();
            this.revenueGeneratedClassC = new System.Windows.Forms.Label();
            this.revenueGeneratedClassB = new System.Windows.Forms.Label();
            this.revenueGeneratedClassA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ticketSoldClassCTextBox);
            this.groupBox1.Controls.Add(this.ticketSoldClassBTextBox);
            this.groupBox1.Controls.Add(this.ticketSoldClassATextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticekts Sold";
            // 
            // ticketSoldClassCTextBox
            // 
            this.ticketSoldClassCTextBox.Location = new System.Drawing.Point(73, 126);
            this.ticketSoldClassCTextBox.Name = "ticketSoldClassCTextBox";
            this.ticketSoldClassCTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketSoldClassCTextBox.TabIndex = 6;
            this.ticketSoldClassCTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ticketSoldClassBTextBox
            // 
            this.ticketSoldClassBTextBox.Location = new System.Drawing.Point(73, 98);
            this.ticketSoldClassBTextBox.Name = "ticketSoldClassBTextBox";
            this.ticketSoldClassBTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketSoldClassBTextBox.TabIndex = 5;
            this.ticketSoldClassBTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ticketSoldClassATextBox
            // 
            this.ticketSoldClassATextBox.Location = new System.Drawing.Point(73, 67);
            this.ticketSoldClassATextBox.Name = "ticketSoldClassATextBox";
            this.ticketSoldClassATextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketSoldClassATextBox.TabIndex = 4;
            this.ticketSoldClassATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class A:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.revenueGeneratedTotal);
            this.groupBox2.Controls.Add(this.revenueGeneratedClassC);
            this.groupBox2.Controls.Add(this.revenueGeneratedClassB);
            this.groupBox2.Controls.Add(this.revenueGeneratedClassA);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(283, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // revenueGeneratedTotal
            // 
            this.revenueGeneratedTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueGeneratedTotal.Location = new System.Drawing.Point(70, 128);
            this.revenueGeneratedTotal.Name = "revenueGeneratedTotal";
            this.revenueGeneratedTotal.Size = new System.Drawing.Size(100, 23);
            this.revenueGeneratedTotal.TabIndex = 7;
            this.revenueGeneratedTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revenueGeneratedClassC
            // 
            this.revenueGeneratedClassC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueGeneratedClassC.Location = new System.Drawing.Point(70, 91);
            this.revenueGeneratedClassC.Name = "revenueGeneratedClassC";
            this.revenueGeneratedClassC.Size = new System.Drawing.Size(100, 23);
            this.revenueGeneratedClassC.TabIndex = 6;
            this.revenueGeneratedClassC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revenueGeneratedClassB
            // 
            this.revenueGeneratedClassB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueGeneratedClassB.Location = new System.Drawing.Point(70, 60);
            this.revenueGeneratedClassB.Name = "revenueGeneratedClassB";
            this.revenueGeneratedClassB.Size = new System.Drawing.Size(100, 23);
            this.revenueGeneratedClassB.TabIndex = 5;
            this.revenueGeneratedClassB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revenueGeneratedClassA
            // 
            this.revenueGeneratedClassA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueGeneratedClassA.Location = new System.Drawing.Point(70, 25);
            this.revenueGeneratedClassA.Name = "revenueGeneratedClassA";
            this.revenueGeneratedClassA.Size = new System.Drawing.Size(100, 23);
            this.revenueGeneratedClassA.TabIndex = 4;
            this.revenueGeneratedClassA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Class C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Class B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Class A:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(101, 229);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(82, 55);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(230, 229);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 55);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(353, 229);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 55);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 305);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ticketSoldClassCTextBox;
        private System.Windows.Forms.TextBox ticketSoldClassBTextBox;
        private System.Windows.Forms.TextBox ticketSoldClassATextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label revenueGeneratedTotal;
        private System.Windows.Forms.Label revenueGeneratedClassC;
        private System.Windows.Forms.Label revenueGeneratedClassB;
        private System.Windows.Forms.Label revenueGeneratedClassA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

