using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ManavOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList manavmeyve = new ArrayList();
            ArrayList manavsebze = new ArrayList();

            manavmeyve.Add("1)Elma");
            manavmeyve.Add("2)Armut");
            manavmeyve.Add("3)Karpuz");
            manavsebze.Add("1)Domates");
            manavsebze.Add("2)Biber");
            manavsebze.Add("3)Soğan");

            double stokelma = 0;
            double stokarmut = 0;
            double stokkarpuz = 0;
            double stokdomates = 0;
            double stokbiber = 0;
            double stoksogan = 0;

        DON:
            Console.WriteLine("*************HOŞGELDİNİZ*************");

            Console.WriteLine("Mevcut durum\n\nElma:" + stokelma);
            Console.WriteLine("Armut:" + stokarmut);
            Console.WriteLine("Karpuz:" + stokkarpuz);
            Console.WriteLine("Domates:" + stokdomates);
            Console.WriteLine("Biber:" + stokbiber);
            Console.WriteLine("Soğan:" + stoksogan);

            Console.WriteLine("\nLütfen seçim yapınız..");

            Console.WriteLine("1) Hal Bölümü\n2) Manav Bölümü");
            int secimhalmanav = Convert.ToInt32(Console.ReadLine());

            #region Hal Bölümü
            if (secimhalmanav == 1)
            {
                Console.WriteLine("Hal Bölümü\nSeçim yapınız..");
                Console.WriteLine("1)Meyve\n2)Sebze");
                int halsecim = Convert.ToInt32(Console.ReadLine());
                #region hal-meyve bölümü
                if (halsecim == 1)
                {
                    Console.WriteLine("Meyve seçimi yapınız");
                    foreach (var item in manavmeyve)
                    {

                        Console.WriteLine(item);


                    }
                    double meyvesecim = Convert.ToDouble(Console.ReadLine());
                    if (meyvesecim == 1)
                    {
                        Console.WriteLine("Kaç Kilo Alacaksınız?");
                        double tus4 = Convert.ToDouble(Console.ReadLine());
                        stokelma += tus4;
                        Console.WriteLine("Satın alındı.");
                        Console.Clear();
                        goto DON;
                    }
                    else if (meyvesecim == 2)
                    {
                        Console.WriteLine("Kaç Kilo Alacaksınız?");
                        double tus5 = Convert.ToDouble(Console.ReadLine());
                        stokarmut += tus5;
                        Console.WriteLine("Satın alındı.");
                        Console.Clear();
                        goto DON;

                    }

                    else if (meyvesecim == 3)
                    {
                        Console.WriteLine("Kaç Kilo Alacaksınız?");
                        double tus6 = Convert.ToDouble(Console.ReadLine());
                        stokkarpuz += tus6;
                        Console.WriteLine("Satın alındı.");
                        Console.Clear();
                        goto DON;

                    }
                    else
                    {

                        Console.WriteLine("Hatalı tuşlama yaptınız.");
                        Console.Clear();
                        goto DON;
                    }

                }
                #endregion
                #region hal-sebze bölümü
                else if (halsecim == 2)
                {
                    Console.WriteLine("Sebze seçimi yapınız");
                    foreach (var item in manavsebze)
                    {

                        Console.WriteLine(item);


                    }
                    double sebzesecim = Convert.ToDouble(Console.ReadLine());
                    if (sebzesecim == 1)
                    {
                        Console.WriteLine("Kaç Kilo Alacaksınız?");
                        double tus4 = Convert.ToDouble(Console.ReadLine());
                        stokdomates += tus4;
                        Console.WriteLine("Satın alındı.");
                        Console.Clear();
                        goto DON;
                    }
                    else if (sebzesecim == 2)
                    {
                        Console.WriteLine("Kaç Kilo Alacaksınız?");
                        double tus5 = Convert.ToDouble(Console.ReadLine());
                        stokbiber += tus5;
                        Console.WriteLine("Satın alındı.");
                        Console.Clear();
                        goto DON;

                    }

                    else if (sebzesecim == 3)
                    {
                        Console.WriteLine("Kaç Kilo Alacaksınız?");
                        double tus6 = Convert.ToDouble(Console.ReadLine());
                        stoksogan += tus6;
                        Console.WriteLine("Satın alındı.");
                        Console.Clear();
                        goto DON;

                    }
                    else
                    {

                        Console.WriteLine("Hatalı tuşlama yaptınız.");
                        Console.Clear();
                        goto DON;
                    }

                }
                #endregion
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    Console.Clear();
                    goto DON;
                }
            }
            #endregion
            #region Manav Bölümü
            else if (secimhalmanav == 2)
            {
                Console.WriteLine("Manav Bölümü\nSeçim yapınız..");
                Console.WriteLine("1)Meyve\n2)Sebze");
                int manavsecim = Convert.ToInt32(Console.ReadLine());
                #region Manav-Meyve Bölümü
                if (manavsecim == 1)
                {
                    Console.WriteLine("Meyve seçimi yapınız");
                    foreach (var item in manavmeyve)
                    {

                        Console.WriteLine(item);


                    }
                    double meyvesecim = Convert.ToDouble(Console.ReadLine());
                    if (meyvesecim == 1)
                    {
                        Console.WriteLine("Kaç Kilo Satacaksınız?");
                        double tus4 = Convert.ToDouble(Console.ReadLine());
                        stokelma -= tus4;
                        Console.WriteLine("Satış yapıldı");
                        Console.Clear();
                        goto DON;
                    }
                    else if (meyvesecim == 2)
                    {
                        Console.WriteLine("Kaç Kilo Satacaksınız?");
                        double tus5 = Convert.ToDouble(Console.ReadLine());
                        stokarmut -= tus5;
                        Console.WriteLine("Satış yapıldı.");
                        Console.Clear();
                        goto DON;

                    }

                    else if (meyvesecim == 3)
                    {
                        Console.WriteLine("Kaç Kilo Satacaksınız?");
                        double tus6 = Convert.ToDouble(Console.ReadLine());
                        stokkarpuz -= tus6;
                        Console.WriteLine("Satış yapıldı.");
                        Console.Clear();
                        goto DON;

                    }
                    else
                    {

                        Console.WriteLine("Hatalı tuşlama yaptınız.");
                        Console.Clear();
                        goto DON;
                    }

                }
                #endregion
                #region Hal-Sebze Bölümü
                else if (manavsecim == 2)
                {
                    Console.WriteLine("Sebze seçimi yapınız");
                    foreach (var item in manavsebze)
                    {

                        Console.WriteLine(item);


                    }
                    double sebzesecim = Convert.ToDouble(Console.ReadLine());
                    if (sebzesecim == 1)
                    {
                        Console.WriteLine("Kaç Kilo Satacaksınız?");
                        double tus4 = Convert.ToDouble(Console.ReadLine());
                        stokdomates -= tus4;
                        Console.WriteLine("Satış yapıldı.");
                        Console.Clear();
                        goto DON;
                    }
                    else if (sebzesecim == 2)
                    {
                        Console.WriteLine("Kaç Kilo Satacaksınız?");
                        double tus5 = Convert.ToDouble(Console.ReadLine());
                        stokbiber -= tus5;
                        Console.WriteLine("Satış yapıldı.");
                        Console.Clear();
                        goto DON;

                    }

                    else if (sebzesecim == 3)
                    {
                        Console.WriteLine("Kaç Kilo Satacaksınız?");
                        double tus6 = Convert.ToDouble(Console.ReadLine());
                        stoksogan -= tus6;
                        Console.WriteLine("Satış yapıldı.");
                        Console.Clear();
                        goto DON;

                    }
                    else
                    {

                        Console.WriteLine("Hatalı tuşlama yaptınız.");
                        Console.Clear();
                        goto DON;
                    }

                }
                #endregion
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    Console.Clear();
                    goto DON;
                }
            }
            #endregion
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız..");
                Console.Clear();
                goto DON;

            }

        }
    }
}
