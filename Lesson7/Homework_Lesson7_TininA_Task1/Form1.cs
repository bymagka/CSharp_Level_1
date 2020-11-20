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
 * Tinin A
 * 
 * а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
   б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
   в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
 * 
 * 
 */

namespace Homework_Lesson7_TininA_Task1
{
    public partial class Form1 : Form
    {
        //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю. За это отвечает переменная ActionsCount
        //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов. За эту часть отвечают переменные GameNumber(загаданное число),MinSteps (минимальное количество шагов), PlayerStep(количество шагов игрока).

        private int ActionsCount,GameNumber,MinSteps,PlayerSteps;
        private Random rnd = new Random();

        //в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
        private Stack<int> StepHistory = new Stack<int>();

        public Form1()
        {
            InitializeComponent();
            number.Text = "0";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            //сохранение истории шагов
            StepHistory.Push(int.Parse(number.Text));

            number.Text = (int.Parse(number.Text) + 1).ToString();

            //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
            ActionsCount++;
            ActionsCountText.Text = $"Количество действий: {ActionsCount}";

            //расчет шагов для игры
            PlayerSteps++;
            lblPlayerSteps.Text = PlayerSteps.ToString();
            Finish();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //сохранение истории шагов
            StepHistory.Push(int.Parse(number.Text));

            number.Text = (int.Parse(number.Text) + int.Parse(number.Text)).ToString();
            ////подсчет действий на форме
            ActionsCount++;
            ActionsCountText.Text = $"Количество действий: {ActionsCount}";

            //расчет шагов для игры
            PlayerSteps++;
            lblPlayerSteps.Text = PlayerSteps.ToString();
            Finish();
        }

        //проверяет на конец игры при осуществлении хода
        private void Finish()
        {
            if (MinSteps < PlayerSteps)
            {
                MessageBox.Show("Сделано не минимальное число ходов!");
                NewGame();
                return;
            }

            if (GameNumber == int.Parse(number.Text))
            {
                    MessageBox.Show("Ура, вы победили!");
                    NewGame();
                    return;
            }
            else if(GameNumber < int.Parse(number.Text))
            {
                MessageBox.Show("Число игрока стало больше загаданного числа!");
                NewGame();
                return;
            }
    
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            number.Text = "1";
            //подсчет действий на форме
            ActionsCount++;
            ActionsCountText.Text = $"Количество действий: {ActionsCount}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //отмена хода
            number.Text = StepHistory.Pop().ToString();
            PlayerSteps--;
            lblPlayerSteps.Text = PlayerSteps.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        //запуск новой игры, обнволение данных формы
        private void NewGame()
        {
            number.Text = "1";

            GameNumber = rnd.Next(2, 500);

            lblGameNumber.Text = GameNumber.ToString();

            ShowMinSteps(GameNumber);
            lblMinSteps.Text = MinSteps.ToString();
            PlayerSteps = 0;
            lblPlayerSteps.Text = PlayerSteps.ToString();
        }

        //считает минимальное количество шагов для достижения загаданного
        private void ShowMinSteps(int Number)
        {
            int temp = Number;
            int MinStepsCount = 0;

            while (temp != 1)
            {
                if (temp % 2 == 0) temp /= 2;
                else temp -= 1;
                MinStepsCount++;
            }

            MinSteps = MinStepsCount;
        }
    }
}
