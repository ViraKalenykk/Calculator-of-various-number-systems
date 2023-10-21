using System.Windows.Forms;

namespace ПЗ1_АКтКМ
{
	partial class TransferForm
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
			this.Exit_button = new System.Windows.Forms.Button();
			this.Back_button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Number_textBox = new System.Windows.Forms.TextBox();
			this.From_comboBox = new System.Windows.Forms.ComboBox();
			this.To_comboBox = new System.Windows.Forms.ComboBox();
			this.Transfer_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Exit_button
			// 
			this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Exit_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Exit_button.ForeColor = System.Drawing.Color.White;
			this.Exit_button.Location = new System.Drawing.Point(734, 26);
			this.Exit_button.Name = "Exit_button";
			this.Exit_button.Size = new System.Drawing.Size(38, 35);
			this.Exit_button.TabIndex = 4;
			this.Exit_button.Text = "Х";
			this.Exit_button.UseVisualStyleBackColor = true;
			this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
			// 
			// Back_button
			// 
			this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Back_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Back_button.ForeColor = System.Drawing.Color.White;
			this.Back_button.Location = new System.Drawing.Point(29, 26);
			this.Back_button.Name = "Back_button";
			this.Back_button.Size = new System.Drawing.Size(38, 35);
			this.Back_button.TabIndex = 6;
			this.Back_button.Text = "<";
			this.Back_button.UseVisualStyleBackColor = true;
			this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(289, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 42);
			this.label1.TabIndex = 7;
			this.label1.Text = "Перевести:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(94, 188);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 35);
			this.label2.TabIndex = 8;
			this.label2.Text = "з";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(436, 188);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(259, 35);
			this.label3.TabIndex = 9;
			this.label3.Text = "системи числення";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(94, 244);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 35);
			this.label4.TabIndex = 10;
			this.label4.Text = "в";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(436, 244);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(256, 35);
			this.label5.TabIndex = 11;
			this.label5.Text = "систему числення";
			// 
			// Number_textBox
			// 
			this.Number_textBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Number_textBox.Location = new System.Drawing.Point(242, 96);
			this.Number_textBox.Name = "Number_textBox";
			this.Number_textBox.Size = new System.Drawing.Size(288, 42);
			this.Number_textBox.TabIndex = 12;
			// 
			// From_comboBox
			// 
			this.From_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.From_comboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.From_comboBox.FormattingEnabled = true;
			this.From_comboBox.Items.AddRange(new object[] {
            "десяткова",
            "двійкова",
            "вісімкова"});
			this.From_comboBox.Location = new System.Drawing.Point(131, 180);
			this.From_comboBox.Name = "From_comboBox";
			this.From_comboBox.Size = new System.Drawing.Size(299, 43);
			this.From_comboBox.TabIndex = 13;
			// 
			// To_comboBox
			// 
			this.To_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.To_comboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.To_comboBox.FormattingEnabled = true;
			this.To_comboBox.Items.AddRange(new object[] {
            "десяткова",
            "двійкова",
            "вісімкова",
            "шістнадцяткова"});
			this.To_comboBox.Location = new System.Drawing.Point(131, 236);
			this.To_comboBox.Name = "To_comboBox";
			this.To_comboBox.Size = new System.Drawing.Size(299, 43);
			this.To_comboBox.TabIndex = 14;
			// 
			// Transfer_button
			// 
			this.Transfer_button.BackColor = System.Drawing.Color.Transparent;
			this.Transfer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Transfer_button.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Transfer_button.ForeColor = System.Drawing.Color.White;
			this.Transfer_button.Location = new System.Drawing.Point(280, 312);
			this.Transfer_button.Name = "Transfer_button";
			this.Transfer_button.Size = new System.Drawing.Size(232, 64);
			this.Transfer_button.TabIndex = 15;
			this.Transfer_button.Text = "Перевести";
			this.Transfer_button.UseVisualStyleBackColor = false;
			this.Transfer_button.Click += new System.EventHandler(this.Transfer_button_Click);
			// 
			// TransferForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.Transfer_button);
			this.Controls.Add(this.To_comboBox);
			this.Controls.Add(this.From_comboBox);
			this.Controls.Add(this.Number_textBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Back_button);
			this.Controls.Add(this.Exit_button);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "TransferForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TransferForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Exit_button;
		private System.Windows.Forms.Button Back_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Number_textBox;
		private System.Windows.Forms.ComboBox From_comboBox;
		private System.Windows.Forms.ComboBox To_comboBox;
		private Button Transfer_button;
	}
}