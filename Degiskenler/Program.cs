using System;
namespace Degiskenler
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int deger;
            deger = 2;
            string degisken = null;
            string Degisken = null;
            byte b = 5;                   //1byte
            sbyte s = 5;                  //1byte
            short sh = 5;                 //2byte
            ushort ush = 5;               //2byte
            int i = 2;                    //4byte
            Int16 i16 = 2;                //2byte
            Int32 i32 = 2;                //4byte
            Int64 i64 = 2;                //4byte
            uint ui = 2;                //4byte
            long l = 4;                //8byte
            ulong ul = 4;                //8byte

            //Reel Sayılar
            float f = 5;                //4byte
            double d = 5;                //8byte
            decimal de = 5;                //16byte

            //String
            char ch = '2';                //2byte
            string fatih = "deneme";                //Sınırsız

            bool b1 = true;
            bool b2 = false;

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

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            bool bool1 =10>2;//true

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