// Кудряшов Сергей

// **Считайте файл различными способами. Смотрите “Пример записи файла различными способами”.
// Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader
// и массив int для BinaryReader.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ReadFromFile
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

            Console.WriteLine("FileStream. Milliseconds:{0}", FileStreamSample("..//..//bigdata0.bin", size));
            byte[] fs = ReadFileStream("..//..//bigdata0.bin");
            Console.WriteLine("BinaryStream. Milliseconds:{0}", BinaryStreamSample("..//..//bigdata1.bin", size));
            int[] bis = ReadBinaryStream("..//..//bigdata1.bin");
            Console.WriteLine("StreamWriter. Milliseconds:{0}", StreamWriterSample("..//..//bigdata2.bin", size));
            string str = ReadStreamReader("..//..//bigdata2.bin");
            Console.WriteLine("BufferedStream. Milliseconds:{0}", BufferedStreamSample("..//..//bigdata3.bin", size));
            byte[] bfs = ReadBufferedStream("..//..//bigdata3.bin");

            Console.ReadKey();
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

        static byte[] ReadFileStream(string filename)
        {
            FileStream fileIn = new FileStream(filename, FileMode.Open, FileAccess.Read);
            List<byte> list = new List<byte>();

            int i;
            while ((i = fileIn.ReadByte()) != -1)
            {
                list.Add((byte)i);
            }

            byte[] bytes = list.ToArray();
            fileIn.Close();
            return bytes;
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

        static int[] ReadBinaryStream(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            long n = fs.Length / 4; // определяем количество чисел в двоичном потоке
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = br.ReadInt32();
            }
            br.Close();
            fs.Close();
            
            return a;
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

        static string ReadStreamReader(string file)
        {
            string str;
            StreamReader sr = new StreamReader(file);
            str = sr.ReadToEnd();
            return str;
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

        static byte[] ReadBufferedStream(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);            
            BufferedStream bs = new BufferedStream(fs);
            int i;
            List<byte> list = new List<byte>();
            while ((i = bs.ReadByte()) != -1)
            {
                list.Add((byte)i);
            }
            bs.Close();
            fs.Close();
            return list.ToArray();
        }

    }
}
