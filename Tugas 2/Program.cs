//CODING!!!
using System;
namespace daspro
{
    //DINDA WULANDARI
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 1;
            const int b = 2;
            const int c = 3;
            const int tambah = a+b+c;
            const int kali = a*b*c;
            const int kurang = a-b-c;
            const int bagi = a/b/c;

            Console.WriteLine("Hello Word");
            Console.WriteLine("");
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("akses ke server membutuhkan password yang tidak di ketahui ");
            Console.WriteLine("- Password terdiri dari 4 angka");
            Console.WriteLine("- Jika ditambahkan hasilnya " + tambah);
            Console.WriteLine("- Jika dikalikan hasilnya " + kali);
            Console.WriteLine("- Jika dikurangkan hasilnya " + kurang);
            Console.WriteLine("- Jika dibagi hasilnya " + bagi);

            Console.WriteLine("");
            Console.Write("Enter code : ");
        }
    }
}