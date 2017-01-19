using System;


namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            var groundL = double.Parse(Console.ReadLine());
            var plateW = double.Parse(Console.ReadLine());
            var plateL = double.Parse(Console.ReadLine());
            var benchW = double.Parse(Console.ReadLine());
            var benchL = double.Parse(Console.ReadLine());

            var ground = groundL * groundL; //20*20=400
            var plates = plateW * plateL; //5*4=20
            var bench = benchL * benchW; //1*2=2
            var platesN = (ground - bench) / plates; // (400/20)-2

            Console.WriteLine(platesN);
            Console.WriteLine(platesN * 0.2);
        }
    }
}
