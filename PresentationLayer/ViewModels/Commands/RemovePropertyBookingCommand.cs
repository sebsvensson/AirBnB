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
    public class RemovePropertyBookingCommand : ICommand
    {
        public readonly PropertyBookingsViewModel propertyBookingsViewModel;
        public RemovePropertyBookingCommand(PropertyBookingsViewModel propertyBookingsViewModel)
        {
            this.propertyBookingsViewModel = propertyBookingsViewModel;
            propertyBookingsViewModel.PropertyChanged += CheckIfCanExecute;            
        }

        private void CheckIfCanExecute(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(PropertyBookingsViewModel.SelectedBooking))
            {
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return propertyBookingsViewModel.SelectedBooking != null;
        }

        public void Execute(object? parameter)
        {
            Booking booking = App.Container.BookingController.GetBooking(propertyBookingsViewModel.SelectedBooking.BookingId);
            App.Container.BookingController.RemoveBooking(booking);
            propertyBookingsViewModel.RefreshPropertyBookings();
            MessageBox.Show("Booking removed");
        }
    }
}
