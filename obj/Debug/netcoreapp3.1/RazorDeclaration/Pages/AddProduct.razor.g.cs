// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NanoSoftGreenMark.Pages
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
#line 4 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Pages\AddProduct.razor"
using NanoSoftGreenMark.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Pages\AddProduct.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Pages\AddProduct.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productadd/{Id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/productadd")]
    public partial class AddProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 149 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Pages\AddProduct.razor"
       

    protected bool ShowConfirmation { get; set; }
    [Parameter]
    public Product data { get; set; }
    ElementReference Model { get; set; }
    [Parameter]
    public int Id { get; set; }
    public string PageHeader { get; set; }
    private IEnumerable<ProductProperty> getProductProperty { get; set; }
    private IEnumerable<Brand> getBrand { get; set; }
    private IEnumerable<Category> getCategory { get; set; }
    bool BarCodeExit = false;
    bool update = false;
    public void Show()
    {
        ShowConfirmation = true;

        PageHeader = "Product  Create";
        data = new Product();
        BarcodeGenerate();
    }
    public void Close()
    {
        ShowConfirmation = false;
        StateHasChanged();
    }
    public async void Edit(int ID)
    {
        ShowConfirmation = true;
        PageHeader = "Product Edit";
        data = await Service.Products.GetAsync(ID);
       
        StateHasChanged();
        update = true;

    }


    protected override async System.Threading.Tasks.Task OnInitializedAsync()
    {
        data = new Product();

        //await Load();
        var ProductPresult = await Service.ProductPropertys.GetAsync(-1, 20);
        getProductProperty = ProductPresult;
        var BrandResult = await Service.Brands.GetAsync(-1, 20);
        getBrand = BrandResult;
        var CategoryResult = await Service.Categorys.GetAsync(-1, 20);
        getCategory = CategoryResult;
        BarcodeGenerate();


    }



    [Parameter]
    public EventCallback<Product> EventAdd { get; set; }
    protected async Task OnConfirmationChange(Product value)
    {
        ShowConfirmation = true;
        if (update == false)
        {
            Product p = await Service.Products.BarcodeExit(value.Barcode);
            if (p != null)
            {
                BarCodeExit = true;
            }
            else
            {
                BarCodeExit = false;
                if (data.PropertyID == null || data.BrandID == null || data.CategoryID == null)
                {
                    //  await InvokeAsync(() => { StateHasChanged(); });
                }
                else
                {
                    ShowConfirmation = true;
                    await EventAdd.InvokeAsync(value);
                    data = new Product();
                    BarcodeGenerate();
                }
            }
        }
        else
        {
            BarCodeExit = false;
            ShowConfirmation = true;
            await EventAdd.InvokeAsync(value);
            data = new Product();
            BarcodeGenerate();
        }
        update = false;

    }
    void BarcodeGenerate()
    {
        string guid = Guid.NewGuid().ToString("N").Substring(0, 12);
        data.Barcode = guid.ToUpper();

    }
    void CheckActive(ChangeEventArgs e)
    {
        if (Convert.ToBoolean(e.Value) == false)
        {
            data.Status = Status.Inactive;
        }
        else
        {
            data.Status = Status.Active;
        }


    }
    private async Task OnInputFileChange(IFileListEntry[] files)
    {
        var rawFile = files.FirstOrDefault();
        if (rawFile != null)
        {
            // Load as an image file in memory
            var format = "image/jpeg";
            var imageFile = await rawFile.ToImageFileAsync(format, 640, 480);
            var ms = new MemoryStream();
            await imageFile.Data.CopyToAsync(ms);
            //photo = $"data:{format};base64,{Convert.ToBase64String(ms.ToArray())}";
            // Make a data URL so we can display it
            data.Photo = Convert.ToBase64String(ms.ToArray());

        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NanoSoftGreenMark.DepandencyInjection.InterFaceModel Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
