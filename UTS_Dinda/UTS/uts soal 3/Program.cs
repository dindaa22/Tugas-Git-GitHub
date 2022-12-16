using System;

namespace uts_soal_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string nama;
            int tahunLahir = 0;

            Console.Write("Nama        : ");
            nama = Console.ReadLine().ToUpper();

            while (true)
            {
                try
                {
                    while (tahunLahir <= 0 || tahunLahir >= 2022)
                    {
                        Console.Write("Tahun Kelahiran : ");
                        tahunLahir = Convert.ToInt32(Console.ReadLine());
                        if (tahunLahir <= 0 || tahunLahir >= 2021)
                        {
                            Console.WriteLine("Tahun lahir anda tidak valid. Silahkan cek dan coba lagi...");
                        }
                    }
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Maaf. Input anda tidak valid");
                }        
            }
            printTiket(nama,tahunLahir);
        }
        static int biayaTiket(int tahunLahir)
        {
            int umur = 2022 - tahunLahir;
            int biaya = 0;
            if(umur < 10 || umur > 60)
            {
               biaya = 10000;
            }
            else
            {
                biaya = 25000;
            }
            return biaya;
        }
        static void printTiket(string nama, int tahunLahir)
        {
            Console.WriteLine("|***************************|");
            Console.WriteLine("|                           |");
            Console.WriteLine("|       --Studio 1--        |");
            Console.WriteLine("|Nama   : {0,18}|",nama);
            Console.WriteLine("|Harga  : {0,18}|",biayaTiket(tahunLahir));
            Console.WriteLine("|---------------------------|");
        }
    }
}
