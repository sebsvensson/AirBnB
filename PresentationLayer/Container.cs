using BusinessLayer.Controllers;
using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Repositories.Interface;
using DataLayer.Repositories;
using Model;

namespace PresentationLayer
{
    public class Container
    {
        public AirBnbContext dbContext;
        public IUnitOfWork unitOfWork;
        public IUserController UserController;
        public IPropertyController PropertyController;
        public IBookingController BookingController;
        public IReviewController ReviewController;
        public User LoggedIn;

        public Container()
        {
            dbContext = new AirBnbContext();
            unitOfWork = new UnitOfWork(dbContext);
            UserController = new UserController(unitOfWork);
            PropertyController = new PropertyController(unitOfWork);
            BookingController = new BookingController(unitOfWork);
            ReviewController = new ReviewController(unitOfWork);
        }

        public bool Login(string userId, string password)
        {
            User u = UserController.Login(userId, password);

            if (u != null && u.VerifyPassword(password))
            {
                LoggedIn = u;
                return true;
            }
            LoggedIn = null;
            return false;
        }

        public void AddNewProperty(string city, string adress, int pricepernight, string facilities, string description)
        {
            PropertyController.AddProperty(city, adress, pricepernight, facilities, description);
            PropertyController.AttachUser(adress, LoggedIn);
        }
       
    }
}
