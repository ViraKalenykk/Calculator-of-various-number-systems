using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace ПЗ1_АКтКМ
{
	public partial class TransferForm : Form
	{
		public TransferForm()
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

		private void Transfer_button_Click(object sender, EventArgs e)
		{
			// Отримання значень з Number_textBox, From_comboBox і To_comboBox
			string numberStr = Number_textBox.Text;
			string fromBase = From_comboBox.Text;
			string toBase = To_comboBox.Text;

			string result = string.Empty;

			try
			{
				if (!int.TryParse(numberStr, out int number))
				{
					throw new ArgumentException("Введіть коректне число.");
				}

				if (fromBase == "десяткова")
				{
					if (toBase == "двійкова")
					{
						result = NumberConverter.ConvertFromDecimalToBinary(number);
					}
					else if (toBase == "вісімкова")
					{
						result = NumberConverter.ConvertFromDecimalToOctal(number);
					}
					else if (toBase == "шістнадцяткова")
					{
						result = NumberConverter.ConvertFromDecimalToHexadecimal(number);
					}
					else
					{
						result = NumberConverter.KeepNumberAsIs(numberStr);
					}
				}
				else if (fromBase == "двійкова")
				{
					if (toBase == "десяткова")
					{
						result = NumberConverter.ConvertFromBinaryToDecimal(numberStr).ToString();
					}
					else if (toBase == "вісімкова")
					{
						result = NumberConverter.ConvertFromBinaryToOctal(numberStr);
					}
					else if (toBase == "шістнадцяткова")
					{
						result = NumberConverter.ConvertFromBinaryToHexadecimal(numberStr);
					}
					else
					{
						result = NumberConverter.KeepNumberAsIs(numberStr);
					}
				}
				else if (fromBase == "вісімкова")
				{
					if (toBase == "десяткова")
					{
						result = NumberConverter.ConvertFromOctalToDecimal(numberStr).ToString();
					}
					else if (toBase == "двійкова")
					{
						result = NumberConverter.ConvertFromOctalToBinary(numberStr);
					}
					else if (toBase == "шістнадцяткова")
					{
						result = NumberConverter.ConvertFromOctalToHexadecimal(numberStr);
					}
					else
					{
						result = NumberConverter.KeepNumberAsIs(numberStr);
					}
				}

				MessageBox.Show($"Результат переведення: {result}", "Відповідь", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
	public class NumberConverter
	{
		public static string ConvertFromDecimalToBinary(int decimalNumber)
		{
			if (decimalNumber == 0)
			{
				return "0";
			}

			string binaryResult = "";
			while (decimalNumber > 0)
			{
				int remainder = decimalNumber % 2;
				binaryResult = remainder + binaryResult;
				decimalNumber /= 2;
			}

			return binaryResult;
		}

		public static string ConvertFromDecimalToOctal(int decimalNumber)
		{
			if (decimalNumber == 0)
			{
				return "0";
			}

			string octalResult = "";
			while (decimalNumber > 0)
			{
				int remainder = decimalNumber % 8;
				octalResult = remainder + octalResult;
				decimalNumber /= 8;
			}

			return octalResult;
		}

		public static string ConvertFromDecimalToHexadecimal(int decimalNumber)
		{
			if (decimalNumber == 0)
			{
				return "0";
			}

			string hexadecimalResult = "";
			char[] hexDigits = "0123456789ABCDEF".ToCharArray();

			while (decimalNumber > 0)
			{
				int remainder = decimalNumber % 16;
				hexadecimalResult = hexDigits[remainder] + hexadecimalResult;
				decimalNumber /= 16;
			}

			return hexadecimalResult;
		}

		public static int ConvertFromBinaryToDecimal(string binaryNumber)
		{
			if (string.IsNullOrWhiteSpace(binaryNumber))
			{
				throw new ArgumentException("Введіть коректне двійкове число.");
			}

			int decimalNumber = 0;
			int baseValue = 1;

			for (int i = binaryNumber.Length - 1; i >= 0; i--)
			{
				char binaryDigit = binaryNumber[i];

				if (binaryDigit != '0' && binaryDigit != '1')
				{
					throw new ArgumentException("Введіть коректне двійкове число.");
				}

				decimalNumber += (binaryDigit - '0') * baseValue;
				baseValue *= 2;
			}

			return decimalNumber;
		}

		public static string ConvertFromBinaryToOctal(string binaryNumber)
		{
			if (string.IsNullOrWhiteSpace(binaryNumber))
			{
				throw new ArgumentException("Введіть коректне двійкове число.");
			}

			// Доповнюємо двійковий рядок, якщо кількість бітів не кратна 3
			while (binaryNumber.Length % 3 != 0)
			{
				binaryNumber = "0" + binaryNumber;
			}

			StringBuilder octalNumber = new StringBuilder();
			int tripletValue = 0;
			int baseValue = 1;

			for (int i = binaryNumber.Length - 1; i >= 0; i--)
			{
				char binaryDigit = binaryNumber[i];

				if (binaryDigit != '0' && binaryDigit != '1')
				{
					throw new ArgumentException("Введіть коректне двійкове число.");
				}

				tripletValue += (binaryDigit - '0') * baseValue;
				baseValue *= 2;

				if (i % 3 == 0)
				{
					octalNumber.Insert(0, tripletValue);
					tripletValue = 0;
					baseValue = 1;
				}
			}
			return octalNumber.ToString();
		}

		public static string ConvertFromBinaryToHexadecimal(string binaryNumber)
		{
			if (string.IsNullOrWhiteSpace(binaryNumber))
			{
				throw new ArgumentException("Введіть коректне двійкове число.");
			}

			// Доповнюємо двійковий рядок, якщо кількість бітів не кратна 4
			while (binaryNumber.Length % 4 != 0)
			{
				binaryNumber = "0" + binaryNumber;
			}

			StringBuilder hexadecimalNumber = new StringBuilder();
			int tetradValue = 0;
			int baseValue = 1;

			for (int i = binaryNumber.Length - 1; i >= 0; i--)
			{
				char binaryDigit = binaryNumber[i];

				if (binaryDigit != '0' && binaryDigit != '1')
				{
					throw new ArgumentException("Введіть коректне двійкове число.");
				}

				tetradValue += (binaryDigit - '0') * baseValue;
				baseValue *= 2;

				if (i % 4 == 0)
				{
					hexadecimalNumber.Insert(0, GetHexadecimalDigit(tetradValue));
					tetradValue = 0;
					baseValue = 1;
				}
			}

			return hexadecimalNumber.ToString();
		}

		private static char GetHexadecimalDigit(int value)
		{
			if (value >= 0 && value <= 9)
			{
				return (char)('0' + value);
			}
			else if (value >= 10 && value <= 15)
			{
				return (char)('A' + value - 10);
			}
			else
			{
				throw new ArgumentException("Помилка при перетворенні в шістнадцятковий формат.");
			}
		}

		public static int ConvertFromOctalToDecimal(string octalNumber)
		{
			int decimalNumber = 0;
			int baseValue = 1;

			for (int i = octalNumber.Length - 1; i >= 0; i--)
			{
				decimalNumber += (octalNumber[i] - '0') * baseValue;
				baseValue *= 8;
			}

			return decimalNumber;
		}

		public static string ConvertFromOctalToBinary(string octalNumber)
		{
			if (string.IsNullOrWhiteSpace(octalNumber))
			{
				throw new ArgumentException("Введіть коректне вісімкове число.");
			}

			StringBuilder binaryNumber = new StringBuilder();

			foreach (char octalDigit in octalNumber)
			{
				if (octalDigit < '0' || octalDigit > '7')
				{
					throw new ArgumentException("Введіть коректне вісімкове число.");
				}

				// Конвертуємо кожну цифру вісімкового числа у відповідний двійковий рядок (заповнення нулями, якщо потрібно)
				string binaryDigit = ConvertOctalDigitToBinary(octalDigit);
				binaryNumber.Append(binaryDigit);
			}

			return binaryNumber.ToString();
		}

		private static string ConvertOctalDigitToBinary(char octalDigit)
		{
			int digitValue = octalDigit - '0';
			string binaryDigit = Convert.ToString(digitValue, 2);

			// Заповнюємо нулями, якщо довжина менше 3
			while (binaryDigit.Length < 3)
			{
				binaryDigit = "0" + binaryDigit;
			}

			return binaryDigit;
		}


		public static string ConvertFromOctalToHexadecimal(string octalNumber)
		{
			int decimalNumber = ConvertFromOctalToDecimal(octalNumber);
			return ConvertFromDecimalToHexadecimal(decimalNumber);
		}

		// Функція для збереження числа відразу
		public static string KeepNumberAsIs(string number)
		{
			return number;
		}
	}
}
