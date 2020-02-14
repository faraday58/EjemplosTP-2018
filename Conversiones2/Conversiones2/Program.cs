using System;


namespace Conversiones2
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 50f;
            int y = 200;
            int z1 = y / (int)x;
            float z2 = y / x;
            Console.WriteLine(z1);
            Console.WriteLine(z2);

            float miFlotante1 = Convert.ToSingle("22") / 2;
            float miFlotante2 = float.Parse("22") / 2;

            int miEntero = (int)21.22f;
            byte miByte1 = 58;
            byte miByte2 = 200;
            int resByte = miByte1 + miByte2;
            Console.ReadLine();
        }
    }
}
