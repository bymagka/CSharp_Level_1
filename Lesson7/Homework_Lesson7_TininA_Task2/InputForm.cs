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

//
namespace Homework_Lesson7_TininA_Task2
{
    public partial class InputForm : Form
    {
        private int InputNumber;
        private int GameNumber;
        public int StepCounts;

        public Form1 owner;

        //В конструктор передается загаданный номер и форма владелец (для того, чтобы передать обратно подсчитанное количество ходов)
        public InputForm(int GameNumber, Form1 owner)
        {
            InitializeComponent();
            this.GameNumber = GameNumber;
            this.owner = owner;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Проверяем номер
            if (int.TryParse(InputValue.Text, out InputNumber))
            {
                if (InputNumber < GameNumber)
                {
                    MessageBox.Show("Введенное число меньше загаданного");
                    StepCounts++;
                }
                else if (InputNumber > GameNumber)
                {
                    MessageBox.Show("Введенное число больше загаданного");
                    StepCounts++;
                }
                else
                {
                    MessageBox.Show("Ура! Вы угадали!");
                    //для того, чтобы передать значение в элемент формы владельца, сделал лейбл StepsCount public
                    owner.StepsCount.Text = StepCounts.ToString();
                    this.Close();
                }
            }
            else MessageBox.Show("Введено не целое число!");
        }
    }
}
