using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        public string qwe()
        {
            //перевод из 10 в 2
            double x = 77.77;
            double y = Math.Truncate(x), t = x, ostat = Math.Round((x - y), 2), ostatt;
            string tsel = "";
            string ost = "";
            double[] div = new double[10];
            ostatt = Math.Round(((t - y) * 2), 3);
            for (int i = 0; i < 10; i++)
            {
                //выделяем целую часть
                t = Math.Round((ostat * 2), 3);//выделяем остаток и умножаем на 2
                ostatt = Math.Truncate(t);//выделяем целую часть остатка
                ostat = Math.Round((t - ostatt), 2);//итоговый остаток
                ost = string.Concat(ost, ostatt);//записываем остаток в строку

                y = Math.Truncate(x) % 2;
                if (x >= 1)
                {
                    if (y != 0)
                        tsel = string.Concat(tsel, 1);
                    else
                        tsel = string.Concat(tsel, 0);

                }
                x = Math.Floor(x / 2);//делим целую часть

            }
            char[] tseluy = tsel.ToCharArray();
            Array.Reverse(tseluy);
            string tsel1 = new string(tseluy);
            return (tsel1);
            return (ost);

        }

        public double qwer()
        {
            //Перевод из 2 в 10
            string tsel = "111001";
            string ost = "011111";
            int y = 0;
            double z = 0;
            for (int i = 0; i < tsel.Length; i++)
            {
                int temp = 2 ^ i;
                y += (int)Char.GetNumericValue(tsel[tsel.Length - i - 1]) * (int)Math.Pow(2, i);

            }
            for (int i = -1; i > -ost.Length; i--)
            { 
                z += (double)Char.GetNumericValue(ost[-i - 1]) * (double)Math.Pow(2, i);
            }
            double res = y + z;
            return (res);
        }

        public double random()
        {
            //Генерация исходной популяции
            Random rnd = new Random();
            double rand = rnd.Next(0,8);
            return (rand);
        }

        public double prisposobl(double x)
        {
            //Оценивание функии приспособленности
            double y = Math.Cos(Math.Pow(x, 2)) / x;
            return (y);
        }

        public string skresh(string[,] mas, int perv, int vtor)
        {
            //Скрещивание
            Random rnd = new Random();
            int rand = rnd.Next(0, 10);
            string tsel1 = mas[0, perv];
            string tsel2 = mas[0, vtor];
            string ost1  = mas[1, perv];
            string ost2  = mas[1, vtor];
            for(int i=0;i<=rand; i++)
            {

            }

            return ("0");
        }
        static void Main(string[] args)
        {

            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
