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
 * TininA
 * 
 * Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
 * 
 * 
 */

namespace Homework_Lesson8_TininA_Task2
{
    public partial class Form1 : Form
    {
        private List<string> Values;
        public Form1()
        {
            InitializeComponent();

            Values = new List<string> { "Первый пункт", "Второй пункт", "Третий пункт" };

            //добавляю обработчик события для изменения переключателя в любую сторону
            numeric.ValueChanged += Numeric_ValueChanged;

            //вывожу в текстбокс значение из ранее инициализированного списка при инициализации формы
            tbString.Text = Values[(int)numeric.Value - 1];
        }

        //обработчик события изменения переключателя
        private void Numeric_ValueChanged(object sender, EventArgs e)
        {
            int index = (int)numeric.Value;     

            tbString.Text = Values[index-1];
        }

       
         
    }
}
