using BlazorDemo.Models;
using LabEntity.Shared;

namespace BlazorDemo.Pages
{
    public partial class CustomerList
    {
        public List<Customer>? Customers { get; set; } = default!;
        private Customer? _selectedCustomer;

        protected override void OnInitialized()
        {
            Customers = DummyDataService.Customers;
        }

        public void ShowCustomerPopup(Customer selectedCustomer)
        {
            _selectedCustomer = selectedCustomer;
        }
    }
}
