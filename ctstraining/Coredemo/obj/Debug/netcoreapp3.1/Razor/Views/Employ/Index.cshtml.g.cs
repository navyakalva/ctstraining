#pragma checksum "E:\Navya\2-1-2020\Coredemo\Views\Employ\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c7a50e63497960ef71ec70391bc792a2bb2c0d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employ_Index), @"mvc.1.0.view", @"/Views/Employ/Index.cshtml")]
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
#line 1 "E:\Navya\2-1-2020\Coredemo\Views\_ViewImports.cshtml"
using Coredemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Navya\2-1-2020\Coredemo\Views\_ViewImports.cshtml"
using Coredemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c7a50e63497960ef71ec70391bc792a2bb2c0d5", @"/Views/Employ/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c3554b53cee54d629a606a3764bb83593f4252", @"/Views/_ViewImports.cshtml")]
    public class Views_Employ_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employ>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <h1>Employ Details</h1>
    <table border=""1"">
        <tr>

            <td>      ID              </td>
            <td>      Name            </td>
            <td>      Email           </td>
            <td>      Dept            </td>
        </tr>
");
#nullable restore
#line 22 "E:\Navya\2-1-2020\Coredemo\Views\Employ\Index.cshtml"
         foreach(var emp in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 25 "E:\Navya\2-1-2020\Coredemo\Views\Employ\Index.cshtml"
       Write(emp.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "E:\Navya\2-1-2020\Coredemo\Views\Employ\Index.cshtml"
       Write(emp.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "E:\Navya\2-1-2020\Coredemo\Views\Employ\Index.cshtml"
       Write(emp.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "E:\Navya\2-1-2020\Coredemo\Views\Employ\Index.cshtml"
       Write(emp.dept);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 30 "E:\Navya\2-1-2020\Coredemo\Views\Employ\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employ>> Html { get; private set; }
    }
}
#pragma warning restore 1591
