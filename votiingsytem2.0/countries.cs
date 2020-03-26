using System;
namespace votiingsytem2._0
{
    public class Country
    {
        private string C_name;
        private double C_percent;

        public Country(string cName, double cPercent)
        {
            this.C_name = cName;
            this.C_percent = cPercent;
        }

        public string CountryName
        {
            get { return C_name; }
            set { C_name = value; }
        }
        public double CountryPercent
        {
            get { return C_percent; }
            set { C_percent = value; }
        }

    }
}
