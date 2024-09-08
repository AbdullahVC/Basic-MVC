using Basic_MVC.Models;
using Basic_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Basic_MVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Örnek  müşteri 
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Muhammed",
                LastName = "ali",
                Email = "muhammed.ali@example.com"
            };

            // Örnek sipariş listesi
            var orders = new List<Order>
        {
            new Order { Id = 101, ProductName = "Telefon", Price = 5000, Quantity = 1 },
            new Order { Id = 102, ProductName = "Laptop", Price = 15000, Quantity = 1 },
        };

            // ViewModel'i dolduruyoruz
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // View'e ViewModel'i gönderiyoruz
            return View(viewModel);


        }
    }
}
