using Model;
using PresentationLayer.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels
{
    public class AddReviewViewModel : BaseViewModel
    {
        public int BookingID { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public ICommand AddReviewCommand { get; set; }

        public AddReviewViewModel(int bookingID)
        {
            BookingID = bookingID;
            AddReviewCommand = new AddReviewCommand(this);

        }
    }
}