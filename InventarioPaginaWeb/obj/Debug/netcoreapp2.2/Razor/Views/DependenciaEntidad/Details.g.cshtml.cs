#pragma checksum "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\DependenciaEntidad\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c19dbefa3e796404a731d957a7ab424194b7e8a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DependenciaEntidad_Details), @"mvc.1.0.view", @"/Views/DependenciaEntidad/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DependenciaEntidad/Details.cshtml", typeof(AspNetCore.Views_DependenciaEntidad_Details))]
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
#line 1 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\_ViewImports.cshtml"
using InventarioPaginaWeb;

#line default
#line hidden
#line 2 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\_ViewImports.cshtml"
using InventarioPaginaWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c19dbefa3e796404a731d957a7ab424194b7e8a2", @"/Views/DependenciaEntidad/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"744364d3c56445e9da57c348ab3386dfaa578dce", @"/Views/_ViewImports.cshtml")]
    public class Views_DependenciaEntidad_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventarioPaginaWeb.Models.DependenciaEntidad>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\DependenciaEntidad\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 139, true);
            WriteLiteral("\n<h1>Detalles</h1>\n\n<div>\n    <h4>Dependencia / Entidad</h4>\n    <hr />\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(280, 56, false);
#line 16 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\DependenciaEntidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdDependenciaEntidad));

#line default
#line hidden
            EndContext();
            BeginContext(336, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(398, 52, false);
#line 19 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\DependenciaEntidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdDependenciaEntidad));

#line default
#line hidden
            EndContext();
            BeginContext(450, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(511, 52, false);
#line 22 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\DependenciaEntidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UbicacionSistema));

#line default
#line hidden
            EndContext();
            BeginContext(563, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(625, 48, false);
#line 25 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\DependenciaEntidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.UbicacionSistema));

#line default
#line hidden
            EndContext();
            BeginContext(673, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(734, 51, false);
#line 28 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\DependenciaEntidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UbicacionFisica));

#line default
#line hidden
            EndContext();
            BeginContext(785, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(847, 47, false);
#line 31 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\DependenciaEntidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.UbicacionFisica));

#line default
#line hidden
            EndContext();
            BeginContext(894, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(955, 48, false);
#line 34 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\DependenciaEntidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1065, 44, false);
#line 37 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\DependenciaEntidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 46, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1155, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c19dbefa3e796404a731d957a7ab424194b7e8a28105", async() => {
                BeginContext(1219, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\DependenciaEntidad\Details.cshtml"
                           WriteLiteral(Model.IdDependenciaEntidad);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1229, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1236, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c19dbefa3e796404a731d957a7ab424194b7e8a210472", async() => {
                BeginContext(1258, 19, true);
                WriteLiteral("Regresar al listado");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1281, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventarioPaginaWeb.Models.DependenciaEntidad> Html { get; private set; }
    }
}
#pragma warning restore 1591
