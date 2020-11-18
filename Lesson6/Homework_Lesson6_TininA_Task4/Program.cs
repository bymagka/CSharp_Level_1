
using System;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
/*
* 
* TininA
* 
* **Считайте файл различными способами. Смотрите “Пример записи файла различными способами”. Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.
*
* 
*/
namespace Homework_Lesson6_TininA_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            long kbyte = 1024;
            long mbyte = 1024 * kbyte;
            long gbyte = 1024 * mbyte;
            long size = mbyte;
            //Write FileStream
            //Write BinaryStream
            //Write StreamReader/StreamWriter
            //Write BufferedStream

            Console.WriteLine("FileStream. Milliseconds:{0}", FileStreamSample("..\\..\\bigdata0.bin", size));
            Console.WriteLine("BinaryStream. Milliseconds:{0}", BinaryStreamSample("..\\..\\bigdata1.bin", size));
            Console.WriteLine("StreamWriter. Milliseconds:{0}", StreamWriterSample("..\\..\\bigdata2.bin", size));
            Console.WriteLine("BufferedStream. Milliseconds:{0}", BufferedStreamSample("..\\..\\bigdata3.bin", size));

            //Создайте методы, которые возвращают массив byte(FileStream)
            Console.WriteLine($"Количество байт в файле FileStream: {FileStreamRead("..\\..\\bigdata0.bin").Length}");

            //Создайте методы, которые возвращают массив byte(FileStream)
            Console.WriteLine($"Количество байт в файле BufferedStream: {BufferedStreamRead("..\\..\\bigdata3.bin",size).Length}");

            //Создайте методы, которые возвращают строку(StreamReader)
            string StreamReaderText = StreamRead("..\\..\\bigdata2.bin");
            Console.WriteLine($"Количество байт в файле StreamReader: {StreamReaderText.Length}    {StreamReaderText}");

            //Создайте методы, которые возвращают массив инт(BinaryReader)
            int[] BinaryReadArray = BinaryRead("..\\..\\bigdata1.bin",size);

            //умножаем на 4 потому что в одном инте 4 байта
            Console.WriteLine($"Количество байт в файле StreamReader: {BinaryReadArray.Length * 4}");


            Console.ReadKey();
        }

        //Создайте методы, которые возвращают массив инт(BinaryReader)
        private static int[] BinaryRead(string filename,long size)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            int[] ReturnArray = new int[size/4];
            for(int i = 0; i < size/4; i++)
            {
                ReturnArray[i] = br.ReadInt32();
            }
            br.Close();
            fs.Close();
            return ReturnArray;
        }

        //Создайте методы, которые возвращают строку(StreamReader)
        private static string StreamRead(string filename)
        {
            FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            string ReturnText = sr.ReadToEnd();
            sr.Close();
            file.Close();
            return ReturnText;

        }

        //Создайте методы, которые возвращают массив byte(FileStream)
        private static byte[] FileStreamRead(string filename)
        {
            FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] ReturnArray = new byte[file.Length];
            int i;
            int count = 0;
            while((i = file.ReadByte()) != -1)
            {
                ReturnArray[count] = (byte)i;
                count++;
            }
            file.Close();

            return ReturnArray;
        }

        //Создайте методы, которые возвращают массив byte(BufferedStream)
        private static byte[] BufferedStreamRead(string filename,long size)
        {

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            int countPart = 4;//количество частей
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Read(buffer, 0, (int)bufsize);
            fs.Close();
            
            return buffer;
        }

        static long FileStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            //FileStream fs = new FileStream("D:\\temp\\bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            for (int i = 0; i < size; i++)
                fs.WriteByte(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static long BinaryStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < size; i++)
                bw.Write((byte)0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static long StreamWriterSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < size; i++)
                sw.Write(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static long BufferedStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            int countPart = 4;//количество частей
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Write(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }
}

