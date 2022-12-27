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
    public class AddBookingCommand : ICommand
    {

        private readonly AddBookingViewModel addBookingViewModel;

        public AddBookingCommand(AddBookingViewModel addBookingViewModel)
        {
            this.addBookingViewModel = addBookingViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            DateTime StartDate = addBookingViewModel.StartDate;
            DateTime EndDate = addBookingViewModel.EndDate;
            int AmountOfPeople = addBookingViewModel.AmountOfPeople;
            Property property = addBookingViewModel.Property;
            double Price = property.PricePerNight;
            double TotalPrice = (EndDate - StartDate).TotalDays * Price;
            if (EndDate > StartDate && StartDate >= DateTime.Now.AddDays(-1))
            {
                Booking b = App.Container.BookingController.AddBooking(property, StartDate, EndDate, TotalPrice, App.Container.LoggedIn, AmountOfPeople);
                if (b != null)
                {
                    App.Container.PropertyController.AttachBooking(b, property.Adress);
                    MessageBox.Show("Booking Created");

                }
                else
                {
                    MessageBox.Show("There is already a booking at this date. Pick another date");
                }

            }
            else
            {
                MessageBox.Show("Invalid booking dates");
            }

        }
    }
}
