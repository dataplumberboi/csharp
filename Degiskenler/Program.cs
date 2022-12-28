using System;
namespace Degiskenler
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'x';
            object o3 = 4;
            object o4 = 4.3;

            string str1 = string.Empty;
            str1 ="str1";
            string ad ="Ad";
            string soyad ="Soyad";
            string tamAd = ad+" "+soyad;

            string strS ="20";
            int intS = 20;
            string yeniDeger = strS + intS.ToString();
            Console.WriteLine(yeniDeger);

            int intS2 = intS+Convert.ToInt32(strS);
            Console.WriteLine(intS2);

            int intS3 = intS2 + int.Parse(strS);


            string datetime1 = DateTime.Now.ToString("dd.MMMM.yyyy");
            Console.WriteLine(datetime1);
            string datetime2 = DateTime.Now.ToString("dd/MMMM/yyyy");
            Console.WriteLine(datetime2);
            string datetime = DateTime.Now.ToString("dd.MMMM.yyyy HH:ss");
            Console.WriteLine(datetime);
        }
    }
}