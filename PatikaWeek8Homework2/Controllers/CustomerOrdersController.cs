using Microsoft.AspNetCore.Mvc;
using PatikaWeek8Homework2.Models;

namespace PatikaWeek8Homework2.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            //Model nesnesi oluşturuluyo...
            CustomerOrderViewModel customerOrderViewModel = new CustomerOrderViewModel();

            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Pelin",
                LastName = "Şahin",
                Email = "psah@dd.com",

            };

            customerOrderViewModel.customer = customer;

            Order order = new Order()
            {
                Id = 1,
                ProductName = "Bilgisayar",
                Price = 50000,
                Quantity = 1,
                
            };
            Order order2 = new Order();
            order2.Id = 2;
            order2.ProductName = "Telefon";
            order2.Price = 30000;
            order2.Quantity = 1;

            customerOrderViewModel.orders=new List<Order> { order, order2 };

          

            //Model view gönderiliyor
            return View(customerOrderViewModel);
        }
    }
}
