using System;

namespace GeographicInformations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Continent europe = new Continent("Europe");
            europe.CreateNat("Italy");
            europe.CreateReg("Sicily");
            europe.CreatePro("Messina");
            europe.CreateMuni("Giardini-Naxos");
            //Console.WriteLine($" {}"); 
            //Console.WriteLine("");
            europe.ChangeMuni("Italy", "Sicily", "Catania", "Giardini-Naxos");
        }
    }
}
