#pragma checksum "E:\E\nashtech\bai6\Views\Rookies\GetOldest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b30ac083fe431829dcf39bc4d2fced5821bb67c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_GetOldest), @"mvc.1.0.view", @"/Views/Rookies/GetOldest.cshtml")]
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
#line 1 "E:\E\nashtech\bai6\Views\_ViewImports.cshtml"
using bai6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\E\nashtech\bai6\Views\_ViewImports.cshtml"
using bai6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b30ac083fe431829dcf39bc4d2fced5821bb67c", @"/Views/Rookies/GetOldest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91c3fe7d9de2b141028d26154771ef4b2b0d991", @"/Views/_ViewImports.cshtml")]
    public class Views_Rookies_GetOldest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PersonModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\E\nashtech\bai6\Views\Rookies\GetOldest.cshtml"
  
    foreach (var i in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 5 "E:\E\nashtech\bai6\Views\Rookies\GetOldest.cshtml"
       Write(i.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 5 "E:\E\nashtech\bai6\Views\Rookies\GetOldest.cshtml"
                     Write(i.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "E:\E\nashtech\bai6\Views\Rookies\GetOldest.cshtml"
                                 Write(i.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "E:\E\nashtech\bai6\Views\Rookies\GetOldest.cshtml"
                                           Write(i.Dob);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "E:\E\nashtech\bai6\Views\Rookies\GetOldest.cshtml"
                                                  Write(i.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "E:\E\nashtech\bai6\Views\Rookies\GetOldest.cshtml"
                                                                 Write(i.BirthPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "E:\E\nashtech\bai6\Views\Rookies\GetOldest.cshtml"
                                                                               Write(i.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "E:\E\nashtech\bai6\Views\Rookies\GetOldest.cshtml"
                                                                                      Write(i.IsGraduated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 6 "E:\E\nashtech\bai6\Views\Rookies\GetOldest.cshtml"
        break;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PersonModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
