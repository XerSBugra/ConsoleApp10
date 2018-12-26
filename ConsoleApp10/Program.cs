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
            //double[] div = new double[10];
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
            for (int i = 0; i < tsel.Length; i++)//Для целой части
            {
                y += (int)Char.GetNumericValue(tsel[tsel.Length - i - 1]) * (int)Math.Pow(2, i);
            }
            for (int i = -1; i > -ost.Length; i--)//Для остатка
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
            string tsel1 = mas[0, perv];
            string tsel2 = mas[0, vtor];
            string TselRes = "";
            string OstRes = "";
            string temp = "";
            string ost1  = mas[1, perv];
            string ost2  = mas[1, vtor];
            int r= Math.Abs(tsel1.Length - tsel2.Length);
            while ((tsel1.Length < tsel2.Length) && (r > 0))
            {
                temp += "0";//Дописываем нули в начало
                r--;
            }
            temp += tsel1;//дописываем после нулей само число
            tsel1 = temp;
            while ((tsel1.Length > tsel2.Length) && (r > 0))
            {
                temp += "0";//Дописываем нули в начало
                r--;
            }
            temp += tsel2;//дописываем после нулей само число
            tsel2 = temp;
            Random rnd = new Random();
            int tempp = Math.Min(tsel1.Length, ost1.Length);
            int rand = rnd.Next(0, tempp);

            for (int i = 0; i < rand; i++)
            {
                TselRes += Char.GetNumericValue(tsel1[i]);
                OstRes += Char.GetNumericValue(tsel1[i]);
            }
            for (int i = rand; i <= tsel1.Length; i++)
            {
                TselRes += Char.GetNumericValue(tsel2[i]);
                OstRes += Char.GetNumericValue(tsel1[i]);
            }

            return (TselRes);
            return (OstRes);
        }

        public string mutation(string[,] mas, int perv)
        {
            //Мутация
            string tsel1 = mas[0, perv];
            string TselRes = "";
            string OstRes = mas[1, perv];
            string temp = "";
            string ost1 = mas[1, perv];
            Random rnd = new Random();
            int rand = rnd.Next(0, tsel1.Length);
            for (int i = 0; i < rand; i++)
                temp += tsel1;
            if(tsel1[rand]==0)
                temp += 1;
            else
                temp += 0;

            for (int i = rand+1; i <=tsel1.Length; i++)
                temp += tsel1;
            TselRes = temp;
            return (TselRes);
            return (OstRes);
        }

        public string inverse(string[,] mas, int perv)
        {
            //Инверсия
            string tsel1 = mas[0, perv];
            string TselRes = "";
            string OstRes = "";
            string temp ="";
            int tempp;
            string ost1 = mas[1, perv];
            for(int i=0; i<=tsel1.Length;i++)
            {
                tempp = (tsel1[i]);
                    if (tempp == 0)
                        tempp = 1;
                    else
                        tempp = 0;
                temp += tempp;
            }
            TselRes = temp;

            for (int i = 0; i <= ost1.Length; i++)
            {
                tempp = (ost1[i]);
                if (tempp == 0)
                    tempp = 1;
                else
                    tempp = 0;
                temp += tempp;
            }
            OstRes = temp;

            return (TselRes);
            return (OstRes);
        }

        public int ruletka(double[] MasPrisposobl, int perv, int vtor)
        {
            //Колесо рулетки
            double temp = MasPrisposobl[0];
            for (int i = 0; i <= MasPrisposobl.Length; i++)
            {
                if (temp > MasPrisposobl[i])//Нахождение минимума
                    temp = MasPrisposobl[i];
            }
            temp = Math.Abs(temp);
            Random rnd = new Random();
            double[,] qwe = new double[2,MasPrisposobl.Length];
            int rand = rnd.Next((int)qwe[1,0], (int)qwe[1,MasPrisposobl.Length]);
            for (int i = 0; i <= MasPrisposobl.Length; i++)//делаем сдвиг
                MasPrisposobl[i] += temp;
            for (int i = 0; i <=MasPrisposobl.Length; i++)//записываем в 0 строку сдвинутый массив
                qwe[0, i] = MasPrisposobl[i];
            qwe[1, 0] = qwe[0, 0];//Первое значение без изменений
            for (int i = 1; i <= MasPrisposobl.Length; i++)
                qwe[1, i] += qwe[1,i-1];//сумма с предидущим числом
                                        // for(int i=MasPrisposobl.Length;i>0;i--)
            int result = MasPrisposobl.Length;
            while (rand < qwe[1, result])
                result--;
            return (result);
        }

        static void Main(string[] args)
        {
            double
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
