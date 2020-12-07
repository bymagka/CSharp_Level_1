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
 * Используя полученные знания и класс TrueFalse, разработать игру «Верю — не верю».
 * 
 */

namespace Homework_Lesson8_TininA_Task5
{
    public partial class Form1 : Form
    {
        TrueFalse database;
        Random rnd = new Random();
        
        int index,points;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(fileDialog.FileName);
                database.Load();
                NextQuestion();
            }
            else MessageBox.Show("Файл не выбран");


        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (database[index - 1].TrueFalse)
            {
                points++;
                MessageBox.Show("Правильно ответили на вопрос!");
            } else MessageBox.Show("Неправильно ответили на вопрос!");
            database.Remove(index - 1);
            NextQuestion();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (!database[index - 1].TrueFalse)
            {
                points++;
                MessageBox.Show("Правильно ответили на вопрос!");
            }
            else MessageBox.Show("Неправильно ответили на вопрос!");
            database.Remove(index - 1);
            NextQuestion();
        }

        private void NextQuestion()
        {
            if(database.Length == 0)
            {
                MessageBox.Show($"Правильно отвеченных вопросов: {points}");

                database.Clear();
                label1.Text = "Выберите новую базу вопросов";

                btnAccept.Visible = false;
                btnDecline.Visible = false;

                return;
            }
            index = rnd.Next(1, database.Length);
            label1.Text = database[index - 1].Text;

            btnAccept.Visible = true;
            btnDecline.Visible = true;
            
        }
    }
}
