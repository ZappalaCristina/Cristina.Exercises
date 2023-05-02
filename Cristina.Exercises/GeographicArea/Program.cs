using System;

namespace GeographicArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Continent europe = new Continent("Europe");
            europe.CreateNation("Italy");
            europe.CreateRegion("Sicily");
            europe.CreateProvince("Messina");
            europe.CreateMunicipality("Giardini-Naxos");
            //Console.WriteLine($" {}"); 
            europe.ChangeMunicipality("Italy", "Sicily", "Catania", "Giardini-Naxos");

        }
    }
}
