using System;
using System.Windows.Forms;

/*
 * TininA
 * 
 * 
 * а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
   б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
   в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
   г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
   д) Добавить в приложение сообщение с предупреждением при попытке удалить вопрос.
 * 
 */


namespace Homework_Lesson8_TininA_Task3
{
    public partial class Form1 : Form
    {
        // База данных с вопросами
        TrueFalse database;
        public Form1()
        {
            InitializeComponent();
        }
        // Обработчик пункта меню Exit
        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Обработчик пункта меню New
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }
        // Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            cboxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
        }
        // Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add(tbQuestion.Text, cboxTrue.Checked);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        // Обработчик кнопки Удалить

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
            if (nudNumber.Maximum == 1 || database == null) return;

            // д) Добавить в приложение сообщение с предупреждением при попытке удалить вопрос.
            MessageBox.Show($"Вопрос {tbQuestion.Text} будет удален");

            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }
        // Обработчик пункта меню Save
        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            // а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
            else MessageBox.Show("База данных не создана");
        }
        // Обработчик пункта меню Open
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }
        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
        }

        // г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAsFileDialog = new SaveFileDialog();
            if(saveAsFileDialog.ShowDialog() == DialogResult.OK)
            {
                database.FileName = saveAsFileDialog.FileName;
                database.Save();
            }
        }

        //в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Автор: Тинин А. \nВерсия:1.0 \nБлагодаронсти: GeekBrains");
        }
    }
}
