using Model;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    public class OpenAddReviewViewCommand : ICommand
    {
        public readonly MyBookingsViewModel myBookingViewModel;

        public OpenAddReviewViewCommand(MyBookingsViewModel myBookingViewModel)
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
            int booking = myBookingViewModel.Selectedbooking.BookingId;
            AddReviewView addReviewView = new AddReviewView(booking);
            addReviewView.ShowDialog();
        }
    }
}