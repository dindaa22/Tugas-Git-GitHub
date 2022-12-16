/*
Dinda Wulandari
2207125080
TI B
*/

using System;

namespace BattleTank
{
    class Program
    {
        static char[,] Tank = {
            {' ','1','2','3','4','5'},
            {'1','~','~','~','~','~'},
            {'2','~','~','~','~','~'},
            {'3','~','~','~','~','~'},
            {'4','~','~','~','~','~'},
            {'5','~','~','~','~','~'}
        };
        static int[,] Answer = {
            {2,2},
            {4,3},
            {5,1}
        };
        static int[,] Recent = {
            {0,0},
            {0,0},
            {0,0}
        };
        static int[] Jawaban = {0,0};
        static int ygBenar = 0;
        static bool MulaiGame = true;
        static int Benarr = 0;

        static void Main(string[] args)
        {
            while(MulaiGame)
            {
                drawTank();
                try
                {
                    Console.Write("Pilih baris: "); Jawaban[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Pilih kolom: "); Jawaban[1] = Convert.ToInt32(Console.ReadLine());
                }catch(Exception e){
                    Console.WriteLine("Error: Yang anda masukkan bukan angka valid");
                }
                Benarr = cekTank();
                if(Benarr == 2)
                {
                    Console.WriteLine("Sudah hancur!");
                }
                else
                if(Benarr == 1)
                {
                    Console.WriteLine("Boom! Tank hancur!");
                    ygBenar++;
                }
                else
                {
                    Console.WriteLine("Miss! Meleset!");
                }
                if(ygBenar >= 3)
                {
                    drawTank();
                    Console.WriteLine("\nMenang! Tank hancur semua!");
                    MulaiGame=false;
                }
                Console.WriteLine();
            }
        }

        static void drawTank()
        {
            for(int i=0;i<6;i++)
            {
                for(int j=0;j<6;j++)
                {
                    Console.Write(Tank[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int cekTank()
        {
            for(int i=0;i<3;i++)
            {
                if(Recent[i,0] == Jawaban[0] && Recent[i,1] == Jawaban[1])
                {
                    return 2;
                }
            }
            for(int i=0;i<3;i++)
            {
                if(Answer[i,0] == Jawaban[0] && Answer[i,1] == Jawaban[1])
                {
                    Tank[Jawaban[0],Jawaban[1]] = 'X';
                    Recent[i,0] = Jawaban[0];
                    Recent[i,1] = Jawaban[1];
                    return 1;
                }
                else
                {
                    Tank[Jawaban[0],Jawaban[1]] = '0';
                }
            }
            return 0;
        }
    }
}