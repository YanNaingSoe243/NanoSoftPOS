// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NanoSoftGreenMark.LocationM
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\_Imports.razor"
using NanoSoftGreenMark;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\_Imports.razor"
using NanoSoftGreenMark.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\AddRegion.razor"
using NanoSoftGreenMark.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/regionadd/{Id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/regionadd")]
    public partial class AddRegion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\AddRegion.razor"
       

    protected bool ShowConfirmation { get; set; }
    [Parameter]
    public Region data { get; set; }
    ElementReference Model { get; set; }
    [Parameter]
    public int Id { get; set; }
    public string PageHeader { get; set; }
    public void Show()
    {
        ShowConfirmation = true;

        PageHeader = "Region Create";
        data = new Region();
    }
    private IEnumerable<Country> _getCountry { get; set; }
    protected IEnumerable<Country> getCountry
    {
        get { return _getCountry; }

        set
        {
            if (!object.Equals(_getCountry, value))
            {
                _getCountry = value;

                InvokeAsync(() => { StateHasChanged(); });
            }
        }
    }
    public void Close()
    {
        ShowConfirmation = false;
       // StateHasChanged();
    }
    public async void Edit(int ID)
    {
        ShowConfirmation = true;
        PageHeader = "Region Edit";
        data = await Service.Regions.GetAsync(ID);
      //  StateHasChanged();

    }


    protected override async System.Threading.Tasks.Task OnInitializedAsync()
    {
        data = new Region();
        var HRDResult = await Service.Countries.GetAsync(-1, 20);
        getCountry = HRDResult;
      


    }



    [Parameter]
    public EventCallback<Region> EventAdd { get; set; }
    protected async Task OnConfirmationChange(Region value)
    {
        ShowConfirmation = true;
        await EventAdd.InvokeAsync(value);
        data = new Region();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NanoSoftGreenMark.DepandencyInjection.InterFaceModel Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591