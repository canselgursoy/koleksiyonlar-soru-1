using System;
using System.Collections;

namespace koleksiyonlar_soru_1
{
    class Program
    {
        static  void Main(string[] args)
        {
            //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            //(ArrayList sınıfını kullanarak yazınız.)

            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            
            ArrayList asalsayiListesi =new ArrayList();
            ArrayList asalolmayansayiListesi= new ArrayList();

            int index =1;
            int step =20;

            while (step > 0)
            {
                Console.WriteLine("{0}.sayıyı giriniz", index++);

                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if(number>1)
                    {
                        for(int i =2; i<number;i++);
                        {
                            if (number % i == 0)
                            {
                                asalolmayansayiListesi.Add(number);
                                break;

                            }
                        }

                        if (!asalolmayansayiListesi.Contains(number))
                        {
                            asalsayiListesi.Add(number);
                        }
                        step --;

                    }

                    else
                    {
                        Console.WriteLine("negatif bir sayı girmeyiniz!");
                        index -- ;
                        continue;

                    }

                }

                catch (Exception e)
                {
                    Console.WriteLine("hata: " +e.Message.ToString());
                    index --;

                }


            }

            Console.WriteLine();

            asalsayiListesi.Sort();
            asalolmayansayiListesi.Sort();
            int sumasal = 0;
            int sumasalolmayan = 0;

            Console.WriteLine("****asal***");
            foreach (int i in asalsayiListesi)
            {
                Console.WriteLine(i);
                sumasal += i;
            }

            Console.WriteLine("asalsayı eleman sayısı:"+ asalsayiListesi.Count);
            Console.WriteLine("asal sayı ortalama:"+ (sumasal/asalsayiListesi.Count));

            Console.WriteLine("****asal olmayan***"); 


            foreach (int i in asalolmayansayiListesi)
            {
                Console.WriteLine(i);
                sumasalolmayan += i;
            }
            Console.WriteLine("asalolmayansayı eleman sayısı:"+ asalolmayansayiListesi.Count);
            Console.WriteLine("asalolmayan sayılar ortalama:"+ (sumasalolmayan/asalolmayansayiListesi.Count));
            








        }
    }
}
