using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    public class CancelBookingsCommand : ICommand
    {
        public readonly MyBookingsViewModel myBookingsViewModel;

        public CancelBookingsCommand(MyBookingsViewModel mybookingsViewModel)
        {
            myBookingsViewModel = mybookingsViewModel;
            myBookingsViewModel.PropertyChanged += CheckIfCanExecute;
        }

        private void CheckIfCanExecute(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MyBookingsViewModel.Selectedbooking))
            {
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return myBookingsViewModel.Selectedbooking !=null ;
        }

        public void Execute(object? parameter)
        {
            DateTime today = DateTime.Now;

            Booking booking = App.Container.BookingController.GetBooking(myBookingsViewModel.Selectedbooking.BookingId);
            if((today -booking.StartDate).TotalDays < 0)
            {
                App.Container.BookingController.RemoveBooking(booking);
                myBookingsViewModel.RefreshBookings();
                MessageBox.Show("Booking cancelled");
            }
            else
            {
                MessageBox.Show("Booking cant be cancelled");
            }

        }
    }
}
