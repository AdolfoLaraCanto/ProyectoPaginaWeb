#pragma checksum "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b99a96d02db035c09a5945abef9a2bf4c6c71dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Motivo_Index), @"mvc.1.0.view", @"/Views/Motivo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Motivo/Index.cshtml", typeof(AspNetCore.Views_Motivo_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b99a96d02db035c09a5945abef9a2bf4c6c71dd", @"/Views/Motivo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"744364d3c56445e9da57c348ab3386dfaa578dce", @"/Views/_ViewImports.cshtml")]
    public class Views_Motivo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InventarioPaginaWeb.Models.Motivo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteMe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 38, true);
            WriteLiteral("\n    <h1>Motivo</h1>\n    <p>\r\n        ");
            EndContext();
            BeginContext(92, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b99a96d02db035c09a5945abef9a2bf4c6c71dd5747", async() => {
                BeginContext(115, 15, true);
                WriteLiteral(" Nuevo Motivo |");
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
            BeginContext(134, 135, true);
            WriteLiteral("\r\n        <a href=\"/Inventario/Index\"> Regresar al Inventario |</a>\r\n        <a href=\"/Home/Index\"> Regresar a Inicio |</a>\r\n    </p>\n\n");
            EndContext();
            BeginContext(269, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b99a96d02db035c09a5945abef9a2bf4c6c71dd7271", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(347, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 12 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
 if (TempData["message"] != null)
{

#line default
#line hidden
            BeginContext(385, 173, true);
            WriteLiteral("    <div id=\"alert-div\" class=\"alert alert-success alert-dismissible fade show\">\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button>\n        <strong>");
            EndContext();
            BeginContext(559, 19, false);
#line 16 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
           Write(TempData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(578, 21, true);
            WriteLiteral("</strong>\n    </div>\n");
            EndContext();
            BeginContext(600, 297, true);
            WriteLiteral(@"    <script type=""text/javascript"">
        $(document).ready(function () {
            setTimeout(function () {
                $(""#alert-div"").fadeTo(500, 0.5).slideUp(""slow"", function () {
                    $(this).remove();
                })
            }, 3000);
        });
    </script>
");
            EndContext();
#line 28 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
}

#line default
#line hidden
            BeginContext(899, 127, true);
            WriteLiteral("\n<script type=\"text/javascript\">\n\n</script>\n\n<table class=\"table\">\n    <thead>\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1027, 44, false);
#line 38 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdMotivo));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1127, 48, false);
#line 41 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreMotivo));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 62, true);
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 47 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1284, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1333, 43, false);
#line 51 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdMotivo));

#line default
#line hidden
            EndContext();
            BeginContext(1376, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1432, 47, false);
#line 54 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombreMotivo));

#line default
#line hidden
            EndContext();
            BeginContext(1479, 69, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1548, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b99a96d02db035c09a5945abef9a2bf4c6c71dd12257", async() => {
                BeginContext(1599, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
                                       WriteLiteral(item.IdMotivo);

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
            BeginContext(1609, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1629, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b99a96d02db035c09a5945abef9a2bf4c6c71dd14625", async() => {
                BeginContext(1683, 8, true);
                WriteLiteral("Detalles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
                                          WriteLiteral(item.IdMotivo);

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
            BeginContext(1695, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1715, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b99a96d02db035c09a5945abef9a2bf4c6c71dd16999", async() => {
                BeginContext(1827, 8, true);
                WriteLiteral("Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
                       Write(item.IdMotivo);

#line default
#line hidden
            WriteLiteral(" ");
#line 60 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
                                      Write(item.NombreMotivo);

#line default
#line hidden
            WriteLiteral(" ");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
                                                                                      WriteLiteral(item.IdMotivo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1839, 35, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\n");
            EndContext();
#line 63 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Motivo\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1884, 23, true);
            WriteLiteral("    </tbody>\n\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InventarioPaginaWeb.Models.Motivo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
