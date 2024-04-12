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

namespace practica_1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);

                double f = 1; // Начальное значение функции F(x) равно первому члену ряда

                double currentTerm = 1;
                double prevTerm = 1;

                int n = 1; // Номер текущего члена ряда

                while (Math.Abs(currentTerm - prevTerm) >= 0.001)
                {
                    prevTerm = currentTerm;
                    currentTerm *= -x;
                    f += currentTerm;
                    n++;
                }

                label1.Text = $"Значение функции F({x}) равно {f:F4}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Неверный формат числа. Пожалуйста, введите числовое значение для поля x.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
