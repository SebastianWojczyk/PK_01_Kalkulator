using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PK_01_Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxDzialanie.SelectedIndex = 0;
        }

        private void buttonLicz_Click(object sender, EventArgs e)
        {
            Licz();
        }

        private void Licz()
        {
            /*
                        bez obsługi wyjątków
                        Double x = Convert.ToDouble(textBoxLiczba1.Text);
                        Double y = Double.Parse(textBoxLiczba2.Text);

                        textBoxLiczbaWynik.Text = (x + y).ToString();
                        */

            Boolean ok = true;

            textBoxLiczba1.BackColor = default;
            textBoxLiczba2.BackColor = default;


            if (!Double.TryParse(textBoxLiczba1.Text, out Double x))
            {
                textBoxLiczba1.BackColor = Color.Red;
                ok = false;
            }
            if (!Double.TryParse(textBoxLiczba2.Text, out Double y))
            {
                textBoxLiczba2.BackColor = Color.Red;
                ok = false;
            }
            else if (listBoxDzialanie.Text == "/" && y == 0)
            {
                textBoxLiczba2.BackColor = Color.Red;
                ok = false;
            }

            if (ok)
            {
                switch (listBoxDzialanie.Text)
                {
                    case "+":
                        textBoxLiczbaWynik.Text = (x + y).ToString();
                        break;
                    case "-":
                        textBoxLiczbaWynik.Text = (x - y).ToString();
                        break;
                    case "*":
                        textBoxLiczbaWynik.Text = (x * y).ToString();
                        break;
                    case "/":
                        textBoxLiczbaWynik.Text = (x / y).ToString();
                        break;
                }

            }
            else
            {
                textBoxLiczbaWynik.Text = "";
                MessageBox.Show("Popraw w zaznaczonych miejscach!", "Bład");
            }
        }

        private void textBoxLiczba1_TextChanged(object sender, EventArgs e)
        {
            Licz();
        }

        private void textBoxLiczba2_TextChanged(object sender, EventArgs e)
        {
            Licz();
        }

        private void listBoxDzialanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            Licz();
        }
    }
}
