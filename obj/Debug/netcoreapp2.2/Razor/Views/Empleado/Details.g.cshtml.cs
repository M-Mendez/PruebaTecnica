#pragma checksum "c:\NetC\PruebaT\Views\Empleado\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4477d084cd94770ea9f4b9191fff6b20d656febb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Details), @"mvc.1.0.view", @"/Views/Empleado/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empleado/Details.cshtml", typeof(AspNetCore.Views_Empleado_Details))]
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
#line 1 "c:\NetC\PruebaT\Views\_ViewImports.cshtml"
using PruebaT;

#line default
#line hidden
#line 2 "c:\NetC\PruebaT\Views\_ViewImports.cshtml"
using PruebaT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4477d084cd94770ea9f4b9191fff6b20d656febb", @"/Views/Empleado/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"042007e9983679f5da52a663ceafc3ea00ef0a1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PruebaT.Models.Empleado>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 94, true);
            WriteLiteral("<section class=\"content-header\">\r\n        <div class=\"col-md-2\">\r\n                            ");
            EndContext();
            BeginContext(126, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4477d084cd94770ea9f4b9191fff6b20d656febb3504", async() => {
                BeginContext(148, 16, true);
                WriteLiteral("Regresar a lista");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(168, 59, true);
            WriteLiteral("\r\n                        </div>\r\n    <h1>\r\n    Detalle de ");
            EndContext();
            BeginContext(228, 20, false);
#line 7 "c:\NetC\PruebaT\Views\Empleado\Details.cshtml"
          Write(Model.NombreCompleto);

#line default
#line hidden
            EndContext();
            BeginContext(248, 161, true);
            WriteLiteral("\r\n    </h1>\r\n</section>\r\n<!-- Main content -->\r\n<section class=\"content container-fluid\">\r\n<div class=\"container\">\r\n<br>\r\n<div class=\"row\">\r\n    <h5>Numero DPI: ");
            EndContext();
            BeginContext(410, 9, false);
#line 15 "c:\NetC\PruebaT\Views\Empleado\Details.cshtml"
               Write(Model.DPI);

#line default
#line hidden
            EndContext();
            BeginContext(419, 61, true);
            WriteLiteral("</h5>  \r\n</div>\r\n<div class=\"row\">\r\n    <h5>Numero de Hijos: ");
            EndContext();
            BeginContext(481, 19, false);
#line 18 "c:\NetC\PruebaT\Views\Empleado\Details.cshtml"
                    Write(Model.cantidadHijos);

#line default
#line hidden
            EndContext();
            BeginContext(500, 179, true);
            WriteLiteral("</h5> \r\n</div>\r\n<div class =\"text-center\">\r\n    <h4 class=\"text-primary\"> Informacion finaciera</h4>\r\n\r\n    <h5 class=\"text-danger\">Descuentos</h5>\r\n\r\n<br>\r\n    <h6>Pago de Iggs: ");
            EndContext();
            BeginContext(680, 10, false);
#line 26 "c:\NetC\PruebaT\Views\Empleado\Details.cshtml"
                 Write(Model.Iggs);

#line default
#line hidden
            EndContext();
            BeginContext(690, 31, true);
            WriteLiteral("</h6> \r\n    <h6>Pago de Irtra: ");
            EndContext();
            BeginContext(722, 11, false);
#line 27 "c:\NetC\PruebaT\Views\Empleado\Details.cshtml"
                  Write(Model.Irtra);

#line default
#line hidden
            EndContext();
            BeginContext(733, 89, true);
            WriteLiteral("</h6> \r\n<br>    \r\n    <h5 class=\"text-success\">Bonos</h5>\r\n\r\n<br>\r\n    <h6>Bono Decreto: ");
            EndContext();
            BeginContext(823, 17, false);
#line 32 "c:\NetC\PruebaT\Views\Empleado\Details.cshtml"
                 Write(Model.BonoDecreto);

#line default
#line hidden
            EndContext();
            BeginContext(840, 32, true);
            WriteLiteral("</h6>\r\n    <h6>Bono Paternidad: ");
            EndContext();
            BeginContext(873, 19, false);
#line 33 "c:\NetC\PruebaT\Views\Empleado\Details.cshtml"
                    Write(Model.BonoPaterniad);

#line default
#line hidden
            EndContext();
            BeginContext(892, 91, true);
            WriteLiteral("</h6> \r\n   <br> \r\n    <h5 class=\"text-warning\">Salario</h5>\r\n\r\n<br>\r\n    <h6>Salario Base: ");
            EndContext();
            BeginContext(984, 17, false);
#line 38 "c:\NetC\PruebaT\Views\Empleado\Details.cshtml"
                 Write(Model.SALARIOBASE);

#line default
#line hidden
            EndContext();
            BeginContext(1001, 30, true);
            WriteLiteral("</h6>\r\n    <h6>Salario Total: ");
            EndContext();
            BeginContext(1032, 18, false);
#line 39 "c:\NetC\PruebaT\Views\Empleado\Details.cshtml"
                  Write(Model.SalarioTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1050, 61, true);
            WriteLiteral("</h6>\r\n<br>\r\n    <h3 class=\"text-success\">Salario Liquido: Q ");
            EndContext();
            BeginContext(1112, 20, false);
#line 41 "c:\NetC\PruebaT\Views\Empleado\Details.cshtml"
                                           Write(Model.SalarioLiquido);

#line default
#line hidden
            EndContext();
            BeginContext(1132, 39, true);
            WriteLiteral("</h3>\r\n</div>    \r\n\r\n</div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PruebaT.Models.Empleado> Html { get; private set; }
    }
}
#pragma warning restore 1591
