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
    public class AddReviewCommand : ICommand
    {
        private readonly AddReviewViewModel addReviewViewModel;

        public AddReviewCommand(AddReviewViewModel addReviewViewModel)
        {
            this.addReviewViewModel = addReviewViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            int Rating = addReviewViewModel.Rating;
            string Comment = addReviewViewModel.Comment;

            Booking b = App.Container.BookingController.GetBooking(addReviewViewModel.BookingID);

            Review r = new Review();
            r.Rating = Rating;
            r.Comment = Comment;
            App.Container.ReviewController.AddReview(Rating, Comment, App.Container.LoggedIn, b.Property); //???????

            int totalRating = 0;
            foreach (Review review in b.Property.Reviews)
            {
                totalRating = totalRating + review.Rating;
            }
            b.Property.Rating = totalRating / b.Property.Reviews.Count;



            //App.Container.PropertyController.AttachReview(r, b.Property.Adress);//?????????
            MessageBox.Show("Review added");

        }
    }
}
