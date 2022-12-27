using Model;
using PresentationLayer.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels
{
    public class MyBookingsViewModel : BaseViewModel
    {
        private Booking selectedbooking;
        public Booking Selectedbooking { get => selectedbooking; set { selectedbooking = value; OnPropertyChanged(); } }
        public ObservableCollection<Booking> MyBookings { get; set; } = new ObservableCollection<Booking>();
        public ObservableCollection<Property> Properties { get; set; } = new ObservableCollection<Property>();
        public ICommand CancelBookingCommand { get; set; }
        public ICommand OpenAddReviewCommand { get; set; }

        public MyBookingsViewModel()
        {
            CancelBookingCommand = new CancelBookingsCommand(this);
            OpenAddReviewCommand = new OpenAddReviewViewCommand(this);
            RefreshProperties();
            RefreshBookings();
        }

        internal void RefreshBookings()
        {
            MyBookings.Clear();

            IEnumerable<Booking> bookings = App.Container.BookingController.GetUserBookings(App.Container.LoggedIn);

            foreach (Booking booking in bookings)
            {
                MyBookings.Add(booking);
            }

        }
        internal void RefreshProperties()
        {
            Properties.Clear();

            IEnumerable<Property> properties = App.Container.PropertyController.GetProperties();
            foreach (Property property in properties)
            {
                Properties.Add(property);
            }
        }

    }
}
