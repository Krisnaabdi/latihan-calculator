using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Method(string[] args) { }
        static float penambahan(float a, float b)
        {
            return a + b;
        }
        static float pengurangan(float a, float b)
        {
            return a - b;
        }
        static float perkalian(float a, float b)
        {
            return a * b;
        }
        static float pembagian(float a, float b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.Title = "calculatorapp1";
        hitungulang:
            int pilih;

            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");

        pilihmenu:
            {

                Console.Write("Pilih menu 1 sampai 4 = ");
                pilih = int.Parse(Console.ReadLine());
            }
            if (pilih < 1)
            {

                Console.WriteLine("menu tidak tersedia!");
                goto pilihmenu;

            }
            else if (pilih > 4)
            {
                Console.WriteLine("menu tidak tersedia!");
                goto pilihmenu;
            }

            {

                Console.Write("Inputkan nilai a = ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                float b = float.Parse(Console.ReadLine());

                switch (pilih)
                {
                    case 1:
                        {
                            Console.WriteLine("hasil penambahan " + a + " + " + b + " = " + penambahan(a, b));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
                            break;
                        }
                    default:
                        Console.WriteLine("menusalah");
                        break;

                }
            menukeluar:
                {
                    Console.WriteLine("1.Ulangi Progream");
                    Console.WriteLine("2.tetap keluar");
                    int ulang = int.Parse(Console.ReadLine());
                    if (ulang == 1)
                    {
                        Console.Clear();
                        goto hitungulang;
                    }
                    else if (ulang == 2)
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Menu Tidak Tersedia");
                        goto menukeluar;
                    }
                }

            }

        }

    }
}