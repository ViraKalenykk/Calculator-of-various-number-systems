using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПЗ1_АКтКМ
{
	public partial class EnterForm : Form
	{
		public EnterForm()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TransferForm transferForm = new TransferForm();
			transferForm.Show();
		}

		private void Calculus_button_Click(object sender, EventArgs e)
		{
			CalculusForm calculusForm = new CalculusForm();
			calculusForm.Show();
		}
	}
}
