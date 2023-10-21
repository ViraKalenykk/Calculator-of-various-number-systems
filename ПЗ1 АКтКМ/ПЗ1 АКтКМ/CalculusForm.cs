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
	public partial class CalculusForm : Form
	{
		public CalculusForm()
		{
			InitializeComponent();
		}

		private void Exit_button_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Back_button_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Calculus_button_Click(object sender, EventArgs e)
		{
			string operation = Operation_comboBox.SelectedItem.ToString();
			string number1 = Number1_textBox.Text;
			string number2 = Number2_textBox.Text;
			string baseSystem = Base_comboBox.SelectedItem.ToString();
			string result = "";

			// Перевірка і виконання операцій в двійковій системі числення
			if (baseSystem == "двійкова")
			{
				if (operation == "додавання")
				{
					result = BinaryAddition(number1, number2);
				}
				else if (operation == "віднімання")
				{
					result = BinarySubtraction(number1, number2);
				}
				else if (operation == "множення")
				{
					result = BinaryMultiplication(number1, number2);
				}
			}
			// Перевірка і виконання операцій в десятковій системі числення
			else if (baseSystem == "десяткова")
			{
				if (operation == "додавання")
				{
					result = DecimalAddition(number1, number2);
				}
				else if (operation == "віднімання")
				{
					result = DecimalSubtraction(number1, number2);
				}
				else if (operation == "множення")
				{
					result = DecimalMultiplication(number1, number2);
				}
			}
			// Перевірка і виконання операцій в вісімковій системі числення
			else if (baseSystem == "вісімкова")
			{
				if (operation == "додавання")
				{
					result = OctalAddition(number1, number2);
				}
				else if (operation == "віднімання")
				{
					result = OctalSubtraction(number1, number2);
				}
				else if (operation == "множення")
				{
					result = OctalMultiplication(number1, number2);
				}
			}

			MessageBox.Show($"Результат обчислення: {result}", "Відповідь", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		// Функція для додавання в двійковій системі числення
		private string BinaryAddition(string binary1, string binary2)
		{
			int maxLength = Math.Max(binary1.Length, binary2.Length);

			// Доповнюємо рядки нулями до однакової довжини
			binary1 = binary1.PadLeft(maxLength, '0');
			binary2 = binary2.PadLeft(maxLength, '0');

			StringBuilder result = new StringBuilder();
			int carry = 0;

			for (int i = maxLength - 1; i >= 0; i--)
			{
				int bit1 = binary1[i] - '0';
				int bit2 = binary2[i] - '0';

				int sum = bit1 + bit2 + carry;

				result.Insert(0, sum % 2);
				carry = sum / 2;
			}

			if (carry > 0)
			{
				result.Insert(0, carry);
			}

			return result.ToString();
		}


		// Функція для віднімання в двійковій системі числення
		private string BinarySubtraction(string binary1, string binary2)
		{
			int maxLength = Math.Max(binary1.Length, binary2.Length);

			// Доповнюємо рядки нулями до однакової довжини
			binary1 = binary1.PadLeft(maxLength, '0');
			binary2 = binary2.PadLeft(maxLength, '0');

			StringBuilder result = new StringBuilder();
			int borrow = 0;

			for (int i = maxLength - 1; i >= 0; i--)
			{
				int bit1 = binary1[i] - '0';
				int bit2 = binary2[i] - '0';

				int diff = bit1 - bit2 - borrow;

				if (diff < 0)
				{
					diff += 2;
					borrow = 1;
				}
				else
				{
					borrow = 0;
				}

				result.Insert(0, diff);
			}

			return result.ToString().TrimStart('0');
		}


		// Функція для множення в двійковій системі числення
		private string BinaryMultiplication(string binary1, string binary2)
		{
			int length1 = binary1.Length;
			int length2 = binary2.Length;

			// Створюємо двовимірний масив для зберігання проміжних результатів множення
			int[,] products = new int[length1, length2];

			// Заповнюємо масив значеннями, де products[i, j] представляє добуток біта i з binary1 на біт j з binary2
			for (int i = 0; i < length1; i++)
			{
				for (int j = 0; j < length2; j++)
				{
					int bit1 = binary1[i] - '0';
					int bit2 = binary2[j] - '0';
					products[i, j] = bit1 * bit2;
				}
			}

			// Створюємо масив для зберігання результатів додавання колонок
			int[] columnSums = new int[length1 + length2];

			// Сумуємо значення з кожної колонки
			for (int i = 0; i < length1; i++)
			{
				for (int j = 0; j < length2; j++)
				{
					columnSums[i + j] += products[i, j];
				}
			}

			// Виконуємо переноси з колонок
			int carry = 0;
			StringBuilder result = new StringBuilder();

			for (int i = columnSums.Length - 1; i >= 0; i--)
			{
				int sum = columnSums[i] + carry;
				result.Insert(0, sum % 2);
				carry = sum / 2;
			}

			return result.ToString().TrimStart('0');
		}

		// Функція для додавання в десятковій системі числення
		private string DecimalAddition(string decimal1, string decimal2)
		{
			int maxLength = Math.Max(decimal1.Length, decimal2.Length);

			// Доповнюємо рядки нулями до однакової довжини
			decimal1 = decimal1.PadLeft(maxLength, '0');
			decimal2 = decimal2.PadLeft(maxLength, '0');

			StringBuilder result = new StringBuilder();
			int carry = 0;

			for (int i = maxLength - 1; i >= 0; i--)
			{
				int digit1 = decimal1[i] - '0';
				int digit2 = decimal2[i] - '0';

				int sum = digit1 + digit2 + carry;

				result.Insert(0, sum % 10);
				carry = sum / 10;
			}

			if (carry > 0)
			{
				result.Insert(0, carry);
			}

			return result.ToString();
		}

		// Функція для віднімання в десятковій системі числення
		private string DecimalSubtraction(string decimal1, string decimal2)
		{
			int maxLength = Math.Max(decimal1.Length, decimal2.Length);

			// Доповнюємо рядки нулями до однакової довжини
			decimal1 = decimal1.PadLeft(maxLength, '0');
			decimal2 = decimal2.PadLeft(maxLength, '0');

			StringBuilder result = new StringBuilder();
			int borrow = 0;

			for (int i = maxLength - 1; i >= 0; i--)
			{
				int digit1 = decimal1[i] - '0';
				int digit2 = decimal2[i] - '0';

				int diff = digit1 - digit2 - borrow;

				if (diff < 0)
				{
					diff += 10;
					borrow = 1;
				}
				else
				{
					borrow = 0;
				}

				result.Insert(0, diff);
			}

			return result.ToString().TrimStart('0');
		}

		// Функція для множення в десятковій системі числення
		// Функція для множення в десятковій системі числення
		private string DecimalMultiplication(string decimal1, string decimal2)
		{
			// Перетворюємо вхідні рядки у масиви зворотнього порядку
			char[] array1 = decimal1.ToCharArray();
			Array.Reverse(array1);
			char[] array2 = decimal2.ToCharArray();
			Array.Reverse(array2);

			// Масив для збереження проміжних результатів
			int[] intermediateResults = new int[array1.Length + array2.Length];

			// Виконуємо множення
			for (int i = 0; i < array1.Length; i++)
			{
				for (int j = 0; j < array2.Length; j++)
				{
					int digit1 = array1[i] - '0';
					int digit2 = array2[j] - '0';
					int product = digit1 * digit2;
					intermediateResults[i + j] += product;
				}
			}

			// Виконуємо переноси
			int carry = 0;
			for (int i = 0; i < intermediateResults.Length; i++)
			{
				intermediateResults[i] += carry;
				carry = intermediateResults[i] / 10;
				intermediateResults[i] %= 10;
			}

			// Перетворюємо результат назад у рядок зворотнього порядку
			StringBuilder result = new StringBuilder();
			for (int i = intermediateResults.Length - 1; i >= 0; i--)
			{
				result.Append(intermediateResults[i]);
			}

			return result.ToString().TrimStart('0');
		}

		// Функція для додавання в вісімковій системі числення
		private string OctalAddition(string octal1, string octal2)
		{
			int maxLength = Math.Max(octal1.Length, octal2.Length);

			// Доповнюємо рядки нулями до однакової довжини
			octal1 = octal1.PadLeft(maxLength, '0');
			octal2 = octal2.PadLeft(maxLength, '0');

			StringBuilder result = new StringBuilder();
			int carry = 0;

			for (int i = maxLength - 1; i >= 0; i--)
			{
				int digit1 = octal1[i] - '0';
				int digit2 = octal2[i] - '0';

				int sum = digit1 + digit2 + carry;

				if (sum >= 8)
				{
					carry = 1;
					sum -= 8;
				}
				else
				{
					carry = 0;
				}

				result.Insert(0, sum);
			}

			if (carry > 0)
			{
				result.Insert(0, carry);
			}

			return result.ToString();
		}

		// Функція для віднімання в вісімковій системі числення
		private string OctalSubtraction(string octal1, string octal2)
		{
			int maxLength = Math.Max(octal1.Length, octal2.Length);

			// Доповнюємо рядки нулями до однакової довжини
			octal1 = octal1.PadLeft(maxLength, '0');
			octal2 = octal2.PadLeft(maxLength, '0');

			StringBuilder result = new StringBuilder();
			int borrow = 0;

			for (int i = maxLength - 1; i >= 0; i--)
			{
				int digit1 = octal1[i] - '0';
				int digit2 = octal2[i] - '0';

				int diff = digit1 - digit2 - borrow;

				if (diff < 0)
				{
					diff += 8;
					borrow = 1;
				}
				else
				{
					borrow = 0;
				}

				result.Insert(0, diff);
			}

			return result.ToString();
		}


		// Функція для множення в вісімковій системі числення
		// Функція для множення в вісімковій системі числення
		private string OctalMultiplication(string octal1, string octal2)
		{
			// Перетворюємо вхідні рядки у масиви зворотнього порядку
			char[] array1 = octal1.ToCharArray();
			Array.Reverse(array1);
			char[] array2 = octal2.ToCharArray();
			Array.Reverse(array2);

			// Масив для збереження проміжних результатів
			int[] intermediateResults = new int[array1.Length + array2.Length];

			// Виконуємо множення
			for (int i = 0; i < array1.Length; i++)
			{
				for (int j = 0; j < array2.Length; j++)
				{
					int digit1 = array1[i] - '0';
					int digit2 = array2[j] - '0';
					int product = digit1 * digit2;
					intermediateResults[i + j] += product;
				}
			}

			// Виконуємо переноси
			int carry = 0;
			for (int i = 0; i < intermediateResults.Length; i++)
			{
				intermediateResults[i] += carry;
				carry = intermediateResults[i] / 8;
				intermediateResults[i] %= 8;
			}

			// Перетворюємо результат назад у рядок зворотнього порядку
			StringBuilder result = new StringBuilder();
			for (int i = intermediateResults.Length - 1; i >= 0; i--)
			{
				result.Append(intermediateResults[i]);
			}

			return result.ToString().TrimStart('0');
		}
	}
}
