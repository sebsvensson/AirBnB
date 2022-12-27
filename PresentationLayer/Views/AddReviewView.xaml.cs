using Model;
using PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PresentationLayer.Views
{
    /// <summary>
    /// Interaction logic for AddReviewView.xaml
    /// </summary>
    public partial class AddReviewView : Window
    {
        public AddReviewView(int bookingID)
        {
            InitializeComponent();
            DataContext = new AddReviewViewModel(bookingID);
            string[] comboRating = new[] { "1", "2", "3", "4", "5" };

            ComboBox.ItemsSource = comboRating;
        }
    }
}
