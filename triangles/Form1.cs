using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace triangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBoxValueA.Text = "0";
            TextBoxValueB.Text = "0";
            TextBoxValueC.Text = "0";

        }

        double a, b, c;

        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxValueA.Text = "0";
            TextBoxValueB.Text= "0";
            TextBoxValueC.Text = "0";
            label4.Text = "Результат:";
        }

        private void TextBoxValueA_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '.') || e.KeyChar == (char)8)
            {
                
                return;
            }
            e.Handled = true;
            label4.Text = "Даун? Вводи числа/цифры";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           a = double.Parse(TextBoxValueA.Text);
           b = double.Parse(TextBoxValueB.Text);
           c = double.Parse(TextBoxValueC.Text);

            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                label4.Text = "Этот треугольник прямоугольный";
            }
            if ((a == b) || (a == c) || (b == c))
            {
                label4.Text = "Этот треугольник равнобедряный";
            }
            if ((a == b) && (a == c) && (b == c))
            {
                label4.Text = "Этот треугольник равносторонний";
            }
            if ((a + b < c) || (a + c < b) || (b + c < a) || (a <= 0) || (b <= 0) || (c <= 0))
            {
                label4.Text = "Такого треугольника не существует";
            }
           
            else
            {
                label4.Text = "Это обычный треугольник";
            }
        }
    }
}
