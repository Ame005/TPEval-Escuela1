#pragma checksum "C:\Leo\ORT\2023\Evaluaciones\EvalPRG4-Escuela-Tema1\Views\Home\VerDetalleDocente.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "dc489ddd6dcbad9cfb4e357d904eb882349ecf433ba5af5498251c144bd6af7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VerDetalleDocente), @"mvc.1.0.view", @"/Views/Home/VerDetalleDocente.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"dc489ddd6dcbad9cfb4e357d904eb882349ecf433ba5af5498251c144bd6af7b", @"/Views/Home/VerDetalleDocente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"280bd96ecee446db4420587e9f05ed433580af0a573b792502de328c1cea18c8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_VerDetalleDocente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"customCard shadow-lg rounded\">\n  <img class=\"mb-3 rounded\"");
            BeginWriteAttribute("src", " src=\"", 70, "\"", 104, 1);
#nullable restore
#line 2 "C:\Leo\ORT\2023\Evaluaciones\EvalPRG4-Escuela-Tema1\Views\Home\VerDetalleDocente.cshtml"
WriteAttributeValue("", 76, ViewBag.Docente.FotoDocente, 76, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\">\n  <h4 class=\"mb-3\">");
#nullable restore
#line 3 "C:\Leo\ORT\2023\Evaluaciones\EvalPRG4-Escuela-Tema1\Views\Home\VerDetalleDocente.cshtml"
              Write(ViewBag.Docente.NombreDocente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n  <p><span class=\"font-weight-bold\">Antiguedad Docente : </span>");
#nullable restore
#line 4 "C:\Leo\ORT\2023\Evaluaciones\EvalPRG4-Escuela-Tema1\Views\Home\VerDetalleDocente.cshtml"
                                                           Write(ViewBag.Docente.AntiguedadDocente);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    año");
#nullable restore
#line 5 "C:\Leo\ORT\2023\Evaluaciones\EvalPRG4-Escuela-Tema1\Views\Home\VerDetalleDocente.cshtml"
   Write(ViewBag.Docente.AntiguedadDocente > 1 ? "s": "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n  <p><span class=\"font-weight-bold\">Materia : </span>");
#nullable restore
#line 6 "C:\Leo\ORT\2023\Evaluaciones\EvalPRG4-Escuela-Tema1\Views\Home\VerDetalleDocente.cshtml"
                                                Write(ViewBag.Docente.NombreMateria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n  <a");
            BeginWriteAttribute("href", " href=\'", 429, "\'", 467, 1);
#nullable restore
#line 7 "C:\Leo\ORT\2023\Evaluaciones\EvalPRG4-Escuela-Tema1\Views\Home\VerDetalleDocente.cshtml"
WriteAttributeValue("", 436, Url.Action("Docentes", "Home"), 436, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Volver</a>\n</div>\n\n<script type=\"text/javascript\" src=\"/js/confetti-effect.js\"></script>");
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
