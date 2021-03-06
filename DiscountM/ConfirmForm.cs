using Microsoft.AspNetCore.Components;
using NanoSoftGreenMark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSoftGreenMark.DiscountM
{
    public class ConfirmDiscount : ComponentBase
    {
        protected bool ShowConfirmation { get; set; }
        [Parameter]
        public string ConfirmationTitle { get; set; } = "Confirm Delete";
        [Parameter]
        public string ConfirmationMessage { get; set; } = "Are you sure you want to delete";
        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged();
        }
        [Parameter]
        public EventCallback<bool> ConfirmationChange { get; set; }
        protected async Task OnConfirmationChange(bool value)
        {
            ShowConfirmation = false;
            await ConfirmationChange.InvokeAsync(value);

        }
    }
}
