namespace StadtInfoTool
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
			this.button1 = new System.Windows.Forms.Button();
			this.Stadt1TB = new System.Windows.Forms.TextBox();
			this.Stadt2TB = new System.Windows.Forms.TextBox();
			this.Distance01 = new System.Windows.Forms.Label();
			this.Pop1 = new System.Windows.Forms.Label();
			this.Tz1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Pop0 = new System.Windows.Forms.Label();
			this.Tz0 = new System.Windows.Forms.Label();
			this.Stadt3TB = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Distance12 = new System.Windows.Forms.Label();
			this.Pop2 = new System.Windows.Forms.Label();
			this.Tz2 = new System.Windows.Forms.Label();
			this.Distance = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(29, 256);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(426, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Stadt1TB
			// 
			this.Stadt1TB.Location = new System.Drawing.Point(29, 75);
			this.Stadt1TB.Name = "Stadt1TB";
			this.Stadt1TB.Size = new System.Drawing.Size(146, 20);
			this.Stadt1TB.TabIndex = 1;
			// 
			// Stadt2TB
			// 
			this.Stadt2TB.Location = new System.Drawing.Point(181, 75);
			this.Stadt2TB.Name = "Stadt2TB";
			this.Stadt2TB.Size = new System.Drawing.Size(139, 20);
			this.Stadt2TB.TabIndex = 2;
			// 
			// Distance01
			// 
			this.Distance01.AutoSize = true;
			this.Distance01.Location = new System.Drawing.Point(26, 172);
			this.Distance01.Name = "Distance01";
			this.Distance01.Size = new System.Drawing.Size(223, 13);
			this.Distance01.TabIndex = 3;
			this.Distance01.Text = "Distanz zwischen den ersten beiden Städten: ";
			// 
			// Pop1
			// 
			this.Pop1.AutoSize = true;
			this.Pop1.Location = new System.Drawing.Point(178, 107);
			this.Pop1.Name = "Pop1";
			this.Pop1.Size = new System.Drawing.Size(73, 13);
			this.Pop1.TabIndex = 4;
			this.Pop1.Text = "Bevölkerung: ";
			// 
			// Tz1
			// 
			this.Tz1.AutoSize = true;
			this.Tz1.Location = new System.Drawing.Point(178, 134);
			this.Tz1.Name = "Tz1";
			this.Tz1.Size = new System.Drawing.Size(54, 13);
			this.Tz1.TabIndex = 5;
			this.Tz1.Text = "Zeitzone: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Erste Stadt";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(178, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Zweite Stadt";
			// 
			// Pop0
			// 
			this.Pop0.AutoSize = true;
			this.Pop0.Location = new System.Drawing.Point(26, 107);
			this.Pop0.Name = "Pop0";
			this.Pop0.Size = new System.Drawing.Size(73, 13);
			this.Pop0.TabIndex = 8;
			this.Pop0.Text = "Bevölkerung: ";
			// 
			// Tz0
			// 
			this.Tz0.AutoSize = true;
			this.Tz0.Location = new System.Drawing.Point(26, 134);
			this.Tz0.Name = "Tz0";
			this.Tz0.Size = new System.Drawing.Size(54, 13);
			this.Tz0.TabIndex = 9;
			this.Tz0.Text = "Zeitzone: ";
			// 
			// Stadt3TB
			// 
			this.Stadt3TB.Location = new System.Drawing.Point(326, 75);
			this.Stadt3TB.Name = "Stadt3TB";
			this.Stadt3TB.Size = new System.Drawing.Size(129, 20);
			this.Stadt3TB.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(323, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Dritte Stadt";
			// 
			// Distance12
			// 
			this.Distance12.AutoSize = true;
			this.Distance12.Location = new System.Drawing.Point(26, 197);
			this.Distance12.Name = "Distance12";
			this.Distance12.Size = new System.Drawing.Size(225, 13);
			this.Distance12.TabIndex = 12;
			this.Distance12.Text = "Distanz zwischen den letzten beiden Städten: ";
			// 
			// Pop2
			// 
			this.Pop2.AutoSize = true;
			this.Pop2.Location = new System.Drawing.Point(323, 107);
			this.Pop2.Name = "Pop2";
			this.Pop2.Size = new System.Drawing.Size(73, 13);
			this.Pop2.TabIndex = 13;
			this.Pop2.Text = "Bevölkerung: ";
			// 
			// Tz2
			// 
			this.Tz2.AutoSize = true;
			this.Tz2.Location = new System.Drawing.Point(323, 134);
			this.Tz2.Name = "Tz2";
			this.Tz2.Size = new System.Drawing.Size(54, 13);
			this.Tz2.TabIndex = 14;
			this.Tz2.Text = "Zeitzone: ";
			// 
			// Distance
			// 
			this.Distance.AutoSize = true;
			this.Distance.Location = new System.Drawing.Point(26, 220);
			this.Distance.Name = "Distance";
			this.Distance.Size = new System.Drawing.Size(228, 13);
			this.Distance.TabIndex = 15;
			this.Distance.Text = "Distanz zwischen der ersten und letzten Stadt: ";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(29, 300);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(426, 33);
			this.button2.TabIndex = 16;
			this.button2.Text = "Info Speichern";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 345);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Distance);
			this.Controls.Add(this.Tz2);
			this.Controls.Add(this.Pop2);
			this.Controls.Add(this.Distance12);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Stadt3TB);
			this.Controls.Add(this.Tz0);
			this.Controls.Add(this.Pop0);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Tz1);
			this.Controls.Add(this.Pop1);
			this.Controls.Add(this.Distance01);
			this.Controls.Add(this.Stadt2TB);
			this.Controls.Add(this.Stadt1TB);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StadtInfoTool";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox Stadt1TB;
		private System.Windows.Forms.TextBox Stadt2TB;
		private System.Windows.Forms.Label Distance01;
		private System.Windows.Forms.Label Pop1;
		private System.Windows.Forms.Label Tz1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label Pop0;
		private System.Windows.Forms.Label Tz0;
		private System.Windows.Forms.TextBox Stadt3TB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Distance12;
		private System.Windows.Forms.Label Pop2;
		private System.Windows.Forms.Label Tz2;
		private System.Windows.Forms.Label Distance;
		private System.Windows.Forms.Button button2;
	}
}

