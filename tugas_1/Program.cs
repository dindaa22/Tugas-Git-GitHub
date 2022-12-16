//CODING!!!
using System;
namespace daspro
{
    //DINDA WULANDARI
    class Program
    {
        //Deklrasi variabel
        public static Random rng = new Random(); 
        public static int kodeA;
        public static int kodeB;
        public static int kodeC;
        public static int hasilTambah;
        public static int hasilKali;
        public static int jumlahKode = 3;
        public static int kesempatan = 3;
        public static int level = 1;
        public static string tebakanA;
        public static string tebakanB;
        public static string tebakanC;
        public static bool bGameStart;

        //Main Method
        static void Main(string[] args)
        {
            bGameStart = true;
            while(bGameStart)
            {
                Intro();
                if(kesempatan > 0)
                {
                    if(bGameStart==true)
                    {
                        PlayGame();
                    }
                    if(level ==6)
                    {
                        Menang();
                    }
                    Console.Clear();
                }
                else
                {
                  ShowEnd();
                  Console.Clear();
                }   
            }
            Console.Write("\nTekan shift untuk keluar..."); Console.ReadKey();
        }

        static void Init()
        {
            //Inisialisasi Variabel
            kodeA = rng.Next(1,2*level);
            kodeB = rng.Next(1,2*level);
            kodeC = rng.Next(1,2*level);

             //Operasi Aritmatika
            hasilTambah = kodeA+kodeB+kodeC;
            hasilKali = kodeA*kodeB*kodeC;
        }

        static void Intro()    
        {
            Init();
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("akses ke server membutuhkan password yang tidak di ketahui ");
            Console.WriteLine("level "+level);
            Console.WriteLine("- Password terdiri dari "+jumlahKode+" angka");
            Console.WriteLine("- Jika ditambahkan hasilnya "+ hasilTambah);
            Console.WriteLine("- Jika dikalikan hasilnya " + hasilKali);
        }

        static void PlayGame()  
        {
             //Tebakan
            Console.Write("Masukan Kode Pertama : ");
            tebakanA = Console.ReadLine();
            Console.Write("Masukan Kode Kedua : ");
            tebakanB = Console.ReadLine();
            Console.Write("Masukan Kode Ketiga : ");
            tebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan anda "+tebakanA+" "+tebakanB+" "+tebakanC+" ?");

            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
            {
                Console.WriteLine("Tebakan Anda Benar...");
                level++;
                Console.WriteLine("");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                kesempatan --;
                Console.WriteLine("Tebakan  Anda Salah...");
                Console.WriteLine("Kesempatan sisa :"+kesempatan);
                Console.ReadLine();
                Console.Clear();
            }
        }
        static void ShowEnd()
        {
            Console.Clear();
            if(kesempatan ==0)
            {
                Console.WriteLine("Tebakan  Anda Salah...");
                Console.ReadLine();
                bGameStart = false;
            }
        }

        static void Menang()   
        {
            Console.Clear();
            Console.WriteLine("Tebakan Anda Benar...");
            Console.ReadLine();
            Console.Clear();
            bGameStart = false;
        } 
    } 
 }          
           



           