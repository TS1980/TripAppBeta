using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TripApp.Model
{
    class Country
    {
        private string tag;
        public string CountryNmae
        {
            get { return countryName; }
            set { countryName = value; }
        }

        private string countryName;
        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        private string currency;
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        private string currencySymbol;
        public string CurrencySymbol
        {
            get { return currencySymbol; }
            set { currencySymbol = value; }
        }

        public Country(string tag)
        {
            RegionInfo region = new RegionInfo(tag);
            countryName = region.EnglishName;
            currency = region.CurrencyEnglishName;
            currencySymbol = region.CurrencySymbol;
            this.tag = tag;
        }

        //public void CountrySearch(string tag)
    }
}
