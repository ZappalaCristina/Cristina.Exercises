using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GeographicInformations.Continent;

namespace GeographicInformations
{
    internal class Organization
    {
        string _name;
        string _seat; // probabilmente la traduzione di "sede" è sbagliata 
        Nation _nation; 
        public string Name { get { return _name; } set { _name = value; } } 
        public string Seat { get { return _seat; } set { _seat = value; } } 
        public Nation Nation { get { return _nation;  } set { _nation = value; } }
        public void AddNation(Nation nation) { Nation = nation; }
        public void RemoveNation(Nation nation) { Nation = null; }

    }
}
