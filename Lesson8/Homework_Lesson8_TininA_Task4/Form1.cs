using System;
using System.Windows.Forms;

/*TininA
*
**Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения данных (Английские слова).
 *
 */


namespace Homework_Lesson8_TininA_Task4
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
            tbWord.Text = database[(int)nudNumber.Value - 1].Word;
            tbMeaning.Text = database[(int)nudNumber.Value - 1].Meaning;
        }
        // Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add(tbWord.Text, tbMeaning.Text);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        // Обработчик кнопки Удалить

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;

            // д) Добавить в приложение сообщение с предупреждением при попытке удалить вопрос.
            MessageBox.Show($"Вопрос {tbWord.Text} будет удален");

            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }
        // Обработчик пункта меню Save
        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
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
                if (database.Count == 0)
                {
                    MessageBox.Show("В указанном файле нет вопросов для загрузки!");
                    return;
                }

                

                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }
        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Word = tbWord.Text;
            database[(int)nudNumber.Value - 1].Meaning = tbMeaning.Text;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAsFileDialog = new SaveFileDialog();
            if(saveAsFileDialog.ShowDialog() == DialogResult.OK)
            {
                database.FileName = saveAsFileDialog.FileName;
                database.Save();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Автор: Тинин А. \nВерсия:1.0 \nБлагодаронсти: GeekBrains");
        }
    }
}
