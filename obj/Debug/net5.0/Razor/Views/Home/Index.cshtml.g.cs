#pragma checksum "C:\Leo\ORT\2023\Evaluaciones\EvalPRG4-Escuela-Tema1\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "637a424b812e6a65c5a8231103ef28567326d4cdff85b6367795768e61533bc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Leo\ORT\2023\Evaluaciones\EvalPRG4-Escuela-Tema1\Views\_ViewImports.cshtml"
using Eval;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Leo\ORT\2023\Evaluaciones\EvalPRG4-Escuela-Tema1\Views\_ViewImports.cshtml"
using Eval.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"637a424b812e6a65c5a8231103ef28567326d4cdff85b6367795768e61533bc8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"280bd96ecee446db4420587e9f05ed433580af0a573b792502de328c1cea18c8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Leo\ORT\2023\Evaluaciones\EvalPRG4-Escuela-Tema1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4 my-3\">Evaluación Programación Septiembre 2022</h1>\n    <div class=\"d-flex flex-column col-md-4 col-8 mx-auto\">\n        <a class=\"btn btn-primary my-3 btn-tema\"");
            BeginWriteAttribute("href", " href=\'", 253, "\'", 290, 1);
#nullable restore
#line 8 "C:\Leo\ORT\2023\Evaluaciones\EvalPRG4-Escuela-Tema1\Views\Home\Index.cshtml"
WriteAttributeValue("", 260, Url.Action("Docentes","Home"), 260, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tema 1 - Docentes</a>\n    </div>\n</div>\n\n<script type=\"text/javascript\" src=\"/js/confetti-index.js\"></script>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
