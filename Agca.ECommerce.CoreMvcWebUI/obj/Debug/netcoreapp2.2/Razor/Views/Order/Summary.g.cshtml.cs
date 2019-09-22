#pragma checksum "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c01305282fe2e28944c6f3d483f20337171e34d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Summary), @"mvc.1.0.view", @"/Views/Order/Summary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Summary.cshtml", typeof(AspNetCore.Views_Order_Summary))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c01305282fe2e28944c6f3d483f20337171e34d", @"/Views/Order/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"536557108cfb44e3c50861faf0d0d911906624c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Agca.ECommerce.CoreMvcWebUI.Models.OrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Summary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 615, true);
            WriteLiteral(@"
<div class=""card border-info mb-3"">
    <div class=""card-header text-dark"" style=""font-size :20pt"">Order Items</div>
    <div class=""card-body text-dark"">

        <table class=""table text-center"">
            <thead>
                <tr>
                    <th class=""text-left"">
                        Product Name
                    </th>
                    <th>
                        Product Quantity
                    </th>
                    <th>
                        Product Unit Price
                    </th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 26 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                 foreach (var item in Model.OrderItems)
                {

#line default
#line hidden
            BeginContext(838, 102, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-left\">\r\n                            ");
            EndContext();
            BeginContext(941, 17, false);
#line 30 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                       Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(958, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1050, 13, false);
#line 33 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                       Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1063, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1155, 22, false);
#line 36 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                       Write(item.Product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1177, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 39 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"

                }

#line default
#line hidden
            BeginContext(1258, 331, true);
            WriteLiteral(@"                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td class=""font-weight-light"">
                        <span class=""font-weight-bold"">
                            Total :
                        </span>
                        ");
            EndContext();
            BeginContext(1590, 22, false);
#line 50 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                   Write(Model.Order.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1612, 441, true);
            WriteLiteral(@" <i class=""fa fa-turkish-lira""></i>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>


<div class=""card border-warning mb-3"">
    <div class=""card-header text-dark"" style=""font-size : 20pt"">Shipping Informations</div>
    <div class=""card-body text-dark"">

        <h5 class=""card-title font-italic"">Customer First Name</h5>
        <p class=""card-text font-weight-light"">");
            EndContext();
            BeginContext(2054, 32, false);
#line 64 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                                          Write(Model.Shipment.ReceiverFirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2086, 137, true);
            WriteLiteral("</p>\r\n        <hr />\r\n        <h5 class=\"card-title font-italic\">Customer Last Name</h5>\r\n        <p class=\"card-text font-weight-light\">");
            EndContext();
            BeginContext(2224, 31, false);
#line 67 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                                          Write(Model.Shipment.ReceiverLastName);

#line default
#line hidden
            EndContext();
            BeginContext(2255, 138, true);
            WriteLiteral("</p>\r\n        <hr />\r\n        <h5 class=\"card-title font-italic\">Customer Turkish Id</h5>\r\n        <p class=\"card-text font-weight-light\">");
            EndContext();
            BeginContext(2394, 34, false);
#line 70 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                                          Write(Model.Shipment.ReceiverTurkishIdNo);

#line default
#line hidden
            EndContext();
            BeginContext(2428, 125, true);
            WriteLiteral("</p>\r\n        <hr />\r\n        <h5 class=\"card-title font-italic\">E Mail</h5>\r\n        <p class=\"card-text font-weight-light\">");
            EndContext();
            BeginContext(2554, 28, false);
#line 73 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                                          Write(Model.Shipment.ReceiverEMail);

#line default
#line hidden
            EndContext();
            BeginContext(2582, 131, true);
            WriteLiteral("</p>\r\n        <hr />\r\n        <h5 class=\"card-title font-italic\">Phone Number</h5>\r\n        <p class=\"card-text font-weight-light\">");
            EndContext();
            BeginContext(2714, 34, false);
#line 76 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                                          Write(Model.Shipment.ReceiverPhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2748, 135, true);
            WriteLiteral("</p>\r\n        <hr />\r\n        <h5 class=\"card-title font-italic\">Shipping Address</h5>\r\n        <p class=\"card-text font-weight-light\">");
            EndContext();
            BeginContext(2884, 30, false);
#line 79 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                                          Write(Model.Shipment.ReceiverAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2914, 314, true);
            WriteLiteral(@"</p>
    </div>
</div>



<div class=""card border-success mb-3"">
    <div class=""card-header text-dark"" style=""font-size :20pt"">Billing</div>
    <div class=""card-body text-dark"">

        <div class=""row font-weight-light"">
            <div class=""col-md-8 text-left"">
                <p>Turkish ID : ");
            EndContext();
            BeginContext(3229, 34, false);
#line 91 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                           Write(Model.Shipment.ReceiverTurkishIdNo);

#line default
#line hidden
            EndContext();
            BeginContext(3263, 38, true);
            WriteLiteral("</p>\r\n                <p>First Name : ");
            EndContext();
            BeginContext(3302, 32, false);
#line 92 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                           Write(Model.Shipment.ReceiverFirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3334, 37, true);
            WriteLiteral("</p>\r\n                <p>Last Name : ");
            EndContext();
            BeginContext(3372, 31, false);
#line 93 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                          Write(Model.Shipment.ReceiverLastName);

#line default
#line hidden
            EndContext();
            BeginContext(3403, 126, true);
            WriteLiteral("</p>\r\n                \r\n            </div>\r\n\r\n            <div class=\"col-md-4 text-left\">\r\n                <p>Phone Number : ");
            EndContext();
            BeginContext(3530, 34, false);
#line 98 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                             Write(Model.Shipment.ReceiverPhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3564, 34, true);
            WriteLiteral("</p>\r\n                <p>E-Mail : ");
            EndContext();
            BeginContext(3599, 28, false);
#line 99 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                       Write(Model.Shipment.ReceiverEMail);

#line default
#line hidden
            EndContext();
            BeginContext(3627, 35, true);
            WriteLiteral("</p>\r\n                <p>Address : ");
            EndContext();
            BeginContext(3663, 30, false);
#line 100 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                        Write(Model.Shipment.ReceiverAddress);

#line default
#line hidden
            EndContext();
            BeginContext(3693, 617, true);
            WriteLiteral(@"</p>
            </div>

        </div>

        <hr />
        <table class=""table text-center font-weight-light"">
            <thead>
                <tr>
                    <th class=""text-left"">
                        Product Name
                    </th>
                    <th>
                        Product Quantity
                    </th>
                    <th>
                        Product Unit Price
                    </th>
                    <th>
                        Price
                    </th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 124 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                 foreach (var item in Model.OrderItems)
                {

#line default
#line hidden
            BeginContext(4386, 90, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"text-left\">\r\n                        ");
            EndContext();
            BeginContext(4477, 17, false);
#line 128 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                   Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4494, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4574, 13, false);
#line 131 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(4587, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4667, 22, false);
#line 134 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                   Write(item.Product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(4689, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4770, 36, false);
#line 137 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
                    Write(item.Quantity*item.Product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(4807, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 140 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"

                }

#line default
#line hidden
            BeginContext(4880, 285, true);
            WriteLiteral(@"            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
                <td>
                    <span>
                        Total :
                    </span>
                    ");
            EndContext();
            BeginContext(5166, 22, false);
#line 153 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Order\Summary.cshtml"
               Write(Model.Order.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(5188, 145, true);
            WriteLiteral(" <i class=\"fa fa-turkish-lira\"></i>\r\n                </td>\r\n            </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(5333, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c01305282fe2e28944c6f3d483f20337171e34d17618", async() => {
                BeginContext(5421, 34, true);
                WriteLiteral("<span class=\"text-white\">Ok</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Agca.ECommerce.CoreMvcWebUI.Models.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
