using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GeographicInformations.Continent;

namespace GeographicInformations
{
    internal class Continent
    {
        string _nameCont;
        Nation _nation; 
        public Continent(string nationName) { Name = nationName; }
        public string Name { get { return _nameCont; }  set { _nameCont = value; } }
        public Nation NationObj { get { return _nation; } set { _nation = value; } }
        public void CreateNat(string nameNat) { NationObj = new Nation(nameNat); }
        public void CreateReg(string nameReg) { NationObj.CreateReg(nameReg); }
        public void CreatePro(string namePro) { NationObj.CreatePro(namePro); }
        public void CreateMuni(string nameMuni) { NationObj.CreateMuni(nameMuni); }

        private void AddNat(Nation nation) { NationObj = nation; } 
        public void ChangeNat(Continent continent) 
        {
            continent.AddNat(NationObj);
            NationObj=null; 
        }
        public void ChangeMuni(string nameNation, string nameRegion, string nameProvince, string nameMunicipality) 
        {
            Nation nation = new Nation(nameNation);
            string printText = $"Update: {Name} -> {nameNation} ->";
            nation.ChangeMuni(nameRegion, nameProvince, nameMunicipality, printText); 
        }






        public class Nation
        {
            string _nameNat;
            Region _region;
            public Nation(string nameNat) { NameNat = nameNat; }
            public string NameNat { get { return _nameNat; } set { _nameNat = value; } }
            private Region RegionObj { get { return _region; } set { _region = value; } }
            public void CreateReg(string nameReg) { RegionObj = new Region(nameReg, this); }
            public void CreatePro(string namePro) { RegionObj.CreatePro(namePro); }
            public void CreateMuni(string nameMuni) { RegionObj.CreateMuni(nameMuni); }
            private void AddReg(Region Region) { RegionObj = Region; } 
            public void ChangeReg(Nation nation)
            {
                nation.AddReg(RegionObj);
                RegionObj = null;
            }
            public void ChangeMuni(string nameRegion, string nameProvince, string nameMunicipality, string printText)
            {
                Region region = new Region(nameRegion, this);
                printText += $" {nameRegion} ->";
                region.ChangeMuni(nameProvince, nameMunicipality, printText);
            }


            class Region
            {
                string _nameReg;
                Nation _nation; 
                Province _province; 

                public Region(string nameReg, Nation nation) 
                { 
                    NameReg = nameReg; 
                    Nation = nation; 
                }
                public string NameReg { get { return _nameReg; } set { _nameReg = value; } }
                public Nation Nation { get { return _nation; } set { _nation = value; } }
                private Province ProvinceObj { get{ return _province; } set { _province = value; } }

                public void CreatePro(string namePro) { ProvinceObj = new Province(namePro, this); } 
                public void CreateMuni(string nameMuni) { ProvinceObj.CreateMuni(nameMuni); } 
                public void ChangePro(string nameProvince) { CreatePro(nameProvince); }
                public void ChangeMuni(string nameProvince, string nameMunicipality, string printText) 
                {
                    Province province = new Province(nameProvince, this);
                    printText += $" {nameProvince} ->"; 
                    province.ChangeMuni(nameMunicipality, printText);
                }


                class Province
                {
                    string _namePro;
                    Region _region;
                    Municipality _muni;

                    public Province(string namePro, Region region)
                    {
                        NamePro = namePro;
                        Region = region;
                        
                    }

                    public string NamePro { get { return _namePro; } set { _namePro = value; } } 
                    public Region Region { get { return _region; } set { _region = value; } } 
                    private Municipality MuniObj { get { return _muni; } set { _muni = value; } } 

                    public void CreateMuni(string nameMuni) 
                    {
                        MuniObj = new Municipality (nameMuni, this); 
                    }
                    public void ChangeMuni(string nameMunicipality, string printText)
                    {
                        this.CreateMuni(nameMunicipality);
                        printText += $" {nameMunicipality}."; 
                        Console.WriteLine(printText); 
                    }

                    class Municipality
                    {
                        string _nameMuni;
                        Province _province;
                        //Resident _resident; 

                        public Municipality(string nameMuni, Province province)
                        {
                            NameMuni = nameMuni;  
                            Province = province;
                        }
                        public string NameMuni { get { return _nameMuni; } set { _nameMuni = value; } }
                        public Province Province { get { return _province; } set { _province = value; } }

                        /* 
                        public Resident Resident { get { return _resident } set { _resident = value ; } }
                        */

                        /*
                        public void AddResident ( Resident Resident ) { Resident = resident; } 
                        public void RemoveResident ( Resident Resident ) { Resident = null; } 
                        */
                    }
                }
            }


        }
        
    }
}
