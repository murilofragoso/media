using System;

namespace Media2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int x = 0 ;
            while (true)
            {

                Console.WriteLine("insira um valor. 0 para encerrar");
                int y = int.Parse(Console.ReadLine());
                if (y == 0)
                    break;
                valor += y;
                x += 1;
            }
            int media = valor / x;
            Console.WriteLine("a media dos valores e: {0} ", media);

            Console.ReadKey();
        }
    }
}