#pragma checksum "D:\Advanced C#\Final Project\Views\Solver\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e54faf3710e9fabe922f464c0178017a66a0dce5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Solver_History), @"mvc.1.0.view", @"/Views/Solver/History.cshtml")]
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
#line 1 "D:\Advanced C#\Final Project\Views\_ViewImports.cshtml"
using Final_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Advanced C#\Final Project\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e54faf3710e9fabe922f464c0178017a66a0dce5", @"/Views/Solver/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4fb7ef317ae05155a488c52b2e91b7ab94cdc5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Solver_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Question>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Advanced C#\Final Project\Views\Solver\History.cshtml"
  
    ViewData["Title"] = "Quizlet Solver";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Your Previousy Asked Questions</h4>\r\n\r\n");
#nullable restore
#line 9 "D:\Advanced C#\Final Project\Views\Solver\History.cshtml"
 foreach(var question in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"question\">\r\n    <h6 class=\"query\">\r\n        You asked: <p>");
#nullable restore
#line 13 "D:\Advanced C#\Final Project\Views\Solver\History.cshtml"
                 Write(question.query);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </h6>\r\n    <h6 class=\"answer\">\r\n        We found: <p>");
#nullable restore
#line 16 "D:\Advanced C#\Final Project\Views\Solver\History.cshtml"
                Write(question.answer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </h6>\r\n</div>\r\n");
#nullable restore
#line 19 "D:\Advanced C#\Final Project\Views\Solver\History.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
