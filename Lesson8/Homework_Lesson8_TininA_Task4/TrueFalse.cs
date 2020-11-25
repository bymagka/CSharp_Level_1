
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
/*TininA
*
**Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения данных (Английские слова).
 *
 */
namespace Homework_Lesson8_TininA_Task4
{
    // Класс для вопроса    
    [Serializable]
    public class Question
    {
        private string text;       
        private bool trueFalse;

        public string Text { get => text; set => text = value; }

        public bool TrueFalse { get => trueFalse; set => trueFalse = value; }

        public Question()
        {
        }
        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }


    //класс для обслуживания пары Слово - Значение
    //** Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения данных(Английские слова).
    public class EnglishWord
    {
        private string word;
        private string meaning;

        public string Word { get => word; set => word = value; }

        public string Meaning { get => meaning; set => meaning = value; }

        public EnglishWord()
        {
        }

        public EnglishWord(string text, string meaning)
        {
            this.Word = text;
            this.Meaning = meaning;
        }
    }



    // Класс для хранения списка вопросов. А также для сериализации в XML и десериализации из XML
    class TrueFalse
    {
        string fileName;
        List<EnglishWord> list;
        public string FileName
        {
            set { fileName = value; }
        }
        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<EnglishWord>();
        }
        public void Add(string text, string meaning)
        {
            list.Add(new EnglishWord(text, meaning));
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        // Индексатор - свойство для доступа к закрытому объекту
        public EnglishWord this[int index]
        {
            get { return list[index]; }
        }
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<EnglishWord>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

     
        //процедура очищает весь спиоск
        public void RemoveAll()
        {
            list.RemoveAll(x => true);
        }

        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<EnglishWord>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<EnglishWord>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public int Count
        {
            get { return list.Count; }
        }
    }
}
