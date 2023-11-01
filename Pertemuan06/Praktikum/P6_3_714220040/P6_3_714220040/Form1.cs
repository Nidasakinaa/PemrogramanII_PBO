using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714220040
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void txtHuruf_Leave(object sender, EventArgs e)
            {
                if (txtHuruf.Text == "")
                {
                    epWarning.SetError(txtHuruf, "TextBox Harus Diisi!");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
                else
                {
                    if ((txtHuruf.Text).All(Char.IsLetter))
                    {
                        epWarning.SetError(txtHuruf, "");
                        epWrong.SetError(txtHuruf, "");
                        epCorrect.SetError(txtHuruf, "Betul!");
                    }
                    else
                    {
                        epWrong.SetError(txtHuruf, "Inputan Harus huruf!");
                        epWarning.SetError(txtHuruf, "");
                        epCorrect.SetError(txtHuruf, "");
                    }
                }
            }

            private void txtAngka_Leave(object sender, EventArgs e)
            {
                if (txtAngka.Text == "")
                {
                    epWarning.SetError(txtAngka, "TextBox Harus Diisi!");
                    epWrong.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "");
                }
                else
                {
                    if ((txtAngka.Text).All(Char.IsNumber))
                    {
                        epWarning.SetError(txtAngka, "");
                        epWrong.SetError(txtAngka, "");
                        epCorrect.SetError(txtAngka, "Betul!");
                    }
                    else
                    {
                        epWrong.SetError(txtAngka, "Inputan Harus Angka!");
                        epWarning.SetError(txtAngka, "");
                        epCorrect.SetError(txtAngka, "");
                    }
                }
            }

            private void txtEmail_Leave(object sender, EventArgs e)
            {
                if (txtEmail.Text == "")
                {
                    epWarning.SetError(txtEmail, "TextBox Harus Diisi!");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
                else
                {
                    if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                    {
                        epWarning.SetError(txtEmail, "");
                        epWrong.SetError(txtEmail, "");
                        epCorrect.SetError(txtEmail, "Betul!");
                    }
                    else
                    {
                        epWrong.SetError(txtEmail, "Format Email Salah!\nContoh : a@b.c");
                        epWarning.SetError(txtEmail, "");
                        epCorrect.SetError(txtEmail, "");
                    }
                }
            }

            private void txtAngka1_Leave(object sender, EventArgs e)
            {
                if (IsNumber(txtAngka1.Text) && IsNumber(txtAngka2.Text))
                {
                    int angka1 = Convert.ToInt32(txtAngka1.Text);
                    int angka2 = Convert.ToInt32(txtAngka2.Text);

                    if (angka1 <= angka2)
                    {
                        epWarning.SetError(txtAngka1, "Angka1 harus lebih besar dari Angka2");
                        epWrong.SetError(txtAngka1, "");
                        epCorrect.SetError(txtAngka1, "");
                    }
                    else
                    {
                        epWarning.SetError(txtAngka1, "");
                        epWrong.SetError(txtAngka1, "");
                        epCorrect.SetError(txtAngka1, "Betul");
                    }
                }
                else
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "Inputan hanya boleh angka!");
                    epCorrect.SetError(txtAngka1, "");
                }
            }

            private bool IsNumber(string text)
            {
                int number;
                return int.TryParse(text, out number);
            }

            private void txtAngka2_Leave(object sender, EventArgs e)
            {
                if (IsNumber(txtAngka1.Text) && IsNumber(txtAngka2.Text))
                {
                    int angka1 = Convert.ToInt32(txtAngka1.Text);
                    int angka2 = Convert.ToInt32(txtAngka2.Text);

                    if (angka1 <= angka2)
                    {
                        epWarning.SetError(txtAngka2, "Angka1 harus lebih besar dari Angka2");
                        epWrong.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "");
                    }
                    else
                    {
                        epWarning.SetError(txtAngka2, "");
                        epWrong.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "Betul!");
                    }
                }
                else
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "Inputan hanya bolehangka!");
                    epCorrect.SetError(txtAngka2, "");
                }
            }
    }
}
