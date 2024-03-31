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

namespace BJD
{
    public partial class Form1 : Form
    {
		double P;
        double L;
        double B;
        double H;
        double Fl;
        double Eh;
        double Kz;
        double Z;
        double Wt;
        double Sn;
        double n;
        double eta;
        double myu;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        private void printResult(int N, double FsvShtrih)
        {
            FsvShtrih = Math.Round(FsvShtrih, 2);
            string result = "Общий световой поток: " + FsvShtrih.ToString() + " лк" + "\nОбщее количество светильников: " + N.ToString();
            MessageBox.Show(this, result, "Вычисление завершено", MessageBoxButtons.OK);
        }

        private bool isEmptyTextBox(System.Windows.Forms.TextBox textbox)
        {
            bool flag;
            if (flag = textbox.Text.Length == 0)
                MessageBox.Show(this, "Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return flag;
        }

        private bool isEmptyTextBox(System.Windows.Forms.ToolStripTextBox textbox)
        {
            bool flag;
            if (flag = textbox.Text.Length == 0)
                MessageBox.Show(this, "Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return flag;
        }


        private bool inputNotValidation()
        {
            bool flag = isEmptyTextBox(this.textBox1);
            if (!flag) flag = isEmptyTextBox(this.textBox2);
            if (!flag) flag = isEmptyTextBox(this.textBox3);
            if (!flag) flag = isEmptyTextBox(this.textBox4);
            if (!flag) flag = isEmptyTextBox(this.textBox5);
            if (!flag) flag = isEmptyTextBox(this.textBox6);
            if (!flag) flag = isEmptyTextBox(this.textBox7);
            if (!flag) flag = isEmptyTextBox(this.textBox8);
            if (!flag) flag = isEmptyTextBox(this.textBox9);
            if (!flag) flag = isEmptyTextBox(this.textBox10);
            if (!flag) flag = isEmptyTextBox(this.textBox11);
            if (!flag) flag = isEmptyTextBox(this.textBox12);
            if (!flag) flag = isEmptyTextBox(this.toolStripTextBox1);
            return flag;
        }

        private bool initValues()
        {
            if (inputNotValidation())
                return false;
            P = double.Parse(this.toolStripTextBox1.Text);
            L = double.Parse(this.textBox1.Text);
            B = double.Parse(this.textBox2.Text);
            H = double.Parse(this.textBox3.Text);
            Fl = double.Parse(this.textBox4.Text);
            Eh = double.Parse(this.textBox5.Text);
            Kz = double.Parse(this.textBox6.Text);
            Z = double.Parse(this.textBox7.Text);
            Wt = double.Parse(this.textBox8.Text);
            Sn = double.Parse(this.textBox9.Text);
            n = double.Parse(this.textBox10.Text);
            eta = double.Parse(this.textBox11.Text);
            myu = double.Parse(this.textBox12.Text);
            return true;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Над проектом работали студенты группы 321-20:\nСахабиев Рослан\nИсмагилов Дамир\nМахмудов Бехруз\nЦой Леонид";
            MessageBox.Show(message, "О программе", MessageBoxButtons.OK);
        }

        //1. Способ «Коэффициента использования светового потока»
        private void способКоэффициентаИспользованияСветовогоПотокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (initValues())
            {
                double Fsv = 2 * Fl;
                int N = (int)((Eh * Sn * Kz * Z * 100) / (Fsv * eta));
                double FsvShtrih = (Eh * Sn * Kz * Z * 100) / (N * eta);
                printResult(N, FsvShtrih);
            }
        }

        //2. Способ «Удельной мощности светильника»
        private void вычислитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (initValues())
            {
                double W = 0.9 * Wt;
                double alpha_kz = 1.3 / 1.5 * W;
                double alpha_z = 1.15 / 1.1 * alpha_kz;
                double alpha_e = 4.0 * alpha_z;
                double K = alpha_e;
                double Wp = K * Wt;
                int N = (int)((Wp * Sn) / (n * P));
                double FsvShtrih = (Eh * Sn * Kz * Z * 100) / (N * eta);
                printResult(N, FsvShtrih);
            }
        }

        //3. Способ «Метод светящихся линий»
        private void вычислитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (initValues())
            {
                double H_shtrih = H - 0.3;
                double L_shtrih = L / H_shtrih;
                double P_shtrih = P / H_shtrih;
                double l = L_shtrih / 2;
                double sigma_e = 42.84; // CHANGE ME!!!
                double Fl_shtrih = (1000 * Eh * Kz * Z) / (myu * sigma_e);
                double Fsv = 2 * Fl;
                int N = (int)   (2 * Fl * L / Fsv);
                double FsvShtrih = (Eh * Sn * Kz * Z * 100) / (N * eta);
                printResult(N, FsvShtrih);
            }
        }
    }
}
