using System;

namespace uts_soal_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double Kurs;
            int TotalUsd;
            while (true)
            {
                try
                {
                    Console.Write("Rate USD ke Rp : ");
                    Kurs = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Maaf. Hanya menerima input berupa angka");
                    continue;
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Jumlah USD   : ");
                    TotalUsd = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Maaf. Hanya menerima input berupa angka...");
                    continue;
                }
            }
            Console.WriteLine("Hasil konversi : Rp."+(Kurs * TotalUsd));
        }    
    }
}