using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.ViewModels
{
        public class ReviewViewModel : BaseViewModel
        {
            private readonly ReviewViewModel reviewViewModel;

            public int PropertyId { get; set; }
            public Property property { get; set; }
            public ObservableCollection<Review> MyReviews { get; set; } = new ObservableCollection<Review>();

            public ReviewViewModel(int propertyID)
            {
                PropertyId = propertyID;
                RefreshReviews();
            }

            internal void RefreshReviews()
            {
                MyReviews.Clear();

                property = App.Container.PropertyController.GetByPropId(PropertyId); 
            
                IEnumerable<Review> reviews = App.Container.ReviewController.GetPropertyReviews(property);

                foreach (Review review in reviews)
                {
                    MyReviews.Add(review);
                }

            }

        }
    }

