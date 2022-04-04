using System;

namespace Homework01042022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region /*Task1*/

            //Task1
            //Daxil Edilmis 3 Dene Ededin Arasinda En Boyuyunu Tapan Alqoritm Qurmaq.
            //    int num1 = 126;
            //    int num2 = 230;
            //    int num3 = 44;
            //    Big(num1,num2,num3);
            //}
            //static void Big(int num1, int num2, int num3)
            //{
            //    if (num1 > num2 && num1 > num3)
            //    {
            //        Console.WriteLine($"En boyuk eded num1-dir.Deyeri={num1}");
            //    }
            //    else if (num2 > num1 && num2 > num3)
            //    {
            //        Console.WriteLine($"En boyuk eded num2-dir.Deyeri={num2}");
            //    }
            //    else if (num3 > num1 && num3 > num2)
            //    {
            //        Console.WriteLine($"En boyuk eded num3-dur. Deyeri={num3}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Beraberlik var");
            //    }
            //}


            #endregion
            #region/* Task2*/

            //Task2
            //    Daxil Edilmis 5 Dene Ededin Ededi Ortasini Tapan Alqoritm Qurmaq
            //    int num1 = 25;
            //    int num2 = 32;
            //    int num3 = 12;
            //    int num4 = 23;
            //    int num5 = 8;

            //    Average(num1, num2, num3, num4, num5);
            //}
            //static void Average(int num1, int num2, int num3, int num4, int num5)
            //{
            //    int average = 0;
            //    int Sum = 1;
            //    int result = 0;
            //    Sum = num1 + num2 + num3 + num4 + num5;
            //    if (Sum > 0)
            //    {
            //        average = Sum / 5;
            //        result = average;
            //        Console.WriteLine(result);
            //    }
            //}

            #endregion

            #region/* Task3*/
            //Task3 Duzbucaqlinin Sahe Ve Perimetrini Tapan Alqoritm Qurmaq
            //    int width = 25;
            //    int length = 16;
            //    SandP(width, length);
            //}

            //static void SandP(int width, int length)
            //{
            //    int S = 0;
            //    int P = 0;
            //    S = width * length;
            //    Console.WriteLine($"Duzbucaqlinin sahesi {S}");
            //    P = 2 * (width + length);
            //    Console.WriteLine($"Duzbucaqlinin perimetri { P}");
            //}
            #endregion

            #region /*Task4*/
            //Task4 İsdifadəçi Ədəd Daxil Edir. Daxil Edilən Ədəd Sadə Və Ya Mürəkkəb Olduğunu Tapana Alqoritm Qurun.
            //    int a = 251;
            //    int count = 0;
            //    Sade(a, count);

            //}
            //static void Sade(int a, int count)
            //{
            //    if (a > 1)
            //    {
            //        for (int i = 1; i <= a; i++)
            //        {
            //            if (a % i == 0)
            //            {
            //                count++;
            //            }

            //            if (count > 2)
            //            {
            //                Console.WriteLine("Daxil edilen eded murekkeb ededdir");
            //                break;
            //            }
            //        }

            //        if (count <= 2)
            //        {
            //            Console.WriteLine("Daxil edilen eded sade ededdir");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Duzgun eded daxil et");
            //    }
            //}
            #endregion

            #region  /*Task5*/
            //İsdifadəçi Ədəd Daxil Edir. Daxil Edilən Ədədin Neçə Mərtəbəbli Olduğunu Tapan Alqoritmi Qurun(Misal: 15613 - 5 Mərtəbəli, 656 - 3 Mərtəbəli)

            //    int a = 15613;
            //    int count = 1;
            //    Digit(a, count);

            //}
            //static void Digit(int a, int count)
            //{
            //    for (int i = 0; i < a; i++)
            //    {
            //        if (a > 1)
            //        {
            //            a = a / 10;
            //            count++;
            //        }
            //    }
            //    Console.WriteLine("Daxil edilen ededin mertebelerinin sayi: " + count);
            //}

            #endregion
            #region /*Task6*/
            // Daxil Edilən Ədədin Müsbət Və Natural Olmalıdır.Daxil Edilən Ədədin Həm 7 - ə Həm Də 3 - ə Bölünüb Bölünməməsini Tap

            //    int num = 63;
            //    Eded(num);
            //}
            //static void Eded(int num)
            //{
            //    if (num > 1)
            //    {
            //        if ((num % 21) == 0)
            //        {
            //            Console.WriteLine("Daxil edilen eded hem3-e, hem de7-e bolunur");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Duzgun eded daxil edin");
            //        }
            //    }
            //}

            #endregion
            #region Task7
            //            Tələbə İmtahan Qiymətini Daxil Edir.Daxil Edilən İmtahan Qiyməti 0 və 100 Aralığında Olmalıdır.
            //Əgər Qiymət 91 və 100 Aralığındadırsa A Çap Etsin.
            //Əgər Qiymət 81 və 90 Aralığındadırsa B Çap Etsin.
            //Əgər Qiymət 71 və 80 Aralığındadırsa C Çap Etsin.
            //Əgər Qiymət 61 və 70 Aralığındadırsa D Çap Etsin.
            //Əgər Qiymət 51 və 60 Aralığındadırsa E Çap Etsin.
            //Əgər Qiymət 51 - dən Kiçikdirsə Kəsildiniz Çap Etsin.

            //    int grade;
            //    Console.WriteLine($"Telebenin qiynetini daxil edin: ");
            //    grade = Convert.ToInt32(Console.ReadLine());
            //    Grade(grade);
            //}

            //    static void Grade(int grade)
            //    {
            //    if (grade >= 0 && grade <= 100)
            //    {
            //        if (grade >= 91 && grade <= 100)
            //        {
            //            Console.WriteLine(" A");
            //        }
            //        else if (grade >= 81 && grade <= 90)
            //        {
            //            Console.WriteLine("B");
            //        }
            //        else if (grade >= 71 && grade <= 80)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else if (grade >= 61 && grade <= 70)
            //        {
            //            Console.WriteLine("D");
            //        }
            //        else if (grade >= 51 && grade <= 60)
            //        {
            //            Console.WriteLine(" E");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Teessuf ki, siz imtahandan kesildiniz");
            //        }
            //    }

            #endregion
            #region /*Task8*/
            //İsdifadəçi 2 Dənə Ədəd Daxil Edir. Daxil Edilən Ədədlərdə Daxil Olmaqla Bu Ədədlərin Aralığında Olan Ədədlərin Çəmin Tapan Alqoritm Qurun.

            //    int a = 32;
            //    int b = 27;
            //    int min = 0;
            //    int max = 0;
            //    int result = 0;
            //    Result(a, b, result, min, max);

            //}
            //static void Result(int a, int b, int result, int min, int max)
            //{
            //    if (a != b)
            //    {
            //        if (a > b)
            //        {
            //            max = a;
            //            min = b;
            //        }
            //        else
            //        {
            //            max = b;
            //            min = a;
            //        }

            //        while (min <= max)
            //        {
            //            result += min;
            //            min++;
            //        }

            //        Console.WriteLine(result);

            //        return;
            //    }
            #endregion

            #region  /*Task9*/
            //İsdifadəçi 2 Dənə Ədəd  Daxil Edir n və m ədədləri. m Ədədinin n Qüvvətini Tapan Alqoritm Qur.
            //    int n = 4;
            //    int m = 3;
            //    int result = 1;
            //    Power(n, m, result);

            //    #endregion
            //}
            //static void Power(int n, int m, int result)
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        if (n > 1 && m > 1)
            //        {
            //            if (i <= n)
            //            {
            //                result = result * m;
            //                i++;
            //            }
            //        }
            //    }
            //    Console.Write("m ededinin n-ci quvveti : " + result);
            //}
            #endregion
        }
    }
}

