using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System;
using System.Windows.Forms;

namespace ConversordeUni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Kilometros a Millas");
            comboBox1.Items.Add("Celsius a Fahrenheit");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double valor))
            {
                MessageBox.Show("INSERTE UN NUMERO VALIDO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double resultado;

            if (comboBox1.SelectedIndex == 0)
            {
                resultado = valor * 0.621371;
                label3.Text = "Resultado: " + resultado.ToString("N2") + " Millas";
            }
            else
            {
                resultado = (valor * 9 / 5) + 32;
                label3.Text = "Resultado: " + resultado.ToString("N2") + " °F";
            }
        }
    }
}