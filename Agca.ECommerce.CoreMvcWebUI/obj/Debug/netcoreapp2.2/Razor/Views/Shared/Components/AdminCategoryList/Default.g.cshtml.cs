#pragma checksum "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Shared\Components\AdminCategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e38b6f10792f537eaf8e577c79471c830d7e063"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminCategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdminCategoryList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/AdminCategoryList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_AdminCategoryList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e38b6f10792f537eaf8e577c79471c830d7e063", @"/Views/Shared/Components/AdminCategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"536557108cfb44e3c50861faf0d0d911906624c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AdminCategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Agca.ECommerce.CoreMvcWebUI.Models.CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 195, true);
            WriteLiteral("\r\n    <div class=\"list-group\">\r\n        <div class=\"list-group-item disabled bg-info text-light\">Categories</div>\r\n        <a href=\"/Admin/ListProducts\" class=\"list-group-item\">All Products</a>\r\n");
            EndContext();
#line 6 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Shared\Components\AdminCategoryList\Default.cshtml"
         foreach (var category in Model.Categories)
        {
            string cssClass = "list-group-item";
            if (Model.CurrentCategoryId == category.Id)
            {
                cssClass += " active";
            }

#line default
#line hidden
            BeginContext(501, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=", 509, "", 525, 1);
#line 13 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Shared\Components\AdminCategoryList\Default.cshtml"
WriteAttributeValue("", 516, cssClass, 516, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(525, 104, true);
            WriteLiteral(">\r\n        <div class=\"row col-md-12\">\r\n            <div class=\"col-md-9 text-left\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 629, "\"", 679, 2);
            WriteAttributeValue("", 636, "/Admin/ListProducts?categoryId=", 636, 31, true);
#line 16 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Shared\Components\AdminCategoryList\Default.cshtml"
WriteAttributeValue("", 667, category.Id, 667, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(680, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(682, 13, false);
#line 16 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Shared\Components\AdminCategoryList\Default.cshtml"
                                                                 Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(695, 91, true);
            WriteLiteral("</a>\r\n            </div>\r\n            <div class=\"col-md-1 text-right\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 786, "\"", 838, 2);
            WriteAttributeValue("", 793, "/Admin/UpdateCategory?categoryId=", 793, 33, true);
#line 19 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Shared\Components\AdminCategoryList\Default.cshtml"
WriteAttributeValue("", 826, category.Id, 826, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(839, 125, true);
            WriteLiteral("><i class=\"fa fa-edit fa-2x\"></i></a>\r\n            </div>\r\n            <div class=\"col-md-1  text-right\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 964, "\"", 1016, 2);
            WriteAttributeValue("", 971, "/Admin/DeleteCategory?categoryId=", 971, 33, true);
#line 22 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Shared\Components\AdminCategoryList\Default.cshtml"
WriteAttributeValue("", 1004, category.Id, 1004, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1017, 92, true);
            WriteLiteral(" ><i class=\"fa fa-remove fa-2x\"></i></a>\r\n            </div>\r\n        </div>  \r\n    </div>\r\n");
            EndContext();
#line 26 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\Shared\Components\AdminCategoryList\Default.cshtml"
            
        }

#line default
#line hidden
            BeginContext(1134, 265, true);
            WriteLiteral(@"        <a href=""/Admin/AddCategory"" class=""list-group-item bg-light text-success"" style=""font-size:14pt; font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; border:dashed;""><i class=""fa fa-plus ""></i>Add a new category</a>
    </div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Agca.ECommerce.CoreMvcWebUI.Models.CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
