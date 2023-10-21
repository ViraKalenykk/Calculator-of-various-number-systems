namespace ПЗ1_АКтКМ
{
	partial class CalculusForm
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
			this.Base_comboBox = new System.Windows.Forms.ComboBox();
			this.Number1_textBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Operation_comboBox = new System.Windows.Forms.ComboBox();
			this.Number2_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Calculus_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Exit_button
			// 
			this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Exit_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Exit_button.ForeColor = System.Drawing.Color.White;
			this.Exit_button.Location = new System.Drawing.Point(733, 24);
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
			this.Back_button.Location = new System.Drawing.Point(26, 24);
			this.Back_button.Name = "Back_button";
			this.Back_button.Size = new System.Drawing.Size(38, 35);
			this.Back_button.TabIndex = 5;
			this.Back_button.Text = "<";
			this.Back_button.UseVisualStyleBackColor = true;
			this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
			// 
			// Base_comboBox
			// 
			this.Base_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Base_comboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Base_comboBox.FormattingEnabled = true;
			this.Base_comboBox.Items.AddRange(new object[] {
            "десяткова",
            "двійкова",
            "вісімкова"});
			this.Base_comboBox.Location = new System.Drawing.Point(152, 281);
			this.Base_comboBox.Name = "Base_comboBox";
			this.Base_comboBox.Size = new System.Drawing.Size(299, 43);
			this.Base_comboBox.TabIndex = 22;
			// 
			// Number1_textBox
			// 
			this.Number1_textBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Number1_textBox.Location = new System.Drawing.Point(342, 151);
			this.Number1_textBox.Name = "Number1_textBox";
			this.Number1_textBox.Size = new System.Drawing.Size(288, 42);
			this.Number1_textBox.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(457, 289);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(250, 35);
			this.label5.TabIndex = 19;
			this.label5.Text = "системі числення";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(115, 289);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 35);
			this.label4.TabIndex = 18;
			this.label4.Text = "в";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(214, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(357, 42);
			this.label1.TabIndex = 15;
			this.label1.Text = "Виконати операцію:";
			// 
			// Operation_comboBox
			// 
			this.Operation_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Operation_comboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Operation_comboBox.FormattingEnabled = true;
			this.Operation_comboBox.Items.AddRange(new object[] {
            "додавання",
            "віднімання",
            "множення"});
			this.Operation_comboBox.Location = new System.Drawing.Point(239, 80);
			this.Operation_comboBox.Name = "Operation_comboBox";
			this.Operation_comboBox.Size = new System.Drawing.Size(299, 43);
			this.Operation_comboBox.TabIndex = 23;
			// 
			// Number2_textBox
			// 
			this.Number2_textBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Number2_textBox.Location = new System.Drawing.Point(342, 210);
			this.Number2_textBox.Name = "Number2_textBox";
			this.Number2_textBox.Size = new System.Drawing.Size(288, 42);
			this.Number2_textBox.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(187, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 35);
			this.label2.TabIndex = 25;
			this.label2.Text = "Число 1:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(187, 217);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 35);
			this.label3.TabIndex = 26;
			this.label3.Text = "Число 2:";
			// 
			// Calculus_button
			// 
			this.Calculus_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.Calculus_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Calculus_button.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Calculus_button.ForeColor = System.Drawing.Color.White;
			this.Calculus_button.Location = new System.Drawing.Point(287, 344);
			this.Calculus_button.Name = "Calculus_button";
			this.Calculus_button.Size = new System.Drawing.Size(232, 64);
			this.Calculus_button.TabIndex = 27;
			this.Calculus_button.Text = "Розрахувати";
			this.Calculus_button.UseVisualStyleBackColor = false;
			this.Calculus_button.Click += new System.EventHandler(this.Calculus_button_Click);
			// 
			// CalculusForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(800, 470);
			this.ControlBox = false;
			this.Controls.Add(this.Calculus_button);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Number2_textBox);
			this.Controls.Add(this.Operation_comboBox);
			this.Controls.Add(this.Base_comboBox);
			this.Controls.Add(this.Number1_textBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Back_button);
			this.Controls.Add(this.Exit_button);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "CalculusForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CalculusForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Exit_button;
		private System.Windows.Forms.Button Back_button;
		private System.Windows.Forms.ComboBox Base_comboBox;
		private System.Windows.Forms.TextBox Number1_textBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Operation_comboBox;
		private System.Windows.Forms.TextBox Number2_textBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Calculus_button;
	}
}