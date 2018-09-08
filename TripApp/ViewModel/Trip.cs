using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripApp.Model;

namespace TripApp.ViewModel
{
    class Trip : ViewModelBase
    {
        private ObservableCollection<Country> trip = new ObservableCollection<Country>();
        public ObservableCollection<Country> TripStruct { get => trip; set => Set(ref trip, value); }

        public Trip()
        {
            this.trip = trip;
        }

        public void AddCountry(string tag)
        {
            Country c = new Country(tag);
            TripStruct.Add(c);
        }

        public void DeleteCountry(string tag)
        {
            Country c = new Country(tag);
            TripStruct.Remove(c);
        }
    }
}
