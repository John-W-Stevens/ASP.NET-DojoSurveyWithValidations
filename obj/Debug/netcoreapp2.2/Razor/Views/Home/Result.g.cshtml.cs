#pragma checksum "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/DojoSurveyWithModel/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "935e4f36a04fb7d617546d738da06889ba3691fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/DojoSurveyWithModel/Views/_ViewImports.cshtml"
using DojoSurveyWithModel;

#line default
#line hidden
#line 4 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/DojoSurveyWithModel/Views/Home/Result.cshtml"
using DojoSurveyWithModel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"935e4f36a04fb7d617546d738da06889ba3691fe", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23eee8675a923651d7066bdc158145829c668f74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/DojoSurveyWithModel/Views/Home/Result.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(95, 629, true);
            WriteLiteral(@"
<div class=""row text-center"">
    <div class=""col-12"">
        <h1 class=""display-4"">Survey Results</h1>
    </div>
</div>


<div class=""row"">
    <div class=""col-10 offset-1 col-md-8 offset-md-2 col-lg-6 offset-lg-3"">
        <h4>Submitted Info</h4>
    </div>
    <div class=""col-10 offset-1 col-md-8 offset-md-2 col-lg-6 offset-lg-3"">
        <div class=""row"">
            <div class=""col-6"">
                <p>Name:</p>
                <p>Dojo Location:</p>
                <p>Favorite Language:</p>
                <p>Comment:</p>
            </div>
            <div class=""col-6"">
                <p>");
            EndContext();
            BeginContext(725, 10, false);
#line 27 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/DojoSurveyWithModel/Views/Home/Result.cshtml"
              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(735, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(761, 14, false);
#line 28 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/DojoSurveyWithModel/Views/Home/Result.cshtml"
              Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(775, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(801, 14, false);
#line 29 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/DojoSurveyWithModel/Views/Home/Result.cshtml"
              Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(815, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(841, 13, false);
#line 30 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/DojoSurveyWithModel/Views/Home/Result.cshtml"
              Write(Model.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(854, 62, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591