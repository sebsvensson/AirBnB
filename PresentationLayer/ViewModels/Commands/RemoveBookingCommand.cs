using BusinessLayer.Interfaces;
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
    public class RemoveBookingCommand : ICommand
    {
            public readonly MyBookingsViewModel myBookingViewModel;

            public RemoveBookingCommand(MyBookingsViewModel myBookingViewModel)
            {
                this.myBookingViewModel = myBookingViewModel;
                myBookingViewModel.PropertyChanged += CheckIfCanExecute;
            }

            private void CheckIfCanExecute(object sender, System.ComponentModel.PropertyChangedEventArgs e)
            {
                if (e.PropertyName == nameof(MyBookingsViewModel.Selectedbooking))
                {
                    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                }
            }

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return myBookingViewModel.Selectedbooking != null;
            }

            public void Execute(object parameter)
            {

                DateTime Today = DateTime.Now;

                Booking booking = App.Container.BookingController.GetBooking(myBookingViewModel.Selectedbooking.BookingId);
                if ((Today - booking.StartDate).TotalDays < 0)
                {
                    App.Container.BookingController.RemoveBooking(booking);
                    myBookingViewModel.RefreshBookings();
                    MessageBox.Show("Booking cancelled");
                }
                else
                {
                    MessageBox.Show("This booking cant be cancelled.");
                }
            }
        }
    }
