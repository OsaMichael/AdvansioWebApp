#pragma checksum "C:\Users\Mr Mchael\Documents\Visual Studio 2019\Projects\AdvanWeb\Views\Shared\_NotificationPanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c91fe3f6f279d9d827cae4694a75194498aea865"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NotificationPanel), @"mvc.1.0.view", @"/Views/Shared/_NotificationPanel.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Mr Mchael\Documents\Visual Studio 2019\Projects\AdvanWeb\Views\_ViewImports.cshtml"
using AdvanWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mr Mchael\Documents\Visual Studio 2019\Projects\AdvanWeb\Views\_ViewImports.cshtml"
using AdvanWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c91fe3f6f279d9d827cae4694a75194498aea865", @"/Views/Shared/_NotificationPanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8055fc4bb18cf0ac8702cbe13b00b029ed9cdc6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NotificationPanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Mr Mchael\Documents\Visual Studio 2019\Projects\AdvanWeb\Views\Shared\_NotificationPanel.cshtml"
 if (TempData["notification"] != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mr Mchael\Documents\Visual Studio 2019\Projects\AdvanWeb\Views\Shared\_NotificationPanel.cshtml"
Write(Html.Raw(TempData["notification"]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mr Mchael\Documents\Visual Studio 2019\Projects\AdvanWeb\Views\Shared\_NotificationPanel.cshtml"
                                       
}

#line default
#line hidden
#nullable disable
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
