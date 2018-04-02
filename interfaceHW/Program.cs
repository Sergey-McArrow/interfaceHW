using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceHW
{
    interface IWriteToFile
    {
        void Write();
    }

    class StrWriter : IWriteToFile
    {
        public void Write()
        {
            using (StreamWriter str = new StreamWriter(@"C:\Users\serge\OneDrive\Рабочий стол\file.txt", true, System.Text.Encoding.Default))
            {
                str.WriteLine("text streamwriter");
            }
        }
    }
    class Filestr : IWriteToFile
    {
        public void Write()
        {
            using (FileStream fstream = new FileStream(@"C:\Users\serge\OneDrive\Рабочий стол\file.txt", FileMode.OpenOrCreate))
            {
                byte[] arrayFileStream = System.Text.Encoding.Default.GetBytes("Text filestream");
                fstream.Write(arrayFileStream, 0, arrayFileStream.Length);

            }
        }
    }
    static class Temperature
    {
        public static void CelsiusToKelvin(double x)
        {
            Console.WriteLine(x+273.15);
        }
       public static void CelsiusToFarengeit(int x)
       {
            Console.WriteLine(x*9/5 +32);
       }
    }
    //public class ArrayMinMax //14.7
    //{
    //    private int[] _array;

    //    public ArrayMinMax()
    //    {
    //        Random random = new Random();
    //        int[] array = new int[10];
    //        for (int i = 0; i < 10; i++)
    //        {
    //            int number = random.Next(10, 100);
    //            array[i] = number;
    //        }
    //    }
             
    //    public int[] Array
    //    {
    //        get
    //        {
    //            return _array;
    //        }
    //        set
    //        {
    //            _array = value;
    //        }
    //    }
        //public int GetMin()
        //{
        //    _array.OrderBy(f => f);
        //    return _array[0];
        //}
        //public int GetMax()
        //{
        //    _array.OrderByDescending(f => f);
        //    return _array[0];
        //}
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Temperature.CelsiusToFarengeit(0);

            //ArrayMinMax Array = new ArrayMinMax();
            //Console.WriteLine(Array.GetMax());
            //Console.WriteLine(Array.GetMin());


            IWriteToFile writeToFile = new StrWriter();
            IWriteToFile writeToFilefilestream = new Filestr();
            writeToFile.Write();
            writeToFilefilestream.Write();

        }
    }
}
