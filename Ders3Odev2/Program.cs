using System;

namespace Ders3Odev2
{
    class Program
    {
        static void Main(string[] args)
        {

            //ref ve out anahtar kelimeleri aynı işlemi yapar.
            //Fakat ref değişkenine başlangıç değerinin verilmesi gerekirken, out değerinde böyle bir zorunluluk yoktur.

                int number1 = 20;
                int number2 = 100;
                int number3;
                int number4 = 50;
                var result = Add(ref number1, number2);
                var result2 = Add2(out number3, number4);

                Console.WriteLine(result);
                Console.WriteLine(result2);
                Console.ReadLine();
            }

            static int Add(ref int number1, int number2)
            {
                number1 = 10;
                var result = number1 + number2;
                return result;
            }

            static int Add2(out int number3, int number4)
            {
              number3 = 30;
              return number3 + number4;
            }
        }
    }
