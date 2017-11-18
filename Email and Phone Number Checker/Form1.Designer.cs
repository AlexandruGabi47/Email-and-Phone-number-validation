namespace WFProject
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
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ApplyButton = new System.Windows.Forms.Button();
			this.ValidationLabel = new System.Windows.Forms.Label();
			this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(15, 25);
			this.EmailTextBox.MaxLength = 255;
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(333, 20);
			this.EmailTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "E-Mail:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Phone Number:";
			// 
			// ApplyButton
			// 
			this.ApplyButton.Location = new System.Drawing.Point(12, 90);
			this.ApplyButton.Name = "ApplyButton";
			this.ApplyButton.Size = new System.Drawing.Size(336, 23);
			this.ApplyButton.TabIndex = 4;
			this.ApplyButton.Text = "Apply";
			this.ApplyButton.UseVisualStyleBackColor = true;
			this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
			// 
			// ValidationLabel
			// 
			this.ValidationLabel.AutoSize = true;
			this.ValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ValidationLabel.Location = new System.Drawing.Point(12, 125);
			this.ValidationLabel.Name = "ValidationLabel";
			this.ValidationLabel.Size = new System.Drawing.Size(0, 17);
			this.ValidationLabel.TabIndex = 5;
			// 
			// PhoneNumberTextBox
			// 
			this.PhoneNumberTextBox.Location = new System.Drawing.Point(12, 64);
			this.PhoneNumberTextBox.MaxLength = 10;
			this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
			this.PhoneNumberTextBox.Size = new System.Drawing.Size(99, 20);
			this.PhoneNumberTextBox.TabIndex = 1;
			this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 254);
			this.Controls.Add(this.ValidationLabel);
			this.Controls.Add(this.ApplyButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PhoneNumberTextBox);
			this.Controls.Add(this.EmailTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button ApplyButton;
		private System.Windows.Forms.Label ValidationLabel;
		private System.Windows.Forms.TextBox PhoneNumberTextBox;
	}
}

