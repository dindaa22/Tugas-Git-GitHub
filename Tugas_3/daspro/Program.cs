using System;
using System.Collections.Generic;

namespace DasPro
{
    class Program
    {
            static int kesempatan = 5;
            static String kataMisteri = "kucing";
            static List<string> listTebakan = new List<String>{};

            static void Main(string[] args) 
            {
                intro();
                PlayGame();
                Endgame();
            }


            static bool CekJawaban(string kataRahasia, List<string> list)
            {
                bool status = false;
                for (int i = 0; i < kataRahasia.Length; i++)
                {
                    string c = Convert.ToString(kataRahasia[i]);
                    if(list.Contains(c))
                    {
                        status = true;
                    } else
                    {
                        return status = false;
                    }
                }
                return status;
            }


            static string CekHuruf(string kataRahasia, List<string> list)
            {
                string x = "";

                for (int i = 0; i < kataRahasia.Length;i++)
                {
                    string c = Convert.ToString(kataRahasia[i]);
                    if(list.Contains(c))
                    {
                        x = x + c;
                    } else
                    {
                        x = x +"_";
                    }
                }
                return x;
            }


            static void intro()
            {
                Console.WriteLine("selamat datang, hari ini kita akan bermain tebak kata");
                Console.WriteLine($"kamu punya {kesempatan} kesempatan untuk menebak kata misteri hari ini");
                Console.WriteLine("petunjuknya adalah kata ini merupakan nama hewan lucu");
                Console.WriteLine($"kata tersebut terdiri dari {kataMisteri.Length} huruf");
                Console.WriteLine("hewan apakah yang dimaksud?");
                Console.ReadKey();
            }

            static void PlayGame()
            {

                while (kesempatan>0)
                {
                    Console.Write("apa huruf tebakan? (pilih a-z) : ");
                    string input = Console.ReadLine();
                    listTebakan.Add(input);
                    if(CekJawaban(kataMisteri, listTebakan))
                    {
                        Console.WriteLine("selamat! anda berhasil menebak katanya");
                        Console.WriteLine($"kata misteri hari ini adalah {kataMisteri}");
                        break;
                    }else if(kataMisteri.Contains(input))
                    {
                        Console.WriteLine("huruf itu ada di dalam kata ini");
                        Console.WriteLine("sekarang tebak huruf lain");
                        Console.WriteLine(CekHuruf(kataMisteri, listTebakan));
                    }else
                    {
                        Console.WriteLine("huruf itu tidak ada dalam kata ini");
                        kesempatan--;
                        Console.WriteLine($"kesempatan anda tersisa {kesempatan}");
                    }
                    if(kesempatan == 0)
                    {
                        Endgame();
                        break;
                    }
                }
            }

            static void Endgame() 
            {
                Console.WriteLine("permainan berakhir!");
            }
        }
    }  
            

                




