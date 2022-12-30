using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3_Calculator
{
	public partial class Form1 : Form
	{
		public bool flag;
		public string tempParametr;
		public string act;
		public Form1()
		{
			InitializeComponent();
		}

		private void button19_Click(object sender, EventArgs e)
		{
			double firstVar, secondVar, result = 0;
			Double.TryParse(tempParametr, out firstVar);
			Double.TryParse(textBox1.Text, out secondVar);
			if (act == "+")
			{
				result = firstVar + secondVar;
			}
			if (act == "-")
			{
				result = firstVar - secondVar;
			}
			if (act == "*")
			{
				result = firstVar * secondVar;
			}
			if (act == "/" && secondVar != 0)
			{
				result = firstVar / secondVar;
			}
			if (act == "/" && secondVar == 0)
			{
				MessageBox.Show("Поділити на нуль неможливо!");
			}
			if (act == "%")
			{
				result = firstVar / 100;
			}
			textBox1.Text = result.ToString();
			flag = true;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			textBox1.Text = " ";
		}

		private void button12_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != " ")
			{
				textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
			}
			else
			{
				textBox1.Text = " "; //
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			Button buttonAct = (Button)sender;
			act = buttonAct.Text;
			tempParametr = textBox1.Text;
			flag = true;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Button numButton = (Button)sender;
			int tempNumber;
			bool isNum = int.TryParse(numButton.Text, out tempNumber);

			if (flag)
			{
				flag = false;
				textBox1.Text = " "; //
			}

			if (textBox1.Text == " " && isNum) //
			{
				textBox1.Text = numButton.Text;
			}
			else
			{
				if (!numButton.Text.Contains(","))
				{
					textBox1.Text = textBox1.Text + numButton.Text;
				}
				else
				{
					textBox1.Text = textBox1.Text + numButton.Text;
				}
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number))
			{
				e.Handled = true;
			}
		}
	}
}
