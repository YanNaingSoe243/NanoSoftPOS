#pragma checksum "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ff970e72fd73256a76feaf8ff76365d8f6810f"
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
#nullable restore
#line 3 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
using NanoSoftGreenMark.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(SaleMainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/detailpage")]
    public partial class DetailPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
 if (ShowConfirmation)
{



#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "model");
            __builder.AddAttribute(3, "style", "z-index:10");
            __builder.AddMarkupContent(4, "\r\n\r\n        ");
            __builder.OpenElement(5, "form");
            __builder.AddAttribute(6, "class", "model-content animate");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "imgcontainer");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "close");
            __builder.AddAttribute(14, "title", "Close Modal");
            __builder.AddContent(15, "??");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.AddMarkupContent(17, "<p>Payment Voncher</p>\r\n               \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "container");
            __builder.AddMarkupContent(21, "\r\n\r\n");
#nullable restore
#line 23 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                 if (invoice == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "                    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 26 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                     if (invoice.purchaseItems.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.AddMarkupContent(27, "<label for=\"uname\"><b>Invoice  Number</b></label>\r\n                            ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "text");
            __builder.AddAttribute(30, "name", "FirstName");
            __builder.AddAttribute(31, "required", true);
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                                            invoice.InvoiceNo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => invoice.InvoiceNo = __value, invoice.InvoiceNo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.AddMarkupContent(35, "<label for=\"uname\"><b>Date </b></label>\r\n                            ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "date");
            __builder.AddAttribute(38, "style", "width:100%;height:50px ;padding: 12px 20px; margin: 8px 0;display: inline-block;border: 1px solid #ccc;box-sizing: border-box;");
            __builder.AddAttribute(39, "name", "FirstName");
            __builder.AddAttribute(40, "required", true);
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                                                                                                                                                                                   invoice.SellDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => invoice.SellDate = __value, invoice.SellDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 37 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                         foreach (var obj in invoice.purchaseItems)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "productitem");
            __builder.AddMarkupContent(48, "\r\n                                ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "leftp");
            __builder.AddMarkupContent(51, "\r\n                                    ");
            __builder.OpenElement(52, "p");
            __builder.AddAttribute(53, "style", "font-weight:700");
            __builder.AddContent(54, " ");
#nullable restore
#line 41 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
__builder.AddContent(55, obj.Products.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                                    ");
            __builder.OpenElement(57, "img");
            __builder.AddAttribute(58, "src", "data:image/jpeg;base64," + (
#nullable restore
#line 42 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                                                      obj.Products.Photo

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n                                ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "detail");
            __builder.AddMarkupContent(63, "\r\n                                    ");
            __builder.OpenElement(64, "div");
            __builder.AddContent(65, " ");
            __builder.OpenElement(66, "p");
#nullable restore
#line 47 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
__builder.AddContent(67, obj.Products.Note);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddContent(68, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                                    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "style", "display:flex");
            __builder.AddMarkupContent(72, "\r\n                                        ");
            __builder.OpenElement(73, "span");
            __builder.AddAttribute(74, "class", "Price");
            __builder.AddAttribute(75, "style", "padding-right:10px;");
            __builder.AddContent(76, "Unit Price: $ ");
#nullable restore
#line 49 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
__builder.AddContent(77, obj.Products.SellPrice);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                                        ");
            __builder.OpenElement(79, "span");
            __builder.AddAttribute(80, "style", "font-weight: 700; padding-right: 10px; padding-left: 10px;");
            __builder.OpenComponent<NanoSoftGreenMark.Sale.NumericButton>(81);
            __builder.AddAttribute(82, "obj", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NanoSoftGreenMark.Data.InvoiceItem>(
#nullable restore
#line 50 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                                                                                                                      obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 50 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                                                                                                                                           (e)=>{ obj.Quantity = e;StateHasChanged(); }

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddContent(84, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                        ");
            __builder.OpenElement(86, "span");
            __builder.AddAttribute(87, "class", "Price");
            __builder.AddAttribute(88, "style", "padding-left:10px;float:right");
            __builder.AddContent(89, "Total Price $ ");
#nullable restore
#line 51 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
__builder.AddContent(90, obj.TotalPrice);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 55 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                         

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                     

                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "subtotal");
            __builder.AddAttribute(98, "style", "margin-left:50%;");
            __builder.AddMarkupContent(99, "\r\n\r\n\r\n                    ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "row");
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.AddMarkupContent(103, "<div class=\"col-50\" style=\"padding-right:10px;\">\r\n                            <label for=\"uname\"><b>Sub Total:</b></label>\r\n                        </div>\r\n                        ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "col-50");
            __builder.AddMarkupContent(106, "\r\n                            ");
            __builder.OpenElement(107, "input");
            __builder.AddAttribute(108, "type", "text");
            __builder.AddAttribute(109, "style", "width:150px;height:30px");
            __builder.AddAttribute(110, "placeholder", "0.0");
            __builder.AddAttribute(111, "value", 
#nullable restore
#line 69 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                                                                                         invoice.SubTotal

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(112, "name", "FirstName");
            __builder.AddAttribute(113, "required", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n\r\n                    ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "row");
            __builder.AddMarkupContent(119, "\r\n                        ");
            __builder.AddMarkupContent(120, "<div class=\"col-50\" style=\"padding-right:10px;\">\r\n                            <label for=\"uname\"><b>Tax:</b></label>\r\n                        </div>\r\n                        ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "col-50");
            __builder.AddMarkupContent(123, "\r\n                            ");
            __builder.OpenElement(124, "input");
            __builder.AddAttribute(125, "type", "text");
            __builder.AddAttribute(126, "style", "width:150px;height:30px");
            __builder.AddAttribute(127, "placeholder", "0.05");
            __builder.AddAttribute(128, "name", "FirstName");
            __builder.AddAttribute(129, "required", true);
            __builder.AddAttribute(130, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                                                                                               invoice.Tax

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(131, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => invoice.Tax = __value, invoice.Tax));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                    ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "row");
            __builder.AddMarkupContent(137, "\r\n                        ");
            __builder.AddMarkupContent(138, "<div class=\"col-50\" style=\"padding-right:10px;\">\r\n                            <label for=\"uname\"><b>Grand Total:</b></label>\r\n                        </div>\r\n                        ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "col-50");
            __builder.AddMarkupContent(141, "\r\n                            ");
            __builder.OpenElement(142, "input");
            __builder.AddAttribute(143, "type", "text");
            __builder.AddAttribute(144, "style", "width:150px;height:30px");
            __builder.AddAttribute(145, "placeholder", "0.0");
            __builder.AddAttribute(146, "value", 
#nullable restore
#line 88 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                                                                                         invoice.GrandTotal

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(147, "name", "FirstName");
            __builder.AddAttribute(148, "required", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                    ");
            __builder.OpenElement(152, "div");
            __builder.AddAttribute(153, "class", "row");
            __builder.AddMarkupContent(154, "\r\n                        ");
            __builder.AddMarkupContent(155, "<div class=\"col-50\" style=\"padding-right:10px;\">\r\n                            <label for=\"uname\"><b>Total Discount:</b></label>\r\n                        </div>\r\n                        ");
            __builder.OpenElement(156, "div");
            __builder.AddAttribute(157, "class", "col-50");
            __builder.AddMarkupContent(158, "\r\n                            ");
            __builder.OpenElement(159, "input");
            __builder.AddAttribute(160, "type", "text");
            __builder.AddAttribute(161, "style", "width:150px;height:30px");
            __builder.AddAttribute(162, "placeholder", "0.0");
            __builder.AddAttribute(163, "value", 
#nullable restore
#line 97 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                                                                                         invoice.TotalDiscount

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(164, "name", "FirstName");
            __builder.AddAttribute(165, "required", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n                    ");
            __builder.OpenElement(169, "div");
            __builder.AddAttribute(170, "class", "row");
            __builder.AddMarkupContent(171, "\r\n                        ");
            __builder.AddMarkupContent(172, "<div class=\"col-50\" style=\"padding-right:10px;\">\r\n                            <label for=\"uname\"><b>Net  Total:</b></label>\r\n                        </div>\r\n                        ");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "col-50");
            __builder.AddMarkupContent(175, "\r\n                            ");
            __builder.OpenElement(176, "input");
            __builder.AddAttribute(177, "type", "text");
            __builder.AddAttribute(178, "style", "width:150px;height:30px");
            __builder.AddAttribute(179, "placeholder", "0.0");
            __builder.AddAttribute(180, "value", 
#nullable restore
#line 106 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                                                                                         invoice.NetTotal

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(181, "name", "FirstName");
            __builder.AddAttribute(182, "required", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(185, "\r\n\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n\r\n                ");
            __builder.OpenElement(187, "div");
            __builder.AddAttribute(188, "class", "row");
            __builder.AddMarkupContent(189, "\r\n\r\n\r\n                    ");
            __builder.AddMarkupContent(190, "<label for=\"uname\"><b>Order Status:</b></label>\r\n\r\n\r\n                    ");
            __builder.OpenElement(191, "select");
            __builder.AddAttribute(192, "required", true);
            __builder.AddAttribute(193, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 120 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                    invoice.PaymentStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(194, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => invoice.PaymentStatus = __value, invoice.PaymentStatus));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(195, "\r\n");
#nullable restore
#line 122 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                         foreach (OrderStatus obj in Enum.GetValues(typeof(OrderStatus)))
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(196, "                            ");
            __builder.OpenElement(197, "option");
            __builder.AddAttribute(198, "value", 
#nullable restore
#line 124 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                            obj

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 124 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
__builder.AddContent(199, obj);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n");
#nullable restore
#line 125 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(201, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n");
#nullable restore
#line 127 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                     if (invoice?.PaymentStatus == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(203, "                        ");
            __builder.AddMarkupContent(204, "<div class=\"validation\" style=\"display:block;width:100%\">Order Status is  Empty </div>\r\n");
#nullable restore
#line 130 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(205, "                ");
            __builder.AddMarkupContent(206, "<div class=\"validation\" style=\"display:none\">Order Status is  Empty </div>\r\n");
#nullable restore
#line 134 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(207, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(208, "\r\n                ");
            __builder.OpenElement(209, "div");
            __builder.AddAttribute(210, "class", "row");
            __builder.AddMarkupContent(211, "\r\n\r\n\r\n                    ");
            __builder.AddMarkupContent(212, "<label for=\"uname\"><b>PaymentStatus:</b></label>\r\n\r\n\r\n                    ");
            __builder.OpenElement(213, "select");
            __builder.AddAttribute(214, "required", true);
            __builder.AddAttribute(215, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 144 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                    invoice.PaymentStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(216, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => invoice.PaymentStatus = __value, invoice.PaymentStatus));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(217, "\r\n");
#nullable restore
#line 146 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                         foreach (PaymentStatus obj in Enum.GetValues(typeof(PaymentStatus)))
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(218, "                            ");
            __builder.OpenElement(219, "option");
            __builder.AddAttribute(220, "value", 
#nullable restore
#line 148 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                            obj

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 148 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
__builder.AddContent(221, obj);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\r\n");
#nullable restore
#line 149 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(223, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(224, "\r\n");
#nullable restore
#line 151 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                     if (invoice?.PaymentStatus == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(225, "                        ");
            __builder.AddMarkupContent(226, "<div class=\"validation\" style=\"display:block;width:100%\">Payment Status is  Empty </div>\r\n");
#nullable restore
#line 154 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(227, "                        ");
            __builder.AddMarkupContent(228, "<div class=\"validation\" style=\"display:none\">Payment Status is  Empty </div>\r\n");
#nullable restore
#line 158 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(229, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(230, "\r\n                ");
            __builder.OpenElement(231, "div");
            __builder.AddAttribute(232, "class", "row");
            __builder.AddMarkupContent(233, "\r\n\r\n\r\n                    ");
            __builder.AddMarkupContent(234, "<label for=\"uname\"><b>Payment Method:</b></label>\r\n\r\n\r\n                    ");
            __builder.OpenElement(235, "select");
            __builder.AddAttribute(236, "required", true);
            __builder.AddAttribute(237, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 168 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                    invoice.PaymentMethod

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(238, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => invoice.PaymentMethod = __value, invoice.PaymentMethod));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(239, "\r\n");
#nullable restore
#line 170 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                         foreach (PaymentMethod obj in Enum.GetValues(typeof(PaymentMethod)))
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(240, "                            ");
            __builder.OpenElement(241, "option");
            __builder.AddAttribute(242, "value", 
#nullable restore
#line 172 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                            obj

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 172 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
__builder.AddContent(243, obj);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(244, "\r\n");
#nullable restore
#line 173 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(245, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(246, "\r\n");
#nullable restore
#line 175 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                     if (invoice?.PaymentMethod == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(247, "                        ");
            __builder.AddMarkupContent(248, "<div class=\"validation\" style=\"display:block;width:100%\">PaymentMethod Status is  Empty </div>\r\n");
#nullable restore
#line 178 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(249, "                        ");
            __builder.AddMarkupContent(250, "<div class=\"validation\" style=\"display:none\">PaymentMethod Status is  Empty </div>\r\n");
#nullable restore
#line 182 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(251, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(252, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(253, "\r\n              \r\n\r\n            ");
            __builder.OpenElement(254, "div");
            __builder.AddAttribute(255, "class", "ModelFooter");
            __builder.AddMarkupContent(256, "\r\n                ");
            __builder.OpenElement(257, "button");
            __builder.AddAttribute(258, "type", "button");
            __builder.AddAttribute(259, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 191 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
                                                Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(260, "class", "btn btn-danger cancelbtn");
            __builder.AddContent(261, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(262, "\r\n                ");
            __builder.AddMarkupContent(263, "<button type=\"button\" class=\"btn btn-success savebtn\">Print</button>\r\n               \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(264, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(265, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(266, "\r\n");
#nullable restore
#line 197 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
  

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 202 "D:\Project\NanoSoftPOS\NanoSoftGreenMark\NanoSoftGreenMark\Sale\DetailPage.razor"
       
    protected bool ShowConfirmation { get; set; }
    [Parameter]
    public Invoice invoice { get; set; }
    public void Show()
    {
        ShowConfirmation = true;


    }
    public void Close()
    {
        ShowConfirmation = false;
        StateHasChanged();
    }
    
   
    //public async void PassData(Invoice obj)
    //{
    //    invoice = obj;
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NanoSoftGreenMark.DepandencyInjection.InterFaceModel Service { get; set; }
    }
}
#pragma warning restore 1591
