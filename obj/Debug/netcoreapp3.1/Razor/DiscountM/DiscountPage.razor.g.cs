#pragma checksum "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a03c7c30168d0e75d117162e03d5d02ea43e45e"
// <auto-generated/>
#pragma warning disable 1591
namespace NanoSoftGreenMark.DiscountM
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/discountpage")]
    public partial class DiscountPage : DiscountComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"font-size:18px\">Discount Management</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "grid-container");
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\r\n\r\n\r\n        ");
            __builder.OpenElement(6, "select");
            __builder.AddAttribute(7, "class", "PageSize");
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                                            ChangePageSize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "id", "PageSize");
            __builder.AddAttribute(10, "name", "PageSize");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "value", "10");
            __builder.AddContent(14, "Page Size ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", "20");
            __builder.AddContent(18, "20");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "30");
            __builder.AddContent(22, "30");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "40");
            __builder.AddContent(26, "40");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", "50");
            __builder.AddContent(30, "50");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "100");
            __builder.AddContent(34, "100");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddMarkupContent(39, "\r\n\r\n        ");
            __builder.OpenElement(40, "form");
            __builder.AddAttribute(41, "class", "example");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "text");
            __builder.AddAttribute(45, "placeholder", "Search..");
            __builder.AddAttribute(46, "name", "search");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                                                                           SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "Icon");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                                       AddCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "<i class=\"oi oi-plus\" style=\"padding-right:10px;\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "style", "margin-right:10px");
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "btn-group");
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.AddMarkupContent(66, "<button class=\"btn btn-danger\">ToPrint</button>\r\n            ");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "class", "btn btn-warning");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                                                      ExportToExcel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(70, "ToExcel");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "class", "btn btn-success");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                                                      ExportToCSV

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "ToCSV");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "Table-container");
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.OpenElement(83, "div");
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 46 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
         if (getRegion == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(85, "            <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 49 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
        }
        else
        {


#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "            ");
            __builder.OpenElement(87, "table");
            __builder.AddAttribute(88, "class", "table");
            __builder.AddMarkupContent(89, "\r\n                ");
            __builder.AddMarkupContent(90, @"<thead>
                    <tr>
                        <th> No.</th>
                        <th>Discount Name</th>
                        <th>Discount Number</th>
                        <th>Discount Type</th>


                        <th width=""50px""> </th>
                        <th width=""50px""> </th>

                    </tr>
                </thead>
                ");
            __builder.OpenElement(91, "tbody");
            __builder.AddMarkupContent(92, "\r\n\r\n");
#nullable restore
#line 69 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                     if (getRegion.Count() > 0)
                    {
                        Count = ((PageIndex - 1) * PageSize) + 1;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                         foreach (var obj in getRegion)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "                    ");
            __builder.OpenElement(94, "tr");
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.OpenElement(96, "td");
#nullable restore
#line 75 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
__builder.AddContent(97, Count);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                        ");
            __builder.OpenElement(99, "td");
#nullable restore
#line 76 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
__builder.AddContent(100, obj.DiscountName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                        ");
            __builder.OpenElement(102, "td");
#nullable restore
#line 77 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
__builder.AddContent(103, obj.Percentage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                        ");
            __builder.OpenElement(105, "td");
#nullable restore
#line 78 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
__builder.AddContent(106, obj?.DiscountType?.DiscountTypeName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n\r\n                        ");
            __builder.OpenElement(108, "td");
            __builder.AddMarkupContent(109, "\r\n\r\n\r\n                            ");
            __builder.OpenElement(110, "button");
            __builder.AddAttribute(111, "class", "Icon");
            __builder.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                                                           (() => Delete(obj.ID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(113, "<i class=\"oi oi-trash\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n\r\n\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                        ");
            __builder.OpenElement(116, "td");
            __builder.AddMarkupContent(117, "\r\n                            ");
            __builder.OpenElement(118, "button");
            __builder.AddAttribute(119, "class", "Icon");
            __builder.AddAttribute(120, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                                                           (() => EditCategory(obj.ID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(121, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n");
#nullable restore
#line 92 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                            Count++;



                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                         

                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(125, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n");
#nullable restore
#line 101 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(128, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n    ");
            __builder.OpenComponent<NanoSoftGreenMark.DiscountM.ConfirnationForm>(130);
            __builder.AddAttribute(131, "ConfirmationChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 104 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                                                                    ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(132, "ConfirmationMessage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 105 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                                         $"Are you sure you want to delete"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(133, (__value) => {
#nullable restore
#line 104 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                            DeleteConfirmation = (NanoSoftGreenMark.DiscountM.ConfirnationForm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(134, "\r\n    ");
            __builder.OpenComponent<NanoSoftGreenMark.DiscountM.AddDiscount>(135);
            __builder.AddAttribute(136, "EventAdd", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<NanoSoftGreenMark.Data.Discount>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<NanoSoftGreenMark.Data.Discount>(this, 
#nullable restore
#line 107 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                                               AddData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(137, (__value) => {
#nullable restore
#line 107 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                       addComponent = (NanoSoftGreenMark.DiscountM.AddDiscount)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(138, "\r\n\r\n    ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "center");
            __builder.AddMarkupContent(141, "\r\n        ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "pagination");
            __builder.AddElementReferenceCapture(144, (__value) => {
#nullable restore
#line 110 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                                      Paging = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(145, "\r\n            ");
            __builder.OpenElement(146, "a");
            __builder.AddAttribute(147, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 111 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                         (()=>Previous())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(148, "«");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n");
#nullable restore
#line 112 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
             for (int i = 1; i <= PageCount; i++)
            {
                var buttonNumber = i;
                if (i == 1)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(150, "                    ");
            __builder.OpenElement(151, "a");
            __builder.AddAttribute(152, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 117 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                                   () => PageEvent(buttonNumber)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 117 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
__builder.AddContent(153, i);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n");
#nullable restore
#line 118 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(155, "                    ");
            __builder.OpenElement(156, "a");
            __builder.AddAttribute(157, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 121 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                                   () => PageEvent(buttonNumber)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 121 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
__builder.AddContent(158, i);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n");
#nullable restore
#line 122 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                }

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(160, "            ");
            __builder.OpenElement(161, "a");
            __builder.AddAttribute(162, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 125 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\DiscountM\DiscountPage.razor"
                         (()=>Next())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(163, "»");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
