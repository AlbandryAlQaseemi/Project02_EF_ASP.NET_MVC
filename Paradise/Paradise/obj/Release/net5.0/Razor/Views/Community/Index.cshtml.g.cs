#pragma checksum "C:\Users\Alban\source\repos\Paradise\Paradise\Views\Community\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82055247745b277ef9db91e4ec82d71ea743264d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Community_Index), @"mvc.1.0.view", @"/Views/Community/Index.cshtml")]
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
#line 1 "C:\Users\Alban\source\repos\Paradise\Paradise\Views\_ViewImports.cshtml"
using Paradise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alban\source\repos\Paradise\Paradise\Views\_ViewImports.cshtml"
using Paradise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82055247745b277ef9db91e4ec82d71ea743264d", @"/Views/Community/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab2d520202860330765bbe94cf1db04ef26b7e56", @"/Views/_ViewImports.cshtml")]
    public class Views_Community_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Alban\source\repos\Paradise\Paradise\Views\Community\Index.cshtml"
  
    var Comments = (List<Comment>)ViewData["Comments"];
    //  var Flowers = (List<Flower>)ViewData["Flowers"];
    var Plants = (List<Plant>)ViewData["Plants"];


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 style=\"color:whitesmoke; font-family:\'Comic Sans MS\';margin-left:340px\">Community of Plants Lover</h1>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Alban\source\repos\Paradise\Paradise\Views\Community\Index.cshtml"
 foreach (var comment in Comments)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"list-group\" style=\"font-family:\'Comic Sans MS\'; margin-top:40px; margin-left:100px;\r\nmargin-right:100px\">\r\n        <li class=\"list-group-item\">");
#nullable restore
#line 16 "C:\Users\Alban\source\repos\Paradise\Paradise\Views\Community\Index.cshtml"
                               Write(comment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\"></li>\r\n    </ul>\r\n");
#nullable restore
#line 19 "C:\Users\Alban\source\repos\Paradise\Paradise\Views\Community\Index.cshtml"

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
