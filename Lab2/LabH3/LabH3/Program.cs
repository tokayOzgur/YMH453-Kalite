using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabH3
{
    public class Program
    {
        class Uyg1
        {
            //Fibonacci sayılarını for, do-while ve while döngüleri ile gerçekleştirip, performanslarını kıyaslayınız.
            Stopwatch stopwatch = new Stopwatch();
            public void FibFor()
            {
                stopwatch.Start();
                int adet = 10;
                int a = 0;
                int b = 1;
                Console.Write(a + " " + b + " ");
                for (int i = 3; i < adet; i++)
                {
                    int c = a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                }
                stopwatch.Stop();
                Console.WriteLine("\nFibonacci For Hesaplanan süre: " + stopwatch.Elapsed);
            }

            public void FibWhile()
            {
                stopwatch.Start();
                int adet = 10;
                int a = 0;
                int b = 1;
                Console.Write(a + " " + b + " ");
                int i = 3; //ekstradan kod yazıldı
                while (i < adet)
                {
                    int c = a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                    i++; // ekstra
                }
                stopwatch.Stop();
                Console.WriteLine("\nFibonacci For Hesaplanan süre: " + stopwatch.Elapsed);
            }

            public void FibDoWhile()
            {
                stopwatch.Start();
                int adet = 10;
                int a = 0;
                int b = 1;
                Console.Write(a + " " + b + " ");
                int i = 3; //ekstradan kod yazıldı
                do
                {
                    int c = a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                    i++; // ekstra
                } while (i < adet);
                stopwatch.Stop();
                Console.WriteLine("\nFibonacci Do-While Hesaplanan süre: " + stopwatch.Elapsed);
            }
        }

        class Uyg2
        {
            //Bir sayının üssünü almak için C# dilinde recursive bir yöntem oluşturunuz. Oluşturduğunuz bu fonksiyonun performansını C# 'ın     Pow() fonksiyonu ile kıyaslayınız.

            public int UsAl(int sayi, int us)
            {
                if (us != 0)
                    return (sayi * UsAl(sayi, us - 1));
                else
                    return 1;
            }
        }

        class Uyg3
        {
            // Merge sort ile Bucket sort algoritmalarının performanslarını kıyaslayınız.

            // Merges two subarrays of []arr.
            // First subarray is arr[l..m]
            // Second subarray is arr[m+1..r]
            public void merge(int[] arr, int l, int m, int r)
            {
                // Find sizes of two
                // subarrays to be merged
                int n1 = m - l + 1;
                int n2 = r - m;

                // Create temp arrays
                int[] L = new int[n1];
                int[] R = new int[n2];
                int i, j;

                // Copy data to temp arrays
                for (i = 0; i < n1; ++i)
                    L[i] = arr[l + i];
                for (j = 0; j < n2; ++j)
                    R[j] = arr[m + 1 + j];

                // Merge the temp arrays

                // Initial indexes of first
                // and second subarrays
                i = 0;
                j = 0;

                // Initial index of merged
                // subarray array
                int k = l;
                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }

                // Copy remaining elements
                // of L[] if any
                while (i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }

                // Copy remaining elements
                // of R[] if any
                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }
            public void Msort(int[] arr, int l, int r)
            {
                if (l < r)
                {
                    // Find the middle
                    // point
                    int m = l + (r - l) / 2;

                    // Sort first and
                    // second halves
                    Msort(arr, l, m);
                    Msort(arr, m + 1, r);

                    // Merge the sorted halves
                    merge(arr, l, m, r);
                }
            }

            public void bucketSort(float[] arr, int n)
            {
                if (n <= 0)
                    return;

                // 1) Create n empty buckets
                List<float>[] buckets = new List<float>[n];

                for (int i = 0; i < n; i++)
                {
                    buckets[i] = new List<float>();
                }

                // 2) Put array elements in different buckets
                for (int i = 0; i < n; i++)
                {
                    float idx = arr[i] * n;
                    buckets[(int)idx].Add(arr[i]);
                }

                // 3) Sort individual buckets
                for (int i = 0; i < n; i++)
                {
                    buckets[i].Sort();
                }

                // 4) Concatenate all buckets into arr[]
                int index = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < buckets[i].Count; j++)
                    {
                        arr[index++] = buckets[i][j];
                    }
                }
            }

            //Diziyi Ekrana Yazdırma
            public void printArray(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
        }

        class Uyg4
        {
            //Kitaplar ve kitapların ISBN numaralarını gösteren bir sözlük yapısı oluşturunuz. Yazacağınız program kullanıcıdan kitabın ismini alacak ve karşılık olarak bu kitabın ISBN numarasını bu sözlük yapısından çekecektir. Eğer kullanıcı kütüphanede bulunmayan bir kitap söylerse ise kullanıcıya böyle bir kitap olmadığına dair bilgi verilecektir.
            // Bu uygulamayı if-else ve switch-case ifadeleri ile gerçekleştirip, performanslarını kıyaslayınız.
            public Dictionary<string, string> Books { get; set; }
            public Uyg4()
            {
                Dictionary<string, string> Kitaplar = new Dictionary<string, string>();
                Kitaplar.Add("Yüzüklerin Efendisi: Yüzük Kardeşliği", "9789753425");
                Kitaplar.Add("Yüzüklerin Efendisi: İki Kule", "9753421818");
                Kitaplar.Add("Yüzüklerin Efendisi: Kralın Dönüşü", "9753422024");
                Kitaplar.Add("Dune", "605375479X");
                Kitaplar.Add("Dune Çocukları", "6053756024");
                Kitaplar.Add("Drizzt Efsanesi I: Anayurt", "6053755575");
                Kitaplar.Add("Drizzt Efsanesi 2: Sürgün", "6059958133");
                Kitaplar.Add("Zaman Çarkı I: Dünyanın Gözü", "9758725718");
                Kitaplar.Add("Zaman Çarkı 2: Büyük Av", "9758725726");
                Books = Kitaplar;
            }

            public void SorguIfElse(string val)
            {
                bool varMi = Books.ContainsKey(val);
                if (varMi)
                {
                    Console.WriteLine(val + " Kitabının ISBN: " + Books[val]);
                }
                else
                {
                    Console.WriteLine("Aradığınız Kitap Bulunamadı.");
                }
            }

            public void SorguSwitchCase(string val)
            {
                bool varMi = Books.ContainsKey(val);
                switch (varMi)
                {
                    case true:
                        Console.WriteLine(val + " Kitabının ISBN: " + Books[val]);
                        break;

                    default:
                        Console.WriteLine("Aradığınız Kitap Bulunamadı.");
                        break;
                }
            }
        }

        class Uyg5
        {
            //Türkçe alfabesindeki harflerin sırasını gösteren programı if-else ve switch-case ifadeleri ile gerçekleştirip, performanslarını kıyaslayınız. Kullanıcılar bir harf değeri girecek ve buna karşılık sistem girilen harfin alfabede kaçıncı sırada olduğunu gösterecektir.

            public void SorguIfElse(string val)
            {
                if (val == "a" || val == "A")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 1");
                else if (val == "b" || val == "B")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 2");
                else if (val == "c" || val == "C")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 3");
                else if (val == "ç" || val == "Ç")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 4");
                else if (val == "d" || val == "D")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 5");
                else if (val == "e" || val == "E")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 6");
                else if (val == "f" || val == "F")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 7");
                else if (val == "g" || val == "G")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 8");
                else if (val == "ğ" || val == "Ğ")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 9");
                else if (val == "h" || val == "H")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 10");
                else if (val == "ı" || val == "I")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 11");
                else if (val == "i" || val == "İ")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 12");
                else if (val == "j" || val == "J")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 13");
                else if (val == "k" || val == "K")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 14");
                else if (val == "l" || val == "L")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 15");
                else if (val == "m" || val == "M")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 16");
                else if (val == "n" || val == "N")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 17");
                else if (val == "o" || val == "O")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 18");
                else if (val == "ö" || val == "Ö")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 19");
                else if (val == "p" || val == "P")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 20");
                else if (val == "r" || val == "R")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 21");
                else if (val == "s" || val == "S")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 22");
                else if (val == "ş" || val == "Ş")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 23");
                else if (val == "t" || val == "T")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 24");
                else if (val == "u" || val == "U")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 25");
                else if (val == "ü" || val == "Ü")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 26");
                else if (val == "v" || val == "V")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 27");
                else if (val == "y" || val == "Y")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 28");
                else if (val == "z" || val == "Z")
                    Console.WriteLine(val + "'ın bulunduğu sıra: 29");
                else
                    Console.WriteLine("Hatalı Değer Girdiniz");
            }

            public void SorguSwitchCase(string val)
            {
                switch (val)
                {
                    case "a":
                    case "A":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 1");
                        break;
                    case "b":
                    case "B":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 2");
                        break;
                    case "c":
                    case "C":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 3");
                        break;
                    case "ç":
                    case "Ç":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 4");
                        break;
                    case "d":
                    case "D":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 5");
                        break;
                    case "e":
                    case "E":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 6");
                        break;
                    case "f":
                    case "F":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 7");
                        break;
                    case "g":
                    case "G":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 8");
                        break;
                    case "ğ":
                    case "Ğ":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 9");
                        break;
                    case "h":
                    case "H":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 10");
                        break;
                    case "ı":
                    case "I":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 11");
                        break;
                    case "i":
                    case "İ":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 12");
                        break;
                    case "j":
                    case "J":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 13");
                        break;
                    case "k":
                    case "K":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 14");
                        break;
                    case "l":
                    case "L":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 15");
                        break;
                    case "m":
                    case "M":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 16");
                        break;
                    case "n":
                    case "N":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 17");
                        break;
                    case "o":
                    case "O":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 18");
                        break;
                    case "ö":
                    case "Ö":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 19");
                        break;
                    case "p":
                    case "P":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 20");
                        break;
                    case "r":
                    case "R":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 21");
                        break;
                    case "s":
                    case "S":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 22");
                        break;
                    case "ş":
                    case "Ş":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 23");
                        break;
                    case "t":
                    case "T":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 24");
                        break;
                    case "u":
                    case "U":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 25");
                        break;
                    case "ü":
                    case "Ü":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 26");
                        break;
                    case "v":
                    case "V":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 27");
                        break;
                    case "y":
                    case "Y":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 28");
                        break;
                    case "z":
                    case "Z":
                        Console.WriteLine(val + "'ın bulunduğu sıra: 29");
                        break;
                    default:
                        Console.WriteLine("Hatalı Giriş");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch(); // Stopwatch nesnesi

            #region Uyg1
            //Uyg1 uyg1 = new Uyg1();
            //uyg1.FibFor();
            //uyg1.FibWhile();
            //uyg1.FibDoWhile();
            #endregion


            #region Uyg2
            //Console.WriteLine("*******************************************************");
            //Uyg2 uyg2 = new Uyg2();

            //// Recursive
            //stopwatch.Start();
            //Console.WriteLine("Sonuç: " + uyg2.UsAl(2, 5));
            //stopwatch.Stop();
            //Console.WriteLine("REcursive Üs Alma Hesaplana Süre: " + stopwatch.Elapsed);

            ////Pow()
            //stopwatch.Start();
            //Console.WriteLine("Sonuç: " + Math.Pow(2, 5));
            //stopwatch.Stop();
            //Console.WriteLine("Pow() Üs Alma Hesaplana Süre: " + stopwatch.Elapsed);
            #endregion


            #region Uyg3
            //Console.WriteLine("*************************************");

            //Uyg3 uyg3 = new Uyg3();
            //int[] arr = { 12, 11, 13, 5, 6, 7 };
            //Console.WriteLine("Verilen Dizi: ");
            //uyg3.printArray(arr);

            ////MergeSort
            //stopwatch.Start();
            //uyg3.Msort(arr, 0, arr.Length - 1);
            //stopwatch.Stop();
            ////Sıralanmış dizi
            //Console.WriteLine("\nSıralanmış Dizi: ");
            //uyg3.printArray(arr);
            //Console.WriteLine("\nMerge Sort Performans: " + stopwatch.Elapsed);

            //Console.WriteLine("\n---------------------------------------------");

            ////BucketSort
            //float[] arr2 = { (float)0.897, (float)0.565,
            //       (float)0.656, (float)0.1234,
            //       (float)0.665, (float)0.3434 };

            //stopwatch.Start();
            //uyg3.bucketSort(arr2, arr.Length);
            //stopwatch.Stop();
            //Console.WriteLine("\nBucketSort ile Sıralanmış Dizi: ");
            //foreach (float el in arr2)
            //{
            //    Console.Write(el + " ");
            //}

            //Console.WriteLine("\nBuckerSort Performans: "+ stopwatch.Elapsed);
            #endregion


            #region Uyg4
            //Console.WriteLine("\n**************************************************");
            //Uyg4 uyg4 = new Uyg4();
            //string value = "Dune";

            //stopwatch.Start();
            //uyg4.SorguIfElse(value);
            //stopwatch.Stop();
            //Console.WriteLine("\nİf-Else Persormansı: " + stopwatch.Elapsed);

            //Console.WriteLine("\n---------------------------------------------------\n");

            //stopwatch.Start();
            //uyg4.SorguSwitchCase(value);
            //stopwatch.Stop();
            //Console.WriteLine("\nSwitch-Case Performansı: " + stopwatch.Elapsed);

            #endregion


            #region Uyg5
            //Console.WriteLine("/**************************************************");
            //Uyg5 uyg5 = new Uyg5();
            //string girdi = "g";

            //stopwatch.Start();
            //uyg5.SorguIfElse(girdi);
            //stopwatch.Stop();
            //Console.WriteLine("\n İf-Else Performans: " + stopwatch.Elapsed);

            //Console.WriteLine("------------------------------------------------");

            //stopwatch.Start();
            //uyg5.SorguSwitchCase(girdi);
            //Console.WriteLine("\nSwitch-Case Performans: " + stopwatch.Elapsed);
            //stopwatch.Stop();
            #endregion

            Console.ReadLine();
        }
    }
}
