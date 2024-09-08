using Basic_MVC.Models;

namespace Basic_MVC.ViewModels
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }

}
