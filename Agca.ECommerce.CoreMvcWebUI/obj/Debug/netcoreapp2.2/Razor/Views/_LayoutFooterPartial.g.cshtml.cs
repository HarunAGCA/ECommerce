#pragma checksum "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\_LayoutFooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6271bdaf8069c9de749f8ab1999c7c7aaa14b4a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__LayoutFooterPartial), @"mvc.1.0.view", @"/Views/_LayoutFooterPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/_LayoutFooterPartial.cshtml", typeof(AspNetCore.Views__LayoutFooterPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6271bdaf8069c9de749f8ab1999c7c7aaa14b4a6", @"/Views/_LayoutFooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"536557108cfb44e3c50861faf0d0d911906624c8", @"/Views/_ViewImports.cshtml")]
    public class Views__LayoutFooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 212, true);
            WriteLiteral("    <!-- Footer -->\r\n<div class=\"col-md-12\">\r\n\r\n    <footer class=\"page-footer font-small blue\">\r\n\r\n        <!-- Copyright -->\r\n        <div class=\"footer-copyright text-center py-3 bg-secondary\">\r\n            © ");
            EndContext();
            BeginContext(213, 17, false);
#line 8 "D:\PROJECTS\WEB\Agca\Agca.ECommerce.CoreMvcWebUI\Views\_LayoutFooterPartial.cshtml"
         Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(230, 140, true);
            WriteLiteral(" Copyright:\r\n            <a href=\"#\"> E-Commerce</a>\r\n        </div>\r\n        <!-- Copyright -->\r\n\r\n    </footer>\r\n\r\n</div>\r\n<!-- Footer -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
