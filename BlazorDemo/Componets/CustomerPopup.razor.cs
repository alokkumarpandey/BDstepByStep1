using LabEntity.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Componets
{
    public partial class CustomerPopup
    {
        private Customer? _customer;

        [Parameter]
        public Customer? Customer { get; set; }

        protected override void OnParametersSet()
        {
            _customer = Customer;

        }

        public void Close()
        {
            _customer = null;
        }
    }
}
