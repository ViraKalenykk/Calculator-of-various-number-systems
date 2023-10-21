namespace ПЗ1_АКтКМ
{
	partial class EnterForm
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
			this.Transfer_button = new System.Windows.Forms.Button();
			this.Calculus_button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Transfer_button
			// 
			this.Transfer_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.Transfer_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Transfer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Transfer_button.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Transfer_button.ForeColor = System.Drawing.Color.White;
			this.Transfer_button.Location = new System.Drawing.Point(121, 140);
			this.Transfer_button.Name = "Transfer_button";
			this.Transfer_button.Size = new System.Drawing.Size(232, 64);
			this.Transfer_button.TabIndex = 0;
			this.Transfer_button.Text = "Переведення";
			this.Transfer_button.UseVisualStyleBackColor = false;
			this.Transfer_button.Click += new System.EventHandler(this.button1_Click);
			// 
			// Calculus_button
			// 
			this.Calculus_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.Calculus_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Calculus_button.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Calculus_button.ForeColor = System.Drawing.Color.White;
			this.Calculus_button.Location = new System.Drawing.Point(121, 248);
			this.Calculus_button.Name = "Calculus_button";
			this.Calculus_button.Size = new System.Drawing.Size(232, 64);
			this.Calculus_button.TabIndex = 1;
			this.Calculus_button.Text = "Розрахування";
			this.Calculus_button.UseVisualStyleBackColor = false;
			this.Calculus_button.Click += new System.EventHandler(this.Calculus_button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(74, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(325, 42);
			this.label1.TabIndex = 2;
			this.label1.Text = "Оберіть операцію:";
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(398, 20);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(38, 35);
			this.button3.TabIndex = 3;
			this.button3.Text = "Х";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// EnterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(479, 394);
			this.ControlBox = false;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Calculus_button);
			this.Controls.Add(this.Transfer_button);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "EnterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Вхід";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Transfer_button;
		private System.Windows.Forms.Button Calculus_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
	}
}

