using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeographicArea
{
    internal class Continent
    {
        string _nameContinent;
        Nation _nation;
        public Continent(string nationName) { Name = nationName; }
        public string Name { get { return _nameContinent; } set { _nameContinent = value; } }
        public Nation NationObj { get { return _nation; } set { _nation = value; } }

        public void CreateNation(string nameNation) { NationObj = new Nation(nameNation); }
        public void CreateRegion(string nameRegion) { NationObj.CreateRegion(nameRegion); }
        public void CreateProvince(string nameProvince) { NationObj.CreateProvince(nameProvince); }
        public void CreateMunicipality(string nameMunicipality) { NationObj.CreateMunicipality(nameMunicipality); }

        private void AddNation(Nation nation) { NationObj = nation; }
        public void ChangeNation(Continent continent)
        {
            continent.AddNation(NationObj);
            NationObj = null;
        }

        public void ChangeMunicipality(string nameNationR, string nameRegionR, string nameProvinceR, string nameMunicipalityR)
        {
            Nation nation = new Nation(nameNationR);
            string printText = $"Update: {Name} -> {nameNationR} ->";
            nation.ChangeMunicipality(nameRegionR, nameProvinceR, nameMunicipalityR, printText);
        }



        public class Nation
        {
            string _nameNation;
            Region _region;

            public Nation(string nameNation) { NameNation = nameNation; }

            public string NameNation { get { return _nameNation; } set { _nameNation = value; } }

            private Region RegionObj { get { return _region; } set { _region = value; } }

            public void CreateRegion(string nameRegion) { RegionObj = new Region(nameRegion, this); }

            public void CreateProvince(string nameProvince) { RegionObj.CreateProvince(nameProvince); }

            public void CreateMunicipality(string nameMunicipality) { RegionObj.CreateMunicipality(nameMunicipality); }
            private void AddRegion(Region region) { RegionObj = region; }
            public void ChangeRegion(Nation nation)
            {
                nation.AddRegion(RegionObj);
                RegionObj = null;
            }
            public void ChangeMunicipality(string nameRegionR, string nameProvinceR, string nameMunicipalityR, string printText)
            {
                Region region = new Region(nameRegionR, this);
                printText += $" {nameRegionR} ->";
                region.ChangeMunicipality(nameProvinceR, nameMunicipalityR, printText);
            }



            class Region
            {
                string _nameRegion;
                Nation _nation;
                Province _province;

                public Region(string nameRegion, Nation nation)
                {
                    NameRegion = nameRegion;
                    Nation = nation;
                }

                public string NameRegion { get { return _nameRegion; } set { _nameRegion = value; } }
                public Nation Nation { get { return _nation; } set { _nation = value; } }
                private Province ProvinceObj { get { return _province; } set { _province = value; } }

                public void CreateProvince(string nameProvince)
                {
                    ProvinceObj = new Province(nameProvince, this);
                }
                public void CreateMunicipality(string nameMunicipality)
                {
                    ProvinceObj.CreateMunicipality(nameMunicipality);
                }

                public void ChangeProvince(string nameProvinceR) { CreateProvince(nameProvinceR); }

                public void ChangeMunicipality(string nameProvinceR, string nameMunicipalityR, string printText)
                {
                    Province province = new Province(nameProvinceR, this);
                    printText += $" {nameProvinceR} ->";
                    province.ChangeMunicipality(nameMunicipalityR, printText);
                }



                class Province
                {
                    string _nameProvince;
                    Region _region;
                    Municipality _municipality;

                    public Province(string nameProvince, Region region)
                    {
                        NameProvince = nameProvince;
                        Region = region;
                    }

                    public string NameProvince { get { return _nameProvince; } set { _nameProvince = value; } }

                    public Region Region { get { return _region; } set { _region = value; } }

                    private Municipality MunicipalityObj { get { return _municipality; } set { _municipality = value; } }

                    public void CreateMunicipality(string nameMunicipality)
                    {
                        MunicipalityObj = new Municipality(nameMunicipality, this);
                    }

                    public void ChangeMunicipality(string nameMunicipalityR, string printText)
                    {
                        this.CreateMunicipality(nameMunicipalityR);
                        printText += $" {nameMunicipalityR}.";
                        Console.WriteLine(printText);

                    }



                    class Municipality
                    {
                        string _nameMunicipality;
                        Province _province;
                        //Resident _resident; 
                        public Municipality(string nameMunicipality, Province province)
                        {
                            NameMunicipality = nameMunicipality;
                            Province = province;
                        }
                        public string NameMunicipality { get { return _nameMunicipality; } set { _nameMunicipality = value; } }

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
