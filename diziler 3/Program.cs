namespace Diziler_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = { 1, 2, 3, 4, 5 };
            //foreach (int i in sayilar)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            //string[] şehirler = { "Ankara", "Maraş", "Elbistan", "İstanbul", "Eskişehir" };
            //foreach(string i in şehirler)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            //int[] sayilar = { 1, 2, 3, 4, 5, };
            //int toplam = 0;
            //foreach (int i in sayilar)
            //{
            //    toplam=toplam+i;
            //}
            //Console.WriteLine("Toplam:"+toplam);
            //Console.ReadLine();
            //int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach(int sayi in rakamlar)
            //{
            //    if (sayi%2== 0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //}
            //Console.ReadLine();
            int[]sayilar= {1,2,3,4,5};
            int sonuç = 1;
            foreach (int i in sayilar)
            {
                sonuç = sonuç * i;
            }
            Console.WriteLine("5 sayısının faktöriyeli:"+sonuç);
            Console.ReadLine();

        }
    }
}
