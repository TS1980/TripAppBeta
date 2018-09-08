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
    class AppViewModelTripStr : ViewModelBase
    {
        private ObservableCollection<Trip> tripList = new ObservableCollection<Trip>();
        public ObservableCollection<Trip> TripList { get => tripList; set => Set(ref tripList, value); }

        private readonly I movieSearch;

        public AppViewModelTripStr()
        {
            this.tripList = tripList;
        }

        public void AddTrip()
        {
            Trip t = new Trip();
            TripList.Add(t);
        }

        public void DeleteCountry()
        {
            Trip t = new Trip();
            TripList.Remove(t);
        }
    }
}
