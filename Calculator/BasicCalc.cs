using System;
/* using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; */
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace Calculator
{
	public partial class Calculator : Form {
		[DllImport("user32.dll")]
		static extern bool HideCaret(IntPtr hWnd);

		public Calculator() {
			InitializeComponent();
			this.KeyPreview = true;
			this.KeyPress += new KeyPressEventHandler(Calculator_KeyPress);
			this.txtbox_result.GotFocus += new EventHandler(txtbox_result_GotFocus);
			txtbox_result.Focus();
		}

		void Calculator_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar >= (char) Keys.D0 && e.KeyChar <= (char) Keys.D9) {
				switch (e.KeyChar) {
				case (char) Keys.D0:
					{
						btn_0_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) Keys.D1:
					{
						btn_1_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) Keys.D2:
					{
						btn_2_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) Keys.D3:
					{
						btn_3_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) Keys.D4:
					{
						btn_4_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) Keys.D5:
					{
						btn_5_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) Keys.D6:
					{
						btn_6_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) Keys.D7:
					{
						btn_7_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) Keys.D8:
					{
						btn_8_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) Keys.D9:
					{
						btn_9_Click(sender, e);
						e.Handled = true;
					} break;
				}
			} else {
				switch (e.KeyChar) {
				case (char) 61:  // '='
				case (char) 13:  // '\r'
					{
						txtbox_result.Focus();
						btn_equal_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) Keys.Back:
					{
						btn_backspace_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) 43:  // '+'
					{
						btn_add_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) 45:  // '-'
					{
						btn_subtract_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) 42:  // '*'
					{
						btn_multiply_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) 47:  // '/'
					{
						btn_divide_Click(sender, e);
						e.Handled = true;
					} break;

				case (char) 46:  // '.'
					{
						btn_period_Click(sender, e);
						e.Handled = true;
					} break;
				}
			}
		}

		void txtbox_result_GotFocus(object sender, EventArgs e) {
			HideCaret(this.txtbox_result.Handle);
		}

		private string expression = "";
		private bool chained = false;
		private double op1 = 0.0;
		private double op2 = 0.0;
		private double res = 0.0;
		private enum LastButton { NONE, DIGIT, OPERATION, EQUAL, MEMORY };
		private enum Operation { NONE, ADD, SUBTRACT, MULTIPLY, DIVIDE };
		private LastButton LB = LastButton.NONE;
		private Operation OP = Operation.NONE;
		private double memory = 0.0;

        private void btn_1_Click(object sender, EventArgs e) {
			if (LB != LastButton.DIGIT) {
				txtbox_result.ResetText();
			}

			if (LB == LastButton.EQUAL) {
				op1 = op2 = 0.0;
				lbl_expr.Text = "";
				chained = false;
			}

			if (LB == LastButton.DIGIT && txtbox_result.Text != "0") {
				if (txtbox_result.TextLength < 12) {
					txtbox_result.AppendText("1");
				} else {
					// max length of input is 12 characters
					SystemSounds.Beep.Play();
				}
			} else {
				txtbox_result.Text = "1";
			}

			LB = LastButton.DIGIT;
        }

		private void btn_2_Click(object sender, EventArgs e) {
			if (LB != LastButton.DIGIT) {
				txtbox_result.ResetText();
			}

			if (LB == LastButton.EQUAL) {
				op1 = op2 = 0.0;
				lbl_expr.Text = "";
				chained = false;
			}

			if (LB == LastButton.DIGIT && txtbox_result.Text != "0") {
				if (txtbox_result.TextLength < 12) {
					txtbox_result.AppendText("2");
				} else {
					// max length of input is 12 characters
					SystemSounds.Beep.Play();
				}
			} else {
				txtbox_result.Text = "2";
			}

			LB = LastButton.DIGIT;
		}

		private void btn_3_Click(object sender, EventArgs e) {
			if (LB != LastButton.DIGIT) {
				txtbox_result.ResetText();
			}

			if (LB == LastButton.EQUAL) {
				op1 = op2 = 0.0;
				lbl_expr.Text = "";
				chained = false;
			}

			if (LB == LastButton.DIGIT && txtbox_result.Text != "0") {
				if (txtbox_result.TextLength < 12) {
					txtbox_result.AppendText("3");
				} else {
					// max length of input is 12 characters
					SystemSounds.Beep.Play();
				}
			} else {
				txtbox_result.Text = "3";
			}

			LB = LastButton.DIGIT;
		}

		private void btn_4_Click(object sender, EventArgs e) {
			if (LB != LastButton.DIGIT) {
				txtbox_result.ResetText();
			}

			if (LB == LastButton.EQUAL) {
				op1 = op2 = 0.0;
				lbl_expr.Text = "";
				chained = false;
			}

			if (LB == LastButton.DIGIT && txtbox_result.Text != "0") {
				if (txtbox_result.TextLength < 12) {
					txtbox_result.AppendText("4");
				} else {
					// max length of input is 12 characters
					SystemSounds.Beep.Play();
				}
			} else {
				txtbox_result.Text = "4";
			}

			LB = LastButton.DIGIT;
		}

		private void btn_5_Click(object sender, EventArgs e) {
			if (LB != LastButton.DIGIT) {
				txtbox_result.ResetText();
			}

			if (LB == LastButton.EQUAL) {
				op1 = op2 = 0.0;
				lbl_expr.Text = "";
				chained = false;
			}

			if (LB == LastButton.DIGIT && txtbox_result.Text != "0") {
				if (txtbox_result.TextLength < 12) {
					txtbox_result.AppendText("5");
				} else {
					// max length of input is 12 characters
					SystemSounds.Beep.Play();
				}
			} else {
				txtbox_result.Text = "5";
			}

			LB = LastButton.DIGIT;
		}

		private void btn_6_Click(object sender, EventArgs e) {
			if (LB != LastButton.DIGIT) {
				txtbox_result.ResetText();
			}

			if (LB == LastButton.EQUAL || LB == LastButton.MEMORY) {
				op1 = op2 = 0.0;
				lbl_expr.Text = "";
				chained = false;
			}

			if (LB == LastButton.DIGIT && txtbox_result.Text != "0") {
				if (txtbox_result.TextLength < 12) {
					txtbox_result.AppendText("6");
				} else {
					// max length of input is 12 characters
					SystemSounds.Beep.Play();
				}
			} else {
				txtbox_result.Text = "6";
			}

			LB = LastButton.DIGIT;
		}

		private void btn_7_Click(object sender, EventArgs e) {
			if (LB != LastButton.DIGIT) {
				txtbox_result.ResetText();
			}

			if (LB == LastButton.EQUAL) {
				op1 = op2 = 0.0;
				lbl_expr.Text = "";
				chained = false;
			}

			if (LB == LastButton.DIGIT && txtbox_result.Text != "0") {
				if (txtbox_result.TextLength < 12) {
					txtbox_result.AppendText("7");
				} else {
					// max length of input is 12 characters
					SystemSounds.Beep.Play();
				}
			} else {
				txtbox_result.Text = "7";
			}

			LB = LastButton.DIGIT;
		}

		private void btn_8_Click(object sender, EventArgs e) {
			if (LB != LastButton.DIGIT) {
				txtbox_result.ResetText();
			}

			if (LB == LastButton.EQUAL) {
				op1 = op2 = 0.0;
				lbl_expr.Text = "";
				chained = false;
			}

			if (LB == LastButton.DIGIT && txtbox_result.Text != "0") {
				if (txtbox_result.TextLength < 12) {
					txtbox_result.AppendText("8");
				} else {
					// max length of input is 12 characters
					SystemSounds.Beep.Play();
				}
			} else {
				txtbox_result.Text = "8";
			}

			LB = LastButton.DIGIT;
		}

		private void btn_9_Click(object sender, EventArgs e) {
			if (LB != LastButton.DIGIT) {
				txtbox_result.ResetText();
			}

			if (LB == LastButton.EQUAL) {
				op1 = op2 = 0.0;
				lbl_expr.Text = "";
				chained = false;
			}

			if (LB == LastButton.DIGIT && txtbox_result.Text != "0") {
				if (txtbox_result.TextLength < 12) {
					txtbox_result.AppendText("9");
				} else {
					// max length of input is 12 characters
					SystemSounds.Beep.Play();
				}
			} else {
				txtbox_result.Text = "9";
			}

			LB = LastButton.DIGIT;
		}

		private void btn_0_Click(object sender, EventArgs e) {
			if (LB != LastButton.DIGIT) {
				txtbox_result.ResetText();
			}

			if (LB == LastButton.EQUAL) {
				op1 = op2 = 0.0;
				lbl_expr.Text = "";
				chained = false;
			}

			if (txtbox_result.Text.IndexOf('0') != 0) {
				if (txtbox_result.TextLength < 12) {
					txtbox_result.AppendText("0");
				} else {
					SystemSounds.Beep.Play();
				}
			}

			LB = LastButton.DIGIT;
		}

		private void btn_period_Click(object sender, EventArgs e) {
			if (LB == LastButton.DIGIT || LB == LastButton.NONE) {
				if (txtbox_result.Text.Contains(".")) {
					// issue system beep sound to indicate error
					SystemSounds.Beep.Play();
				} else {
					txtbox_result.AppendText(".");
				}
			} else if (LB == LastButton.EQUAL) {
				op1 = op2 = 0.0;
				txtbox_result.Text = ".";
				lbl_expr.Text = "";
				chained = false;
			} else if (LB == LastButton.OPERATION) {
				txtbox_result.Text = ".";
			}

			LB = LastButton.DIGIT;
		}

		private void btn_backspace_Click(object sender, EventArgs e) {
			if (LB == LastButton.OPERATION) {
				// indicate user cannot do this
				SystemSounds.Beep.Play();
			} else if (LB != LastButton.EQUAL) {
				if (txtbox_result.TextLength != 0 && txtbox_result.Text != "0") {
					if (txtbox_result.TextLength == 1) {
						txtbox_result.Text = "0";
					} else {
						txtbox_result.Text = txtbox_result.Text.Substring(0, txtbox_result.TextLength - 1);
					}
				}
			} else {
				txtbox_result.Text = "0";
			}
		}

		private void btn_clear_Click(object sender, EventArgs e) {
			// reset input
			txtbox_result.Text = "0";
			lbl_expr.ResetText();
			chained = false;
			LB = LastButton.NONE;
		}

		private void btn_add_Click(object sender, EventArgs e) {
			double D = 0.0;
			expression = lbl_expr.Text;

			// attempt parse and store in local D
			if (double.TryParse(txtbox_result.Text, out D)) {
				if (LB == LastButton.DIGIT && !chained) {
					expression += D.ToString() + " + ";
					op1 = D;
					chained = true;
				} else if (LB == LastButton.OPERATION) {
					// if last button pressed was an operation button then
					// replace previous operation in expression with newly
					// pressed operation
					if (OP == Operation.ADD || OP == Operation.SUBTRACT ||
						OP == Operation.MULTIPLY || OP == Operation.DIVIDE) {
						if (expression.LastIndexOf(" − ") == expression.Length - 3 ||
							expression.LastIndexOf(" × ") == expression.Length - 3 ||
							expression.LastIndexOf(" ÷ ") == expression.Length - 3) {

							expression = expression.Substring(0, expression.Length - 3);
							expression += " + ";
						}
					} else {
						expression += D.ToString() + " + ";
						op1 += D;
					}
				} else if (LB == LastButton.DIGIT && chained) {
					expression += D.ToString() + " + ";
					op1 += D;
				} else if (LB == LastButton.EQUAL || LB == LastButton.MEMORY) {
					op1 = D;
					expression = D.ToString() + " + ";
				}
			}

			LB = LastButton.OPERATION;
			OP = Operation.ADD;
			lbl_expr.Text = expression;
		}

		private void btn_subtract_Click(object sender, EventArgs e) {
			double D = 0.0;
			expression = lbl_expr.Text;

			// attempt parse and store in local D
			if (double.TryParse(txtbox_result.Text, out D)) {
				if (LB == LastButton.DIGIT && !chained) {
					expression += D.ToString() + " − ";
					op1 = D;
					chained = true;
				} else if (LB == LastButton.OPERATION) {
					// if last button pressed was an operation button then
					// replace previous operation in expression with newly
					// pressed operation
					if (OP == Operation.ADD || OP == Operation.SUBTRACT ||
						OP == Operation.MULTIPLY || OP == Operation.DIVIDE) {
						if (expression.LastIndexOf(" + ") == expression.Length - 3 ||
						expression.LastIndexOf(" × ") == expression.Length - 3 ||
						expression.LastIndexOf(" ÷ ") == expression.Length - 3) {

							expression = expression.Substring(0, expression.Length - 3);
							expression += " − ";
						}
					}
				} else if (LB == LastButton.DIGIT && chained) {
					expression += D.ToString() + " − ";
					op1 -= D;
                } else if (LB == LastButton.EQUAL || LB == LastButton.MEMORY) {
					op1 = D;
					expression = D.ToString() + " − ";
				}
			}

			LB = LastButton.OPERATION;
			OP = Operation.SUBTRACT;
			lbl_expr.Text = expression;
		}

		private void btn_multiply_Click(object sender, EventArgs e) {
			double D = 0.0;
			expression = lbl_expr.Text;

			// attempt parse and store in local D
			if (double.TryParse(txtbox_result.Text, out D)) {
				if (LB == LastButton.DIGIT && !chained) {
					expression += D.ToString() + " × ";
					op1 = D;
					chained = true;
				} else if (LB == LastButton.OPERATION) {
					// if last button pressed was an operation button then
					// replace previous operation in expression with newly
					// pressed operation
					if (OP == Operation.ADD || OP == Operation.SUBTRACT ||
						OP == Operation.MULTIPLY || OP == Operation.DIVIDE) {
						if (expression.LastIndexOf(" + ") == expression.Length - 3 ||
						expression.LastIndexOf(" − ") == expression.Length - 3 ||
						expression.LastIndexOf(" ÷ ") == expression.Length - 3) {

							expression = expression.Substring(0, expression.Length - 3);
							expression += " × ";
						}
					}
				} else if (LB == LastButton.DIGIT && chained) {
					expression += D.ToString() + " × ";
					op1 *= D;
				} else if (LB == LastButton.EQUAL || LB == LastButton.MEMORY) {
					op1 = D;
					expression = D.ToString() + " × ";
				}
			}

			LB = LastButton.OPERATION;
			OP = Operation.MULTIPLY;
			lbl_expr.Text = expression;
		}

		private void btn_divide_Click(object sender, EventArgs e) {
			double D = 0.0;
			expression = lbl_expr.Text;

			// attempt parse and store in local D
			if (double.TryParse(txtbox_result.Text, out D)) {
				if (LB == LastButton.DIGIT && !chained) {
					expression += D.ToString() + " ÷ ";
					op1 = D;
					chained = true;
				} else if (LB == LastButton.OPERATION) {
					// if last button pressed was an operation button then
					// replace previous operation in expression with newly
					// pressed operation
					if (OP == Operation.ADD || OP == Operation.SUBTRACT ||
						OP == Operation.MULTIPLY || OP == Operation.DIVIDE) {
						if (expression.LastIndexOf(" + ") == expression.Length - 3 ||
						expression.LastIndexOf(" − ") == expression.Length - 3 ||
						expression.LastIndexOf(" × ") == expression.Length - 3) {

							expression = expression.Substring(0, expression.Length - 3);
							expression += " ÷ ";
						}
					}
				} else if (LB == LastButton.DIGIT && chained) {
					expression += D.ToString() + " ÷ ";
					op1 /= D;
				} else if (LB == LastButton.EQUAL || LB == LastButton.MEMORY) {
					op1 = D;
					expression = D.ToString() + " ÷ ";
				}
			}

			LB = LastButton.OPERATION;
			OP = Operation.DIVIDE;
			lbl_expr.Text = expression;
		}

		private void btn_equal_Click(object sender, EventArgs e) {
			double D = 0.0;
			expression = lbl_expr.Text;

			if (double.TryParse(txtbox_result.Text, out D)) {
				if (LB == LastButton.DIGIT || LB == LastButton.OPERATION || LB == LastButton.MEMORY) {
					op2 = D;					
					expression += D.ToString() + " =";
					
					// perform operation depending on latest operation button pressed
					switch (OP) {
					case Operation.ADD:
						{
							res = op1 + op2;
						} break;

					case Operation.SUBTRACT:
						{
							res = op1 - op2;
						} break;

					case Operation.MULTIPLY:
						{
							res = op1 * op2;
						} break;

					case Operation.DIVIDE:
						{
							res = op1 / op2;
						} break;

					case Operation.NONE:
						{
							res = op2;
						} break;
					}

					txtbox_result.Text = res.ToString();
					lbl_expr.Text = expression;
				} else if (LB == LastButton.EQUAL) {
					op1 = D;

					switch (OP) {
					case Operation.ADD:
						{
							res = op1 + op2;
							expression = op1.ToString() + " + " + op2.ToString() + " =";
						} break;

					case Operation.SUBTRACT:
						{
							res = op1 - op2;
							expression = op1.ToString() + " - " + op2.ToString() + " =";
						} break;

					case Operation.MULTIPLY:
						{
							res = op1 * op2;
							expression = op1.ToString() + " × " + op2.ToString() + " =";
						} break;

					case Operation.DIVIDE:
						{
							res = op1 / op2;
							expression = op1.ToString() + " ÷ " + op2.ToString() + " =";
						} break;

					case Operation.NONE:
						{
							res = op1;
							expression = op1.ToString() + " =";
						} break;
					}

					lbl_expr.Text = expression;
					txtbox_result.Text = res.ToString();
				}

				LB = LastButton.EQUAL;
			}
		}

		private void btn_memStore_Click(object sender, EventArgs e) {
			double D;

			if (double.TryParse(txtbox_result.Text, out D)) {
				memory = D;
			}

			lbl_memory.Text = "M";

			if (LB != LastButton.EQUAL) {
				LB = LastButton.MEMORY;
			}
		}

		private void btn_memRecall_Click(object sender, EventArgs e) {
			txtbox_result.Text = memory.ToString();

			if (LB != LastButton.EQUAL) {
				LB = LastButton.MEMORY;
			}
		}

		private void btn_memMinus_Click(object sender, EventArgs e) {
			double D;

			if (double.TryParse(txtbox_result.Text, out D)) {
				memory -= D;
			}

			lbl_memory.Text = "M";

			if (LB != LastButton.EQUAL) {
				LB = LastButton.MEMORY;
			}
		}

		private void btn_memPlus_Click(object sender, EventArgs e) {
			double D;

			if (double.TryParse(txtbox_result.Text, out D)) {
				memory += D;
			}

			lbl_memory.Text = "M";

			if (LB != LastButton.EQUAL) {
				LB = LastButton.MEMORY;
			}
		}

		private void btn_memClear_Click(object sender, EventArgs e) {
			memory = 0.0;
			lbl_memory.Text = " ";

			if (LB != LastButton.EQUAL) {
				LB = LastButton.MEMORY;
			}
		}

		// TODO: implement sqrt, %, 1/x , ± buttons
	}
}
