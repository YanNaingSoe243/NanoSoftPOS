#pragma checksum "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3a2324fd303571708d495abf5038178913e7a6a"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/locationpage")]
    public partial class LocationPage : LocationComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"font-size:18px\">Location Management</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "grid-container");
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\r\n\r\n        ");
            __builder.OpenElement(6, "select");
            __builder.AddAttribute(7, "class", "PageSize");
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
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
#line 25 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
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
#line 32 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
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
#line 37 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
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
#line 38 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
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
#line 46 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
         if (getResult == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(85, "            <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 49 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
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
                        <th>ShopeName</th>
                        <th>Latitude</th>
                        <th>Longitude</th>
                        <th>Phone</th>
                        <th>Contact</th>
                        <th>City</th>
                        <th>Region</th>
                        <th>Country</th>


                        <th width=""50px""> </th>
                        <th width=""50px""> </th>

                    </tr>
                </thead>
                ");
            __builder.OpenElement(91, "tbody");
            __builder.AddMarkupContent(92, "\r\n\r\n");
#nullable restore
#line 74 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                     if (getResult.Count() > 0)
                    {
                        Count = ((PageIndex - 1) * PageSize) + 1;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                         foreach (var obj in getResult)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "                    ");
            __builder.OpenElement(94, "tr");
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.OpenElement(96, "td");
#nullable restore
#line 80 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
__builder.AddContent(97, Count);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                        ");
            __builder.OpenElement(99, "td");
#nullable restore
#line 81 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
__builder.AddContent(100, obj.ShopeName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                        ");
            __builder.OpenElement(102, "td");
#nullable restore
#line 82 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
__builder.AddContent(103, obj.Latitude);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                        ");
            __builder.OpenElement(105, "td");
#nullable restore
#line 83 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
__builder.AddContent(106, obj.Longitude);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                        ");
            __builder.OpenElement(108, "td");
#nullable restore
#line 84 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
__builder.AddContent(109, obj.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                        ");
            __builder.OpenElement(111, "td");
#nullable restore
#line 85 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
__builder.AddContent(112, obj.Contact);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.OpenElement(114, "td");
#nullable restore
#line 86 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
__builder.AddContent(115, obj.City?.CityName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                        ");
            __builder.OpenElement(117, "td");
#nullable restore
#line 87 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
__builder.AddContent(118, obj.City?.Region?.RegionName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                        ");
            __builder.OpenElement(120, "td");
#nullable restore
#line 88 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
__builder.AddContent(121, obj.City?.Region?.Country?.CountryName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                        ");
            __builder.OpenElement(123, "td");
            __builder.OpenElement(124, "img");
            __builder.AddAttribute(125, "class", "pic");
            __builder.AddAttribute(126, "src", "data:image/jpeg;base64," + (
#nullable restore
#line 89 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                                                                          obj.ImagePath

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(127, "style", "height:45px;width:45px;");
            __builder.CloseElement();
            __builder.AddContent(128, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                        ");
            __builder.OpenElement(130, "td");
            __builder.AddMarkupContent(131, "\r\n\r\n\r\n                            ");
            __builder.OpenElement(132, "button");
            __builder.AddAttribute(133, "class", "Icon");
            __builder.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                                                           (() => Delete(obj.ID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(135, "<i class=\"oi oi-trash\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n\r\n\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                        ");
            __builder.OpenElement(138, "td");
            __builder.AddMarkupContent(139, "\r\n                            ");
            __builder.OpenElement(140, "button");
            __builder.AddAttribute(141, "class", "Icon");
            __builder.AddAttribute(142, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                                                           (() => EditCategory(obj.ID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(143, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n");
#nullable restore
#line 102 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                            Count++;



                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                         

                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(147, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n");
#nullable restore
#line 111 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(150, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n    ");
            __builder.OpenComponent<NanoSoftGreenMark.LocationM.DeleteConfirm>(152);
            __builder.AddAttribute(153, "ConfirmationChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 114 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                                                                 ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(154, "ConfirmationMessage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 115 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                                         $"Are you sure you want to delete"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(155, (__value) => {
#nullable restore
#line 114 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                         DeleteConfirmation = (NanoSoftGreenMark.LocationM.DeleteConfirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(156, "\r\n    ");
            __builder.OpenComponent<NanoSoftGreenMark.LocationM.AddLocation>(157);
            __builder.AddAttribute(158, "EventAdd", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<NanoSoftGreenMark.Data.Location>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<NanoSoftGreenMark.Data.Location>(this, 
#nullable restore
#line 117 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                                               AddData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(159, (__value) => {
#nullable restore
#line 117 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                       addComponent = (NanoSoftGreenMark.LocationM.AddLocation)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(160, "\r\n\r\n    ");
            __builder.OpenElement(161, "div");
            __builder.AddAttribute(162, "class", "center");
            __builder.AddMarkupContent(163, "\r\n        ");
            __builder.OpenElement(164, "div");
            __builder.AddAttribute(165, "class", "pagination");
            __builder.AddElementReferenceCapture(166, (__value) => {
#nullable restore
#line 120 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                                      Paging = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(167, "\r\n            ");
            __builder.OpenElement(168, "a");
            __builder.AddAttribute(169, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 121 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                         (()=>Previous())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(170, "??");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n");
#nullable restore
#line 122 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
             for (int i = 1; i <= PageCount; i++)
            {
                var buttonNumber = i;
                if (i == 1)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(172, "                    ");
            __builder.OpenElement(173, "a");
            __builder.AddAttribute(174, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 127 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                                     () => PageEvent(buttonNumber)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 127 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
__builder.AddContent(175, i);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n");
#nullable restore
#line 128 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(177, "                    ");
            __builder.OpenElement(178, "a");
            __builder.AddAttribute(179, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 131 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                                    () => PageEvent(buttonNumber)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 131 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
__builder.AddContent(180, i);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n");
#nullable restore
#line 132 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                }

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(182, "            ");
            __builder.OpenElement(183, "a");
            __builder.AddAttribute(184, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 135 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\LocationM\LocationPage.razor"
                         (()=>Next())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(185, "??");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
