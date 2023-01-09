using BlazorDemo.Models;
using LabEntity.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages
{
    public partial class CustomerDetail
    {
        [Parameter]
        public string CustomerId { get; set; }
        public Customer? Customer { get; set; } = new Customer();
        protected override Task OnInitializedAsync()
        {
            Customer = DummyDataService.Customers!.FirstOrDefault(e => e.CustomerId == Int32.Parse(CustomerId));
            return base.OnInitializedAsync();
        }
    }
}
