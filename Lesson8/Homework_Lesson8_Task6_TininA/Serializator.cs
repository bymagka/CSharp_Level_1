using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework_Lesson8_Task6_TininA
{
    public enum WaysOfSerialize
    {
        FromXML_ToCSV,
        FromCSV_ToXML
    }

    public class Serializator
    {
        List<Student> Students = new List<Student>();

        public void Serialize(string cSVFilename, string xMLFilename, WaysOfSerialize way)
        {
            Students.Clear();
            if(way == WaysOfSerialize.FromCSV_ToXML)
            {           
                ReadCSV(cSVFilename);
                WriteXML(xMLFilename);
            }
            else
            {
                ReadXML(xMLFilename);
                WriteCSV(cSVFilename);
            }
        }

        private void WriteCSV(string cSVFilename)
        {

           

            StreamWriter sw = new StreamWriter(cSVFilename,false,Encoding.Unicode);


            foreach(Student std in Students)
            {
               sw.WriteLine(std);
            }

            sw.Close();
        }

        private void ReadXML(string xMLFilename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            FileStream fStream = new FileStream(xMLFilename, FileMode.Open, FileAccess.Read);
            Students = (xmlSerializer.Deserialize(fStream) as List<Student>);

            fStream.Close();
        }

        private void WriteXML(string xMLFilename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            FileStream fStream = new FileStream(xMLFilename, FileMode.Create,FileAccess.Write);
            xmlSerializer.Serialize(fStream, Students);
            fStream.Close();
        }

        private void ReadCSV(string cSVFilename)
        {
            StreamReader sr = new StreamReader(cSVFilename);
            while (!sr.EndOfStream)
            {

                string[] s = sr.ReadLine().Split(';');
                // Добавляем в список новый экземпляр класса Student
                Students.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[6]), int.Parse(s[5]), int.Parse(s[7]), s[8]));
            }
            sr.Close();
        }
    }
}
