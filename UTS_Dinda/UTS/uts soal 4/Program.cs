using System;

namespace uts
{
    class noempat
    {
        public static void Main(string[] args) {
            String abjad = "abcdefghijklmnopqrstuvwxyzabcABCDEFGHIJKLMNOPQRSTUVWXYZABC";
            String teks, enkripsi = "";
            System.Console.Write("Teks : ");
            teks = Console.ReadLine();

            char sementara = ' ';
            for(int karaktek=0;karaktek<teks.Length;karaktek++)
            {
                Char t = teks[karaktek];
                for(int abjadd=0;abjadd<abjad.Length;abjadd++)
                {
                    Char c = abjad[abjadd];
                    if (t.Equals(c)) { 
                        sementara = abjad[karaktek+3];
                    } else if (t.Equals(' ')) {
                        sementara = ' ';
                    }
                }
                enkripsi = enkripsi + sementara;
            }
            System.Console.Write("Hasil enkripsi : " + enkripsi);
        }
    }
}