using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kata = new string[10];
            kata[0] = "sekolah";
            kata[1] = "menengah";
            kata[2] = "atas";
            kata[3] = "pengetahuan";
            kata[4] = "alam";
            kata[5] = "sosial";
            kata[6] = "matematika";
            kata[7] = "fisika";
            kata[8] = "ekonomi";
            kata[9] = "pancasila";
            bool wrong = false, right = false;
            int kesempatan = 0; 

            Random rng = new Random();
            string misteri = kata[rng.Next(0, 10)];
            String Terjawab = ""; 
            char[] Tebakan = new char[misteri.Length];

            Console.Clear();
            for (int p = 0; p < misteri.Length; p++) {
                Tebakan[p] = '_';
            }

            while (true)
            {
                Console.Write("Huruf tebakan : ");
                string pTebakan = Console.ReadLine();
                if(pTebakan == "")
                {
                    continue;
                }
                for (int j = 0; j < misteri.Length; j++)
                {
                    char pt = pTebakan[0];
                    if (pt == misteri[j]) {
                        right = true;
                        Tebakan[j] = pt;
                    } else if (j == misteri.Length - 1 && right == false){
                        wrong = true;
                    }
                }

                Console.Clear();
                Terjawab = Convert.ToString(Tebakan);

                if (wrong == true) {
                    Console.WriteLine("Tebakan anda salah!");
                    kesempatan++;
                    wrong = false;
                }
                right = false;
                Console.WriteLine(Tebakan);
                Console.WriteLine();
                switch (kesempatan)
                {
                    case 1:
                        Console.WriteLine("_|___");
                        break;
                    case 2:
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 3:
                        Console.WriteLine(" |/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 4:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 5:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 6:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 7:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 8:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 9:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |      / \\");
                        Console.WriteLine("_|___");
                        break;
                    case 10:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |      / \\");
                        Console.WriteLine("_|___");
                        break;

                    default:
                        break;
                }
                if (Terjawab == misteri) {
                    Console.WriteLine("Selamat, anda menang!");
                    break;
                } else if (kesempatan == 10 && Terjawab != misteri) { 
                    Console.WriteLine("Anda kurang beruntung!");
                    break;
                }
            }
        }
    }
}