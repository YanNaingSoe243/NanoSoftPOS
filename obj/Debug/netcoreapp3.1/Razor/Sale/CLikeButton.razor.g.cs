#pragma checksum "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\CLikeButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5c858eadc1b6988d1e868d4d6abb77e5c5af293"
// <auto-generated/>
#pragma warning disable 1591
namespace NanoSoftGreenMark.Sale
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
    public partial class CLikeButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\CLikeButton.razor"
               ToggleLike

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", (
#nullable restore
#line 1 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\CLikeButton.razor"
                                   icon

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 1 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\CLikeButton.razor"
                                           liked == true ? "active" : " " 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "style", "color:#ffffff");
            __builder.AddMarkupContent(4, "\r\n   ");
#nullable restore
#line 2 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\CLikeButton.razor"
__builder.AddContent(5, title);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\CLikeButton.razor"
       

    bool liked = false;
    [Parameter]
    public string icon { get; set; }
    [Parameter]
    public string title { get; set; }
    //public int id { get; set; }

     void ToggleLike()
    {
        liked = !liked;
    }
    // [Parameter] EventCallback<bool> OnLikeToggled { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
