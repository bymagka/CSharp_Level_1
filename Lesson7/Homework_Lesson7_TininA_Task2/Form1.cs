using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 
 * 
 * Tinin A
 * 
 * Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.  
    a) Для ввода данных от человека используется элемент TextBox;
    б) **Реализовать отдельную форму c TextBox для ввода числа.
*/
namespace Homework_Lesson7_TininA_Task2
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private int GameNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //загадываем число
            GameNumber = rnd.Next(1, 100);
            MessageBox.Show("Новое число от 1 до 100 загадано");
            StepsCount.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //вызываем форму ввода значения. Передаем номер и эту форму, чтобы передать обратно количество сделанных ходов
            InputForm inputForm = new InputForm(GameNumber,this);
            inputForm.Show(this);
        }
    }
}
