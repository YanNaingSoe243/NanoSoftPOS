#pragma checksum "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08b6f05c862152c181c165535a2734f379b65102"
// <auto-generated/>
#pragma warning disable 1591
namespace NanoSoftGreenMark.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidenav");
            __builder.AddElementReferenceCapture(2, (__value) => {
#nullable restore
#line 16 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Shared\MainLayout.razor"
                               Sidebar = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n\r\n        \r\n\r\n        ");
            __builder.AddMarkupContent(4, "<div class=\"OverFlow\">\r\n            <div class=\"subnav\">\r\n                <div class=\"groupheader\" style=\" font-weight: bold;color: #5e09ce;padding-top:15px;font-size: 30px;padding-bottom:15px;position:sticky\">NanoSoft</div>\r\n\r\n            </div>\r\n            <div class=\"subnav\">\r\n                <div class=\"groupheader\" ondblclick=\"document.getElementById(\'id01\').style.display =\'none\'\" onclick=\"document.getElementById(\'id01\').style.display =\'block\'\">Financial Management<a class=\"fa fa-caret-down nav-link\"></a></div>\r\n                <ul id=\"id01\" style=\"display:block\">\r\n                    <li>   <a href=\"#team\">Delivery Management</a></li>\r\n                    <li> <a href=\"#careers\">Accounting Management</a></li>\r\n                    <li> <a href=\"#careers\">Bank Management</a></li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"subnav\">\r\n                <div class=\"groupheader\" ondblclick=\"document.getElementById(\'id05\').style.display =\'none\'\" onclick=\"document.getElementById(\'id05\').style.display =\'block\'\">Discount Management<a class=\"fa fa-caret-down nav-link\"></a></div>\r\n                <ul id=\"id05\">\r\n                    <li> <a href=\"#careers\">Discount Product</a></li>\r\n                    <li> <a href=\"discounttypepage\">DiscountType</a></li>\r\n                    <li> <a href=\"giftcardpage\">GiftCard</a></li>\r\n                    <li> <a href=\"discountpage\">Discount</a></li>\r\n                </ul>\r\n            </div>\r\n\r\n            <div class=\"subnav\">\r\n                <div class=\"groupheader\" ondblclick=\"document.getElementById(\'id02\').style.display =\'none\'\" onclick=\"document.getElementById(\'id02\').style.display =\'block\'\">Product Management<a class=\"fa fa-caret-down nav-link\"></a></div>\r\n                <ul id=\"id02\" style=\"display:block\">\r\n                    <li> <a href=\"categorypage\">Category</a></li>\r\n                    <li>   <a href=\"productpage\">Product</a></li>\r\n                    <li>   <a href=\"brandpage\">Brand</a></li>\r\n                    <li>   <a href=\"productpropertypage\">Product Property</a></li>\r\n                    <li><a href=\"purchasepage\">Purchase</a></li>\r\n\r\n                </ul>\r\n            </div>\r\n            <div class=\"subnav\">\r\n                <div class=\"groupheader\" ondblclick=\"document.getElementById(\'id03\').style.display =\'none\'\" onclick=\"document.getElementById(\'id03\').style.display =\'block\'\">People Management<a class=\"fa fa-caret-down nav-link\"></a></div>\r\n                <ul id=\"id03\">\r\n                    <li> <a href=\"employeepage\">Employee</a></li>\r\n                    <li> <a href=\"supplierpage\">Supplier</a></li>\r\n                    <li> <a href=\"employeetypepage\">Employee Type</a></li>\r\n                    <li> <a href=\"rolepage\">Role</a></li>\r\n\r\n\r\n                </ul>\r\n            </div>\r\n            <div class=\"subnav\">\r\n                <div class=\"groupheader\" ondblclick=\"document.getElementById(\'id04\').style.display =\'none\'\" onclick=\"document.getElementById(\'id04\').style.display =\'block\'\">Location Management <a class=\"fa fa-caret-down nav-link\"></a></div>\r\n                <ul id=\"id04\">\r\n                    <li> <a href=\"locationpage\">Shop Location</a></li>\r\n                    <li> <a href=\"citypage\">City</a></li>\r\n                    <li> <a href=\"regionpage\">Region</a></li>\r\n                    <li> <a href=\"countrypage\">Country</a></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "flex-container");
            __builder.AddElementReferenceCapture(8, (__value) => {
#nullable restore
#line 83 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Shared\MainLayout.razor"
                                  Main = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "flex-item-left");
            __builder.AddElementReferenceCapture(12, (__value) => {
#nullable restore
#line 84 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Shared\MainLayout.razor"
                                      ActiveItem = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "tooggle");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Shared\MainLayout.razor"
                                          Toggle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "\r\n            <i class=\"oi oi-menu\"></i>\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddMarkupContent(19, @"<ul>
            <li><a href=""counter"" class=""nav-link Current"">Home</a></li>
            <li><a href=""homepage"" class=""nav-link"">Point Of Sale</a></li>            
            <li><a href=""#contact"" class=""nav-link"">Customer Management</a></li>
            <li><a href=""#contact"" class=""nav-link"">Register</a></li>
            <li><a href=""#contact"" class=""nav-link"">Message</a></li>
        </ul>


    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.AddMarkupContent(21, @"<div class=""flex-item-right"">

        <div class=""rightbar"">
            <div>
              
            </div>
            <img src=""css/download.jpg"" alt=""User"" class=""avatar"">

            <div class=""dropdown"">
                <button class=""btn"">Hello Admin<i style=""margin-left:5px"" class=""fa fa-caret-down fa-lg""></i></button>
                <div class=""dropdown-content"">
                    <a href=""#"">Change Password</a>
                    <a href=""#"">Profile</a>
                    <a href=""#"">Logout</a>
                    <a href=""#"">Setting</a>
                </div>
            </div>
        </div>

    </div>
    
    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "px-3 pt-3 row");
            __builder.AddMarkupContent(24, "\r\n          ");
#nullable restore
#line 123 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Shared\MainLayout.razor"
__builder.AddContent(25, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Shared\MainLayout.razor"
      
    ElementReference ActiveItem;
    ElementReference Main;
    ElementReference Sidebar;
    ElementReference UpDown;

    protected override async Task OnAfterRenderAsync(bool a)
    {
        if (a)
        {

            await JSRuntime.InvokeAsync<bool>("NavBottom", ActiveItem);



        }
    }
    bool hidden = false;
    public async void Toggle()
    {

        if (hidden != false)
        {

            await JSRuntime.InvokeAsync<bool>("Toggle", Sidebar, Main, hidden);
            hidden = false;
        }
        else
        {
            await JSRuntime.InvokeAsync<bool>("Toggle", Sidebar, Main, hidden);
            hidden = true;
        }


    }
    public async void UpDownClick()
    {
        await JSRuntime.InvokeAsync<bool>("UpDown", UpDown);
    }

   


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591