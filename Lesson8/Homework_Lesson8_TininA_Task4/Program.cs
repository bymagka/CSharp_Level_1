﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 
 * TininA
 * 
 * *Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения данных (Например: Дни рождения,  Траты, Напоминалка, Английские слова и другие).
 * 
 */
namespace Homework_Lesson8_TininA_Task4
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
