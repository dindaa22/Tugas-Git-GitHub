using System;

namespace game_dadu
{
    class Program
    {
        public static int nilaiKp;
        public static int nilaiAnda;
        public static int skorAnda=0;
        public static int skorKp=0;

       public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                PlayGame(i);
                Console.WriteLine("Lanjutkan ke ronde berikutnya\n");
                Console.ReadKey();
            }
            Closing();

        }

        public static void PlayGame(int i)
        {
            Random rng = new Random();

            nilaiKp = rng.Next(1,7);
            nilaiAnda = rng.Next(1,7);

            Console.WriteLine("Ronde " +i);
            Console.WriteLine("Nilai Komputer: " +nilaiKp);

            Console.WriteLine("Lempar dadu anda...");
            Console.WriteLine("Nilai anda: "+nilaiAnda);

            if(nilaiAnda==nilaiKp)
            {
                Console.WriteLine("Ronde ini seri!");
            }
            else if(nilaiAnda > nilaiKp)
            {
                skorAnda++;
                Console.WriteLine("Anda memenangkan ronde ini");
            }
            else
            {
                skorKp++;
                Console.WriteLine("Komputer memenangkan ronde ini");
            }   
            Console.WriteLine("Skor - Anda : "+skorAnda+" Komputer : "+skorKp+".");                     
        }

        public static void Closing()
        {
            if(skorAnda==skorKp)
            {
                Console.WriteLine("Ronde ini seri!");
            }
            else if(skorAnda > skorKp)
            {
                Console.WriteLine("Anda memenangkan ronde ini");
            }
            else
            {
                Console.WriteLine("Komputer memenangkan ronde ini");
            }                           
        }
    }
}